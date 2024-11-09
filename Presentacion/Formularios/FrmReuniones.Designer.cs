namespace Presentacion.Formularios
{
    partial class FrmReuniones
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
            pHistorial = new Panel();
            gbHistorial = new GroupBox();
            dgvHistorialTareas = new DataGridView();
            pTareas = new Panel();
            btnVolverBomberos = new Button();
            pHistorial.SuspendLayout();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTareas).BeginInit();
            pTareas.SuspendLayout();
            SuspendLayout();
            // 
            // pHistorial
            // 
            pHistorial.Controls.Add(gbHistorial);
            pHistorial.Dock = DockStyle.Top;
            pHistorial.Location = new Point(0, 0);
            pHistorial.Name = "pHistorial";
            pHistorial.Padding = new Padding(10);
            pHistorial.Size = new Size(770, 261);
            pHistorial.TabIndex = 4;
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
            gbHistorial.Size = new Size(750, 241);
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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
            dgvHistorialTareas.Size = new Size(748, 220);
            dgvHistorialTareas.TabIndex = 0;
            // 
            // pTareas
            // 
            pTareas.Controls.Add(btnVolverBomberos);
            pTareas.Dock = DockStyle.Fill;
            pTareas.Location = new Point(0, 261);
            pTareas.Name = "pTareas";
            pTareas.Padding = new Padding(10);
            pTareas.Size = new Size(770, 207);
            pTareas.TabIndex = 5;
            // 
            // btnVolverBomberos
            // 
            btnVolverBomberos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolverBomberos.BackColor = Color.Red;
            btnVolverBomberos.Cursor = Cursors.Hand;
            btnVolverBomberos.FlatStyle = FlatStyle.Popup;
            btnVolverBomberos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverBomberos.Location = new Point(636, 164);
            btnVolverBomberos.Name = "btnVolverBomberos";
            btnVolverBomberos.Size = new Size(121, 30);
            btnVolverBomberos.TabIndex = 4;
            btnVolverBomberos.Text = "Volver";
            btnVolverBomberos.UseVisualStyleBackColor = false;
            btnVolverBomberos.Click += btnVolverBomberos_Click;
            // 
            // FrmReuniones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(770, 468);
            Controls.Add(pTareas);
            Controls.Add(pHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReuniones";
            Text = "FrmReuniones";
            Load += FrmReuniones_Load;
            pHistorial.ResumeLayout(false);
            gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTareas).EndInit();
            pTareas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pHistorial;
        private GroupBox gbHistorial;
        private DataGridView dgvHistorialTareas;
        private Panel pTareas;
        private Button btnVolverBomberos;
    }
}