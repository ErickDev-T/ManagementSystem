using BusinessLayer;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarProductosInactivos()
        {
            var lista = ProductService.GetInactiveProducts();
            inactiveProductsGrid.DataSource = lista;
        }


        private void Repots_Load(object sender, EventArgs e)
        {
            CargarProductosInactivos();

            inactiveProductsGrid.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            inactiveProductsGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);


            inactiveProductsGrid.ColumnHeadersHeight = 40;

            inactiveProductsGrid.Columns[0].Width = 40;
            inactiveProductsGrid.Columns[1].Width = 200;
            inactiveProductsGrid.Columns[2].Width = 50;
            inactiveProductsGrid.Columns[3].Width = 60;

            inactiveProductsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 133, 202);

        }
    }
}
