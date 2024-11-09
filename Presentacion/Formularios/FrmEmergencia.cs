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
    public partial class FrmEmergencia : Form
    {
        public FrmEmergencia()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        Validaciones validaciones = new Validaciones();
        DataTable Tabla = new DataTable();

        string consulta = "SELECT fecha,inicio,fin,detalle FROM emergencia";

        private void FrmEmergencia_Load(object sender, EventArgs e)
        {
            dgvHistorialEmergencia.DataSource = metodos.Actualizar(Tabla, consulta);
        }

        private void btnVolverBomberos_Click(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }
    }
}
