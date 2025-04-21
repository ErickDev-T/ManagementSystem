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
                string query = "SELECT ProductID, ProductName, Price, Stock,CategoryID  FROM Products WHERE IsActive = 1";
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
        public static bool addProduct(Product product)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_AgregarProducto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductName", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }


        //search product by name
        public static List<Product> GetInactiveProducts()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT ProductID, ProductName, Price, Stock, CategoryID FROM Products WHERE IsActive = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = (double)reader.GetDecimal(2),
                        Stock = reader.GetInt32(3),
                        CategoryID = reader.GetInt32(4).ToString()
                    });
                }
            }
             
            return list;
        }


        //search product by id
        public static Product BuscarProductoPorID(int id)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarProductoPorID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ProductID")),
                            Name = reader.GetString(reader.GetOrdinal("ProductName")),
                            Price = (double)reader.GetDecimal(reader.GetOrdinal("Price")),
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                        };
                    }
                }
            }

            return null; // No encontrado
        }





    }

}
