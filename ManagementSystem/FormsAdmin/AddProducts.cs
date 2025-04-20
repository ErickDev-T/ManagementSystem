using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.FormsAdmin
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }


        private void CargarCategorias()
        {


            categoryGrid.DataSource = CategoriaBL.ObtenerTodas();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            categoryGrid.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            categoryGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);


            categoryGrid.Columns[0].Width = 20;
            categoryGrid.Columns[1].Width = 90;


            //// Encabezados: fondo negro, texto blanco
            categoryGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 133, 202);

        }



        private void AddBNT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nameTXT.Text) ||
            string.IsNullOrWhiteSpace(priceTXT.Text) ||
            string.IsNullOrWhiteSpace(stockTXT.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!double.TryParse(priceTXT.Text, out double price))
            {
                MessageBox.Show("Price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(stockTXT.Text, out int stock))
            {
                MessageBox.Show("Stock must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product nuevo = new Product
            {
                Name = nameTXT.Text.Trim(),
                Price = price,
                Stock = stock,
                CategoryID = categoryIDTXTC.Text.Trim(),
            };

            if (ProductService.TryAgregarProducto(nuevo, out string mensaje))
            {
                MessageBox.Show(mensaje, "✅", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // opcional: limpiar campos
                nameTXT.Clear();
                priceTXT.Clear();
                stockTXT.Clear();
                categoryIDTXTC.Clear();
                //categoryIDTXTC.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(mensaje, "❌", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryIDTXTC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

