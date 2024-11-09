using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.codec.wmf;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class FrmAreaRegistro : Form
    {
        public FrmAreaRegistro()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        Validaciones validaciones = new Validaciones();
        DataTable Tabla = new DataTable();

        string consulta = "SELECT bombero.cod_bombero AS Codigo, area.nombre AS Nombre, tarea.fecha AS Fecha, tarea.hora AS Hora, tarea.detalle AS Detalle, tarea.estado AS Estado FROM tarea INNER JOIN bombero ON tarea.cod_bombero = bombero.cod_bombero INNER JOIN area ON bombero.cod_area = area.cod_area";

        private void FrmAreaRegistro_Load(object sender, EventArgs e)
        {
            dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);

            cmbAreas.DisplayMember = "nombre";
            cmbAreas.ValueMember = "dod_area";
            cmbAreas.DataSource = metodos.Actualizar(Tabla, ("SELECT * FROM area"));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigo.Text.Trim());

            string DescripcionTarea = txtDescripcion.Text;
            int area = cmbAreas.SelectedIndex + 1;

            string AltaTarea = "INSERT INTO tarea (cod_bombero,fecha,hora,cod_area,detalle,estado) VALUES (" + txtCodigo.Text + ",'"
            + DateTime.Today.ToString("yyyy/MM/dd") + "','" + mtxtHora.Text + "'," +area + ",'" + txtDescripcion.Text + "','" + "Completada');";

            validaciones.PruebaAbm(AltaTarea);

            dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            mtxtHora.Text = "";

        }

        private void ValidacionDeFormato(object sender, KeyPressEventArgs e)
        {
            // Ignora cualquier tecla que no sea un número o retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Obtiene el texto actual y la posición del cursor
            string currentText = mtxtHora.Text.Replace(":", ""); // Eliminamos el carácter ":"
            int position = mtxtHora.SelectionStart;

            // Validación para cada posición
            switch (position)
            {
                case 0:
                    // Primera posición: permite solo 0, 1 o 2
                    if (e.KeyChar < 0 || e.KeyChar > 2)
                        e.Handled = true;
                    break;

                case 1:
                    // Segunda posición: depende del primer dígito
                    if (currentText[0] == '2' && (e.KeyChar < '0' || e.KeyChar > '3'))
                        e.Handled = true;
                    else if (currentText[0] != '2' && (e.KeyChar < '0' || e.KeyChar > '9'))
                        e.Handled = true;
                    break;

                case 2:
                    // Tercera posición: salta automáticamente el símbolo ":" entre horas y minutos
                    mtxtHora.SelectionStart = 3;
                    break;

                case 3:
                    // Cuarta posición: permite solo 0 a 5
                    if (e.KeyChar < '0' || e.KeyChar > '5')
                        e.Handled = true;
                    break;

                case 4:
                    // Quinta posición: permite solo 0 a 9
                    if (e.KeyChar < '0' || e.KeyChar > '9')
                        e.Handled = true;
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void mtxtHora_MouseLeave(object sender, EventArgs e)
        {
            if (mtxtHora.Text == "")
            {
                mtxtHora.Text = "0000";
            }
        }

        private void mtxtHora_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtHora.Text = "";
        }

        private void dtpBuscar_ValueChanged(object sender, EventArgs e)
        {

        }

        string cadena = "";
        string consultaBuscar = "";

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                if (cadena.Length != 0)
                {
                    cadena = cadena.Remove(cadena.Length - 1);
                }
            }

            else
            {
                cadena = cadena + e.KeyChar;
            }

            if (cadena == "")
            {
                dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);
                dgvHistorialTareas.ClearSelection();
            }
            else
            {
                Tabla.Clear();
                consultaBuscar = "SELECT * FROM tarea WHERE nombre LIKE '%" + cadena + "%'  OR cod_bombero LIKE '%" + cadena + "%'";
                dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consultaBuscar);
                dgvHistorialTareas.ClearSelection();
            }
        }
    }
}
