using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{

    public static class ProductDAO
    {

        public static List<Product> GetActive()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            //OBTENER PRODUCTOS ACTIVOS
            {

                conn.Open();
                string query = "SELECT IdProducto, Nombre, Precio, Stock FROM Productos WHERE Estado = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = (double)reader.GetDecimal(2),
                        Stock = reader.GetInt32(3)
                    });
                }

                return list;
            }
        }
        //OBTENER PRODUCTOS INACTIVOS
        public static List<Product> GetInactive()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection conn = ConexionDB.ObtenerConexion())

            {
                string query = "SELECT IdProducto, Nombre, Precio, Stock FROM Productos WHERE Estado = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = (double)reader.GetDecimal(2),
                        Stock = reader.GetInt32(3)
                    });
                }

                return list;
            }
        }


        //ADD PRODUCT
        public static bool AgregarProducto(Product p)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_AgregarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", p.Name);
                cmd.Parameters.AddWithValue("@Precio", p.Price);
                cmd.Parameters.AddWithValue("@Stock", p.Stock);
                cmd.Parameters.AddWithValue("@Estado", 1);

                int filas = cmd.ExecuteNonQuery();

                return filas > 0;
            }
        }






    }

}
