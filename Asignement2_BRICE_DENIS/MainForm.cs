namespace Asignement2_BRICE_DENIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Doctor_Management DoctorForm = new Doctor_Management();
          DoctorForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("Code error: already used", "Error", button, icon);
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}