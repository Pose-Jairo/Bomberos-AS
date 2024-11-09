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
    public partial class FrmReuniones : Form
    {
        public FrmReuniones()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        Validaciones validaciones = new Validaciones();
        DataTable Tabla = new DataTable();

        string consulta = "SELECT fecha,hora,descripcion FROM reunion";

        private void btnVolverBomberos_Click(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }

        private void FrmReuniones_Load(object sender, EventArgs e)
        {
            dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);
        }
    }
}
