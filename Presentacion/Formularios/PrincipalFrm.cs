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
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmMain());
        }

        private void tFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private Form FormActivo = null;

        private Button BotonAnterior { get; set; }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            if (BotonAnterior != null)
                BotonAnterior.BackColor = Color.FromArgb(97, 24, 35);

            var button = ((Button)sender);
            button.BackColor = Color.FromArgb(140, 11, 32);
            BotonAnterior = button;
            AbrirFormulario(button.Name);
        }

        public void AbrirFormulario(string name)
        {
            switch (name)
            {
                case "btnInicio":
                    OpenFormHijo(new FrmMain());
                    break;
                case "btnConsultas":
                    OpenFormHijo(new Consultas());
                    break;
            }
        }

        private void OpenFormHijo(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            FormActivo = formHijo;
            FormActivo.TopLevel = false;
            FormActivo.FormBorderStyle = FormBorderStyle.None;
            FormActivo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormActivo);
            panelContenedor.Tag = formHijo;
            FormActivo.BringToFront();
            FormActivo.Show();
        }

    }
}
