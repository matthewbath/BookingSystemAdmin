using System.Numerics;
using System.Xml.Linq;

namespace wip
{
    public partial class Form1 : Form
    {
        public static List<Doctor> RegisteredDoctors = new List<Doctor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDoctorName.Text) || string.IsNullOrWhiteSpace(textBoxDoctorNumber.Text) || string.IsNullOrWhiteSpace(textBoxDoctorAddress.Text))
            {
                MessageBox.Show("Please fill all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Doctor newDoctor = new Doctor
            {
                Name = textBoxDoctorName.Text,
                ContactNumber = textBoxDoctorNumber.Text,
                Address = textBoxDoctorAddress.Text
            };

            RegisteredDoctors.Add(newDoctor);

            MessageBox.Show("Doctor registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxDoctorName.Clear();
            textBoxDoctorNumber.Clear();
            textBoxDoctorAddress.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}