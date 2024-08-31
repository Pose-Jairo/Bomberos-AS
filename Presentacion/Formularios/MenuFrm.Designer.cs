namespace Presentacion.Formularios
{
    partial class MenuFrm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblFecha = new Label();
            panel5 = new Panel();
            lblHora = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            timerHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(163, 11, 46);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 102);
            label1.Location = new Point(92, 16);
            label1.Name = "label1";
            label1.Size = new Size(618, 32);
            label1.TabIndex = 0;
            label1.Text = "BOMBEROS VOLUNTARIOS DE SAN VICENTE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(142, 48, 45);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 104);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 292);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblFecha);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 292);
            panel4.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(123, 17);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "label3";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = Color.FromArgb(157, 76, 76);
            panel5.Controls.Add(lblHora);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(51, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 173);
            panel5.TabIndex = 2;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(19, 62);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(164, 56);
            lblHora.TabIndex = 0;
            lblHora.Text = "HORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "HORA:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(157, 76, 76);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(592, 202);
            button2.Name = "button2";
            button2.Size = new Size(145, 60);
            button2.TabIndex = 1;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(157, 76, 76);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(414, 202);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 0;
            button1.Text = "Ingreso";
            button1.UseVisualStyleBackColor = false;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Tick += timerHora_Tick;
            // 
            // MenuFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 201, 179);
            ClientSize = new Size(800, 457);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuFrm";
            Text = "BOMBEROS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private Label label2;
        private Panel panel5;
        private Label lblFecha;
    }
}