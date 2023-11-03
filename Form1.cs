namespace WinFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
                cmbDoctor.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtReason.Text) ||
                cmbTime.SelectedIndex == -1)
            {

                MessageBox.Show("Please complete the form", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Booking Submitted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtPatientName.Clear();
                cmbDoctor.SelectedIndex = -1;
                dtpDate.Value = DateTime.Now; 
                cmbTime.SelectedIndex = -1;
                txtReason.Clear();
            }
        }

    }
}