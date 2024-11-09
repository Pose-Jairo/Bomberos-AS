using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public static PrincipalFrm Instancia { get; private set; }

        public PrincipalFrm()
        {
            InitializeComponent();
            Instancia = this;
        }

        private Image imgMaximizar;
        private Image imgMinimizar;

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
            imgMaximizar = Properties.Resources.icon_maximizar;
            imgMinimizar = Properties.Resources.icon_restaurar;

            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            OpenFormHijo(new FrmMain());
            btnInicio.BackColor = Color.FromArgb(140, 11, 32);
            BotonAnterior = btnInicio;
            pMaxMin.BackgroundImage = imgMinimizar;
        }

        private void tFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private Form FormActivo = null;

        private Button BotonAnterior { get; set; }

        public string Planilla {  get; set; }

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
                case "btnArea":
                    OpenFormHijo(new FrmAreaRegistro());
                    break;
                case "btnAdmin":
                    OpenFormHijo(new FrmAdministracion());
                    break;
                case "btnAreas":
                    OpenFormHijo(new FrmAreaRegistro());
                    break;
                case "btnBomberos":
                    OpenFormHijo(new FrmABMpersonal());
                    break;
                case "btnAsisArea":
                    Planilla = "Area";
                    OpenFormHijo(new FrmCalificaciones());
                    break;
                case "btnAsisInsti":
                    Planilla = "Institucion";
                    OpenFormHijo(new FrmCalificaciones());
                    break;
                case "btnVolverArea":
                    OpenFormHijo(new FrmAreas());
                    break;
                case "btnVolverBomberos":
                    OpenFormHijo(new FrmAdministracion());
                    break;
                case "btnCancelarCalificaciones":
                    OpenFormHijo(new FrmAdministracion());
                    break;
                case "btnEmergencia":
                    OpenFormHijo(new FrmEmergencia());
                    break;
                case "btnReuniones":
                    OpenFormHijo(new FrmReuniones());
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

        private void AccionBotonesBarra(object sender, EventArgs e)
        {
            var panel = ((Panel)sender);

            switch (panel.Name)
            {
                case "pCerrar":
                    Application.Exit();
                    break;
                case "pMaxMin":
                    if (pMaxMin.BackgroundImage == imgMinimizar)
                    {
                        this.Size = new Size(800, 600);

                        int pantallaAncho = Screen.PrimaryScreen.Bounds.Width;
                        int pantallaAlto = Screen.PrimaryScreen.Bounds.Height;

                        int formX = (pantallaAncho - this.Width) / 2;
                        int formY = (pantallaAlto - this.Height) / 2;

                        this.Location = new Point(formX, formY);

                        pMaxMin.BackgroundImage = imgMaximizar;
                    }
                    else
                    {
                        this.Bounds = Screen.PrimaryScreen.WorkingArea;
                        pMaxMin.BackgroundImage = imgMinimizar;
                    }
                    break;
                case "pMin":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }
    }
}
