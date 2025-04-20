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


            //// Encabezados: fondo negro, texto blanco
            ProductsTabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 133, 202);
            //ProductsTabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //ProductsTabla.EnableHeadersVisualStyles = false;

            //// Fondo general blanco
            //ProductsTabla.BackgroundColor = Color.White;
            //ProductsTabla.DefaultCellStyle.BackColor = Color.White;
            //ProductsTabla.DefaultCellStyle.ForeColor = Color.Black;

            //// Color al seleccionar: gris oscuro
            //ProductsTabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50); // gris oscuro
            //ProductsTabla.DefaultCellStyle.SelectionForeColor = Color.White;

            //// Alternar filas: gris muy claro
            //ProductsTabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            //// Otros ajustes visuales
            //ProductsTabla.GridColor = Color.LightGray;
            //ProductsTabla.RowTemplate.Height = 35;
            //ProductsTabla.BorderStyle = BorderStyle.None;
            //ProductsTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //// Quitar el tema de Guna2
            //ProductsTabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            //ProductsTabla.ThemeStyle = null;




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
