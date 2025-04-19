using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Forms_Admin;
using PresentationLayer.FormsAdmin;



namespace PresentationLayer
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void guna2PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new ProductsForm());

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new AddProducts());
        }
    }
}
