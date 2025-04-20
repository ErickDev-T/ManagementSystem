using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                SELECT Usertype 
                FROM Users 
                WHERE Username = @Username AND PasswordHash = @PasswordHash", conn);

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashHelper.HashSHA256(password));

                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); // Devuelve el rol o null si no coincide
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }

    }


    class HashHelper
    {
        public static byte[] HashSHA256(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }
    }
}
