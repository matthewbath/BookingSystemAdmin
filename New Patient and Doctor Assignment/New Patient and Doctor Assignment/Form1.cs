using System.Net;

namespace New_Patient_and_Doctor_Assignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDoB_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNewPatientAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblDoctorName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPatientAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateDoB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDateOfRegister_Click(object sender, EventArgs e)
        {

        }
        List<Patient> patients = new List<Patient>();

        public class Patient
        {
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string PhoneNum { get; set; }
            public string Address { get; set; }
            public string DoctorAssigned { get; set; }
            public DateTime DateOfRegister { get; set; }
        }


        private void btnConfirmPatient_Click(object sender, EventArgs e)
        {
            ComboBox comboDoctorAssigned = boxDoctorDetails.Controls["comboDoctorAssigned"] as ComboBox;
            DateTimePicker dateDateofRegister = boxDoctorDetails.Controls["dateDateofRegister"] as DateTimePicker;

            Patient newPatient = new Patient
            {
                Name = txtName.Text,
                DateOfBirth = dateDoB.Value,
                PhoneNum = txtPhoneNum.Text,
                Address = txtNewPatientAddress.Text,
                DoctorAssigned = comboDoctorAssigned.SelectedItem.ToString(),
                DateOfRegister = dateDateofRegister.Value
            };

            patients.Add(newPatient);
            txtName.Text = "";
        }
    }
}