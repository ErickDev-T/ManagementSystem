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
using DataLayer;
using BusinessLayer;



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
            loadform(new Reports());
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new AddProducts());
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            int total = DatosDAO.gettingtTotalProducts();
            lblProductTypes.Text = total.ToString();

            int totalStock = DatosDAO.gettingtTotalStock();
            lblTotalUnits.Text = totalStock.ToString();

            MostrarProductoMenorStock();
            MostrarProductoMayorStock();
            MostrarProductoAgotado();

        }

        private void MostrarProductoMenorStock()
        {
            var producto = ProductService.ObtenerProductoMenorStock();

            lblNombreMenorStock.Text = producto.Nombre;
            lblOutStock.Text = producto.Cantidad.ToString();
        }

        private void MostrarProductoMayorStock()
        {
            var producto = ProductService.ObtenerProductoMayorStock();

            lblNombreMostStock.Text = producto.Nombre;
            lblMostStock.Text = producto.Cantidad.ToString();
        }


        private void MostrarProductoAgotado()
        {
            var agotado = ProductService.ObtenerUnProductoAgotado();

            lblNombreOut.Text = agotado.Nombre;
        }



        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new settings(this));
        }
    }
}
