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
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalleE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora_Finalizacion = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_FechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 330);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle de Emergencia";
            // 
            // txtDetalleE
            // 
            this.txtDetalleE.Location = new System.Drawing.Point(12, 255);
            this.txtDetalleE.Name = "txtDetalleE";
            this.txtDetalleE.Size = new System.Drawing.Size(506, 23);
            this.txtDetalleE.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora Finalizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicio";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 89);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 10, 15, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // dtpHora_Finalizacion
            // 
            this.dtpHora_Finalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHora_Finalizacion.CustomFormat = "HH:mm";
            this.dtpHora_Finalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_Finalizacion.Location = new System.Drawing.Point(264, 163);
            this.dtpHora_Finalizacion.MaxDate = new System.DateTime(2025, 10, 15, 0, 0, 0, 0);
            this.dtpHora_Finalizacion.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpHora_Finalizacion.Name = "dtpHora_Finalizacion";
            this.dtpHora_Finalizacion.Size = new System.Drawing.Size(200, 23);
            this.dtpHora_Finalizacion.TabIndex = 11;
            this.dtpHora_Finalizacion.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(264, 89);
            this.dtpHoraInicio.MaxDate = new System.DateTime(2025, 10, 15, 0, 0, 0, 0);
            this.dtpHoraInicio.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpHoraInicio.TabIndex = 12;
            this.dtpHoraInicio.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha Finalizacion";
            // 
            // dtp_FechaFinalizacion
            // 
            this.dtp_FechaFinalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_FechaFinalizacion.CustomFormat = "";
            this.dtp_FechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFinalizacion.Location = new System.Drawing.Point(12, 163);
            this.dtp_FechaFinalizacion.MaxDate = new System.DateTime(2025, 10, 15, 0, 0, 0, 0);
            this.dtp_FechaFinalizacion.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaFinalizacion.Name = "dtp_FechaFinalizacion";
            this.dtp_FechaFinalizacion.Size = new System.Drawing.Size(200, 23);
            this.dtp_FechaFinalizacion.TabIndex = 14;
            this.dtp_FechaFinalizacion.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // VentanaEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 379);
            this.Controls.Add(this.dtp_FechaFinalizacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpHora_Finalizacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDetalleE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Name = "VentanaEmergencia";
            this.Text = "VentanaEmergencia";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DateTimePicker dtpHora_Finalizacion;
        private DateTimePicker dtpHoraInicio;
        private Label label5;
        private DateTimePicker dtp_FechaFinalizacion;
    }
}