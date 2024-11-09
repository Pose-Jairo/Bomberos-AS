namespace Presentacion.Formularios
{
    partial class FrmAreaRegistro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gbHistorial = new GroupBox();
            dgvHistorialTareas = new DataGridView();
            gbTareas = new GroupBox();
            cmbAreas = new ComboBox();
            mtxtHora = new MaskedTextBox();
            btnVolverArea = new Button();
            lblHoraInicio = new Label();
            lblDescripcion = new Label();
            lblCodigo = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            btnRegistrar = new Button();
            pHistorial = new Panel();
            pTareas = new Panel();
            label1 = new Label();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTareas).BeginInit();
            gbTareas.SuspendLayout();
            pHistorial.SuspendLayout();
            pTareas.SuspendLayout();
            SuspendLayout();
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(dgvHistorialTareas);
            gbHistorial.Dock = DockStyle.Fill;
            gbHistorial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbHistorial.ForeColor = Color.White;
            gbHistorial.Location = new Point(10, 10);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Padding = new Padding(1);
            gbHistorial.Size = new Size(810, 292);
            gbHistorial.TabIndex = 0;
            gbHistorial.TabStop = false;
            gbHistorial.Text = "Historial de registros:";
            // 
            // dgvHistorialTareas
            // 
            dgvHistorialTareas.AllowUserToAddRows = false;
            dgvHistorialTareas.AllowUserToDeleteRows = false;
            dgvHistorialTareas.AllowUserToResizeRows = false;
            dgvHistorialTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialTareas.BackgroundColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorialTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorialTareas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialTareas.Dock = DockStyle.Fill;
            dgvHistorialTareas.Location = new Point(1, 20);
            dgvHistorialTareas.Name = "dgvHistorialTareas";
            dgvHistorialTareas.ReadOnly = true;
            dgvHistorialTareas.RowHeadersVisible = false;
            dgvHistorialTareas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(176, 140, 145);
            dgvHistorialTareas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorialTareas.RowTemplate.Height = 25;
            dgvHistorialTareas.Size = new Size(808, 271);
            dgvHistorialTareas.TabIndex = 0;
            // 
            // gbTareas
            // 
            gbTareas.Controls.Add(label1);
            gbTareas.Controls.Add(cmbAreas);
            gbTareas.Controls.Add(mtxtHora);
            gbTareas.Controls.Add(btnVolverArea);
            gbTareas.Controls.Add(lblHoraInicio);
            gbTareas.Controls.Add(lblDescripcion);
            gbTareas.Controls.Add(lblCodigo);
            gbTareas.Controls.Add(txtDescripcion);
            gbTareas.Controls.Add(txtCodigo);
            gbTareas.Controls.Add(btnRegistrar);
            gbTareas.Dock = DockStyle.Fill;
            gbTareas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbTareas.ForeColor = Color.White;
            gbTareas.Location = new Point(10, 10);
            gbTareas.Name = "gbTareas";
            gbTareas.Size = new Size(810, 181);
            gbTareas.TabIndex = 1;
            gbTareas.TabStop = false;
            gbTareas.Text = "Registrar Nueva Tarea:";
            // 
            // cmbAreas
            // 
            cmbAreas.Anchor = AnchorStyles.None;
            cmbAreas.BackColor = Color.FromArgb(176, 140, 145);
            cmbAreas.FlatStyle = FlatStyle.Flat;
            cmbAreas.ForeColor = Color.White;
            cmbAreas.FormattingEnabled = true;
            cmbAreas.Location = new Point(291, 42);
            cmbAreas.Name = "cmbAreas";
            cmbAreas.Size = new Size(145, 28);
            cmbAreas.TabIndex = 13;
            // 
            // mtxtHora
            // 
            mtxtHora.Anchor = AnchorStyles.None;
            mtxtHora.BackColor = Color.FromArgb(176, 140, 145);
            mtxtHora.BorderStyle = BorderStyle.None;
            mtxtHora.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtHora.ForeColor = Color.White;
            mtxtHora.Location = new Point(162, 46);
            mtxtHora.Mask = "00:00";
            mtxtHora.Name = "mtxtHora";
            mtxtHora.ShortcutsEnabled = false;
            mtxtHora.Size = new Size(108, 24);
            mtxtHora.TabIndex = 12;
            mtxtHora.Text = "0000";
            mtxtHora.TextAlign = HorizontalAlignment.Center;
            mtxtHora.ValidatingType = typeof(DateTime);
            mtxtHora.MouseClick += mtxtHora_MouseClick;
            mtxtHora.KeyPress += ValidacionDeFormato;
            mtxtHora.MouseLeave += mtxtHora_MouseLeave;
            // 
            // btnVolverArea
            // 
            btnVolverArea.Anchor = AnchorStyles.None;
            btnVolverArea.BackColor = Color.Red;
            btnVolverArea.Cursor = Cursors.Hand;
            btnVolverArea.FlatStyle = FlatStyle.Popup;
            btnVolverArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverArea.Location = new Point(653, 140);
            btnVolverArea.Name = "btnVolverArea";
            btnVolverArea.Size = new Size(121, 30);
            btnVolverArea.TabIndex = 2;
            btnVolverArea.Text = "Volver";
            btnVolverArea.UseVisualStyleBackColor = false;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.Anchor = AnchorStyles.None;
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(159, 23);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(111, 20);
            lblHoraInicio.TabIndex = 10;
            lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(42, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(151, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Tarea (Descripcion):";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(63, 20);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Codigo:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.BackColor = Color.FromArgb(176, 140, 145);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(42, 97);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(394, 67);
            txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.BackColor = Color.FromArgb(176, 140, 145);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(42, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 24);
            txtCodigo.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(515, 140);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 30);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pHistorial
            // 
            pHistorial.Controls.Add(gbHistorial);
            pHistorial.Dock = DockStyle.Top;
            pHistorial.Location = new Point(0, 0);
            pHistorial.Name = "pHistorial";
            pHistorial.Padding = new Padding(10);
            pHistorial.Size = new Size(830, 312);
            pHistorial.TabIndex = 3;
            // 
            // pTareas
            // 
            pTareas.Controls.Add(gbTareas);
            pTareas.Dock = DockStyle.Fill;
            pTareas.Location = new Point(0, 312);
            pTareas.Name = "pTareas";
            pTareas.Padding = new Padding(10);
            pTareas.Size = new Size(830, 201);
            pTareas.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(291, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 14;
            label1.Text = "Area:";
            // 
            // FrmAreaRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(830, 513);
            ControlBox = false;
            Controls.Add(pTareas);
            Controls.Add(pHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAreaRegistro";
            Text = "FrmAreaRegistro";
            Load += FrmAreaRegistro_Load;
            gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTareas).EndInit();
            gbTareas.ResumeLayout(false);
            gbTareas.PerformLayout();
            pHistorial.ResumeLayout(false);
            pTareas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbHistorial;
        private DataGridView dgvHistorialTareas;
        private GroupBox gbTareas;
        private Label lblHoraInicio;
        private Label lblDescripcion;
        private Label lblCodigo;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Button btnRegistrar;
        private Button btnVolverArea;
        private Panel pHistorial;
        private Panel pTareas;
        private MaskedTextBox mtxtHora;
        private ComboBox cmbAreas;
        private Label label1;
    }
}