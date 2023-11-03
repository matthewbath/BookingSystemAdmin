namespace New_Patient_and_Doctor_Assignment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox comboDoctorAssigned;
            this.lblNewPatient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.dateDoB = new System.Windows.Forms.DateTimePicker();
            this.boxNewPatientDetails = new System.Windows.Forms.GroupBox();
            this.txtNewPatientAddress = new System.Windows.Forms.TextBox();
            this.lblNewPatientAddress = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.boxDoctorDetails = new System.Windows.Forms.GroupBox();
            this.dateDateOfRegister = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfRegister = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.btnConfirmPatient = new System.Windows.Forms.Button();
            comboDoctorAssigned = new System.Windows.Forms.ComboBox();
            this.boxNewPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.boxDoctorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDoctorAssigned
            // 
            comboDoctorAssigned.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboDoctorAssigned.FormattingEnabled = true;
            comboDoctorAssigned.Location = new System.Drawing.Point(145, 22);
            comboDoctorAssigned.Name = "comboDoctorAssigned";
            comboDoctorAssigned.Size = new System.Drawing.Size(350, 28);
            comboDoctorAssigned.TabIndex = 3;
            // 
            // lblNewPatient
            // 
            this.lblNewPatient.AutoSize = true;
            this.lblNewPatient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPatient.Location = new System.Drawing.Point(318, 18);
            this.lblNewPatient.Name = "lblNewPatient";
            this.lblNewPatient.Size = new System.Drawing.Size(142, 32);
            this.lblNewPatient.TabIndex = 0;
            this.lblNewPatient.Text = "New Patient";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(145, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 27);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoB.Location = new System.Drawing.Point(9, 78);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(97, 21);
            this.lblDoB.TabIndex = 3;
            this.lblDoB.Text = "Date of Birth";
            this.lblDoB.Click += new System.EventHandler(this.lblDoB_Click);
            // 
            // dateDoB
            // 
            this.dateDoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDoB.Location = new System.Drawing.Point(145, 78);
            this.dateDoB.Name = "dateDoB";
            this.dateDoB.Size = new System.Drawing.Size(350, 27);
            this.dateDoB.TabIndex = 4;
            this.dateDoB.ValueChanged += new System.EventHandler(this.dateDoB_ValueChanged);
            // 
            // boxNewPatientDetails
            // 
            this.boxNewPatientDetails.Controls.Add(this.txtNewPatientAddress);
            this.boxNewPatientDetails.Controls.Add(this.lblNewPatientAddress);
            this.boxNewPatientDetails.Controls.Add(this.txtPhoneNum);
            this.boxNewPatientDetails.Controls.Add(this.lblPhoneNum);
            this.boxNewPatientDetails.Controls.Add(this.lblName);
            this.boxNewPatientDetails.Controls.Add(this.dateDoB);
            this.boxNewPatientDetails.Controls.Add(this.txtName);
            this.boxNewPatientDetails.Controls.Add(this.lblDoB);
            this.boxNewPatientDetails.Location = new System.Drawing.Point(125, 64);
            this.boxNewPatientDetails.Name = "boxNewPatientDetails";
            this.boxNewPatientDetails.Size = new System.Drawing.Size(554, 237);
            this.boxNewPatientDetails.TabIndex = 5;
            this.boxNewPatientDetails.TabStop = false;
            this.boxNewPatientDetails.Text = "Patient Details";
            this.boxNewPatientDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNewPatientAddress
            // 
            this.txtNewPatientAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPatientAddress.Location = new System.Drawing.Point(145, 190);
            this.txtNewPatientAddress.Name = "txtNewPatientAddress";
            this.txtNewPatientAddress.Size = new System.Drawing.Size(350, 27);
            this.txtNewPatientAddress.TabIndex = 8;
            this.txtNewPatientAddress.TextChanged += new System.EventHandler(this.txtNewPatientAddress_TextChanged);
            // 
            // lblNewPatientAddress
            // 
            this.lblNewPatientAddress.AutoSize = true;
            this.lblNewPatientAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPatientAddress.Location = new System.Drawing.Point(9, 190);
            this.lblNewPatientAddress.Name = "lblNewPatientAddress";
            this.lblNewPatientAddress.Size = new System.Drawing.Size(66, 21);
            this.lblNewPatientAddress.TabIndex = 7;
            this.lblNewPatientAddress.Text = "Address";
            this.lblNewPatientAddress.Click += new System.EventHandler(this.lblNewPatientAddress_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNum.Location = new System.Drawing.Point(145, 135);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(350, 27);
            this.txtPhoneNum.TabIndex = 6;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNum.Location = new System.Drawing.Point(6, 135);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(116, 21);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // boxDoctorDetails
            // 
            this.boxDoctorDetails.Controls.Add(this.dateDateOfRegister);
            this.boxDoctorDetails.Controls.Add(this.lblDateOfRegister);
            this.boxDoctorDetails.Controls.Add(comboDoctorAssigned);
            this.boxDoctorDetails.Controls.Add(this.lblDoctorName);
            this.boxDoctorDetails.Location = new System.Drawing.Point(125, 318);
            this.boxDoctorDetails.Name = "boxDoctorDetails";
            this.boxDoctorDetails.Size = new System.Drawing.Size(554, 122);
            this.boxDoctorDetails.TabIndex = 6;
            this.boxDoctorDetails.TabStop = false;
            this.boxDoctorDetails.Text = "Doctor Details";
            this.boxDoctorDetails.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // dateDateOfRegister
            // 
            this.dateDateOfRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDateOfRegister.Location = new System.Drawing.Point(145, 72);
            this.dateDateOfRegister.Name = "dateDateOfRegister";
            this.dateDateOfRegister.Size = new System.Drawing.Size(350, 27);
            this.dateDateOfRegister.TabIndex = 9;
            // 
            // lblDateOfRegister
            // 
            this.lblDateOfRegister.AutoSize = true;
            this.lblDateOfRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfRegister.Location = new System.Drawing.Point(9, 72);
            this.lblDateOfRegister.Name = "lblDateOfRegister";
            this.lblDateOfRegister.Size = new System.Drawing.Size(97, 21);
            this.lblDateOfRegister.TabIndex = 4;
            this.lblDateOfRegister.Text = "Today\'s Date";
            this.lblDateOfRegister.Click += new System.EventHandler(this.lblDateOfRegister_Click);
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoctorName.Location = new System.Drawing.Point(9, 22);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(124, 21);
            this.lblDoctorName.TabIndex = 2;
            this.lblDoctorName.Text = "Doctor Assigned";
            this.lblDoctorName.Click += new System.EventHandler(this.lblDoctorName_Click);
            // 
            // btnConfirmPatient
            // 
            this.btnConfirmPatient.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConfirmPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmPatient.Location = new System.Drawing.Point(318, 455);
            this.btnConfirmPatient.Name = "btnConfirmPatient";
            this.btnConfirmPatient.Size = new System.Drawing.Size(123, 62);
            this.btnConfirmPatient.TabIndex = 7;
            this.btnConfirmPatient.Text = "Confirm Patient";
            this.btnConfirmPatient.UseVisualStyleBackColor = false;
            this.btnConfirmPatient.Click += new System.EventHandler(this.btnConfirmPatient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 529);
            this.Controls.Add(this.btnConfirmPatient);
            this.Controls.Add(this.boxDoctorDetails);
            this.Controls.Add(this.boxNewPatientDetails);
            this.Controls.Add(this.lblNewPatient);
            this.Name = "Form1";
            this.Text = "New Patient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxNewPatientDetails.ResumeLayout(false);
            this.boxNewPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.boxDoctorDetails.ResumeLayout(false);
            this.boxDoctorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNewPatient;
        private Label lblName;
        private TextBox txtName;
        private Label lblDoB;
        private DateTimePicker dateDoB;
        private GroupBox boxNewPatientDetails;
        private Label lblPhoneNum;
        private ErrorProvider errorProvider1;
        private TextBox txtPhoneNum;
        private TextBox txtNewPatientAddress;
        private Label lblNewPatientAddress;
        private Label lblDoctorName;
        private Label lblDateOfRegister;
        private DateTimePicker dateDateOfRegister;
        private Button btnConfirmPatient;
        private GroupBox boxDoctorDetails;
    }
}