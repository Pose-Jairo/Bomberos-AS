namespace Presentacion.Formularios
{
    partial class FrmAdministracion
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
            pInferior = new Panel();
            pSuperior = new Panel();
            pictureBox1 = new PictureBox();
            btnCalificacion = new Button();
            btnAreas = new Button();
            btnReuniones = new Button();
            btnBomberos = new Button();
            btnAsisArea = new Button();
            btnAsisInsti = new Button();
            pContenedor = new Panel();
            pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pInferior
            // 
            pInferior.BackColor = Color.FromArgb(78, 17, 25);
            pInferior.Dock = DockStyle.Bottom;
            pInferior.Location = new Point(0, 451);
            pInferior.Name = "pInferior";
            pInferior.Size = new Size(1095, 100);
            pInferior.TabIndex = 0;
            // 
            // pSuperior
            // 
            pSuperior.BackColor = Color.FromArgb(78, 17, 25);
            pSuperior.Controls.Add(pictureBox1);
            pSuperior.Dock = DockStyle.Top;
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Size = new Size(1095, 100);
            pSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(499, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCalificacion
            // 
            btnCalificacion.Anchor = AnchorStyles.None;
            btnCalificacion.BackColor = Color.FromArgb(97, 24, 35);
            btnCalificacion.FlatStyle = FlatStyle.Popup;
            btnCalificacion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalificacion.ForeColor = Color.White;
            btnCalificacion.Location = new Point(577, 61);
            btnCalificacion.Name = "btnCalificacion";
            btnCalificacion.Size = new Size(200, 84);
            btnCalificacion.TabIndex = 2;
            btnCalificacion.Text = "Calificacion";
            btnCalificacion.UseVisualStyleBackColor = false;
            // 
            // btnAreas
            // 
            btnAreas.Anchor = AnchorStyles.None;
            btnAreas.BackColor = Color.FromArgb(97, 24, 35);
            btnAreas.FlatStyle = FlatStyle.Popup;
            btnAreas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAreas.ForeColor = Color.White;
            btnAreas.Location = new Point(59, 61);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(200, 84);
            btnAreas.TabIndex = 3;
            btnAreas.Text = "Areas";
            btnAreas.UseVisualStyleBackColor = false;
            btnAreas.Click += SeleccionButtons;
            // 
            // btnReuniones
            // 
            btnReuniones.Anchor = AnchorStyles.None;
            btnReuniones.BackColor = Color.FromArgb(97, 24, 35);
            btnReuniones.FlatStyle = FlatStyle.Popup;
            btnReuniones.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReuniones.ForeColor = Color.White;
            btnReuniones.Location = new Point(836, 61);
            btnReuniones.Name = "btnReuniones";
            btnReuniones.Size = new Size(200, 84);
            btnReuniones.TabIndex = 4;
            btnReuniones.Text = "Reuniones";
            btnReuniones.UseVisualStyleBackColor = false;
            // 
            // btnBomberos
            // 
            btnBomberos.Anchor = AnchorStyles.None;
            btnBomberos.BackColor = Color.FromArgb(97, 24, 35);
            btnBomberos.FlatStyle = FlatStyle.Popup;
            btnBomberos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBomberos.ForeColor = Color.White;
            btnBomberos.Location = new Point(318, 61);
            btnBomberos.Name = "btnBomberos";
            btnBomberos.Size = new Size(200, 84);
            btnBomberos.TabIndex = 5;
            btnBomberos.Text = "Bomberos";
            btnBomberos.UseVisualStyleBackColor = false;
            btnBomberos.Click += SeleccionButtons;
            // 
            // btnAsisArea
            // 
            btnAsisArea.Anchor = AnchorStyles.None;
            btnAsisArea.AutoSize = true;
            btnAsisArea.BackColor = Color.FromArgb(97, 24, 35);
            btnAsisArea.FlatStyle = FlatStyle.Popup;
            btnAsisArea.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsisArea.ForeColor = Color.White;
            btnAsisArea.Location = new Point(59, 206);
            btnAsisArea.Name = "btnAsisArea";
            btnAsisArea.Size = new Size(459, 84);
            btnAsisArea.TabIndex = 6;
            btnAsisArea.Text = "Asistencia a Area";
            btnAsisArea.UseVisualStyleBackColor = false;
            btnAsisArea.Click += SeleccionButtons;
            // 
            // btnAsisInsti
            // 
            btnAsisInsti.Anchor = AnchorStyles.None;
            btnAsisInsti.AutoSize = true;
            btnAsisInsti.BackColor = Color.FromArgb(97, 24, 35);
            btnAsisInsti.FlatStyle = FlatStyle.Popup;
            btnAsisInsti.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsisInsti.ForeColor = Color.White;
            btnAsisInsti.Location = new Point(577, 206);
            btnAsisInsti.Name = "btnAsisInsti";
            btnAsisInsti.Size = new Size(459, 84);
            btnAsisInsti.TabIndex = 7;
            btnAsisInsti.Text = "Asistencia a Institucion";
            btnAsisInsti.UseVisualStyleBackColor = false;
            btnAsisInsti.Click += SeleccionButtons;
            // 
            // pContenedor
            // 
            pContenedor.Controls.Add(btnAreas);
            pContenedor.Controls.Add(btnAsisInsti);
            pContenedor.Controls.Add(btnCalificacion);
            pContenedor.Controls.Add(btnAsisArea);
            pContenedor.Controls.Add(btnReuniones);
            pContenedor.Controls.Add(btnBomberos);
            pContenedor.Dock = DockStyle.Fill;
            pContenedor.Location = new Point(0, 100);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(1095, 351);
            pContenedor.TabIndex = 8;
            // 
            // FrmAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(1095, 551);
            Controls.Add(pContenedor);
            Controls.Add(pSuperior);
            Controls.Add(pInferior);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministracion";
            Text = "FrmAdministracion";
            pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pInferior;
        private Panel pSuperior;
        private Button btnCalificacion;
        private Button btnAreas;
        private Button btnReuniones;
        private Button btnBomberos;
        private Button btnAsisArea;
        private Button btnAsisInsti;
        private Panel pContenedor;
        private PictureBox pictureBox1;
    }
}