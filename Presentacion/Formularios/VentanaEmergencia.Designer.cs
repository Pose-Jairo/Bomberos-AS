namespace Presentacion.Formularios
{
    partial class VentanaEmergencia
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
            btnCargar = new Button();
            label1 = new Label();
            txtDetalleE = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            dtp_FechaFinalizacion = new DateTimePicker();
            mtxtHoraFina = new MaskedTextBox();
            mtxtHoraInicio = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Green;
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(21, 330);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(104, 37);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(250, 25);
            label1.TabIndex = 1;
            label1.Text = "Detalle de Emergencia";
            // 
            // txtDetalleE
            // 
            txtDetalleE.Location = new Point(21, 234);
            txtDetalleE.Name = "txtDetalleE";
            txtDetalleE.Size = new Size(506, 23);
            txtDetalleE.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(291, 107);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 9;
            label4.Text = "Hora Finalizacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(291, 33);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 6;
            label3.Text = "Hora Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 33);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 4;
            label2.Text = "Fecha Inicio";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(48, 61);
            dtpFecha.MaxDate = new DateTime(2025, 10, 15, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 10;
            dtpFecha.Value = new DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 107);
            label5.Name = "label5";
            label5.Size = new Size(211, 25);
            label5.TabIndex = 13;
            label5.Text = "Fecha Finalizacion";
            // 
            // dtp_FechaFinalizacion
            // 
            dtp_FechaFinalizacion.Anchor = AnchorStyles.None;
            dtp_FechaFinalizacion.CustomFormat = "";
            dtp_FechaFinalizacion.Format = DateTimePickerFormat.Short;
            dtp_FechaFinalizacion.Location = new Point(48, 135);
            dtp_FechaFinalizacion.MaxDate = new DateTime(2025, 10, 15, 0, 0, 0, 0);
            dtp_FechaFinalizacion.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtp_FechaFinalizacion.Name = "dtp_FechaFinalizacion";
            dtp_FechaFinalizacion.Size = new Size(200, 23);
            dtp_FechaFinalizacion.TabIndex = 14;
            dtp_FechaFinalizacion.Value = new DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // mtxtHoraFina
            // 
            mtxtHoraFina.Anchor = AnchorStyles.None;
            mtxtHoraFina.BackColor = Color.FromArgb(176, 140, 145);
            mtxtHoraFina.BorderStyle = BorderStyle.None;
            mtxtHoraFina.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtHoraFina.ForeColor = Color.White;
            mtxtHoraFina.Location = new Point(300, 133);
            mtxtHoraFina.Mask = "00:00";
            mtxtHoraFina.Name = "mtxtHoraFina";
            mtxtHoraFina.ShortcutsEnabled = false;
            mtxtHoraFina.Size = new Size(200, 24);
            mtxtHoraFina.TabIndex = 15;
            mtxtHoraFina.Text = "0000";
            mtxtHoraFina.TextAlign = HorizontalAlignment.Center;
            mtxtHoraFina.ValidatingType = typeof(DateTime);
            // 
            // mtxtHoraInicio
            // 
            mtxtHoraInicio.Anchor = AnchorStyles.None;
            mtxtHoraInicio.BackColor = Color.FromArgb(176, 140, 145);
            mtxtHoraInicio.BorderStyle = BorderStyle.None;
            mtxtHoraInicio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mtxtHoraInicio.ForeColor = Color.White;
            mtxtHoraInicio.Location = new Point(300, 60);
            mtxtHoraInicio.Mask = "00:00";
            mtxtHoraInicio.Name = "mtxtHoraInicio";
            mtxtHoraInicio.ShortcutsEnabled = false;
            mtxtHoraInicio.Size = new Size(200, 24);
            mtxtHoraInicio.TabIndex = 16;
            mtxtHoraInicio.Text = "0000";
            mtxtHoraInicio.TextAlign = HorizontalAlignment.Center;
            mtxtHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // VentanaEmergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 93, 101);
            ClientSize = new Size(565, 379);
            Controls.Add(mtxtHoraInicio);
            Controls.Add(mtxtHoraFina);
            Controls.Add(dtp_FechaFinalizacion);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDetalleE);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Name = "VentanaEmergencia";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emergencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private Label label1;
        private TextBox txtDetalleE;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label5;
        private DateTimePicker dtp_FechaFinalizacion;
        private MaskedTextBox mtxtHoraFina;
        private MaskedTextBox mtxtHoraInicio;
    }
}