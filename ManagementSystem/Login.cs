using System.Configuration;
using System.Data.SqlClient;
using PresentationLayer;
using DataLayer;
using BusinessLayer;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using Entities;

namespace ManagementSystem
{


    public partial class Form1 : Form
    {

        private string selectedLanguage = "es";

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
            if (usertxtd.Text == "" || passwtxt.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                try
                {
                    string usuario = usertxtd.Text;
                    string clave = passwtxt.Text;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwtxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwtxt.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("¿Estás segura de que quieres cerrar la aplicación?",
                                                      "Confirmar salida",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (usertxtd.Text == "" || passwtxt.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                try
                {
                    string usuario = usertxtd.Text;
                    string clave = passwtxt.Text;

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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        // Estas funciones son para mover el formulario con el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (configurationPanel.Visible)
            {
                loginpanel.Visible = true;
                configurationPanel.Hide();
            }
            else if (!configurationPanel.Visible)
            {
                configurationPanel.Visible = true;
                loginpanel.Hide();
            }

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string, string> mapaIdiomas = new()
        {
            { "Spanish", "es" },
            { "English", "en" }
        };


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            // Obtener el idioma visible del ComboBox
            string visible = comboLanguage.SelectedItem.ToString();

            if (mapaIdiomas.ContainsKey(visible))
            {
                string idioma = mapaIdiomas[visible]; // ← "es" o "en"

                // Cargar JSON
                //LanguageManager.CargarIdiomas();

                // Aplicar traducción
                //Traductor.AplicarIdioma(this, idioma);

                // Mostrar confirmación
                //LanguageManager.MostrarTraducciones(idioma);
                MessageBox.Show("Idioma aplicado correctamente: " + idioma.ToUpper(), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Idioma no reconocido.");
            }
        }
    }
}