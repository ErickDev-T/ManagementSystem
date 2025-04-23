using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem;
using Microsoft.VisualBasic.Logging;
using PresentationLayer;
using PresentationLayer.FormsAdmin; // Added this namespace


namespace PresentationLayer.FormsAdmin
{
    public partial class settings : Form
    {
        private Form adminRe;
        public settings(Form Admin)
        {
            InitializeComponent();
            this.adminRe = Admin;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            adminRe.Close();

        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
    }
}
