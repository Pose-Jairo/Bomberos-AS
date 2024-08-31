namespace bomberos
{
    partial class Form2
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
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Location = new Point(-1, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 148);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Goldenrod;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(634, -1);
            button6.Name = "button6";
            button6.Size = new Size(105, 32);
            button6.TabIndex = 0;
            button6.Text = "inicio";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 82);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bombero21;
            pictureBox1.Location = new Point(254, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 101);
            button1.Name = "button1";
            button1.Size = new Size(121, 59);
            button1.TabIndex = 2;
            button1.Text = "edificio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(154, 101);
            button2.Name = "button2";
            button2.Size = new Size(126, 59);
            button2.TabIndex = 3;
            button2.Text = "taller";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 200);
            button3.Name = "button3";
            button3.Size = new Size(135, 67);
            button3.TabIndex = 4;
            button3.Text = "automotores";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(174, 200);
            button4.Name = "button4";
            button4.Size = new Size(126, 67);
            button4.TabIndex = 5;
            button4.Text = "guardias";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(298, 101);
            button5.Name = "button5";
            button5.Size = new Size(138, 59);
            button5.TabIndex = 6;
            button5.Text = "capacitacion";
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Goldenrod;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(466, 101);
            button7.Name = "button7";
            button7.Size = new Size(125, 59);
            button7.TabIndex = 8;
            button7.Text = "furrieles";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Goldenrod;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(616, 101);
            button9.Name = "button9";
            button9.Size = new Size(109, 59);
            button9.TabIndex = 10;
            button9.Text = "roperia";
            button9.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(737, 374);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "area";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button9;
        private PictureBox pictureBox1;
        private Button button6;
    }
}