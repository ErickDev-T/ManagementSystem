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

namespace PresentationLayer.FormsAdmin
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void AddBNT_Click(object sender, EventArgs e)
        {
         
            Product nuevo = new Product
            {
                Name = nameTXT.Text,
                Price = double.Parse(priceTXT.Text),
                Stock = int.Parse(stockTXT.Text)
            };

            bool agregado = ProductDAO.AgregarProducto(nuevo);

            if (agregado)
                MessageBox.Show("Producto agregado correctamente ✅");
            else
                MessageBox.Show("Error al agregar el producto ❌");
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
    }
}

