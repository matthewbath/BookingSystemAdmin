namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Patient_Name = new Label();
            lbl_Doctor = new Label();
            lbl_Date = new Label();
            lbl_Time = new Label();
            lbl_Reason_for_visit = new Label();
            SuspendLayout();
            // 
            // lbl_Patient_Name
            // 
            lbl_Patient_Name.AutoSize = true;
            lbl_Patient_Name.Location = new Point(63, 143);
            lbl_Patient_Name.Name = "lbl_Patient_Name";
            lbl_Patient_Name.Size = new Size(79, 15);
            lbl_Patient_Name.TabIndex = 0;
            lbl_Patient_Name.Text = "Patient Name";
            // 
            // lbl_Doctor
            // 
            lbl_Doctor.AutoSize = true;
            lbl_Doctor.Location = new Point(63, 191);
            lbl_Doctor.Name = "lbl_Doctor";
            lbl_Doctor.Size = new Size(43, 15);
            lbl_Doctor.TabIndex = 1;
            lbl_Doctor.Text = "Doctor";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(63, 245);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(31, 15);
            lbl_Date.TabIndex = 2;
            lbl_Date.Text = "Date";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Location = new Point(63, 295);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(33, 15);
            lbl_Time.TabIndex = 3;
            lbl_Time.Text = "Time";
            // 
            // lbl_Reason_for_visit
            // 
            lbl_Reason_for_visit.AutoSize = true;
            lbl_Reason_for_visit.Location = new Point(63, 354);
            lbl_Reason_for_visit.Name = "lbl_Reason_for_visit";
            lbl_Reason_for_visit.Size = new Size(88, 15);
            lbl_Reason_for_visit.TabIndex = 4;
            lbl_Reason_for_visit.Text = "Reason for Visit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(lbl_Reason_for_visit);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_Doctor);
            Controls.Add(lbl_Patient_Name);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Booking Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Patient_Name;
        private Label lbl_Doctor;
        private Label lbl_Date;
        private Label lbl_Time;
        private Label lbl_Reason_for_visit;
    }
}