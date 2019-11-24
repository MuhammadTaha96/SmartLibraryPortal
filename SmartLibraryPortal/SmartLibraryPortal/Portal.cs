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
            bookControl1.BringToFront();
            WindowState = FormWindowState.Maximized;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            bookControl1.BringToFront();
            WindowState = FormWindowState.Maximized;
        }

        private void Portal_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            studentUserControl1.BringToFront();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            uc_Reservation1.BringToFront();
        }

        private void uc_Reservation1_Load(object sender, EventArgs e)
        {

        }
    }
}
