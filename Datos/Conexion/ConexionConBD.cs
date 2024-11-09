using System;
using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;

namespace Datos.Conexion
{
    public class ConexionConBD
    {
      //  public static string ObtenerServer()
       // {        
          //  string server = Environment.MachineName;

           // RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
        //    String[]? instances = (String[])rk.GetValue("InstalledInstances");
        //    if (instances.Length > 0)
         //   {
         //       foreach (String element in instances)
         //       {
         //           string Server = server + "\\" + element + ";";
         //           return Server ;
         //       }
        //    }
        //    return null;
      //  }


        //static string server = ObtenerServer(); 

        static private string strConexion = @"Server=LAPTOP-VTNNNOQ2\SQLEXPRESS;Database=Bomberos;Trusted_Connection=True;TrustServerCertificate=True;";
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


        //exp
        public int entrada(string Consulta)
        {
            int Resultado = 0;
            Conexion = new SqlConnection(strConexion);
            Orden = new SqlCommand(Consulta, Conexion);

            try
            {
                Conexion.Open();
                Resultado = Orden.ExecuteNonQuery(); // Esto devolverá el número real de filas afectadas
            }
            catch
            {
                Resultado = 0;
            }
            finally
            {
                Desconectar();
            }

            return Resultado;
        }

        //necesario para reconocer si el bombero tiene un ingreso sin salida
        public int ObtenerConteo(string Consulta)
        {
            int conteo = 0;

            // Crear la conexión y el comando de SQL
            using (SqlConnection Conexion = new SqlConnection(strConexion))
            using (SqlCommand Orden = new SqlCommand(Consulta, Conexion))
            {
                try
                {
                    Conexion.Open();
                    // Ejecutar la consulta y obtener el conteo
                    conteo = (int)Orden.ExecuteScalar();
                }
                catch 
                {
                    conteo = 0;
                }
            }

            return conteo;
        }
    }
}
