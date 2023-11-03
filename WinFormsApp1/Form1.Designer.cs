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
            txtPatientName = new TextBox();
            txtReason = new TextBox();
            cmbDoctor = new ComboBox();
            dtpDate = new DateTimePicker();
            cmbTime = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Patient_Name
            // 
            lbl_Patient_Name.AutoSize = true;
            lbl_Patient_Name.Location = new Point(9, 30);
            lbl_Patient_Name.Name = "lbl_Patient_Name";
            lbl_Patient_Name.Size = new Size(79, 15);
            lbl_Patient_Name.TabIndex = 0;
            lbl_Patient_Name.Text = "Patient Name";
            // 
            // lbl_Doctor
            // 
            lbl_Doctor.AutoSize = true;
            lbl_Doctor.Location = new Point(9, 78);
            lbl_Doctor.Name = "lbl_Doctor";
            lbl_Doctor.Size = new Size(43, 15);
            lbl_Doctor.TabIndex = 1;
            lbl_Doctor.Text = "Doctor";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(9, 49);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(31, 15);
            lbl_Date.TabIndex = 2;
            lbl_Date.Text = "Date";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Location = new Point(9, 99);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(33, 15);
            lbl_Time.TabIndex = 3;
            lbl_Time.Text = "Time";
            // 
            // lbl_Reason_for_visit
            // 
            lbl_Reason_for_visit.AutoSize = true;
            lbl_Reason_for_visit.Location = new Point(9, 158);
            lbl_Reason_for_visit.Name = "lbl_Reason_for_visit";
            lbl_Reason_for_visit.Size = new Size(88, 15);
            lbl_Reason_for_visit.TabIndex = 4;
            lbl_Reason_for_visit.Text = "Reason for Visit";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(122, 22);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(322, 23);
            txtPatientName.TabIndex = 5;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(122, 150);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(322, 23);
            txtReason.TabIndex = 6;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(122, 70);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(322, 23);
            cmbDoctor.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(122, 41);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(322, 23);
            dtpDate.TabIndex = 8;
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(122, 91);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(322, 23);
            cmbTime.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPatientName);
            groupBox1.Controls.Add(lbl_Patient_Name);
            groupBox1.Controls.Add(lbl_Doctor);
            groupBox1.Controls.Add(cmbDoctor);
            groupBox1.Location = new Point(134, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 117);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient and Doctor Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDate);
            groupBox2.Controls.Add(lbl_Date);
            groupBox2.Controls.Add(cmbTime);
            groupBox2.Controls.Add(lbl_Time);
            groupBox2.Controls.Add(lbl_Reason_for_visit);
            groupBox2.Controls.Add(txtReason);
            groupBox2.Location = new Point(134, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 188);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appointment Details";
            // 
            // button1
            // 
            button1.Location = new Point(288, 497);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(427, 497);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 13;
            button2.Text = "Submit Booking";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 50);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 14;
            label1.Text = "Doctor Appointment Booking";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Patient_Name;
        private Label lbl_Doctor;
        private Label lbl_Date;
        private Label lbl_Time;
        private Label lbl_Reason_for_visit;
        private TextBox txtPatientName;
        private TextBox txtReason;
        private ComboBox cmbDoctor;
        private DateTimePicker dtpDate;
        private ComboBox cmbTime;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}