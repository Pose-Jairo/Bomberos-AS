using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        Validaciones validaciones = new Validaciones();

        Metodos metodos = new Metodos();

        DataTable Tabla = new DataTable();

        string consulta = "SELECT tarea.cod_bombero AS Codigo, bombero.nombre AS Nombre, bombero.apellido AS Apellido, tarea.detalle AS Tarea, " +
                          "tarea.estado AS Estado FROM tarea INNER JOIN bombero ON bombero.cod_bombero=tarea.cod_bombero WHERE tarea.fecha='" + DateTime.Now.ToShortDateString() + "';";

        private void Consultas_Load(object sender, EventArgs e)
        {
            CargaDeGrilla(consulta);
        }
        private void btn_Consultar(object sender, EventArgs e)
        {
            string Codigo = txtConsulta.Text;

            string consulta = "SELECT tarea.cod_bombero AS Codigo, bombero.nombre AS Nombre, bombero.apellido AS Apellido, tarea.detalle AS Tarea, " +
                              "tarea.estado AS Estado, tarea.fecha AS Fecha FROM tarea INNER JOIN bombero ON bombero.cod_bombero=tarea.cod_bombero WHERE bombero.cod_bombero= " + Codigo + ";";

            CargaDeGrilla(consulta);
        }

        private void CambioDeFecha(object sender, EventArgs e)
        {
            var fecha = ((DateTimePicker)sender);

            string consulta = "SELECT tarea.cod_bombero AS Codigo, bombero.nombre AS Nombre, bombero.apellido AS Apellido, tarea.detalle AS Tarea, " +
                              "tarea.estado AS Estado FROM tarea INNER JOIN bombero ON bombero.cod_bombero=tarea.cod_bombero WHERE tarea.fecha='" + fecha.Value.Date.ToString("yyyy/MM/dd") + "';";
            CargaDeGrilla(consulta);
        }
        public void CargaDeGrilla(string consulta)
        {
            try
            {
                dgvHistorial.DataSource = metodos.Actualizar(Tabla, consulta);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
        
        /*private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            var textbox = ((TextBox)sender);

            if (textbox.Text == "")
            {
                string consulta = "SELECT tarea.cod_bombero AS Codigo, bombero.nombre AS Nombre, bombero.apellido AS Apellido, tarea.detalle AS Tarea, " +
                                  "tarea.estado AS Estado FROM tarea INNER JOIN bombero ON bombero.cod_bombero=tarea.cod_bombero WHERE tarea.fecha='" + DateTime.Now.ToShortDateString() + "';";

                CargaDeGrilla(consulta);

                dtpFecha.Text = DateTime.Now.ToShortDateString();
            }
        } */






    }
}
