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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnEmergencia = new Button();
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
            btnEntrada.Cursor = Cursors.Hand;
            btnEntrada.FlatStyle = FlatStyle.Popup;
            btnEntrada.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.ForeColor = Color.White;
            btnEntrada.Location = new Point(348, 151);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(175, 45);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = ">> Entrada >>";
            btnEntrada.UseVisualStyleBackColor = false;
            // 
            // btnSalida
            // 
            btnSalida.Anchor = AnchorStyles.None;
            btnSalida.BackColor = Color.Red;
            btnSalida.Cursor = Cursors.Hand;
            btnSalida.FlatStyle = FlatStyle.Popup;
            btnSalida.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalida.ForeColor = Color.White;
            btnSalida.Location = new Point(533, 151);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(175, 45);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "<< Salida <<";
            btnSalida.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.BackColor = Color.FromArgb(176, 140, 145);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(348, 92);
            txtCodigo.MaxLength = 3;
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(360, 46);
            txtCodigo.TabIndex = 2;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(dgvHistorial);
            gbHistorial.Dock = DockStyle.Fill;
            gbHistorial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbHistorial.ForeColor = Color.White;
            gbHistorial.Location = new Point(0, 0);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Padding = new Padding(9, 8, 9, 8);
            gbHistorial.Size = new Size(1059, 308);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(176, 140, 145);
            dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHistorial.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(9, 27);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(1041, 273);
            dgvHistorial.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo:";
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
            lblCodigo.Location = new Point(348, 70);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(122, 20);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Identificación:";
            // 
            // pHistorial
            // 
            pHistorial.Controls.Add(gbHistorial);
            pHistorial.Dock = DockStyle.Fill;
            pHistorial.Location = new Point(18, 228);
            pHistorial.Margin = new Padding(3, 2, 3, 2);
            pHistorial.Name = "pHistorial";
            pHistorial.Size = new Size(1059, 308);
            pHistorial.TabIndex = 5;
            // 
            // pEncabezado
            // 
            pEncabezado.Controls.Add(btnEmergencia);
            pEncabezado.Controls.Add(lblCodigo);
            pEncabezado.Controls.Add(btnEntrada);
            pEncabezado.Controls.Add(btnSalida);
            pEncabezado.Controls.Add(txtCodigo);
            pEncabezado.Dock = DockStyle.Top;
            pEncabezado.Location = new Point(18, 15);
            pEncabezado.Margin = new Padding(3, 2, 3, 2);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(1059, 213);
            pEncabezado.TabIndex = 6;
            // 
            // btnEmergencia
            // 
            btnEmergencia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEmergencia.BackColor = Color.Red;
            btnEmergencia.Cursor = Cursors.Hand;
            btnEmergencia.FlatStyle = FlatStyle.Popup;
            btnEmergencia.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmergencia.ForeColor = Color.White;
            btnEmergencia.Location = new Point(881, 162);
            btnEmergencia.Name = "btnEmergencia";
            btnEmergencia.Size = new Size(175, 45);
            btnEmergencia.TabIndex = 5;
            btnEmergencia.Text = "EMERGENCIA";
            btnEmergencia.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(1095, 551);
            Controls.Add(pHistorial);
            Controls.Add(pEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Padding = new Padding(18, 15, 18, 15);
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
        private Label lblCodigo;
        private Panel pHistorial;
        private Panel pEncabezado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnEmergencia;
    }
}