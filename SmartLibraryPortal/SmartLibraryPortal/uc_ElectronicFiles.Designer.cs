namespace SmartLibraryPortal
{
    partial class uc_ElectronicFiles
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgElectronicFiles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorEfile = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgElectronicFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(630, 346);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 33);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblPageCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPageCount.Location = new System.Drawing.Point(573, 356);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(35, 13);
            this.lblPageCount.TabIndex = 20;
            this.lblPageCount.Text = "label1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.Location = new System.Drawing.Point(490, 346);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 33);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(762, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 33);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgElectronicFiles
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgElectronicFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgElectronicFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgElectronicFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgElectronicFiles.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgElectronicFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgElectronicFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElectronicFiles.GridColor = System.Drawing.Color.Black;
            this.dgElectronicFiles.Location = new System.Drawing.Point(343, 85);
            this.dgElectronicFiles.Name = "dgElectronicFiles";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgElectronicFiles.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgElectronicFiles.RowTemplate.Height = 40;
            this.dgElectronicFiles.Size = new System.Drawing.Size(486, 255);
            this.dgElectronicFiles.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 255);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(116, 143);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(178, 20);
            this.txtPath.TabIndex = 5;
            this.txtPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtPath_Validating);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(116, 91);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(178, 21);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(116, 36);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(178, 20);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFileName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // errorEfile
            // 
            this.errorEfile.ContainerControl = this;
            // 
            // uc_ElectronicFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgElectronicFiles);
            this.Name = "uc_ElectronicFiles";
            this.Size = new System.Drawing.Size(835, 477);
            this.Load += new System.EventHandler(this.ElectronicFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgElectronicFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgElectronicFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorEfile;
    }
}
