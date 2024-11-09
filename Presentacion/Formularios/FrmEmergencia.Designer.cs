namespace Presentacion.Formularios
{
    partial class FrmEmergencia
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
            dgvHistorialEmergencia = new DataGridView();
            btnVolverBomberos = new Button();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialEmergencia).BeginInit();
            SuspendLayout();
            // 
            // gbHistorial
            // 
            gbHistorial.Controls.Add(dgvHistorialEmergencia);
            gbHistorial.Dock = DockStyle.Top;
            gbHistorial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbHistorial.ForeColor = Color.White;
            gbHistorial.Location = new Point(5, 5);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Padding = new Padding(1);
            gbHistorial.Size = new Size(790, 336);
            gbHistorial.TabIndex = 1;
            gbHistorial.TabStop = false;
            gbHistorial.Text = "Historial de registros:";
            // 
            // dgvHistorialEmergencia
            // 
            dgvHistorialEmergencia.AllowUserToAddRows = false;
            dgvHistorialEmergencia.AllowUserToDeleteRows = false;
            dgvHistorialEmergencia.AllowUserToResizeRows = false;
            dgvHistorialEmergencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialEmergencia.BackgroundColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorialEmergencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialEmergencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorialEmergencia.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialEmergencia.Dock = DockStyle.Fill;
            dgvHistorialEmergencia.Location = new Point(1, 20);
            dgvHistorialEmergencia.Name = "dgvHistorialEmergencia";
            dgvHistorialEmergencia.ReadOnly = true;
            dgvHistorialEmergencia.RowHeadersVisible = false;
            dgvHistorialEmergencia.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(176, 140, 145);
            dgvHistorialEmergencia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorialEmergencia.RowTemplate.Height = 25;
            dgvHistorialEmergencia.Size = new Size(788, 315);
            dgvHistorialEmergencia.TabIndex = 0;
            // 
            // btnVolverBomberos
            // 
            btnVolverBomberos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolverBomberos.BackColor = Color.Red;
            btnVolverBomberos.Cursor = Cursors.Hand;
            btnVolverBomberos.FlatStyle = FlatStyle.Popup;
            btnVolverBomberos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverBomberos.Location = new Point(667, 408);
            btnVolverBomberos.Name = "btnVolverBomberos";
            btnVolverBomberos.Size = new Size(121, 30);
            btnVolverBomberos.TabIndex = 3;
            btnVolverBomberos.Text = "Volver";
            btnVolverBomberos.UseVisualStyleBackColor = false;
            btnVolverBomberos.Click += btnVolverBomberos_Click;
            // 
            // FrmEmergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverBomberos);
            Controls.Add(gbHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmergencia";
            Padding = new Padding(5);
            ShowIcon = false;
            Text = "Historial de Emergencias";
            Load += FrmEmergencia_Load;
            gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialEmergencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbHistorial;
        private DataGridView dgvHistorialEmergencia;
        private Button btnVolverBomberos;
    }
}