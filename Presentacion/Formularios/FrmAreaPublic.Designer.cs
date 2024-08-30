namespace Presentacion.Formularios
{
    partial class FrmAreaPublic
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 284);
            button1.Name = "button1";
            button1.Size = new Size(126, 71);
            button1.TabIndex = 0;
            button1.Text = "Edificio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(126, 71);
            button2.TabIndex = 1;
            button2.Text = "Taller";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 142);
            button3.Name = "button3";
            button3.Size = new Size(126, 71);
            button3.TabIndex = 2;
            button3.Text = "Capacitacion";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 71);
            button4.Name = "button4";
            button4.Size = new Size(126, 71);
            button4.TabIndex = 3;
            button4.Text = "Furrieles";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 213);
            button5.Name = "button5";
            button5.Size = new Size(126, 71);
            button5.TabIndex = 4;
            button5.Text = "Roperia";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 355);
            button6.Name = "button6";
            button6.Size = new Size(126, 71);
            button6.TabIndex = 5;
            button6.Text = "Automotores";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 429);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(126, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 429);
            panel2.TabIndex = 2;
            // 
            // FrmAreaPublic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 429);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAreaPublic";
            Text = "FrmAreaPublic";
            Load += FrmAreaPublic_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Panel panel1;
        private Panel panel2;
    }
}