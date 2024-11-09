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
        Validaciones validaciones = new Validaciones(); 
        DataTable Tabla = new DataTable();

        private void FrmABMpersonal_Load(object? sender, EventArgs? e)
        {
            string consulta="";
            Tabla.Clear();
            if (cbSelectAll.Checked == false)
            {
                consulta = "SELECT bombero.cod_bombero AS Codigo,bombero.nombre AS Nombre, bombero.apellido AS Apellido,bombero.estado AS Activo, rango.rango AS Jerarquia,area.nombre AS Area FROM bombero INNER JOIN rango ON rango.cod_rango = bombero.cod_rango INNER JOIN area ON area.cod_area = bombero.cod_area WHERE estado = 1";
            }
            else if (cbSelectAll.Checked == true)
            {
                consulta = "SELECT bombero.cod_bombero AS Codigo,bombero.nombre AS Nombre, bombero.apellido AS Apellido,bombero.estado AS Activo, rango.rango AS Jerarquia,area.nombre AS Area FROM bombero INNER JOIN rango ON rango.cod_rango = bombero.cod_rango INNER JOIN area ON area.cod_area = bombero.cod_area";
            }
            //asigna los datos a la tabla...
            dgvTablaPersonal.DataSource = metodo.Actualizar(Tabla,consulta);

            //llama a los metodos que llena los combobox...
            cmbRango.DisplayMember = "rango";
            cmbRango.ValueMember = "cod_rango";
            cmbRango.DataSource = metodo.Actualizar(Tabla, ("SELECT * FROM rango"));

            //llama a los metodos que llena los combobox...
            cmbArea.DisplayMember = "nombre";
            cmbArea.ValueMember = "dod_area";
            cmbArea.DataSource = metodo.Actualizar(Tabla, ("SELECT * FROM area"));

            LimpiarTxt();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //ALTA del Bombero
            if (rbAgregarReg.Checked)
            {
                int area = cmbArea.SelectedIndex + 1;
                int rango = cmbRango.SelectedIndex + 1;
                //consulta de insert...
                validaciones.PruebaAbm("INSERT INTO bombero(nombre, apellido, cod_rango, cod_area) VALUES('" + txtNombre.Text + "','" + txtApellido.Text + "'," + rango + "," + area + ")");
                FrmABMpersonal_Load(null, null);
            }
            //UPDATE del Bombero
            else if (rbModReg.Checked)
            {
                int areamod = cmbArea.SelectedIndex + 1;
                int rangomod = cmbRango.SelectedIndex + 1;
                int activo = Convert.ToInt32(cbActivo.Checked);
                
                validaciones.PruebaAbm("UPDATE bombero SET nombre ='"
                        + txtNombre.Text + "', apellido = '"
                        + txtApellido.Text + "', estado = "
                        + activo + ", cod_rango = "
                        + rangomod + ", cod_area = "
                        + areamod + " WHERE cod_bombero = " + txtCodBom.Text + ";");

                FrmABMpersonal_Load(null, null);
            }
            //DELETE del Bombero
            else if (rbElimReg.Checked) 
            {
                int activo = 0;
                DialogResult Respuesta = MessageBox.Show("Esta seguro de dar de baja el usuario?", "Confirmacion", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes)
                {
                    validaciones.PruebaAbm("UPDATE bombero SET estado =" + activo + " WHERE cod_bombero =" + txtCodBom.Text + ";");
                    FrmABMpersonal_Load(null, null);
                }
            }
        }
        private void Click_Celda(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && (rbElimReg.Checked || rbModReg.Checked))
            {
                txtCodBom.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNombre.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                cmbRango.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["Jerarquia"].Value.ToString();
                cmbArea.Text = dgvTablaPersonal.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                var estadoVal = dgvTablaPersonal.Rows[e.RowIndex].Cells["Activo"].Value;
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

        private void rbAgregarReg_CheckedChanged(object sender, EventArgs e)
        {
            CambioValores(true);
            cbActivo.Visible = false;
            LimpiarTxt();
        }

        private void rbModReg_CheckedChanged(object sender, EventArgs e)
        {
            CambioValores(true);
        }

        private void rbElimReg_CheckedChanged(object sender, EventArgs e)
        {
            CambioValores(false);
        }

        private void LimpiarTxt()
        {
            txtCodBom.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbArea.Text = "";
            cmbRango.Text = "";
        }

        public void CambioValores (bool Valor)
        {
            txtApellido.Enabled = Valor;
            txtNombre.Enabled = Valor;
            cmbArea.Enabled = Valor;
            cmbRango.Enabled = Valor;
            cbActivo.Enabled = Valor;
            cbActivo.Visible = Valor;
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            FrmABMpersonal_Load(null, null);
        }
    }
}
