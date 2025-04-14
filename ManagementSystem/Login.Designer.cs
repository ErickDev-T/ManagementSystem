namespace ManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textun = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textpass = new TextBox();
            bntlogin = new Button();
            checkBox1 = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textun
            // 
            textun.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textun.Location = new Point(176, 181);
            textun.Name = "textun";
            textun.Size = new Size(204, 33);
            textun.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 153);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(746, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 599);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 32);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PresentationLayer.Properties.Resources.x;
            pictureBox1.Location = new Point(1089, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 255);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // textpass
            // 
            textpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpass.Location = new Point(176, 283);
            textpass.Name = "textpass";
            textpass.Size = new Size(204, 33);
            textpass.TabIndex = 4;
            // 
            // bntlogin
            // 
            bntlogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntlogin.Location = new Point(222, 371);
            bntlogin.Name = "bntlogin";
            bntlogin.Size = new Size(129, 52);
            bntlogin.TabIndex = 6;
            bntlogin.Text = "Login";
            bntlogin.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(277, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Pasword";
            checkBox1.TextImageRelation = TextImageRelation.ImageAboveText;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 630);
            Controls.Add(checkBox1);
            Controls.Add(bntlogin);
            Controls.Add(label2);
            Controls.Add(textpass);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textun);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textun;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textpass;
        private Button bntlogin;
        private CheckBox checkBox1;
    }
}
