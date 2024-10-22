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
    public partial class FrmABMpersonal : Form
    {
        public FrmABMpersonal()
        {
            InitializeComponent();
        }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }

        ConexionConBD ClaseConexion = new ConexionConBD();
        Metodos metodo = new Metodos();
        DataTable Tabla = new DataTable();



        private void FrmABMpersonal_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(ClaseConexion.LectorSql("Select * from bombero"));
            //asigna los datos a la tabla...
            dgvTablaPersonal.DataSource = Tabla;

            ClaseConexion.Desconectar();

            //llama a los metodos que llena los combobox...
            cmbRango.DisplayMember = "rango";
            cmbRango.ValueMember = "cod_rango";
            cmbRango.DataSource = metodo.Carga_Rango();

            cmbFiltraRango.DisplayMember = "rango";
            cmbFiltraRango.ValueMember = "cod_rango";
            cmbFiltraRango.DataSource = metodo.Carga_Rango();

            //llama a los metodos que llena los combobox...
            cmbArea.DisplayMember = "nombre";
            cmbArea.ValueMember = "dod_area";
            cmbArea.DataSource = metodo.Carga_Area();

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //ejecuta el metodo de insert...
            //variable de control...
            bool alta = false;
            int area = cmbArea.SelectedIndex + 1;
            int rango = cmbRango.SelectedIndex + 1;
            //consulta de insert...
            alta = ClaseConexion.EjecutarConsulta("Insert into bombero(nombre, apellido, cod_rango, cod_area) VALUES('" + txtNombre.Text + "','" + txtApellido.Text + "'," + rango + "," + area + ")");
        }


    }
}
