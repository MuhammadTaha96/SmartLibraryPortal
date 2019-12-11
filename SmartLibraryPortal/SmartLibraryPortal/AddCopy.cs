using Models;
using PagedList;
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
    public partial class AddCopy : Form
    {

        int pageNumber = 1;
        IPagedList<Location> list;

        public AddCopy()
        {
            InitializeComponent();
        }

        private void AddCopy_Load(object sender, EventArgs e)
        {
            BindBookCombo(cbBookTitle);

            if (!this.DesignMode)
            {
                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgCopyLocation.DataSource = list.Select(o => new { Shelve = o.Shelf, Row = o.ShelfRow, Column = o.ShelfCol }).ToList();
                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        public IPagedList<Location> GetPagedListAsync(int pageNumber = 1, int pageSize = 10, string usertype = "student")
        {
            return WebApiClient.GetAvailableLocation().ToPagedList(pageNumber, pageSize);
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
                    dgCopyLocation.DataSource = list.Select(o => new { Shelve = o.Shelf, Row = o.ShelfRow, Column = o.ShelfCol }).ToList();
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
                    dgCopyLocation.DataSource = list.Select(o => new { Shelve = o.Shelf, Row = o.ShelfRow, Column = o.ShelfCol }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }
            }
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                List<Location> availableLocation = WebApiClient.GetAvailableLocation();

                if (availableLocation.Where(x => x.Shelf.Equals((int)numShelve.Value) && x.ShelfCol.Equals((int)numCol.Value) && x.ShelfRow.Equals((int)numRow.Value)).SingleOrDefault() != null)
                {
                    Copy copy = new Copy();

                    copy.RFID = txtRFID.Text;

                    copy.Status = new Status();
                    copy.Status.Name = "Available";

                    copy.Book = new Book();
                    copy.Book.BookId = int.Parse((cbBookTitle.SelectedItem as ComboBoxItem).Value.ToString());

                    copy.Location = new Location()
                    {
                        Shelf = (int)numShelve.Value,
                        ShelfRow = (int)numRow.Value,
                        ShelfCol = (int)numCol.Value
                    };

                    if (WebApiClient.AddCopy(copy))
                    {
                        MessageBox.Show("Copy has been added.");

                        if (!this.DesignMode)
                        {
                            list = GetPagedListAsync();

                            btnPrevious.Enabled = list.HasPreviousPage;
                            btnNext.Enabled = list.HasNextPage;
                            dgCopyLocation.DataSource = list.Select(o => new { Shelve = o.Shelf, Row = o.ShelfRow, Column = o.ShelfCol }).ToList();
                            lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("That location is not available. Please select a different location from the grid table.");
                }
            }
        }

        public void BindBookCombo(ComboBox cb)
        {
            List<Book> books = WebApiClient.GetAllBooks();

            foreach (var book in books)
            {
                ComboBoxItem item = new ComboBoxItem();

                item.Text = book.Title;
                item.Value = book.BookId.ToString();

                cbBookTitle.Items.Add(item);
                cbBookTitle.SelectedIndex = 0;
            }
        }

        private void cbShelve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRFID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRFID.Text))
            {
                e.Cancel = true;
                txtRFID.Focus();
                errorProviderCopy.SetError(txtRFID, "Please read a RFID card from RF Reader");
            }
            else
            {
                e.Cancel = false;
                errorProviderCopy.SetError(txtRFID, "");
            }
        }

        private void numShelve_Validating(object sender, CancelEventArgs e)
        {
            if (numShelve.Value.Equals(0))
            {
                e.Cancel = true;
                numShelve.Focus();
                errorProviderCopy.SetError(numShelve, "Shelve value cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProviderCopy.SetError(numShelve, "");
            }
        }

        private void numRow_Validating(object sender, CancelEventArgs e)
        {
            if (numRow.Value.Equals(0))
            {
                e.Cancel = true;
                numRow.Focus();
                errorProviderCopy.SetError(numRow, "Row value cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProviderCopy.SetError(numRow, "");
            }
        }

        private void numCol_Validating(object sender, CancelEventArgs e)
        {
            if (numCol.Value.Equals(0))
            {
                e.Cancel = true;
                numCol.Focus();
                errorProviderCopy.SetError(numCol, "Column value cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProviderCopy.SetError(numCol, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgCopyLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numCol.Value = decimal.Parse(dgCopyLocation.Rows[e.RowIndex].Cells["Column"].Value.ToString());
            numRow.Value = decimal.Parse(dgCopyLocation.Rows[e.RowIndex].Cells["Row"].Value.ToString());
            numShelve.Value = decimal.Parse(dgCopyLocation.Rows[e.RowIndex].Cells["Shelve"].Value.ToString());

        }

        private void txtRFID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
