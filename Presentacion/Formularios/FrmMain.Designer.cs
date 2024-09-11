namespace Presentacion.Formularios
{
    partial class FrmMain
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
            btnEntrada = new Button();
            btnSalida = new Button();
            txtCodigo = new TextBox();
            gbHistorial = new GroupBox();
            dgvHistorial = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblCodigo = new Label();
            pHistorial = new Panel();
            pEncabezado = new Panel();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            pHistorial.SuspendLayout();
            pEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Anchor = AnchorStyles.None;
            btnEntrada.BackColor = Color.Green;
            btnEntrada.FlatStyle = FlatStyle.Popup;
            btnEntrada.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.ForeColor = Color.White;
            btnEntrada.Location = new Point(399, 201);
            btnEntrada.Margin = new Padding(3, 4, 3, 4);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(200, 60);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = ">> Entrada >>";
            btnEntrada.UseVisualStyleBackColor = false;
            // 
            // btnSalida
            // 
            btnSalida.Anchor = AnchorStyles.None;
            btnSalida.BackColor = Color.Red;
            btnSalida.FlatStyle = FlatStyle.Popup;
            btnSalida.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalida.ForeColor = Color.White;
            btnSalida.Location = new Point(610, 201);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(200, 60);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "<< Salida <<";
            btnSalida.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.Location = new Point(399, 123);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(411, 60);
            txtCodigo.TabIndex = 2;
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(dgvHistorial);
            gbHistorial.Dock = DockStyle.Fill;
            gbHistorial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbHistorial.ForeColor = Color.White;
            gbHistorial.Location = new Point(0, 0);
            gbHistorial.Margin = new Padding(3, 4, 3, 4);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Padding = new Padding(10);
            gbHistorial.Size = new Size(1211, 411);
            gbHistorial.TabIndex = 3;
            gbHistorial.TabStop = false;
            gbHistorial.Text = "Historial de registros";
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(10, 33);
            dgvHistorial.Margin = new Padding(3, 4, 3, 4);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(1191, 368);
            dgvHistorial.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cod:";
            Column1.MaxInputLength = 3;
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre:";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido:";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Hora Entrada:";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Hora Salida:";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(399, 94);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(146, 25);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Identificación:";
            // 
            // pHistorial
            // 
            pHistorial.Controls.Add(gbHistorial);
            pHistorial.Dock = DockStyle.Fill;
            pHistorial.Location = new Point(20, 304);
            pHistorial.Name = "pHistorial";
            pHistorial.Size = new Size(1211, 411);
            pHistorial.TabIndex = 5;
            // 
            // pEncabezado
            // 
            pEncabezado.Controls.Add(lblCodigo);
            pEncabezado.Controls.Add(btnEntrada);
            pEncabezado.Controls.Add(btnSalida);
            pEncabezado.Controls.Add(txtCodigo);
            pEncabezado.Dock = DockStyle.Top;
            pEncabezado.Location = new Point(20, 20);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(1211, 284);
            pEncabezado.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 167, 173);
            ClientSize = new Size(1251, 735);
            Controls.Add(pHistorial);
            Controls.Add(pEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Padding = new Padding(20);
            Text = "FrmMain";
            gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            pHistorial.ResumeLayout(false);
            pEncabezado.ResumeLayout(false);
            pEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrada;
        private Button btnSalida;
        private TextBox txtCodigo;
        private GroupBox gbHistorial;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lblCodigo;
        private Panel pHistorial;
        private Panel pEncabezado;
    }
}