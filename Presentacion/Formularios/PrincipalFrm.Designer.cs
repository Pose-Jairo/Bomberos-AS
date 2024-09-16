namespace Presentacion.Formularios
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            pBarraSuperior = new Panel();
            lblTitulo = new Label();
            panelLogo = new Panel();
            pbLogo2 = new PictureBox();
            pMin = new Panel();
            pMaxMin = new Panel();
            pCerrar = new Panel();
            pContenedor = new Panel();
            btnAdmin = new Button();
            pFecha = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            btnArea = new Button();
            btnConsultas = new Button();
            btnInicio = new Button();
            pLogo = new Panel();
            pbLogo = new PictureBox();
            panelContenedor = new Panel();
            tFecha = new System.Windows.Forms.Timer(components);
            pBarraSuperior.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo2).BeginInit();
            pContenedor.SuspendLayout();
            pFecha.SuspendLayout();
            pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pBarraSuperior
            // 
            pBarraSuperior.BackColor = Color.FromArgb(68, 17, 25);
            pBarraSuperior.Controls.Add(lblTitulo);
            pBarraSuperior.Controls.Add(panelLogo);
            pBarraSuperior.Controls.Add(pMin);
            pBarraSuperior.Controls.Add(pMaxMin);
            pBarraSuperior.Controls.Add(pCerrar);
            pBarraSuperior.Dock = DockStyle.Top;
            pBarraSuperior.Location = new Point(0, 0);
            pBarraSuperior.Name = "pBarraSuperior";
            pBarraSuperior.Size = new Size(1120, 22);
            pBarraSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(44, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 17);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Bomberos Voluntarios de San Vicente";
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Controls.Add(pbLogo2);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(2);
            panelLogo.Size = new Size(40, 22);
            panelLogo.TabIndex = 3;
            // 
            // pbLogo2
            // 
            pbLogo2.BackgroundImage = Properties.Resources.Logo;
            pbLogo2.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo2.Dock = DockStyle.Fill;
            pbLogo2.Location = new Point(2, 2);
            pbLogo2.Name = "pbLogo2";
            pbLogo2.Size = new Size(36, 18);
            pbLogo2.TabIndex = 0;
            pbLogo2.TabStop = false;
            // 
            // pMin
            // 
            pMin.BackgroundImage = Properties.Resources.icon_minimizar;
            pMin.BackgroundImageLayout = ImageLayout.Center;
            pMin.Dock = DockStyle.Right;
            pMin.Location = new Point(970, 0);
            pMin.Name = "pMin";
            pMin.Size = new Size(50, 22);
            pMin.TabIndex = 2;
            pMin.Click += AccionBotonesBarra;
            // 
            // pMaxMin
            // 
            pMaxMin.BackgroundImage = Properties.Resources.icon_restaurar;
            pMaxMin.BackgroundImageLayout = ImageLayout.Center;
            pMaxMin.Dock = DockStyle.Right;
            pMaxMin.Location = new Point(1020, 0);
            pMaxMin.Name = "pMaxMin";
            pMaxMin.Size = new Size(50, 22);
            pMaxMin.TabIndex = 1;
            pMaxMin.Click += AccionBotonesBarra;
            // 
            // pCerrar
            // 
            pCerrar.BackgroundImage = Properties.Resources.icon_cerrar;
            pCerrar.BackgroundImageLayout = ImageLayout.Center;
            pCerrar.Dock = DockStyle.Right;
            pCerrar.Location = new Point(1070, 0);
            pCerrar.Name = "pCerrar";
            pCerrar.Size = new Size(50, 22);
            pCerrar.TabIndex = 0;
            pCerrar.Click += AccionBotonesBarra;
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(68, 17, 25);
            pContenedor.Controls.Add(btnAdmin);
            pContenedor.Controls.Add(pFecha);
            pContenedor.Controls.Add(btnArea);
            pContenedor.Controls.Add(btnConsultas);
            pContenedor.Controls.Add(btnInicio);
            pContenedor.Controls.Add(pLogo);
            pContenedor.Dock = DockStyle.Left;
            pContenedor.Location = new Point(0, 22);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(180, 518);
            pContenedor.TabIndex = 1;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(97, 24, 35);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Image = Properties.Resources.icon_bombero;
            btnAdmin.ImageAlign = ContentAlignment.MiddleRight;
            btnAdmin.Location = new Point(0, 375);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.RightToLeft = RightToLeft.No;
            btnAdmin.Size = new Size(180, 75);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = " Administracion";
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += SeleccionButtons;
            // 
            // pFecha
            // 
            pFecha.Controls.Add(lblHora);
            pFecha.Controls.Add(lblFecha);
            pFecha.Dock = DockStyle.Bottom;
            pFecha.Location = new Point(0, 429);
            pFecha.Name = "pFecha";
            pFecha.Size = new Size(180, 89);
            pFecha.TabIndex = 4;
            // 
            // lblHora
            // 
            lblHora.BackColor = Color.FromArgb(68, 17, 25);
            lblHora.Dock = DockStyle.Bottom;
            lblHora.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(0, 45);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(180, 44);
            lblHora.TabIndex = 1;
            lblHora.Text = "HORA";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.BackColor = Color.FromArgb(68, 17, 25);
            lblFecha.Dock = DockStyle.Top;
            lblFecha.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(0, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(180, 45);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "FECHA";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnArea
            // 
            btnArea.BackColor = Color.FromArgb(97, 24, 35);
            btnArea.Cursor = Cursors.Hand;
            btnArea.Dock = DockStyle.Top;
            btnArea.FlatStyle = FlatStyle.Popup;
            btnArea.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnArea.ForeColor = Color.White;
            btnArea.Image = (Image)resources.GetObject("btnArea.Image");
            btnArea.ImageAlign = ContentAlignment.MiddleRight;
            btnArea.Location = new Point(0, 300);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(180, 75);
            btnArea.TabIndex = 3;
            btnArea.Text = " Areas";
            btnArea.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArea.UseVisualStyleBackColor = false;
            btnArea.Click += SeleccionButtons;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(97, 24, 35);
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.Dock = DockStyle.Top;
            btnConsultas.FlatStyle = FlatStyle.Popup;
            btnConsultas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Image = Properties.Resources.icon_consultas;
            btnConsultas.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultas.Location = new Point(0, 225);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(180, 75);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = " Consultas";
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += SeleccionButtons;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(97, 24, 35);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.icon_inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleRight;
            btnInicio.Location = new Point(0, 150);
            btnInicio.Name = "btnInicio";
            btnInicio.RightToLeft = RightToLeft.No;
            btnInicio.Size = new Size(180, 75);
            btnInicio.TabIndex = 1;
            btnInicio.Text = " Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += SeleccionButtons;
            // 
            // pLogo
            // 
            pLogo.BackColor = Color.FromArgb(68, 17, 25);
            pLogo.BackgroundImageLayout = ImageLayout.None;
            pLogo.Controls.Add(pbLogo);
            pLogo.Dock = DockStyle.Top;
            pLogo.Location = new Point(0, 0);
            pLogo.Name = "pLogo";
            pLogo.Padding = new Padding(10);
            pLogo.Size = new Size(180, 150);
            pLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.Logo;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Location = new Point(10, 10);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(160, 130);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(144, 93, 101);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(180, 22);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(940, 518);
            panelContenedor.TabIndex = 2;
            // 
            // tFecha
            // 
            tFecha.Enabled = true;
            tFecha.Tick += tFecha_Tick;
            // 
            // PrincipalFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 540);
            Controls.Add(panelContenedor);
            Controls.Add(pContenedor);
            Controls.Add(pBarraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrincipalFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalFrm";
            Load += PrincipalFrm_Load;
            pBarraSuperior.ResumeLayout(false);
            pBarraSuperior.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo2).EndInit();
            pContenedor.ResumeLayout(false);
            pFecha.ResumeLayout(false);
            pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pBarraSuperior;
        private Panel pContenedor;
        private Panel panelContenedor;
        private Panel pLogo;
        private Button btnInicio;
        private Panel pFecha;
        private Button btnArea;
        private Button btnConsultas;
        private Label lblFecha;
        private Panel pMin;
        private Panel pMaxMin;
        private Panel pCerrar;
        private Label lblHora;
        private System.Windows.Forms.Timer tFecha;
        private Panel panelLogo;
        private Button btnAdmin;
        private Label lblTitulo;
        private PictureBox pbLogo2;
        private PictureBox pbLogo;
    }
}