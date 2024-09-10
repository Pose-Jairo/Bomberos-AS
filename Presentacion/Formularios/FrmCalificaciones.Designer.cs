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
            dgvCalendario = new DataGridView();
            ColumnPersonal = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).BeginInit();
            SuspendLayout();
            // 
            // dgvCalendario
            // 
            dgvCalendario.AllowUserToAddRows = false;
            dgvCalendario.AllowUserToDeleteRows = false;
            dgvCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalendario.Columns.AddRange(new DataGridViewColumn[] { ColumnPersonal });
            dgvCalendario.Location = new Point(12, 56);
            dgvCalendario.Name = "dgvCalendario";
            dgvCalendario.RowHeadersVisible = false;
            dgvCalendario.RowTemplate.Height = 25;
            dgvCalendario.Size = new Size(746, 337);
            dgvCalendario.TabIndex = 0;
            // 
            // ColumnPersonal
            // 
            ColumnPersonal.HeaderText = "Nombre del Personal";
            ColumnPersonal.MaxInputLength = 100;
            ColumnPersonal.Name = "ColumnPersonal";
            ColumnPersonal.Resizable = DataGridViewTriState.False;
            ColumnPersonal.Width = 131;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(606, 399);
            button1.Name = "button1";
            button1.Size = new Size(152, 57);
            button1.TabIndex = 1;
            button1.Text = ">>IMPRIMIR<<";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 399);
            button2.Name = "button2";
            button2.Size = new Size(152, 57);
            button2.TabIndex = 2;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(323, 17);
            label1.TabIndex = 3;
            label1.Text = "Lista de la asistencias y puntuaciones del personal:";
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 468);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvCalendario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            Load += FrmCalificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalendario;
        private DataGridViewTextBoxColumn ColumnPersonal;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}