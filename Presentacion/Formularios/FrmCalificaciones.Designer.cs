namespace Presentacion.Formularios
{
    partial class FrmCalificaciones
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
            dgvCalificacion = new DataGridView();
            label1 = new Label();
            btnImprimir = new Button();
            btnCancelarCalificaciones = new Button();
            btnRecargar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCalificacion
            // 
            dgvCalificacion.AllowUserToAddRows = false;
            dgvCalificacion.AllowUserToDeleteRows = false;
            dgvCalificacion.AllowUserToResizeRows = false;
            dgvCalificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalificacion.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(176, 140, 145);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCalificacion.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCalificacion.Dock = DockStyle.Bottom;
            dgvCalificacion.Location = new Point(0, 41);
            dgvCalificacion.Name = "dgvCalificacion";
            dgvCalificacion.RowHeadersVisible = false;
            dgvCalificacion.RowTemplate.Height = 25;
            dgvCalificacion.Size = new Size(870, 326);
            dgvCalificacion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(174, 16);
            label1.TabIndex = 1;
            label1.Text = "Tabla de calificaciones:";
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.BackColor = Color.Green;
            btnImprimir.FlatStyle = FlatStyle.Popup;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(706, 461);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(152, 49);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = ">>Imprimir<<";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // btnCancelarCalificaciones
            // 
            btnCancelarCalificaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarCalificaciones.BackColor = Color.Red;
            btnCancelarCalificaciones.FlatStyle = FlatStyle.Popup;
            btnCancelarCalificaciones.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarCalificaciones.ForeColor = Color.White;
            btnCancelarCalificaciones.Location = new Point(12, 461);
            btnCancelarCalificaciones.Name = "btnCancelarCalificaciones";
            btnCancelarCalificaciones.Size = new Size(152, 49);
            btnCancelarCalificaciones.TabIndex = 3;
            btnCancelarCalificaciones.Text = "Cancelar";
            btnCancelarCalificaciones.UseVisualStyleBackColor = false;
            btnCancelarCalificaciones.Click += SeleccionButtons;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = Color.DarkGreen;
            btnRecargar.FlatStyle = FlatStyle.Popup;
            btnRecargar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecargar.ForeColor = Color.White;
            btnRecargar.Location = new Point(12, 373);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(152, 33);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 382);
            label2.Name = "label2";
            label2.Size = new Size(312, 16);
            label2.TabIndex = 5;
            label2.Text = "Volver a cargar la grilla (se perderan las ediciones)";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvCalificacion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 367);
            panel1.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(335, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 22);
            dtpFecha.TabIndex = 2;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(870, 522);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnRecargar);
            Controls.Add(btnCancelarCalificaciones);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            Load += FrmCalificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalificacion;
        private Label label1;
        private Button btnImprimir;
        private Button btnCancelarCalificaciones;
        private Button btnRecargar;
        private Label label2;
        private Panel panel1;
        private DateTimePicker dtpFecha;
    }
}