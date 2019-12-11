using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using Models;
using SmartLibraryPortal.Operations;

namespace SmartLibraryPortal
{
    public partial class uc_Transaction : UserControl
    {
        int pageNumber = 1;
        IPagedList<Transaction> list;

        public uc_Transaction()
        {
            InitializeComponent();
        }

        private void uc_Transaction_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgTransactions.DataSource = list.Select(o => new { User = o.User.FullName, Book = o.Copy.Book.Title , CheckinDate = o.CheckInDate, CheckOutDate = o.CheckOutDate, DaysKept = o.DaysKept, Fine = o.Fine, Status = o.Type.Name }).ToList();
                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        public IPagedList<Transaction> GetPagedListAsync(int pageNumber = 1, int pageSize = 10, string usertype = "student")
        {
            return WebApiClient.GetTransactions().ToPagedList(pageNumber, pageSize);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                if (list.HasPreviousPage)
                {
                    list = GetPagedListAsync(--pageNumber);
                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    dgTransactions.DataSource = list.Select(o => new { User = o.User.FullName, Book = o.Copy.Book.Title, CheckinDate = o.CheckInDate, CheckOutDate = o.CheckOutDate, DaysKept = o.DaysKept, Fine = o.Fine, Status = o.Type.Name }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (list.HasNextPage)
                {
                    list = GetPagedListAsync(++pageNumber);
                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    dgTransactions.DataSource = list.Select(o => new { User = o.User.FullName, Book = o.Copy.Book.Title, CheckinDate = o.CheckInDate, CheckOutDate = o.CheckOutDate, DaysKept = o.DaysKept, Fine = o.Fine, Status = o.Type.Name }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgTransactions.DataSource = list.Select(o => new { User = o.User.FullName, Book = o.Copy.Book.Title, CheckinDate = o.CheckInDate, CheckOutDate = o.CheckOutDate, DaysKept = o.DaysKept, Fine = o.Fine, Status = o.Type.Name }).ToList();
                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

    }
}
