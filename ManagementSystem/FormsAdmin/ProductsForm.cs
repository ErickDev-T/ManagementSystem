using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.Forms_Admin
{
    public partial class ProductsForm : Form
    {

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            ProductsTabla.DataSource = ProductDAO.GetActive();

            // Fuente limpia
            ProductsTabla.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            ProductsTabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);


            ProductsTabla.Columns[1].Width = 300;


            ProductsTabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 133, 202);


            MostrarResumenDashboard();



        }


        private void MostrarResumenDashboard()
        {
            // Puedes usar try-catch si prefieres manejar errores visuales
            lblProductosVendidos.Text = DatosDAO.ObtenerTotalProductosVendidos().ToString();

            decimal vendidoHoy = DatosDAO.ObtenerTotalVendidoHoy();
            lblVendidoHoy.Text = $"${vendidoHoy:N2}";

            decimal vendidoMes = DatosDAO.ObtenerTotalVendidoMes();
            lblVendidoMes.Text = $"${vendidoMes:N2}";

            lblUsuarios.Text = DatosDAO.ObtenerTotalUsuarios().ToString();
        }


        private void ProductsTabla_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
