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
using SmartLibraryPortal.Operations;
using PagedList;
using System.Configuration;
using System.IO;

namespace SmartLibraryPortal
{
    public partial class uc_ElectronicFiles : UserControl
    {
        int pageNumber = 1;
        IPagedList<ElectronicFile> list;

        public uc_ElectronicFiles()
        {
            InitializeComponent();
        }

        public void LoadFileCategory(ComboBox cb)
        {
            cb.Items.Clear();
            List<ElectronicFileType> eFileTypeList = WebApiClient.GetElectronicTypes();

            foreach (var fileType in eFileTypeList)
            {
                ComboBoxItem item = new ComboBoxItem();

                item.Text = fileType.Name;
                item.Value = fileType.ElectronicFileTypeId.ToString();

                cb.Items.Add(item);
            }

            cb.SelectedIndex = 1;
        }

        public IPagedList<ElectronicFile> GetPagedListAsync(int pageNumber = 1, int pageSize = 10, string fileType = "Ebook")
        {
            return WebApiClient.GetElectronicFiles().ToPagedList(pageNumber, pageSize);
        }
        private void ElectronicFiles_Load(object sender, EventArgs e)
        {
            LoadFileCategory(cbCategory);

            if (!this.DesignMode)
            {
                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();
                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                // LoadUserTypes(cbUType);
                string fileType = cbCategory.Text.ToLower();
                list = GetPagedListAsync(1, 10, fileType);

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();

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
                    dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();
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
                    dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (WebApiClient.EFileNameAvailability(txtFileName.Text))
                {
                    bool isSuccess = false;
                    string EFileCopyDirectoryPath = ConfigurationSettings.AppSettings.Get("EFileCopyDirectoryPath").ToString() + "\\" + (cbCategory.SelectedItem as ComboBoxItem).Text;
                    string FileSQLPath = ConfigurationSettings.AppSettings.Get("EFileSQLPath").ToString() + "/" + (cbCategory.SelectedItem as ComboBoxItem).Text;

                    ElectronicFile eFile = new ElectronicFile()
                    {
                        FileName = txtFileName.Text,
                        Path = FileSQLPath + "/" + Path.GetFileName(txtPath.Text),

                        FileType = new ElectronicFileType()
                        {
                            ElectronicFileTypeId = int.Parse((cbCategory.SelectedItem as ComboBoxItem).Value.ToString())
                        }
                    };

                    isSuccess = WebApiClient.AddElectronicFile(eFile);

                    if (isSuccess)
                    {
                        MessageBox.Show((cbCategory.SelectedItem as ComboBoxItem).Text + " has been added");
                        File.Copy(txtPath.Text, Path.Combine(EFileCopyDirectoryPath, Path.GetFileName(txtPath.Text)), true);
                    }
                }
                else
                {
                    MessageBox.Show((cbCategory.SelectedItem as ComboBoxItem).Text + " already exist by that name");
                }

                if (!this.DesignMode)
                {
                    list = GetPagedListAsync();

                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();
                    lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                }

            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "PDF Files (*.pdf;) | *.pdf";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = opnfd.FileName;
            }
        }

        private void txtFileName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                e.Cancel = true;
                txtFileName.Focus();
                errorEfile.SetError(txtFileName, "File Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorEfile.SetError(txtFileName, "");
            }
        }

        private void txtPath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                e.Cancel = true;
                txtPath.Focus();
                errorEfile.SetError(txtPath, "Please select a file");
            }
            else
            {
                e.Cancel = false;
                errorEfile.SetError(txtPath, "");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                list = GetPagedListAsync();

                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dgElectronicFiles.DataSource = list.Select(o => new { Name = o.FileName, Type = o.FileType.Name, Format = o.Path.Substring(o.Path.LastIndexOf('.') + 1) }).ToList();
                lblPageCount.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }
    }
}
