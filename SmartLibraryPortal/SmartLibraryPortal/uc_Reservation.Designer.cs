namespace SmartLibraryPortal
{
    partial class uc_Reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dgReservations = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblPageCount);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Location = new System.Drawing.Point(292, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 39);
            this.panel1.TabIndex = 16;
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
            // dgReservations
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgReservations.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgReservations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.GridColor = System.Drawing.Color.Black;
            this.dgReservations.Location = new System.Drawing.Point(9, 87);
            this.dgReservations.Name = "dgReservations";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReservations.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservations.RowTemplate.Height = 40;
            this.dgReservations.Size = new System.Drawing.Size(820, 286);
            this.dgReservations.TabIndex = 15;
            this.dgReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservations_CellClick);
            // 
            // uc_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgReservations);
            this.Name = "uc_Reservation";
            this.Size = new System.Drawing.Size(835, 435);
            this.Load += new System.EventHandler(this.uc_Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridView dgReservations;
    }
}
