namespace SmartLibraryPortal
{
    partial class CheckIn
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
            this.lblSwap = new System.Windows.Forms.Label();
            this.txtStuRFID = new System.Windows.Forms.TextBox();
            this.txtBkRFID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSwap
            // 
            this.lblSwap.AutoSize = true;
            this.lblSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSwap.Location = new System.Drawing.Point(157, 66);
            this.lblSwap.Name = "lblSwap";
            this.lblSwap.Size = new System.Drawing.Size(249, 25);
            this.lblSwap.TabIndex = 0;
            this.lblSwap.Text = "Swap Your Student Card";
            // 
            // txtStuRFID
            // 
            this.txtStuRFID.Location = new System.Drawing.Point(305, 138);
            this.txtStuRFID.Name = "txtStuRFID";
            this.txtStuRFID.Size = new System.Drawing.Size(131, 20);
            this.txtStuRFID.TabIndex = 1;
            this.txtStuRFID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStuRFID_KeyUp);
            // 
            // txtBkRFID
            // 
            this.txtBkRFID.Location = new System.Drawing.Point(305, 193);
            this.txtBkRFID.Name = "txtBkRFID";
            this.txtBkRFID.Size = new System.Drawing.Size(131, 20);
            this.txtBkRFID.TabIndex = 2;
            this.txtBkRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBkRFID_KeyDown);
            this.txtBkRFID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBkRFID_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(159, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student RF ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(159, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book RF ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(479, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(97, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBkRFID);
            this.Controls.Add(this.txtStuRFID);
            this.Controls.Add(this.lblSwap);
            this.Name = "CheckIn";
            this.Size = new System.Drawing.Size(835, 435);
            this.Load += new System.EventHandler(this.CICO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSwap;
        private System.Windows.Forms.TextBox txtStuRFID;
        private System.Windows.Forms.TextBox txtBkRFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}
