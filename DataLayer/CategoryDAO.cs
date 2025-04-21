using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace DataLayer
{
    public class CategoryDAO
    {
        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        Id = reader.GetInt32(0),
                        CategoryName = reader.GetString(1),
                        Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                    });
                }
            }

            return lista;
        }
    }
}
    