using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignement2_BRICE_DENIS
{
    public partial class SearchAppByDate : Form
    {
        public SearchAppByDate()
        {
            InitializeComponent();
        }

        /* NATIVE FORM FUNCTIONS */

        //On Form Load display columns
        private void SearchAppByDate_Load(object sender, EventArgs e)
        {
            getHeaderColumns();
        }

        // Seach By Date
        private void SearchAppOkButton_Click(object sender, EventArgs e)
        {
            GetAppointmentByDate();
        }

        //Exit Form
        private void SearchAppCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            this.Close();
        }

        //When Double Click on cell content
        private void SearchAppDateGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getDoctorValues(e);
                getPatientValues(e);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* SQL - OTHER  METHODS */

        private void GetAppointmentByDate()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Appointments where AppointmentDate=@date", connection);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(this.SearchAppDatePicker.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("No Appointments at this date", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            try
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                this.SearchAppDateGrid.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            reader.Close();
            connection.Close();
        }


        // Get doctor values from his selected row id
        private void getDoctorValues(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow dgRow = this.SearchAppDateGrid.Rows[e.RowIndex];
            int doctorId = Convert.ToInt32(dgRow.Cells[3].Value.ToString());

            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Doctors where DoctorId=" + doctorId;
            SqlDataReader reader = search.ExecuteReader();
            reader.Read();

            this.TboxDoctorName.Text = reader["DoctorName"].ToString();
            this.TboxDoctorSpec.Text = reader["DoctorSpecialism"].ToString();

            reader.Close();
            connection.Close();
        }

        //get patient values from his selected row id
        private void getPatientValues(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dgRow = this.SearchAppDateGrid.Rows[e.RowIndex];
            int patientId = Convert.ToInt32(dgRow.Cells[4].Value.ToString());
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Patient where PatientId=" + patientId;
            SqlDataReader reader = search.ExecuteReader();
            reader.Read();

            this.TboxPatientName.Text = reader["PatientName"].ToString();

            string formattedBirthDate = String.Format("{0:MMddyyyy}", reader["BirthDate"]);
            this.TboxPatientBirth.Text = formattedBirthDate;

            reader.Close();
            connection.Close();
        }

        // gets the appointment attribute names
        private void getHeaderColumns()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select TOP 0 * from Appointments", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            this.SearchAppDateGrid.DataSource = dt;
        }


    }
}
