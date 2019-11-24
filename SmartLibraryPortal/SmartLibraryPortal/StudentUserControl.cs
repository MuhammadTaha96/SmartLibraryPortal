using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using PagedList;
using SmartLibraryPortal.Operations;

namespace SmartLibraryPortal
{
    public partial class StudentUserControl : UserControl
    {
        int pageNumber = 1;
        IPagedList<UserLogin> list;

        public StudentUserControl()
        {
            InitializeComponent();
        }

        public IPagedList<UserLogin> GetPagedListAsync(int pageNumber = 1, int pageSize = 10, string usertype = "student")
        {
            return WebApiClient.GetUsers(usertype).ToPagedList(pageNumber, pageSize);
        }

        private void StudentUserControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadUserTypes(cbUType);

                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgStudents.DataSource = list.Select(o => new { UserName = o.UserName, Name = o.FullName, Email = o.Email, PhoneNumber = o.PhoneNumber }).ToList();

                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
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
                    dgStudents.DataSource = list.Select(o => new { UserName = o.UserName, Name = o.FullName, Email = o.Email, PhoneNumber = o.PhoneNumber }).ToList();
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
                    dgStudents.DataSource = list.Select(o => new { UserName = o.UserName, Name = o.FullName, Email = o.Email, PhoneNumber = o.PhoneNumber }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }
            }
        }

        public void LoadUserTypes(ComboBox cb)
        {
            cb.Items.Clear();
            List<UserType> userTypeList = WebApiClient.GetUserTypes();

            foreach (var userType in userTypeList)
            {
                ComboBoxItem item = new ComboBoxItem();

                item.Text = userType.Name;
                item.Value = userType.UserTypeId.ToString();

                cb.Items.Add(item);
            }

            cb.SelectedIndex = 1;


        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!this.DesignMode)
            //{
            //    LoadUserTypes(cbUType);
            //    string userType = cbUType.Text.ToLower();
            //    list = GetPagedListAsync(1, 10, userType);

            //    btnPrevious.Enabled = list.HasPreviousPage;
            //    btnNext.Enabled = list.HasNextPage;
            //    dgStudents.DataSource = list.Select(o => new { UserName = o.UserName, Name = o.FullName, Email = o.Email, PhoneNumber = o.PhoneNumber }).ToList();

            //    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            //}
        }

        private void cbUType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
               // LoadUserTypes(cbUType);
                string userType = cbUType.Text.ToLower();
                list = GetPagedListAsync(1, 10, userType);

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgStudents.DataSource = list.Select(o => new { UserName = o.UserName, Name = o.FullName, Email = o.Email, PhoneNumber = o.PhoneNumber }).ToList();

                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
        }

        //Update & Delete button
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser();
            update.Show();
        }
    }
}
