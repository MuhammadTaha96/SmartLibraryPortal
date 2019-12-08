using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLibraryPortal.Operations;
using Models;

namespace SmartLibraryPortal
{
    public partial class CheckIn : UserControl
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CICO_Load(object sender, EventArgs e)
        {
            txtStuRFID.Focus();
        }

        private void txtStuRFID_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtStuRFID.TextLength != 10)
                return;
            else
            {
                lblSwap.Text = "Please bring books near RF Reader";
                txtBkRFID.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBkRFID.Clear();
            txtStuRFID.Clear();
            txtStuRFID.Focus();

        }

        private void txtBkRFID_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtBkRFID.TextLength != 10)
            //    return;
            //else
            //{
            //  // MessageBox.Show(string.Format("Student RFID: {0} \n Copy RFID: {1}", txtStuRFID.Text, txtBkRFID.Text));

            //    TransactionResponse Tresponse =  WebApiClient.CheckIn(txtStuRFID.Text, txtBkRFID.Text);
            //    MessageBox.Show(Tresponse.ResponseMessage);
            //}
        }

        private void txtBkRFID_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBkRFID.TextLength != 10)
                return;
            else
            {
                // MessageBox.Show(string.Format("Student RFID: {0} \n Copy RFID: {1}", txtStuRFID.Text, txtBkRFID.Text));

                TransactionResponse Tresponse = WebApiClient.CheckInCheckOut(txtStuRFID.Text, txtBkRFID.Text);
                
                MessageBox.Show(Tresponse.ResponseMessage);
            }
        }


    }
}
