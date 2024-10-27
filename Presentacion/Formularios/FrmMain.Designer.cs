namespace Presentacion.Formularios
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pHistorial = new System.Windows.Forms.Panel();
            this.pEncabezado = new System.Windows.Forms.Panel();
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.pHistorial.SuspendLayout();
            this.pEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrada.BackColor = System.Drawing.Color.Green;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(348, 151);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(175, 45);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = ">> Entrada >>";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalida.BackColor = System.Drawing.Color.Red;
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(533, 151);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(175, 45);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "<< Salida <<";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(348, 92);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(360, 46);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbHistorial
            // 
            this.gbHistorial.Controls.Add(this.dgvHistorial);
            this.gbHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbHistorial.ForeColor = System.Drawing.Color.White;
            this.gbHistorial.Location = new System.Drawing.Point(0, 0);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.gbHistorial.Size = new System.Drawing.Size(1059, 308);
            this.gbHistorial.TabIndex = 3;
            this.gbHistorial.TabStop = false;
            this.gbHistorial.Text = "Historial de registros";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorial.Location = new System.Drawing.Point(9, 27);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 25;
            this.dgvHistorial.Size = new System.Drawing.Size(1041, 273);
            this.dgvHistorial.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(348, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(122, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Identificación:";
            // 
            // pHistorial
            // 
            this.pHistorial.Controls.Add(this.gbHistorial);
            this.pHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHistorial.Location = new System.Drawing.Point(18, 228);
            this.pHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHistorial.Name = "pHistorial";
            this.pHistorial.Size = new System.Drawing.Size(1059, 308);
            this.pHistorial.TabIndex = 5;
            // 
            // pEncabezado
            // 
            this.pEncabezado.Controls.Add(this.btnEmergencia);
            this.pEncabezado.Controls.Add(this.lblCodigo);
            this.pEncabezado.Controls.Add(this.btnEntrada);
            this.pEncabezado.Controls.Add(this.btnSalida);
            this.pEncabezado.Controls.Add(this.txtCodigo);
            this.pEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEncabezado.Location = new System.Drawing.Point(18, 15);
            this.pEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pEncabezado.Name = "pEncabezado";
            this.pEncabezado.Size = new System.Drawing.Size(1059, 213);
            this.pEncabezado.TabIndex = 6;
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmergencia.BackColor = System.Drawing.Color.Red;
            this.btnEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmergencia.ForeColor = System.Drawing.Color.White;
            this.btnEmergencia.Location = new System.Drawing.Point(881, 162);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(175, 45);
            this.btnEmergencia.TabIndex = 5;
            this.btnEmergencia.Text = "EMERGENCIA";
            this.btnEmergencia.UseVisualStyleBackColor = false;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1095, 551);
            this.Controls.Add(this.pHistorial);
            this.Controls.Add(this.pEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.Text = "FrmMain";
            this.gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.pHistorial.ResumeLayout(false);
            this.pEncabezado.ResumeLayout(false);
            this.pEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEntrada;
        private Button btnSalida;
        private TextBox txtCodigo;
        private GroupBox gbHistorial;
        private DataGridView dgvHistorial;
        private Label lblCodigo;
        private Panel pHistorial;
        private Panel pEncabezado;
        private Button btnEmergencia;
    }
}