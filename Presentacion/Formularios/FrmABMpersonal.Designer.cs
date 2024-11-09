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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gbSuperior = new GroupBox();
            pIzquierdo = new Panel();
            dgvTablaPersonal = new DataGridView();
            pDerecha = new Panel();
            groupBox1 = new GroupBox();
            cbSelectAll = new CheckBox();
            groupBox3 = new GroupBox();
            txtCodBom = new TextBox();
            label7 = new Label();
            cbActivo = new CheckBox();
            label9 = new Label();
            cmbArea = new ComboBox();
            btnVolverBomberos = new Button();
            gbAcciones = new GroupBox();
            rbElimReg = new RadioButton();
            rbModReg = new RadioButton();
            rbAgregarReg = new RadioButton();
            btnEjecutar = new Button();
            cmbRango = new ComboBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pSuperior = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gbSuperior.SuspendLayout();
            pIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPersonal).BeginInit();
            pDerecha.SuspendLayout();
            groupBox1.SuspendLayout();
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
            pIzquierdo.Controls.Add(dgvTablaPersonal);
            pIzquierdo.Dock = DockStyle.Fill;
            pIzquierdo.Location = new Point(5, 20);
            pIzquierdo.Name = "pIzquierdo";
            pIzquierdo.Padding = new Padding(5);
            pIzquierdo.Size = new Size(505, 311);
            pIzquierdo.TabIndex = 2;
            // 
            // dgvTablaPersonal
            // 
            dgvTablaPersonal.AllowUserToAddRows = false;
            dgvTablaPersonal.AllowUserToDeleteRows = false;
            dgvTablaPersonal.AllowUserToResizeRows = false;
            dgvTablaPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaPersonal.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvTablaPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaPersonal.Dock = DockStyle.Fill;
            dgvTablaPersonal.GridColor = SystemColors.ActiveCaptionText;
            dgvTablaPersonal.Location = new Point(5, 5);
            dgvTablaPersonal.Margin = new Padding(5);
            dgvTablaPersonal.Name = "dgvTablaPersonal";
            dgvTablaPersonal.ReadOnly = true;
            dgvTablaPersonal.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(176, 140, 145);
            dgvTablaPersonal.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTablaPersonal.RowTemplate.Height = 25;
            dgvTablaPersonal.Size = new Size(495, 301);
            dgvTablaPersonal.TabIndex = 0;
            dgvTablaPersonal.CellClick += Click_Celda;
            // 
            // pDerecha
            // 
            pDerecha.Controls.Add(groupBox1);
            pDerecha.Dock = DockStyle.Right;
            pDerecha.Location = new Point(510, 20);
            pDerecha.Name = "pDerecha";
            pDerecha.Padding = new Padding(5);
            pDerecha.Size = new Size(275, 311);
            pDerecha.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSelectAll);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 64);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condicion de lectura:";
            // 
            // cbSelectAll
            // 
            cbSelectAll.AutoSize = true;
            cbSelectAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbSelectAll.Location = new Point(13, 25);
            cbSelectAll.Name = "cbSelectAll";
            cbSelectAll.Size = new Size(220, 24);
            cbSelectAll.TabIndex = 0;
            cbSelectAll.Text = "Ver Todos los Registros";
            cbSelectAll.UseVisualStyleBackColor = true;
            cbSelectAll.CheckedChanged += cbSelectAll_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCodBom);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cbActivo);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbArea);
            groupBox3.Controls.Add(btnVolverBomberos);
            groupBox3.Controls.Add(gbAcciones);
            groupBox3.Controls.Add(btnEjecutar);
            groupBox3.Controls.Add(cmbRango);
            groupBox3.Controls.Add(txtApellido);
            groupBox3.Controls.Add(txtNombre);
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
            groupBox3.Text = "Control de personal:";
            // 
            // txtCodBom
            // 
            txtCodBom.Anchor = AnchorStyles.Left;
            txtCodBom.BackColor = Color.FromArgb(176, 140, 145);
            txtCodBom.BorderStyle = BorderStyle.None;
            txtCodBom.Enabled = false;
            txtCodBom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBom.ForeColor = Color.White;
            txtCodBom.Location = new Point(70, 26);
            txtCodBom.Name = "txtCodBom";
            txtCodBom.Size = new Size(100, 19);
            txtCodBom.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(10, 26);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 20;
            label7.Text = "Codigo:";
            // 
            // cbActivo
            // 
            cbActivo.Anchor = AnchorStyles.Left;
            cbActivo.AutoSize = true;
            cbActivo.Enabled = false;
            cbActivo.Location = new Point(201, 121);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(154, 20);
            cbActivo.TabIndex = 16;
            cbActivo.Text = "El usuario esta Activo";
            cbActivo.UseVisualStyleBackColor = true;
            cbActivo.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(25, 147);
            label9.Name = "label9";
            label9.Size = new Size(39, 16);
            label9.TabIndex = 14;
            label9.Text = "Area:";
            // 
            // cmbArea
            // 
            cmbArea.Anchor = AnchorStyles.Left;
            cmbArea.BackColor = Color.FromArgb(176, 140, 145);
            cmbArea.FlatStyle = FlatStyle.Flat;
            cmbArea.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbArea.ForeColor = Color.White;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(70, 147);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(100, 28);
            cmbArea.TabIndex = 13;
            // 
            // btnVolverBomberos
            // 
            btnVolverBomberos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolverBomberos.BackColor = Color.Red;
            btnVolverBomberos.FlatStyle = FlatStyle.Popup;
            btnVolverBomberos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverBomberos.Location = new Point(687, 211);
            btnVolverBomberos.Name = "btnVolverBomberos";
            btnVolverBomberos.Size = new Size(96, 26);
            btnVolverBomberos.TabIndex = 3;
            btnVolverBomberos.Text = "Volver";
            btnVolverBomberos.UseVisualStyleBackColor = false;
            btnVolverBomberos.Click += SeleccionButtons;
            // 
            // gbAcciones
            // 
            gbAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbAcciones.Controls.Add(rbElimReg);
            gbAcciones.Controls.Add(rbModReg);
            gbAcciones.Controls.Add(rbAgregarReg);
            gbAcciones.ForeColor = Color.White;
            gbAcciones.Location = new Point(583, 14);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Size = new Size(200, 161);
            gbAcciones.TabIndex = 2;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Selecciona un Metodo:";
            // 
            // rbElimReg
            // 
            rbElimReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbElimReg.AutoSize = true;
            rbElimReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbElimReg.Location = new Point(22, 105);
            rbElimReg.Name = "rbElimReg";
            rbElimReg.Size = new Size(154, 24);
            rbElimReg.TabIndex = 2;
            rbElimReg.TabStop = true;
            rbElimReg.Text = "Eliminar Registros";
            rbElimReg.UseVisualStyleBackColor = true;
            rbElimReg.CheckedChanged += rbElimReg_CheckedChanged;
            // 
            // rbModReg
            // 
            rbModReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbModReg.AutoSize = true;
            rbModReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbModReg.Location = new Point(22, 75);
            rbModReg.Name = "rbModReg";
            rbModReg.Size = new Size(160, 24);
            rbModReg.TabIndex = 1;
            rbModReg.TabStop = true;
            rbModReg.Text = "Modificar registros";
            rbModReg.UseVisualStyleBackColor = true;
            rbModReg.CheckedChanged += rbModReg_CheckedChanged;
            // 
            // rbAgregarReg
            // 
            rbAgregarReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbAgregarReg.AutoSize = true;
            rbAgregarReg.Checked = true;
            rbAgregarReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbAgregarReg.Location = new Point(22, 45);
            rbAgregarReg.Name = "rbAgregarReg";
            rbAgregarReg.Size = new Size(154, 24);
            rbAgregarReg.TabIndex = 0;
            rbAgregarReg.TabStop = true;
            rbAgregarReg.Text = "Agregar Registros";
            rbAgregarReg.UseVisualStyleBackColor = true;
            rbAgregarReg.CheckedChanged += rbAgregarReg_CheckedChanged;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEjecutar.BackColor = Color.Green;
            btnEjecutar.FlatStyle = FlatStyle.Popup;
            btnEjecutar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.Location = new Point(548, 202);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(133, 35);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Continuar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // cmbRango
            // 
            cmbRango.Anchor = AnchorStyles.Left;
            cmbRango.BackColor = Color.FromArgb(176, 140, 145);
            cmbRango.FlatStyle = FlatStyle.Flat;
            cmbRango.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRango.ForeColor = Color.White;
            cmbRango.FormattingEnabled = true;
            cmbRango.Location = new Point(70, 110);
            cmbRango.Name = "cmbRango";
            cmbRango.Size = new Size(100, 28);
            cmbRango.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left;
            txtApellido.BackColor = Color.FromArgb(176, 140, 145);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(70, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 19);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.BackColor = Color.FromArgb(176, 140, 145);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(70, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 19);
            txtNombre.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(13, 116);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 2;
            label6.Text = "Rango:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(10, 85);
            label5.Name = "label5";
            label5.Size = new Size(60, 16);
            label5.TabIndex = 1;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(10, 54);
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
            Load += FrmABMpersonal_Load;
            gbSuperior.ResumeLayout(false);
            pIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaPersonal).EndInit();
            pDerecha.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dgvTablaPersonal;
        private GroupBox groupBox3;
        private RadioButton rbPermisoFalse;
        private RadioButton rbPermisoTrue;
        private ComboBox cmbRango;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbAcciones;
        private Button btnEjecutar;
        private RadioButton rbElimReg;
        private RadioButton rbModReg;
        private RadioButton rbAgregarReg;
        private Button btnVolverBomberos;
        private Panel pSuperior;
        private Panel panel2;
        private Panel panel3;
        private Panel pIzquierdo;
        private Panel pDerecha;
        private RadioButton rbActivo;
        private RadioButton rbInactivo;
        private Label label8;
        private Label label9;
        private ComboBox cmbArea;
        private CheckBox cbActivo;
        private TextBox txtCodBom;
        private GroupBox groupBox1;
        private CheckBox cbSelectAll;
    }
}