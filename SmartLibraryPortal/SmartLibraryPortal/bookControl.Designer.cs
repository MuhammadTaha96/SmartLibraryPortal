﻿namespace SmartLibraryPortal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBooks
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBooks.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.GridColor = System.Drawing.Color.Black;
            this.dgBooks.Location = new System.Drawing.Point(3, 94);
            this.dgBooks.Name = "dgBooks";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBooks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgBooks.RowTemplate.Height = 40;
            this.dgBooks.Size = new System.Drawing.Size(820, 286);
            this.dgBooks.TabIndex = 1;
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
            this.btnAddBook.Location = new System.Drawing.Point(6, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(89, 37);
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
            this.button2.Location = new System.Drawing.Point(112, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.button3);
            this.gbBooks.Controls.Add(this.btnAddBook);
            this.gbBooks.Controls.Add(this.button2);
            this.gbBooks.Location = new System.Drawing.Point(509, 20);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Size = new System.Drawing.Size(314, 68);
            this.gbBooks.TabIndex = 8;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Manage Books";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(217, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
        private System.Windows.Forms.Button button3;
    }
}