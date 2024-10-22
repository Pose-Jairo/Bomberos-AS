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

        //metodo que carga los rangos de la DB en un CMB
        public DataTable Carga_Rango()
        {
            DataTable Tabla = new DataTable();

            Tabla.Clear();
            Tabla.Load(BDConexion.LectorSql("Select * from rango"));
            BDConexion.Desconectar();
            return (Tabla);
        }

        //metodo que carga las areas de la DB en un CMB
        public DataTable Carga_Area()
        {
            DataTable Tabla = new DataTable();

            Tabla.Clear();
            Tabla.Load(BDConexion.LectorSql("Select * from area"));
            BDConexion.Desconectar();
            return (Tabla);
        }

        //metodo que carga un nuevo registro en bombero...

    }
}
