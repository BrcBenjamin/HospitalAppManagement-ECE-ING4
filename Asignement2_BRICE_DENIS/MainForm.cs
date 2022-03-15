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

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            this.Close();
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Management PatientForm = new Patient_Management();
            PatientForm.Show();
        }

        private void appointementManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentManagement AppointmentForm = new AppointmentManagement();
            AppointmentForm.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_All form = new Show_All();
            form.Show();
        }

        private void searchAppointmentByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAppByDate form = new SearchAppByDate();
            form.Show();
        }

        private void showAPatientsAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPatientAppointments form = new ShowPatientAppointments();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}