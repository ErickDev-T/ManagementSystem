namespace PresentationLayer
{
    partial class Cashier
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x;
            pictureBox1.Location = new Point(1089, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 32);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 298);
            label1.Name = "label1";
            label1.Size = new Size(297, 65);
            label1.TabIndex = 5;
            label1.Text = "Cashier form";
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 630);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
    }
}