namespace Presentacion.Formularios
{
    partial class FrmAreas
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
            pContenedor = new Panel();
            btnFurrieles = new Button();
            btnRoperia = new Button();
            btnAutomotores = new Button();
            btnEdificio = new Button();
            btnCapacitacion = new Button();
            btnTaller = new Button();
            pSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pInferior = new Panel();
            pContenedor.SuspendLayout();
            pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.Controls.Add(btnFurrieles);
            pContenedor.Controls.Add(btnRoperia);
            pContenedor.Controls.Add(btnAutomotores);
            pContenedor.Controls.Add(btnEdificio);
            pContenedor.Controls.Add(btnCapacitacion);
            pContenedor.Controls.Add(btnTaller);
            pContenedor.Dock = DockStyle.Fill;
            pContenedor.Location = new Point(0, 100);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(1095, 351);
            pContenedor.TabIndex = 11;
            // 
            // btnFurrieles
            // 
            btnFurrieles.Anchor = AnchorStyles.None;
            btnFurrieles.BackColor = Color.FromArgb(97, 24, 35);
            btnFurrieles.Cursor = Cursors.Hand;
            btnFurrieles.FlatStyle = FlatStyle.Popup;
            btnFurrieles.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFurrieles.ForeColor = Color.White;
            btnFurrieles.Location = new Point(78, 206);
            btnFurrieles.Name = "btnFurrieles";
            btnFurrieles.Size = new Size(260, 84);
            btnFurrieles.TabIndex = 8;
            btnFurrieles.Text = "Furrieles";
            btnFurrieles.UseVisualStyleBackColor = false;
            btnFurrieles.Click += SeleccionButtons;
            // 
            // btnRoperia
            // 
            btnRoperia.Anchor = AnchorStyles.None;
            btnRoperia.BackColor = Color.FromArgb(97, 24, 35);
            btnRoperia.Cursor = Cursors.Hand;
            btnRoperia.FlatStyle = FlatStyle.Popup;
            btnRoperia.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoperia.ForeColor = Color.White;
            btnRoperia.Location = new Point(417, 206);
            btnRoperia.Name = "btnRoperia";
            btnRoperia.Size = new Size(260, 84);
            btnRoperia.TabIndex = 7;
            btnRoperia.Text = "Roperia";
            btnRoperia.UseVisualStyleBackColor = false;
            btnRoperia.Click += SeleccionButtons;
            // 
            // btnAutomotores
            // 
            btnAutomotores.Anchor = AnchorStyles.None;
            btnAutomotores.BackColor = Color.FromArgb(97, 24, 35);
            btnAutomotores.Cursor = Cursors.Hand;
            btnAutomotores.FlatStyle = FlatStyle.Popup;
            btnAutomotores.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutomotores.ForeColor = Color.White;
            btnAutomotores.Location = new Point(756, 206);
            btnAutomotores.Name = "btnAutomotores";
            btnAutomotores.Size = new Size(260, 84);
            btnAutomotores.TabIndex = 6;
            btnAutomotores.Text = "Automotores";
            btnAutomotores.UseVisualStyleBackColor = false;
            btnAutomotores.Click += SeleccionButtons;
            // 
            // btnEdificio
            // 
            btnEdificio.Anchor = AnchorStyles.None;
            btnEdificio.BackColor = Color.FromArgb(97, 24, 35);
            btnEdificio.Cursor = Cursors.Hand;
            btnEdificio.FlatStyle = FlatStyle.Popup;
            btnEdificio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdificio.ForeColor = Color.White;
            btnEdificio.Location = new Point(78, 59);
            btnEdificio.Name = "btnEdificio";
            btnEdificio.Size = new Size(260, 84);
            btnEdificio.TabIndex = 3;
            btnEdificio.Text = "Edificio";
            btnEdificio.UseVisualStyleBackColor = false;
            btnEdificio.Click += SeleccionButtons;
            // 
            // btnCapacitacion
            // 
            btnCapacitacion.Anchor = AnchorStyles.None;
            btnCapacitacion.BackColor = Color.FromArgb(97, 24, 35);
            btnCapacitacion.Cursor = Cursors.Hand;
            btnCapacitacion.FlatStyle = FlatStyle.Popup;
            btnCapacitacion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapacitacion.ForeColor = Color.White;
            btnCapacitacion.Location = new Point(756, 59);
            btnCapacitacion.Name = "btnCapacitacion";
            btnCapacitacion.Size = new Size(260, 84);
            btnCapacitacion.TabIndex = 2;
            btnCapacitacion.Text = "Capacitacion";
            btnCapacitacion.UseVisualStyleBackColor = false;
            btnCapacitacion.Click += SeleccionButtons;
            // 
            // btnTaller
            // 
            btnTaller.Anchor = AnchorStyles.None;
            btnTaller.BackColor = Color.FromArgb(97, 24, 35);
            btnTaller.Cursor = Cursors.Hand;
            btnTaller.FlatStyle = FlatStyle.Popup;
            btnTaller.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaller.ForeColor = Color.White;
            btnTaller.Location = new Point(417, 59);
            btnTaller.Name = "btnTaller";
            btnTaller.Size = new Size(260, 84);
            btnTaller.TabIndex = 5;
            btnTaller.Text = "Taller";
            btnTaller.UseVisualStyleBackColor = false;
            btnTaller.Click += SeleccionButtons;
            // 
            // pSuperior
            // 
            pSuperior.BackColor = Color.FromArgb(78, 17, 25);
            pSuperior.Controls.Add(pictureBox1);
            pSuperior.Dock = DockStyle.Top;
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Size = new Size(1095, 100);
            pSuperior.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(500, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 94);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pInferior
            // 
            pInferior.BackColor = Color.FromArgb(78, 17, 25);
            pInferior.Dock = DockStyle.Bottom;
            pInferior.Location = new Point(0, 451);
            pInferior.Name = "pInferior";
            pInferior.Size = new Size(1095, 100);
            pInferior.TabIndex = 9;
            // 
            // FrmAreas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(1095, 551);
            Controls.Add(pContenedor);
            Controls.Add(pSuperior);
            Controls.Add(pInferior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAreas";
            Text = "FrmAreas";
            pContenedor.ResumeLayout(false);
            pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pContenedor;
        private Button btnEdificio;
        private Button btnCapacitacion;
        private Button btnTaller;
        private Panel pSuperior;
        private Panel pInferior;
        private Button btnFurrieles;
        private Button btnRoperia;
        private Button btnAutomotores;
        private PictureBox pictureBox1;
    }
}