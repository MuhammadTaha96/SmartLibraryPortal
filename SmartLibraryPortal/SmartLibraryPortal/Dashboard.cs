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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SidePanel.Height = btnBook.Height;
            SidePanel.Top = btnBook.Top;
            bookUserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBook.Height;
            SidePanel.Top = btnBook.Top;
            bookUserControl1.BringToFront();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStudent.Height;
            SidePanel.Top = btnStudent.Top;
            studentUserControl1.BringToFront();
        }
    }
}
