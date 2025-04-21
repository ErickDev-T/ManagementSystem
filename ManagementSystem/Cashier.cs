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

namespace PresentationLayer
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            cashierTabla.DataSource = ProductDAO.GetActive();

            cashierTabla.ColumnHeadersHeight = 40;
            cashierTabla.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            cashierTabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);


            cashierTabla.Columns[0].Width = 40;
            cashierTabla.Columns[1].Width = 200;
            cashierTabla.Columns[2].Width = 40;
            cashierTabla.Columns[3].Width = 40;


            cashierTabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 133, 202);
        }

        private void cashierTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtBuscarID.Text, out int idBuscado))
            {
                var producto = ProductDAO.BuscarProductoPorID(idBuscado);

                if (producto != null)
                {
                    txtNombre.Text = producto.Name;
                    txtPrecio.Text = producto.Price.ToString("F2");
                    txtStock.Text = producto.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
