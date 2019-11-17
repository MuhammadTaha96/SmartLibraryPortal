using Models;
using SmartLibraryPortal.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLibraryPortal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin user = WebApiClient.ValidateLibrarian(txtUsername.Text.ToString(), txtPassword.Text.ToString());

            if (user != null)
            {
                this.Hide();
                Portal portal = new Portal();
                portal.Show();
            }
            else
                MessageBox.Show("The username and password are wrong");
        }
    }
}
