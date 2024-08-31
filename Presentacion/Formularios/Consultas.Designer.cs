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
            pFormularios = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnCargar = new Button();
            label3 = new Label();
            label2 = new Label();
            lblActividad = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pageSetupDialog1 = new PageSetupDialog();
            pFormularios.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pFormularios
            // 
            pFormularios.BackColor = Color.FromArgb(208, 167, 173);
            pFormularios.Controls.Add(panel5);
            pFormularios.Controls.Add(label1);
            pFormularios.Controls.Add(label4);
            pFormularios.Controls.Add(panel1);
            pFormularios.Dock = DockStyle.Fill;
            pFormularios.Location = new Point(0, 0);
            pFormularios.Name = "pFormularios";
            pFormularios.Size = new Size(950, 500);
            pFormularios.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(79, 274);
            panel5.Name = "panel5";
            panel5.Size = new Size(752, 184);
            panel5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 18);
            label5.Name = "label5";
            label5.Size = new Size(173, 19);
            label5.TabIndex = 8;
            label5.Text = "Bienvenido {Nombre}";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(746, 115);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 241);
            label1.Name = "label1";
            label1.Size = new Size(292, 19);
            label1.TabIndex = 8;
            label1.Text = "Historico de actividades del bombero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(345, 9);
            label4.Name = "label4";
            label4.Size = new Size(204, 19);
            label4.TabIndex = 6;
            label4.Text = "Cargar Tareas Realizadas";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblActividad);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(79, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 180);
            panel1.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(128, 255, 128);
            btnCargar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.Location = new Point(676, 149);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(73, 28);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(502, 44);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 5;
            label3.Text = "Fecha y Hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(14, 120);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(181, 19);
            lblActividad.TabIndex = 3;
            lblActividad.Text = "Detalle de la Actividad:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(641, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(502, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 500);
            Controls.Add(pFormularios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultas";
            Text = "Consultas";
            pFormularios.ResumeLayout(false);
            pFormularios.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pFormularios;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel5;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Button btnCargar;
        private Label label3;
        private Label label2;
        private Label lblActividad;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}