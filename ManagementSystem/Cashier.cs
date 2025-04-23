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
using static System.Collections.Specialized.BitVector32;
using PresentationLayer;
using ManagementSystem;
using PresentationLayer.FormsAdmin;

namespace PresentationLayer
{
    public partial class Cashier : Form
    {
        private Form adminRef;

        public Cashier(Form Admin)
        {
            InitializeComponent();
            this.adminRef = Admin;
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            adminRef.Close();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            lblTotalVenta.Text = $"${total:F2}";
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

            dgvDetalle.ColumnHeadersHeight = 40;

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

            if (int.TryParse(txtProductID.Text, out int idBuscado))
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Please enter both Product ID and Quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductID.Text, out int productId) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("ID and Quantity must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = ProductDAO.BuscarProductoPorID(productId);

            if (producto == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            if (cantidad > producto.Stock)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            decimal subtotal = (decimal)producto.Price * cantidad;

            dgvDetalle.Rows.Add(producto.Id, producto.Name, producto.Price, cantidad, subtotal);

            txtProductID.Clear();
            txtCantidad.Clear();
            CalcularTotal();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            decimal totalVenta = 0;
            int totalCantidad = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    totalVenta += Convert.ToDecimal(row.Cells["Subtotal"].Value);

                if (row.Cells["Cantidad"].Value != null)
                    totalCantidad += Convert.ToInt32(row.Cells["Cantidad"].Value);
            }

            try
            {
                // Usuario fijo para pruebas, puedes cambiar el 1 por otro ID si estás logueado
                bool exito = DatosDAO.RegistrarVentaRapida(1, totalVenta, totalCantidad);

                if (exito)
                {
                    MessageBox.Show("✅ Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDetalle.Rows.Clear();
                    lblTotalVenta.Text = "Total: $0.00";
                }
                else
                {
                    MessageBox.Show("❌ Error al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}
