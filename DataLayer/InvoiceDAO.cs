using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class InvoiceDAO
    {
        public static bool RegistrarVenta(int userId, List<Product> productos, out string mensaje)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1. Insertar factura
                    SqlCommand cmdFactura = new SqlCommand(@"
                INSERT INTO Invoices (InvoiceDate, UserID, TotalAmount)
                OUTPUT INSERTED.InvoiceID
                VALUES (GETDATE(), @UserID, @Total)", conn, trans);

                    decimal total = productos.Sum(p => (decimal)(p.Price * p.Stock));
                    cmdFactura.Parameters.AddWithValue("@UserID", userId);
                    cmdFactura.Parameters.AddWithValue("@Total", total);

                    int invoiceId = (int)cmdFactura.ExecuteScalar();

                    // 2. Insertar productos y rebajar stock
                    foreach (var p in productos)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(@"
                    INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, UnitPrice, Subtotal)
                    VALUES (@InvoiceID, @ProductID, @Quantity, @UnitPrice, @Subtotal)", conn, trans);

                        cmdDetalle.Parameters.AddWithValue("@InvoiceID", invoiceId);
                        cmdDetalle.Parameters.AddWithValue("@ProductID", p.Id);
                        cmdDetalle.Parameters.AddWithValue("@Quantity", p.Stock);
                        cmdDetalle.Parameters.AddWithValue("@UnitPrice", p.Price);
                        cmdDetalle.Parameters.AddWithValue("@Subtotal", p.Stock * p.Price);
                        cmdDetalle.ExecuteNonQuery();

                        SqlCommand cmdUpdate = new SqlCommand(
                            "UPDATE Products SET Stock = Stock - @Cantidad WHERE ProductID = @ProductID", conn, trans);

                        cmdUpdate.Parameters.AddWithValue("@Cantidad", p.Stock);
                        cmdUpdate.Parameters.AddWithValue("@ProductID", p.Id);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    trans.Commit();
                    mensaje = "✅ Venta registrada con éxito.";
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    mensaje = "❌ Error al registrar venta: " + ex.Message;
                    return false;
                }
            }
        }

    }
}
