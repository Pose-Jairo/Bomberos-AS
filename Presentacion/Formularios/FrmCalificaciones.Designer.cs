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
            dgvCalificacion = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnImprimir = new Button();
            btnCancelarCalificaciones = new Button();
            button2 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCalificacion
            // 
            dgvCalificacion.AllowUserToAddRows = false;
            dgvCalificacion.AllowUserToDeleteRows = false;
            dgvCalificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCalificacion.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificacion.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvCalificacion.Dock = DockStyle.Bottom;
            dgvCalificacion.Location = new Point(0, 28);
            dgvCalificacion.Name = "dgvCalificacion";
            dgvCalificacion.RowHeadersVisible = false;
            dgvCalificacion.RowTemplate.Height = 25;
            dgvCalificacion.Size = new Size(770, 303);
            dgvCalificacion.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre de Personal";
            Column1.Name = "Column1";
            Column1.Width = 128;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
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
            btnImprimir.Location = new Point(606, 407);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(152, 49);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = ">>Imprimir<<";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCalificaciones
            // 
            btnCancelarCalificaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarCalificaciones.BackColor = Color.Red;
            btnCancelarCalificaciones.FlatStyle = FlatStyle.Popup;
            btnCancelarCalificaciones.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarCalificaciones.ForeColor = Color.White;
            btnCancelarCalificaciones.Location = new Point(12, 407);
            btnCancelarCalificaciones.Name = "btnCancelarCalificaciones";
            btnCancelarCalificaciones.Size = new Size(152, 49);
            btnCancelarCalificaciones.TabIndex = 3;
            btnCancelarCalificaciones.Text = "Cancelar";
            btnCancelarCalificaciones.UseVisualStyleBackColor = false;
            btnCancelarCalificaciones.Click += SeleccionButtons;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 337);
            button2.Name = "button2";
            button2.Size = new Size(152, 33);
            button2.TabIndex = 4;
            button2.Text = "Recargar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 346);
            label2.Name = "label2";
            label2.Size = new Size(312, 16);
            label2.TabIndex = 5;
            label2.Text = "Volver a cargar la grilla (se perderan las ediciones)";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvCalificacion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 331);
            panel1.TabIndex = 6;
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(770, 468);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button2);
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
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private Button btnImprimir;
        private Button btnCancelarCalificaciones;
        private Button button2;
        private Label label2;
        private Panel panel1;
    }
}