using System.Data.SqlClient;
using System.Data;


namespace DataLayer
{
    public class ConexionDB
    {
        private readonly SqlConnection conn;

        public ConexionDB()
        {
            conn = new SqlConnection("Data Source=DESKTOP-372NBM0\\RIC;Initial Catalog=ManagementSystemDB;Integrated Security=True");
        }
        //patrol de dise;o singelton
        public SqlConnection AbrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void CerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool ProbarConexion()
        {
            try
            {
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
