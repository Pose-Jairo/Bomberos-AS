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
    public partial class FrmCalificaciones : Form
    {
        public FrmCalificaciones()
        {
            InitializeComponent();
        }

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                string nomcolumn = Convert.ToString(i);
                dgvCalificacion.Columns.Add("columna" + i, nomcolumn);
            }

            dgvCalificacion.Columns.Add("columnaAsistencia", "Total Horas");
            dgvCalificacion.Columns.Add("columnaCalificacion", "Calificacion Final");
        }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }
    }
}
