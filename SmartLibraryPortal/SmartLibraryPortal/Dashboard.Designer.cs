namespace SmartLibraryPortal
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReservations);
            this.panel3.Controls.Add(this.btnStudents);
            this.panel3.Controls.Add(this.btnBooks);
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 566);
            this.panel3.TabIndex = 0;
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservations.Location = new System.Drawing.Point(0, 212);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(200, 54);
            this.btnReservations.TabIndex = 2;
            this.btnReservations.Text = "RESERVATIONS";
            this.btnReservations.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudents.Location = new System.Drawing.Point(0, 161);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 54);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBooks.Location = new System.Drawing.Point(0, 110);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(200, 54);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "BOOKS";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(863, 567);
            this.Controls.Add(this.panel3);
            this.Name = "Dashboard";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel panel2;
//private BookUserControl bookUserControl1;
        private StudentUserControl studentUserControl1;
        private System.Windows.Forms.Button btnClose;
        private StudentUserControl studentUserControl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBooks;
    }
}