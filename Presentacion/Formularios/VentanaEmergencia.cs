using Datos.Conexion;
using Logica.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class VentanaEmergencia : Form
    {
        public VentanaEmergencia()
        {
            InitializeComponent();
        }

        Validaciones validaciones = new Validaciones();

        Metodos metodos = new Metodos();

        DataTable Tabla1 = new DataTable();

        ConexionConBD coneccion = new ConexionConBD();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //que ingresa la emergencia?, como manejan quienes salieron a la misma.
            string detalle = txtDetalleE.Text;
            string fecha_inicio = dtpFecha.Value.ToString("yyyy-MM-dd");
            string hora_inicio = dtpHoraInicio.Value.ToString("HH:mm:ss");
            string fecha_fin = dtp_FechaFinalizacion.Value.ToString("yyyy-MM-dd");
            string hora_fin = dtpHora_Finalizacion.Value.ToString("HH:mm:ss");

            string emergencia = $"INSERT INTO emergencia (fecha, inicio, fin, detalle) " +
                                $"VALUES ('{fecha_inicio}', '{fecha_inicio} {hora_inicio}', '{fecha_fin} {hora_fin}', '{detalle}')";
            MessageBox.Show(emergencia);
            metodos.EjecutarConsulta(emergencia);




        }

        //validar textboxs para que solo se pueda ingresar numeros salvo en detalle
    }
}
