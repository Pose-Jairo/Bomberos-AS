using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Logica.Negocio;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Presentacion.Formularios
{
    public partial class FrmCalificaciones : Form
    {
        public FrmCalificaciones()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();

        int selectedYear;      
        int selectedMonth; 

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            selectedYear = dtpFecha.Value.Year;
            selectedMonth = dtpFecha.Value.Month;
            string query = "";
            string connectionString = @"Server=LAPTOP-VTNNNOQ2\SQLEXPRESS;Database=Bomberos;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Consulta SQL para obtener el presentismo de cada día y las horas totales del mes para cada bombero
                    if (PrincipalFrm.Instancia.Planilla == "Institucion")
                    {
                        query = $@"
                        SELECT 
                            b.cod_bombero,
                            b.nombre,
                            b.apellido,
                            ISNULL(SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) / 60.0, 0) AS HorasTotales,
                            a.fecha,
                            CASE
                                WHEN SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) >= 60 THEN '1'
                                WHEN SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) < 60 AND SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) > 0 THEN '0'
                                ELSE 'A'
                            END AS Presentismo
                        FROM bombero b
                        LEFT JOIN asistencia a ON b.cod_bombero = a.cod_bombero
                        WHERE 
                        YEAR(a.fecha) = {selectedYear} AND MONTH(a.fecha) = {selectedMonth}
                        GROUP BY b.cod_bombero, b.nombre, b.apellido, a.fecha
                        ORDER BY b.cod_bombero, a.fecha ASC";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Transformar los datos para mostrar en el formato cruzado
                        DataTable crossTabTable = new DataTable();
                        crossTabTable.Columns.Add("Nombre y Apellido");
                        crossTabTable.Columns.Add("Horas Totales");

                        // Obtener los días del mes ordenados de menor a mayor
                        var fechasOrdenadas = table.AsEnumerable()
                        .Where(row => row["fecha"] != DBNull.Value) // Verifica que "fecha" no sea DBNull
                        .Select(row => row["fecha"] == DBNull.Value ? null : Convert.ToDateTime(row["fecha"]).ToString("dd"))
                        .Distinct()
                        .OrderBy(f => f);

                        // Agregar columnas de fechas en orden
                        foreach (string fecha in fechasOrdenadas)
                        {
                            crossTabTable.Columns.Add(fecha);
                        }

                        // Llenar la tabla cruzada
                        var groupedData = table.AsEnumerable()
                            .GroupBy(r => new
                            {
                                CodBombero = r.Field<int>("cod_bombero"),
                                Nombre = r.Field<string>("nombre"),
                                Apellido = r.Field<string>("apellido")
                            });

                        foreach (var group in groupedData)
                        {
                            DataRow newRow = crossTabTable.NewRow();
                            newRow["Nombre y Apellido"] = group.Key.Nombre + " " + group.Key.Apellido;
                            newRow["Horas Totales"] = group.Sum(r => r["HorasTotales"] == DBNull.Value ? 0 : Convert.ToInt32(r["HorasTotales"]));

                            foreach (var fechaRow in group)
                            {
                                string fecha = fechaRow["fecha"] == DBNull.Value ? "" : Convert.ToDateTime(fechaRow["fecha"]).ToString("dd");
                                newRow[fecha] = fechaRow["Presentismo"];
                            }

                            crossTabTable.Rows.Add(newRow);
                        }

                        // Rellenar celdas vacías con "A"
                        foreach (DataRow row in crossTabTable.Rows)
                        {
                            foreach (DataColumn col in crossTabTable.Columns)
                            {
                                if (col.ColumnName != "Nombre y Apellido" && col.ColumnName != "Horas Totales" && row[col] == DBNull.Value)
                                {
                                    row[col] = "A";
                                }
                            }
                        }

                        // Cargar la tabla cruzada en el DataGridView
                        dgvCalificacion.DataSource = crossTabTable;
                    }

                    else if (PrincipalFrm.Instancia.Planilla == "Area")
                    {
                        query = $@"
                        SELECT  
                        b.cod_bombero,
                        b.nombre,
                        b.apellido,
                        t.fecha,
                        CASE 
                            WHEN SUM(CASE WHEN t.asistencia = 1 THEN 1 ELSE 0 END) > 0 THEN '1'
                            ELSE 'A'
                        END AS Presentismo
	                    FROM bombero b
	                    LEFT JOIN tarea t ON b.cod_bombero = t.cod_bombero
                        WHERE 
                        YEAR(t.fecha) = {selectedYear} AND MONTH(t.fecha) = {selectedMonth}
	                    GROUP BY b.cod_bombero, b.nombre, b.apellido, t.fecha
	                    ORDER BY b.cod_bombero, t.fecha ASC";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Transformar los datos para mostrar en el formato cruzado
                        DataTable crossTabTable = new DataTable();
                        crossTabTable.Columns.Add("Nombre y Apellido");

                        // Obtener los días del mes ordenados de menor a mayor
                        var fechasOrdenadas = table.AsEnumerable()
                            .Select(row => Convert.ToDateTime(row["fecha"]).ToString("dd"))
                            .Distinct()
                            .OrderBy(f => f);

                        // Agregar columnas de fechas en orden
                        foreach (string fecha in fechasOrdenadas)
                        {
                            crossTabTable.Columns.Add(fecha);
                        }

                        // Llenar la tabla cruzada
                        var groupedData = table.AsEnumerable()
                            .GroupBy(r => new
                            {
                                CodBombero = r.Field<int>("cod_bombero"),
                                Nombre = r.Field<string>("nombre"),
                                Apellido = r.Field<string>("apellido")
                            });
                        foreach (var group in groupedData)
                        {
                            DataRow newRow = crossTabTable.NewRow();
                            newRow["Nombre y Apellido"] = group.Key.Nombre + " " + group.Key.Apellido;

                            foreach (var fechaRow in group)
                            {
                                string fecha = Convert.ToDateTime(fechaRow["fecha"]).ToString("dd");
                                newRow[fecha] = fechaRow["Presentismo"];
                            }

                            crossTabTable.Rows.Add(newRow);
                        }

                        // Rellenar celdas vacías con "A"
                        foreach (DataRow row in crossTabTable.Rows)
                        {
                            foreach (DataColumn col in crossTabTable.Columns)
                            {
                                if (col.ColumnName != "Nombre y Apellido" && row[col] == DBNull.Value)
                                {
                                    row[col] = "A";
                                }
                            }
                        }

                        dgvCalificacion.DataSource = crossTabTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            FrmCalificaciones_Load(null, null);
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            // Configura el archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cambiar la orientación de la hoja a horizontal
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                try
                {
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Crear tabla con el mismo número de columnas que el DataGridView
                    PdfPTable pdfTable = new PdfPTable(dgvCalificacion.ColumnCount);

                    // Agregar encabezados de columna al PDF
                    foreach (DataGridViewColumn column in dgvCalificacion.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdfTable.AddCell(cell);
                    }

                    // Agregar las filas del DataGridView al PDF
                    foreach (DataGridViewRow row in dgvCalificacion.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    MessageBox.Show("PDF generado con éxito en: " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el PDF: " + ex.Message);
                }
                finally
                {
                    pdfDoc.Close();
                }
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            FrmCalificaciones_Load(null,null);
        }
    }
}
