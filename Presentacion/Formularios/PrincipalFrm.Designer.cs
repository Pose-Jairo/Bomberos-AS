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
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pContenedor = new Panel();
            pFecha = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            btnAdmin = new Button();
            btnConsultas = new Button();
            btnInicio = new Button();
            pLogo = new Panel();
            pFormularios = new Panel();
            tFecha = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pBarraSuperior.SuspendLayout();
            pContenedor.SuspendLayout();
            pFecha.SuspendLayout();
            pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pBarraSuperior
            // 
            pBarraSuperior.BackColor = Color.FromArgb(138, 34, 50);
            pBarraSuperior.Controls.Add(panel4);
            pBarraSuperior.Controls.Add(panel3);
            pBarraSuperior.Controls.Add(panel2);
            pBarraSuperior.Dock = DockStyle.Top;
            pBarraSuperior.Location = new Point(0, 0);
            pBarraSuperior.Name = "pBarraSuperior";
            pBarraSuperior.Size = new Size(950, 32);
            pBarraSuperior.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(800, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(50, 32);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(850, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 32);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(900, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 32);
            panel2.TabIndex = 0;
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(138, 34, 50);
            pContenedor.Controls.Add(pFecha);
            pContenedor.Controls.Add(btnAdmin);
            pContenedor.Controls.Add(btnConsultas);
            pContenedor.Controls.Add(btnInicio);
            pContenedor.Controls.Add(pLogo);
            pContenedor.Dock = DockStyle.Left;
            pContenedor.Location = new Point(0, 32);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(180, 468);
            pContenedor.TabIndex = 1;
            // 
            // pFecha
            // 
            pFecha.Controls.Add(lblHora);
            pFecha.Controls.Add(lblFecha);
            pFecha.Dock = DockStyle.Bottom;
            pFecha.Location = new Point(0, 379);
            pFecha.Name = "pFecha";
            pFecha.Size = new Size(180, 89);
            pFecha.TabIndex = 4;
            // 
            // lblHora
            // 
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
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(97, 24, 35);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleRight;
            btnAdmin.Location = new Point(0, 300);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(180, 75);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Administracion";
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(97, 24, 35);
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.Dock = DockStyle.Top;
            btnConsultas.FlatStyle = FlatStyle.Popup;
            btnConsultas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Image = (Image)resources.GetObject("btnConsultas.Image");
            btnConsultas.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultas.Location = new Point(0, 225);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(180, 75);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = "Consultas";
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(97, 24, 35);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleRight;
            btnInicio.Location = new Point(0, 150);
            btnInicio.Name = "btnInicio";
            btnInicio.RightToLeft = RightToLeft.No;
            btnInicio.Size = new Size(180, 75);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // pLogo
            // 
            pLogo.Controls.Add(pictureBox1);
            pLogo.Dock = DockStyle.Top;
            pLogo.Location = new Point(0, 0);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(180, 150);
            pLogo.TabIndex = 0;
            // 
            // pFormularios
            // 
            pFormularios.BackColor = Color.FromArgb(208, 167, 173);
            pFormularios.Dock = DockStyle.Fill;
            pFormularios.Location = new Point(180, 32);
            pFormularios.Name = "pFormularios";
            pFormularios.Size = new Size(770, 468);
            pFormularios.TabIndex = 2;
            // 
            // tFecha
            // 
            tFecha.Enabled = true;
            tFecha.Tick += tFecha_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PrincipalFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 500);
            Controls.Add(pFormularios);
            Controls.Add(pContenedor);
            Controls.Add(pBarraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalFrm";
            Load += PrincipalFrm_Load;
            pBarraSuperior.ResumeLayout(false);
            pContenedor.ResumeLayout(false);
            pFecha.ResumeLayout(false);
            pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pBarraSuperior;
        private Panel pContenedor;
        private Panel pFormularios;
        private Panel pLogo;
        private Button btnInicio;
        private Panel pFecha;
        private Button btnAdmin;
        private Button btnConsultas;
        private Label lblFecha;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblHora;
        private System.Windows.Forms.Timer tFecha;
        private PictureBox pictureBox1;
    }
}