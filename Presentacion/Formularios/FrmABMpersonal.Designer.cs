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
            dgvTablaPersonal = new DataGridView();
            pDerecha = new Panel();
            gbDerecha = new GroupBox();
            btnFiltrar = new Button();
            txtFiltraNom = new TextBox();
            cmbFiltraRango = new ComboBox();
            txtFiltraCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtContrasena = new TextBox();
            cbActivo = new CheckBox();
            cbPermiso = new CheckBox();
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
            btnMod = new Button();
            btnDel = new Button();
            gbSuperior.SuspendLayout();
            pIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPersonal).BeginInit();
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
            dgvTablaPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaPersonal.BackgroundColor = Color.FromArgb(176, 140, 145);
            dgvTablaPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaPersonal.Dock = DockStyle.Fill;
            dgvTablaPersonal.Location = new Point(5, 5);
            dgvTablaPersonal.Margin = new Padding(5);
            dgvTablaPersonal.Name = "dgvTablaPersonal";
            dgvTablaPersonal.RowHeadersVisible = false;
            dgvTablaPersonal.RowTemplate.Height = 25;
            dgvTablaPersonal.Size = new Size(495, 301);
            dgvTablaPersonal.TabIndex = 0;
            dgvTablaPersonal.CellClick += Click_Celda;
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
            gbDerecha.Controls.Add(txtFiltraNom);
            gbDerecha.Controls.Add(cmbFiltraRango);
            gbDerecha.Controls.Add(txtFiltraCodigo);
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
            // txtFiltraNom
            // 
            txtFiltraNom.BackColor = Color.FromArgb(176, 140, 145);
            txtFiltraNom.BorderStyle = BorderStyle.None;
            txtFiltraNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltraNom.ForeColor = Color.White;
            txtFiltraNom.Location = new Point(146, 136);
            txtFiltraNom.Name = "txtFiltraNom";
            txtFiltraNom.Size = new Size(100, 19);
            txtFiltraNom.TabIndex = 5;
            // 
            // cmbFiltraRango
            // 
            cmbFiltraRango.BackColor = Color.FromArgb(176, 140, 145);
            cmbFiltraRango.FlatStyle = FlatStyle.Flat;
            cmbFiltraRango.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFiltraRango.ForeColor = Color.White;
            cmbFiltraRango.FormattingEnabled = true;
            cmbFiltraRango.Items.AddRange(new object[] { "Oficial", "SubOficial", "Bombero", "Cadete" });
            cmbFiltraRango.Location = new Point(146, 90);
            cmbFiltraRango.Name = "cmbFiltraRango";
            cmbFiltraRango.Size = new Size(100, 28);
            cmbFiltraRango.TabIndex = 4;
            // 
            // txtFiltraCodigo
            // 
            txtFiltraCodigo.BackColor = Color.FromArgb(176, 140, 145);
            txtFiltraCodigo.BorderStyle = BorderStyle.None;
            txtFiltraCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltraCodigo.ForeColor = Color.White;
            txtFiltraCodigo.Location = new Point(146, 46);
            txtFiltraCodigo.Name = "txtFiltraCodigo";
            txtFiltraCodigo.Size = new Size(100, 19);
            txtFiltraCodigo.TabIndex = 3;
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
            groupBox3.Controls.Add(btnDel);
            groupBox3.Controls.Add(btnMod);
            groupBox3.Controls.Add(txtContrasena);
            groupBox3.Controls.Add(cbActivo);
            groupBox3.Controls.Add(cbPermiso);
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
            // txtContrasena
            // 
            txtContrasena.Location = new Point(201, 68);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(157, 22);
            txtContrasena.TabIndex = 17;
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.Location = new Point(201, 121);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(163, 20);
            cbActivo.TabIndex = 16;
            cbActivo.Text = "El usuario esta inactivo";
            cbActivo.UseVisualStyleBackColor = true;
            // 
            // cbPermiso
            // 
            cbPermiso.AutoSize = true;
            cbPermiso.Location = new Point(201, 26);
            cbPermiso.Name = "cbPermiso";
            cbPermiso.Size = new Size(179, 36);
            cbPermiso.TabIndex = 15;
            cbPermiso.Text = "El usuario tiene permisos \r\nde administracion";
            cbPermiso.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(22, 158);
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
            cmbArea.Location = new Point(70, 152);
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
            gbAcciones.Controls.Add(rbElimReg);
            gbAcciones.Controls.Add(rbModReg);
            gbAcciones.Controls.Add(rbAgregarReg);
            gbAcciones.ForeColor = Color.White;
            gbAcciones.Location = new Point(399, 14);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Size = new Size(200, 223);
            gbAcciones.TabIndex = 2;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Selecciona un Metodo:";
            // 
            // rbElimReg
            // 
            rbElimReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbElimReg.AutoSize = true;
            rbElimReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbElimReg.Location = new Point(22, 136);
            rbElimReg.Name = "rbElimReg";
            rbElimReg.Size = new Size(154, 24);
            rbElimReg.TabIndex = 2;
            rbElimReg.TabStop = true;
            rbElimReg.Text = "Eliminar Registros";
            rbElimReg.UseVisualStyleBackColor = true;
            // 
            // rbModReg
            // 
            rbModReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbModReg.AutoSize = true;
            rbModReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbModReg.Location = new Point(22, 106);
            rbModReg.Name = "rbModReg";
            rbModReg.Size = new Size(160, 24);
            rbModReg.TabIndex = 1;
            rbModReg.TabStop = true;
            rbModReg.Text = "Modificar registros";
            rbModReg.UseVisualStyleBackColor = true;
            // 
            // rbAgregarReg
            // 
            rbAgregarReg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rbAgregarReg.AutoSize = true;
            rbAgregarReg.Checked = true;
            rbAgregarReg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbAgregarReg.Location = new Point(22, 76);
            rbAgregarReg.Name = "rbAgregarReg";
            rbAgregarReg.Size = new Size(154, 24);
            rbAgregarReg.TabIndex = 0;
            rbAgregarReg.TabStop = true;
            rbAgregarReg.Text = "Agregar Registros";
            rbAgregarReg.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Anchor = AnchorStyles.Left;
            btnEjecutar.BackColor = Color.Green;
            btnEjecutar.FlatStyle = FlatStyle.Popup;
            btnEjecutar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.Location = new Point(10, 202);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(119, 35);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Agregar";
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
            cmbRango.Location = new Point(70, 105);
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
            txtApellido.Location = new Point(70, 65);
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
            txtNombre.Location = new Point(70, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 19);
            txtNombre.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(10, 108);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 2;
            label6.Text = "Rango:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(10, 68);
            label5.Name = "label5";
            label5.Size = new Size(60, 16);
            label5.TabIndex = 1;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(10, 30);
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
            // btnMod
            // 
            btnMod.Anchor = AnchorStyles.Left;
            btnMod.BackColor = Color.Teal;
            btnMod.FlatStyle = FlatStyle.Popup;
            btnMod.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(135, 202);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(119, 35);
            btnMod.TabIndex = 18;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Left;
            btnDel.BackColor = Color.Crimson;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(260, 202);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(119, 35);
            btnDel.TabIndex = 19;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = false;
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
        private DataGridView dgvTablaPersonal;
        private Button btnFiltrar;
        private TextBox txtFiltraNom;
        private ComboBox cmbFiltraRango;
        private TextBox txtFiltraCodigo;
        private Label label3;
        private Label label2;
        private Label label1;
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
        private CheckBox cbPermiso;
        private TextBox txtContrasena;
        private CheckBox cbActivo;
        private Button btnDel;
        private Button btnMod;
    }
}