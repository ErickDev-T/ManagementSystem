using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DatosDAO
    {
        public static int gettingtTotalProducts()
        {
            int total = 0;

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_TotalProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int valor))
                {
                    total = valor;
                }
            }

            return total;
        }

        public static int gettingtTotalStock()
        {
            int total = 0;

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_TotalInventario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int valor))
                {
                    total = valor;
                }
            }

            return total;
        }


        public static (string Nombre, int Cantidad) ObtenerProductoMenorStock()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ProductoMenorStock", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        int stock = reader.GetInt32(2);
                        return (nombre, stock);
                    }
                    else
                    {
                        return ("N/A", 0); // por si no hay productos
                    }
                }
            }
        }


        public static (string Nombre, int Cantidad) ObtenerProductoMayorStock()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ProductoMayorStock", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        int stock = reader.GetInt32(1);
                        return (nombre, stock);
                    }
                    else
                    {
                        return ("N/A", 0);
                    }
                }
            }
        }




        public static (string Nombre, int Stock) ObtenerUnProductoAgotado()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ProductoAgotado", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        int stock = reader.GetInt32(1);
                        return (nombre, stock);
                    }
                    else
                    {
                        return ("All in stock", 0); // mensaje por defecto
                    }
                }
            }
        }



        public static int ObtenerTotalProductosVendidos()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ProductosVendidosCantidad", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();

                // 👇 Validación completa: null o DBNull
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }


        public static decimal ObtenerTotalVendidoHoy()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TotalVendidoHoy", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;

            }
        }

        public static decimal ObtenerTotalVendidoMes()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TotalVendidoMes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
            }
        }


        public static int ObtenerTotalUsuarios()
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TotalUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();
                return (result != null) ? Convert.ToInt32(result) : 0;
            }
        }


        public static bool RegistrarVentaRapida(int userId, decimal total, int cantidad)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_RegistrarVentaRapida1", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@TotalAmount", total);
                    cmd.Parameters.AddWithValue("@Quantity", cantidad);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }








    }
}
