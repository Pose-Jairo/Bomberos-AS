using System;
using System.Data;
using Datos.Conexion;
using Microsoft.Data.SqlClient;

namespace Logica.Negocio
{
    public class Metodos
    {
        ConexionConBD BDConexion = new ConexionConBD();

        public DataTable Actualizar(DataTable Tabla, string consulta)
        {
            Tabla = new DataTable();

            Tabla.Clear();

            Tabla.Load(BDConexion.LectorSql(consulta));

            BDConexion.Desconectar();

            return (Tabla);
        }

        public DataTable CargarPlanilla()
        {
            string query = @"
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
                GROUP BY b.cod_bombero, b.nombre, b.apellido, a.fecha
                ORDER BY b.cod_bombero, a.fecha ASC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, BDConexion.Conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Transformar los datos para mostrar en el formato cruzado
            DataTable crossTabTable = new DataTable();
            crossTabTable.Columns.Add("Nombre y Apellido");
            crossTabTable.Columns.Add("Horas Totales");

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
                newRow["Horas Totales"] = group.Sum(r => Convert.ToInt32(r["HorasTotales"]));

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
                    if (col.ColumnName != "Nombre y Apellido" && col.ColumnName != "Horas Totales" && row[col] == DBNull.Value)
                    {
                        row[col] = "A";
                    }
                }
            }
            return crossTabTable;
        }
    }
}
