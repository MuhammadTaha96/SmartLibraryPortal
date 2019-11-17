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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
            sidePanel.Height = btnBooks.Height;
            sidePanel.Top = btnBooks.Top;
             //.BringToFront();
            WindowState = FormWindowState.Maximized;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void Portal_Load(object sender, EventArgs e)
        {

        }
    }
}
