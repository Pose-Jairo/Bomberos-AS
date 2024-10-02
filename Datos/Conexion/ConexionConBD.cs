using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos.Conexion
{
    public class ConexionConBD
    {
        static private string strConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Bomberito_DB;Integrated Security=True";

        public SqlConnection Conexion {  get; set; }
        public SqlCommand Orden {  get; set; }

        public SqlDataReader LectorSql(string Consulta)
        {
            SqlDataReader Lector;

            Conexion = new SqlConnection(strConexion);
            Orden = new SqlCommand(Consulta, Conexion);
            try
            {
                Conexion.Open();
                Lector = Orden.ExecuteReader();
                return Lector;
            }
            catch
            {
                Lector = null;
                return Lector;
            }
        }

        public void Desconectar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public bool EjecutarConsulta(string Consulta)
        {
            bool Resultado = false;

            Conexion = new SqlConnection(strConexion);

            Orden = new SqlCommand(Consulta, Conexion);

            try
            {
                Conexion.Open();
                Orden.ExecuteNonQuery();
                Resultado = true;
            }
            catch
            {
                Resultado = false;
            }

            Desconectar();
            return Resultado;
        }
    }
}
