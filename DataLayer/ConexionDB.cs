using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public static class ConexionDB
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["ManagementSystemDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(cadena))
                throw new InvalidOperationException("⚠ La cadena de conexión no está definida correctamente en App.config.");

            return new SqlConnection(cadena);
        }
    }
}
