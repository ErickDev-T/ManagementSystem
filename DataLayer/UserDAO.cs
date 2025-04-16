using System.Data.SqlClient;

namespace DataLayer
{
    public class UserDAO
    {
        public static string GetRole(string username, string password)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open(); // <- abrimos aquí
                    SqlCommand cmd = new SqlCommand("SELECT Usertype FROM Users WHERE Username=@Username AND Password=@Password", conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); // si no hay resultado, devuelve null
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
