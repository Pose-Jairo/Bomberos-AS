using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conexion;

namespace Logica.Negocio
{
    public class Validaciones
    {
        ConexionConBD BDConexion = new ConexionConBD();

        public void PruebaAbm(string consulta)
        {
            bool ABM = false;

            ABM = BDConexion.EjecutarConsulta(consulta);

            if (ABM == true)
            {

            }
            else
            {
               
            }
        }
    }
}
