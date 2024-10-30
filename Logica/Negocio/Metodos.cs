using System;
using System.Data;
using Datos.Conexion;

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


    }
}
