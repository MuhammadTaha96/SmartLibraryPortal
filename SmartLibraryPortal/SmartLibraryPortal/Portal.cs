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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
            uctrl_Books.BringToFront();
            WindowState = FormWindowState.Maximized;
        }

        //Not in Use
        private void btnBooks_Click(object sender, EventArgs e)
        {
            //uctrl_Books.BringToFront();
            //WindowState = FormWindowState.Maximized;
        }

        private void Portal_Load(object sender, EventArgs e)
        {

        }

        //Not in Use
        private void btnStudents_Click(object sender, EventArgs e)
        {
            //uctrl_Users.BringToFront();
        }

        //Not in Use
        private void btnReservations_Click(object sender, EventArgs e)
        {
            //uctrl_Reservation.BringToFront();
        }

        private void uc_Reservation1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uc_Transaction1 = new SmartLibraryPortal.uc_Transaction();
            this.uctrl_CheckIn = new SmartLibraryPortal.CheckIn();
            this.uctrl_Books = new SmartLibraryPortal.bookControl();
            this.uctrl_Users = new SmartLibraryPortal.StudentUserControl();
            this.uctrl_Reservation = new SmartLibraryPortal.uc_Reservation();
            this.uctrl_CheckOut = new SmartLibraryPortal.CheckOut();
            this.button4 = new System.Windows.Forms.Button();
            this.uc_ElectronicFiles1 = new SmartLibraryPortal.uc_ElectronicFiles();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnCheckIn);
            this.panel3.Controls.Add(this.btnReservations);
            this.panel3.Controls.Add(this.btnStudents);
            this.panel3.Controls.Add(this.btnBooks);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 566);
            this.panel3.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckIn.Location = new System.Drawing.Point(0, 256);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(200, 54);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "CHECK IN";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
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
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click_1);
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
            this.btnStudents.Text = "USERS";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click_1);
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
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "TRANSACTION HISTORY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uc_Transaction1
            // 
            this.uc_Transaction1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Transaction1.Location = new System.Drawing.Point(208, 110);
            this.uc_Transaction1.Name = "uc_Transaction1";
            this.uc_Transaction1.Size = new System.Drawing.Size(835, 435);
            this.uc_Transaction1.TabIndex = 8;
            // 
            // uctrl_CheckIn
            // 
            this.uctrl_CheckIn.BackColor = System.Drawing.Color.Transparent;
            this.uctrl_CheckIn.Location = new System.Drawing.Point(210, 110);
            this.uctrl_CheckIn.Name = "uctrl_CheckIn";
            this.uctrl_CheckIn.Size = new System.Drawing.Size(835, 435);
            this.uctrl_CheckIn.TabIndex = 7;
            // 
            // uctrl_Books
            // 
            this.uctrl_Books.BackColor = System.Drawing.Color.Transparent;
            this.uctrl_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uctrl_Books.Location = new System.Drawing.Point(210, 110);
            this.uctrl_Books.Name = "uctrl_Books";
            this.uctrl_Books.Size = new System.Drawing.Size(835, 435);
            this.uctrl_Books.TabIndex = 6;
            // 
            // uctrl_Users
            // 
            this.uctrl_Users.BackColor = System.Drawing.Color.Transparent;
            this.uctrl_Users.Location = new System.Drawing.Point(210, 110);
            this.uctrl_Users.Name = "uctrl_Users";
            this.uctrl_Users.Size = new System.Drawing.Size(835, 435);
            this.uctrl_Users.TabIndex = 5;
            // 
            // uctrl_Reservation
            // 
            this.uctrl_Reservation.BackColor = System.Drawing.Color.Transparent;
            this.uctrl_Reservation.Location = new System.Drawing.Point(210, 110);
            this.uctrl_Reservation.Name = "uctrl_Reservation";
            this.uctrl_Reservation.Size = new System.Drawing.Size(835, 435);
            this.uctrl_Reservation.TabIndex = 4;
            // 
            // uctrl_CheckOut
            // 
            this.uctrl_CheckOut.BackColor = System.Drawing.Color.Transparent;
            this.uctrl_CheckOut.Location = new System.Drawing.Point(210, 110);
            this.uctrl_CheckOut.Name = "uctrl_CheckOut";
            this.uctrl_CheckOut.Size = new System.Drawing.Size(835, 435);
            this.uctrl_CheckOut.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "ELECTRONIC FILES";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // uc_ElectronicFiles1
            // 
            this.uc_ElectronicFiles1.BackColor = System.Drawing.Color.Transparent;
            this.uc_ElectronicFiles1.Location = new System.Drawing.Point(210, 110);
            this.uc_ElectronicFiles1.Name = "uc_ElectronicFiles1";
            this.uc_ElectronicFiles1.Size = new System.Drawing.Size(908, 477);
            this.uc_ElectronicFiles1.TabIndex = 9;
            // 
            // Portal
            // 
            this.ClientSize = new System.Drawing.Size(1163, 567);
            this.Controls.Add(this.uc_ElectronicFiles1);
            this.Controls.Add(this.uc_Transaction1);
            this.Controls.Add(this.uctrl_CheckIn);
            this.Controls.Add(this.uctrl_Books);
            this.Controls.Add(this.uctrl_Users);
            this.Controls.Add(this.uctrl_Reservation);
            this.Controls.Add(this.uctrl_CheckOut);
            this.Controls.Add(this.panel3);
            this.Name = "Portal";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            uctrl_CheckIn.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uctrl_CheckOut.BringToFront();
        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            uctrl_Books.BringToFront();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            uctrl_Users.BringToFront();
        }

        private void btnReservations_Click_1(object sender, EventArgs e)
        {
            uctrl_Reservation.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uc_Transaction1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uc_ElectronicFiles1.BringToFront();
        }
    }
}
