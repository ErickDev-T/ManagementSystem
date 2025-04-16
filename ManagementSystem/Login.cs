using System.Configuration;
using System.Data.SqlClient;
using PresentationLayer;
using DataLayer;
using BusinessLayer;


namespace ManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly UserService servicio = new UserService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static string conn = ConfigurationManager.ConnectionStrings["ManagementSystemDB"].ConnectionString;
        public static string utl;

        private void bntlogin_Click(object sender, EventArgs e)
        {
            if (textuser.Text == "" || textpass.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                try
                {

                    string usuario = textuser.Text;
                    string clave = textpass.Text;

                    string rol = servicio.IniciarSesion(usuario, clave);

                    if (rol == "Admin")
                    {
                        MessageBox.Show("Bienvenido Administrador");
                        new Admin().Show();
                        this.Hide();
                    }
                    else if (rol == "Cashier")
                    {
                        MessageBox.Show("Bienvenido Cajero");
                        new Cashier().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
