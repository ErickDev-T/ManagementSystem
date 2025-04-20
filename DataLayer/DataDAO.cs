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

    }
}
