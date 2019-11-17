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
    public partial class AddCopy : Form
    {
        public AddCopy()
        {
            InitializeComponent();
        }

        private void AddCopy_Load(object sender, EventArgs e)
        {
            BindBookCombo(cbBookTitle);
          //  BindLocationCombos();
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            Copy copy = new Copy();
            
            copy.RFID = txtRFID.Text;

            copy.Status = new Status();
            copy.Status.Name = "Available";

            copy.Book = new Book();
            copy.Book.BookId = int.Parse((cbBookTitle.SelectedItem as ComboBoxItem).Value.ToString());

            copy.Location = new Location()
            {
                Shelf = (int) numShelve.Value,
                ShelfRow = (int) numRow.Value,
                ShelfCol = (int) numCol.Value 
            };

            if(WebApiClient.AddCopy(copy))
                MessageBox.Show("Copy has been added.");
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

        //This methods bind available shelves, columns, rows to combo boxes
        //Deprecated for now.
        //public void BindLocationCombos()
        //{
        //    List<Location> locations = WebApiClient.GetAvailableLocation();

        //      foreach (var item in locations.Select(x => x.Shelf).Distinct())
        //    {
        //        cbShelve.Items.Add(item);  
        //    }

        //    foreach (var item in locations.Select(x => x.ShelfRow).Distinct())
        //    {
        //        cbRow.Items.Add(item);
        //    }

        //    foreach (var item in locations.Select(x => x.ShelfCol).Distinct())
        //    {
        //        cbColumn.Items.Add(item);
        //    } 
        //}

        private void cbShelve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
