namespace SmartLibraryPortal
{
    partial class bookControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.cbSearchItems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBooks
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBooks.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.GridColor = System.Drawing.Color.Black;
            this.dgBooks.Location = new System.Drawing.Point(3, 94);
            this.dgBooks.Name = "dgBooks";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBooks.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgBooks.RowTemplate.Height = 40;
            this.dgBooks.Size = new System.Drawing.Size(820, 235);
            this.dgBooks.TabIndex = 1;
            this.dgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBooks_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblPageCount);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Location = new System.Drawing.Point(302, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 39);
            this.panel1.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBook.Location = new System.Drawing.Point(24, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(105, 37);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(135, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update or Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.btnRefresh);
            this.gbBooks.Controls.Add(this.btnAddBook);
            this.gbBooks.Controls.Add(this.button2);
            this.gbBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBooks.Location = new System.Drawing.Point(459, 20);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Size = new System.Drawing.Size(364, 68);
            this.gbBooks.TabIndex = 8;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Manage Books";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(243, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 37);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "All",
            "Category",
            "Publisher"});
            this.cbSearchBy.Location = new System.Drawing.Point(66, 29);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(104, 21);
            this.cbSearchBy.TabIndex = 10;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // cbSearchItems
            // 
            this.cbSearchItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchItems.FormattingEnabled = true;
            this.cbSearchItems.Items.AddRange(new object[] {
            "All"});
            this.cbSearchItems.Location = new System.Drawing.Point(189, 29);
            this.cbSearchItems.Name = "cbSearchItems";
            this.cbSearchItems.Size = new System.Drawing.Size(235, 21);
            this.cbSearchItems.TabIndex = 11;
            this.cbSearchItems.SelectedIndexChanged += new System.EventHandler(this.cbSearchItems_SelectedIndexChanged);
            // 
            // bookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cbSearchItems);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgBooks);
            this.Name = "bookControl";
            this.Size = new System.Drawing.Size(835, 435);
            this.Load += new System.EventHandler(this.bookControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.ComboBox cbSearchItems;
    }
}
