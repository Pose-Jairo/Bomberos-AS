namespace Presentacion.Formularios
{
    partial class Consultas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel5 = new Panel();
            gbConsultas = new GroupBox();
            dgvHistorial = new DataGridView();
            panel1 = new Panel();
            dtpFecha = new DateTimePicker();
            btnCargar = new Button();
            label2 = new Label();
            txtConsulta = new TextBox();
            panel5.SuspendLayout();
            gbConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(gbConsultas);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(18, 228);
            panel5.Name = "panel5";
            panel5.Size = new Size(849, 299);
            panel5.TabIndex = 9;
            // 
            // gbConsultas
            // 
            gbConsultas.Controls.Add(dgvHistorial);
            gbConsultas.Dock = DockStyle.Fill;
            gbConsultas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbConsultas.ForeColor = Color.White;
            gbConsultas.Location = new Point(0, 0);
            gbConsultas.Name = "gbConsultas";
            gbConsultas.Padding = new Padding(9, 8, 9, 8);
            gbConsultas.Size = new Size(849, 299);
            gbConsultas.TabIndex = 8;
            gbConsultas.TabStop = false;
            gbConsultas.Text = "Lista de Tareas";
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(176, 140, 145);
            dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHistorial.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle7;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(9, 27);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(831, 264);
            dgvHistorial.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConsulta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(18, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 213);
            panel1.TabIndex = 0;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(324, 184);
            dtpFecha.MaxDate = new DateTime(2024, 10, 15, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 7;
            dtpFecha.Value = new DateTime(2024, 10, 15, 0, 0, 0, 0);
            dtpFecha.ValueChanged += CambioDeFecha;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Left;
            btnCargar.BackColor = Color.Green;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(12, 130);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(148, 45);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Consultar Tareas";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 4;
            label2.Text = "Identificacion:";
            // 
            // txtConsulta
            // 
            txtConsulta.Anchor = AnchorStyles.Left;
            txtConsulta.BackColor = Color.FromArgb(176, 140, 145);
            txtConsulta.BorderStyle = BorderStyle.None;
            txtConsulta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConsulta.ForeColor = Color.White;
            txtConsulta.Location = new Point(12, 87);
            txtConsulta.MaxLength = 3;
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(148, 23);
            txtConsulta.TabIndex = 0;
            txtConsulta.TextAlign = HorizontalAlignment.Center;
            txtConsulta.TextChanged += txtConsulta_TextChanged;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(885, 542);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultas";
            Padding = new Padding(18, 15, 18, 15);
            Text = "Consultas";
            Load += Consultas_Load;
            panel5.ResumeLayout(false);
            gbConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private Panel panel1;
        private Button btnCargar;
        private Label label2;
        private TextBox txtConsulta;
        private DateTimePicker dtpFecha;
        private GroupBox gbConsultas;
        private DataGridView dgvHistorial;
    }
}