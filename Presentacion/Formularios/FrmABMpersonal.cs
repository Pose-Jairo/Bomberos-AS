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
            if (cbSelectAll.Checked == false)
            {
                Tabla.Load(ClaseConexion.LectorSql("select bombero.cod_bombero,bombero.nombre, bombero.apellido,bombero.estado, rango.rango,area.nombre from bombero inner join rango on rango.cod_rango = bombero.cod_rango inner join area on area.cod_area = bombero.cod_area where estado = 1"));
            }
            else if (cbSelectAll.Checked == true)
            {
                Tabla.Load(ClaseConexion.LectorSql("select bombero.cod_bombero,bombero.nombre, bombero.apellido,bombero.estado, rango.rango,area.nombre from bombero inner join rango on rango.cod_rango = bombero.cod_rango inner join area on area.cod_area = bombero.cod_area"));
            }
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

            limpiartext();

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
            //comprueba el resultado e informa por mensaje
            if (alta == true)
            {
                MessageBox.Show("Se registro con exito!");
                //se llama al vento load del formulario para recargar la grilla...
                FrmABMpersonal_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERROR al ejecutar la consulta...!");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //ejecuta la modificacion de un registro
            bool mod = false;
            int areamod = cmbArea.SelectedIndex + 1;
            int rangomod = cmbRango.SelectedIndex + 1;
            int activo = Convert.ToInt32(cbActivo.Checked);

            mod = ClaseConexion.EjecutarConsulta("update bombero set nombre ='"
                    + txtNombre.Text + "', apellido = '"
                    + txtApellido.Text + "', estado = "
                    + activo + ", cod_rango = "
                    + rangomod + ", cod_area = "
                    + areamod + " where cod_bombero = " + txtCodBom.Text + ";");
            if (mod == true)
            {
                MessageBox.Show("Se Modifico con exito!");
                //se llama al vento load del formulario para recargar la grilla...
                FrmABMpersonal_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERROR al ejecutar la consulta...!");
            }

        }

        private void Click_Celda(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && (rbElimReg.Checked || rbModReg.Checked))
            {
                txtCodBom.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["cod_bombero"].Value.ToString();
                txtNombre.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                cmbRango.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["rango"].Value.ToString();
                cmbArea.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["nombre1"].Value.ToString();
                var estadoVal = dgvTablaPersonal.Rows[e.RowIndex].Cells["estado"].Value;
                if (estadoVal is bool)
                {
                    cbActivo.Checked = (bool)estadoVal;
                }
                if (estadoVal is int)
                {
                    cbActivo.Checked = (int)estadoVal == 1;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int activo = 0;
            DialogResult Respuesta = MessageBox.Show("esta seguro de dar de baja el usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (Respuesta == DialogResult.Yes)
            {
                if (ClaseConexion.EjecutarConsulta("update bombero set estado =" + activo + " where cod_bombero =" + txtCodBom.Text + ";"))
                {
                    MessageBox.Show("Se dio de baja el usuario!", "Proceso finalizado:");
                    FrmABMpersonal_Load(null, null);
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:");
                }
            }
        }

        private void rbAgregarReg_CheckedChanged(object sender, EventArgs e)
        {
            btnEjecutar.Enabled = true;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cmbArea.Enabled = true;
            cmbRango.Enabled = true;
            cbActivo.Enabled = true;
            cbActivo.Visible = false;
            limpiartext();
        }

        private void rbModReg_CheckedChanged(object sender, EventArgs e)
        {
            btnMod.Enabled = true;
            btnEjecutar.Enabled = false;
            btnDel.Enabled = false;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cmbArea.Enabled = true;
            cmbRango.Enabled = true;
            cbActivo.Enabled = true;
            cbActivo.Visible = true;
        }

        private void rbElimReg_CheckedChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            btnEjecutar.Enabled = false;
            btnMod.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cmbArea.Enabled = false;
            cmbRango.Enabled = false;
            cbActivo.Enabled = false;
            cbActivo.Visible = false;
        }

        private void limpiartext()
        {
            txtCodBom.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbArea.Text = "";
            cmbRango.Text = "";
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            FrmABMpersonal_Load(null, null);
        }
    }
}
