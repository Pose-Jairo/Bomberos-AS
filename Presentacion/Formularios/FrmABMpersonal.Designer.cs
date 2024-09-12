namespace Presentacion.Formularios
{
    partial class FrmABMpersonal
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
            gbSuperior = new GroupBox();
            pIzquierdo = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pDerecha = new Panel();
            gbDerecha = new GroupBox();
            btnFiltrar = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnVolverBomberos = new Button();
            gbAcciones = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            btnEjecutar = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pSuperior = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gbSuperior.SuspendLayout();
            pIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pDerecha.SuspendLayout();
            gbDerecha.SuspendLayout();
            groupBox3.SuspendLayout();
            gbAcciones.SuspendLayout();
            pSuperior.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gbSuperior
            // 
            gbSuperior.Controls.Add(pIzquierdo);
            gbSuperior.Controls.Add(pDerecha);
            gbSuperior.Dock = DockStyle.Fill;
            gbSuperior.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbSuperior.ForeColor = Color.White;
            gbSuperior.Location = new Point(5, 5);
            gbSuperior.Name = "gbSuperior";
            gbSuperior.Padding = new Padding(5);
            gbSuperior.Size = new Size(790, 336);
            gbSuperior.TabIndex = 0;
            gbSuperior.TabStop = false;
            gbSuperior.Text = "Lista de Personal";
            // 
            // pIzquierdo
            // 
            pIzquierdo.Controls.Add(dataGridView1);
            pIzquierdo.Dock = DockStyle.Fill;
            pIzquierdo.Location = new Point(5, 20);
            pIzquierdo.Name = "pIzquierdo";
            pIzquierdo.Padding = new Padding(5);
            pIzquierdo.Size = new Size(505, 311);
            pIzquierdo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(176, 140, 145);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(495, 301);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo:";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre:";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido:";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Rango:";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Permisos";
            Column5.Name = "Column5";
            // 
            // pDerecha
            // 
            pDerecha.Controls.Add(gbDerecha);
            pDerecha.Dock = DockStyle.Right;
            pDerecha.Location = new Point(510, 20);
            pDerecha.Name = "pDerecha";
            pDerecha.Padding = new Padding(5);
            pDerecha.Size = new Size(275, 311);
            pDerecha.TabIndex = 2;
            // 
            // gbDerecha
            // 
            gbDerecha.Controls.Add(btnFiltrar);
            gbDerecha.Controls.Add(textBox2);
            gbDerecha.Controls.Add(comboBox1);
            gbDerecha.Controls.Add(textBox1);
            gbDerecha.Controls.Add(label3);
            gbDerecha.Controls.Add(label2);
            gbDerecha.Controls.Add(label1);
            gbDerecha.Dock = DockStyle.Fill;
            gbDerecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbDerecha.ForeColor = Color.White;
            gbDerecha.Location = new Point(5, 5);
            gbDerecha.Name = "gbDerecha";
            gbDerecha.Padding = new Padding(0);
            gbDerecha.Size = new Size(265, 301);
            gbDerecha.TabIndex = 1;
            gbDerecha.TabStop = false;
            gbDerecha.Text = "Filtros de Busqueda:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.DarkGreen;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(86, 218);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(113, 39);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(176, 140, 145);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(146, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(176, 140, 145);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Oficial", "SubOficial", "Bombero", "Cadete" });
            comboBox1.Location = new Point(146, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(176, 140, 145);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(146, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 19);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 139);
            label3.Name = "label3";
            label3.Size = new Size(122, 16);
            label3.TabIndex = 2;
            label3.Text = "Nombre y Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 93);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = "Rango:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnVolverBomberos);
            groupBox3.Controls.Add(gbAcciones);
            groupBox3.Controls.Add(btnEjecutar);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(790, 244);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registrar nuevo Personal:";
            // 
            // btnVolverBomberos
            // 
            btnVolverBomberos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolverBomberos.BackColor = Color.Red;
            btnVolverBomberos.FlatStyle = FlatStyle.Popup;
            btnVolverBomberos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverBomberos.Location = new Point(641, 202);
            btnVolverBomberos.Name = "btnVolverBomberos";
            btnVolverBomberos.Size = new Size(142, 35);
            btnVolverBomberos.TabIndex = 3;
            btnVolverBomberos.Text = "Volver";
            btnVolverBomberos.UseVisualStyleBackColor = false;
            btnVolverBomberos.Click += SeleccionButtons;
            // 
            // gbAcciones
            // 
            gbAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbAcciones.Controls.Add(radioButton5);
            gbAcciones.Controls.Add(radioButton4);
            gbAcciones.Controls.Add(radioButton3);
            gbAcciones.ForeColor = Color.White;
            gbAcciones.Location = new Point(399, 14);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Size = new Size(200, 223);
            gbAcciones.TabIndex = 2;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Selecciona un Metodo:";
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(22, 136);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(154, 24);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "Eliminar Registros";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(22, 106);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(160, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Modificar registros";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(22, 76);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(154, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Agregar Registros";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Anchor = AnchorStyles.Left;
            btnEjecutar.BackColor = Color.Green;
            btnEjecutar.FlatStyle = FlatStyle.Popup;
            btnEjecutar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.Location = new Point(201, 127);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(157, 48);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(201, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 20);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "NO";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(285, 90);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 20);
            radioButton1.TabIndex = 7;
            radioButton1.Text = "SI";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left;
            comboBox2.BackColor = Color.FromArgb(176, 140, 145);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Oficial", "SubOficial", "Bombero", "Cadete" });
            comboBox2.Location = new Point(75, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.BackColor = Color.FromArgb(176, 140, 145);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(75, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 19);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.BackColor = Color.FromArgb(176, 140, 145);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(75, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 19);
            textBox3.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(201, 72);
            label7.Name = "label7";
            label7.Size = new Size(177, 16);
            label7.TabIndex = 3;
            label7.Text = "Permisos de Administracion:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(15, 155);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 2;
            label6.Text = "Rango:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(15, 110);
            label5.Name = "label5";
            label5.Size = new Size(60, 16);
            label5.TabIndex = 1;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(15, 69);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 0;
            label4.Text = "Nombre:";
            // 
            // pSuperior
            // 
            pSuperior.Controls.Add(gbSuperior);
            pSuperior.Dock = DockStyle.Top;
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Padding = new Padding(5);
            pSuperior.Size = new Size(800, 346);
            pSuperior.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 254);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(800, 254);
            panel3.TabIndex = 4;
            // 
            // FrmABMpersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(800, 600);
            Controls.Add(panel2);
            Controls.Add(pSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmABMpersonal";
            Text = "FrmABMpersonal";
            gbSuperior.ResumeLayout(false);
            pIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pDerecha.ResumeLayout(false);
            gbDerecha.ResumeLayout(false);
            gbDerecha.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbAcciones.ResumeLayout(false);
            gbAcciones.PerformLayout();
            pSuperior.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSuperior;
        private GroupBox gbDerecha;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbAcciones;
        private Button btnEjecutar;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button btnVolverBomberos;
        private Panel pSuperior;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel pIzquierdo;
        private Panel pDerecha;
    }
}