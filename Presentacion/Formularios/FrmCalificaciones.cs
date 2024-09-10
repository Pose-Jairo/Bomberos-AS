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
                dgvCalendario.Columns.Add("columna"+i,nomcolumn);
            }

            dgvCalendario.Columns.Add("columnaAsistencia", "Total Horas");
            dgvCalendario.Columns.Add("columnaCalificacion", "Calificacion Final");

        }
    }
}
