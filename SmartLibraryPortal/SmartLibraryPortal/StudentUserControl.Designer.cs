namespace SmartLibraryPortal
{
    partial class StudentUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStudents
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgStudents.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.GridColor = System.Drawing.Color.Black;
            this.dgStudents.Location = new System.Drawing.Point(7, 74);
            this.dgStudents.Name = "dgStudents";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgStudents.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgStudents.RowTemplate.Height = 40;
            this.dgStudents.Size = new System.Drawing.Size(820, 286);
            this.dgStudents.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblPageCount);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Location = new System.Drawing.Point(290, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 39);
            this.panel1.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(143, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 33);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblPageCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPageCount.Location = new System.Drawing.Point(86, 13);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(35, 13);
            this.lblPageCount.TabIndex = 2;
            this.lblPageCount.Text = "label1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 33);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.btnAddBook);
            this.gbBooks.Controls.Add(this.btnUpdate);
            this.gbBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBooks.Location = new System.Drawing.Point(513, 3);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Size = new System.Drawing.Size(314, 68);
            this.gbBooks.TabIndex = 9;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Manage User";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBook.Location = new System.Drawing.Point(24, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(110, 37);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(171, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update or Delete";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Type";
            // 
            // cbUType
            // 
            this.cbUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUType.FormattingEnabled = true;
            this.cbUType.Location = new System.Drawing.Point(94, 31);
            this.cbUType.Name = "cbUType";
            this.cbUType.Size = new System.Drawing.Size(151, 21);
            this.cbUType.TabIndex = 14;
            this.cbUType.SelectedIndexChanged += new System.EventHandler(this.cbUType_SelectedIndexChanged);
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbUType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgStudents);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(835, 435);
            this.Load += new System.EventHandler(this.StudentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUType;
    }
}
