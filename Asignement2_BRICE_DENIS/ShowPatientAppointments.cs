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
    public partial class ShowPatientAppointments : Form
    {
        public ShowPatientAppointments()
        {
            InitializeComponent();
        }

        // global Data to be passed to the doctor management form
        public static string doctorCode = "";
        public static string doctorName ="";
        public static string doctorTel = "";
        public static string doctorHiringDate = "";
        public static string doctorSpeciality = "";

        /* NATIVE FORM METHODS */


        // On Form Load
        private void ShowPatientAppointments_Load(object sender, EventArgs e)
        {
            GetHeaderColumns();
            this.TboxAppDate.MinDate = DateTime.Today;
        }

        //Search up a patient with their code
        private void ButtonSearchPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TboxPatientCode.Text))
            {
                MessageBox.Show("Enter the id of the patient you want to search in the code textbox", "Search Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(this.TboxPatientCode.Text,out int value))
            {
                MessageBox.Show("Patient Code must be a number", "Search Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GetPatientInformation();
        }

        // Clear all form Values
        private void ButtonCancelPatient_Click(object sender, EventArgs e)
        {
            EmptyAllValues();
        }


        // On Cell Click in DataGridView
        private void DataGridPatientApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDoctorInformation(e);
            GetAppointmentInformation(e);

        }

        // Edit Appointment
        private void ButtonAppSave_Click(object sender, EventArgs e)
        {
            if (CheckEmptyValues())
            {
                MessageBox.Show("Make sure you fill in every information before you edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to Edit this appointments's information?", "Edit Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            EditAppointment();
        }

        // Delete Appointment
        private void ButtonAppDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Delete this appointment?", "Delete Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            DeleteAppointment();

        }



        /* SQL - OTHER METHODS */

        private Boolean CheckEmptyValues()
        {
            if (string.IsNullOrWhiteSpace(this.TboxAppCode.Text) || string.IsNullOrWhiteSpace(this.CboxDoctorCode.Text)|| !this.MtboxAppTime.MaskFull) return true;
            return false;
        }

        private void EmptyAllValues()
        {
            //Patient Values
            this.TboxPatientAddress.Text = String.Empty;
            this.TboxPatientCode.Text = String.Empty;
            this.TboxPatientName.Text = String.Empty;
            this.MtboxPatientBirth.Text = String.Empty;
            //App values
            this.TboxAppCode.Clear();
            this.TboxAppDate.Text = String.Empty;
            this.MtboxAppTime.Text = String.Empty;
            //Doctors Values
            this.CboxDoctorCode.Text = String.Empty;

            DataTable dt = new DataTable();
            this.DataGridPatientApp.DataSource = dt;
        }

        // Get Patient Information from his code
        private void GetPatientInformation()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            int code = Convert.ToInt32(this.TboxPatientCode.Text);

            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Patient where PatientId=" + code;
            SqlDataReader reader = search.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Patient Doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };


            this.TboxPatientName.Text = Convert.ToString(reader["PatientName"]);
            this.TboxPatientAddress.Text = Convert.ToString(reader["PatientAddress"]);
            this.MtboxPatientBirth.Text = Convert.ToString(reader["BirthDate"]);

            reader.Close();
            GetPatientAppointments(connection,code);

            connection.Close();

        }

        //Display the patient appointments in the data grid
        private void GetPatientAppointments(SqlConnection connection,int code)
        {
            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Appointments where PatientId=" + code;
            SqlDataReader reader = search.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("No Appointments at this date", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            DataTable dt = new DataTable();
            dt.Load(reader);
            this.DataGridPatientApp.DataSource = dt;

            DataGridViewColumn AppointmentDate = this.DataGridPatientApp.Columns[1];
            ListSortDirection direction = ListSortDirection.Descending;
             //Sort Appointment dates by descending order
            this.DataGridPatientApp.Sort(AppointmentDate, direction);

            reader.Close();

        }


        private void GetHeaderColumns()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select TOP 0 * from Appointments", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            this.DataGridPatientApp.DataSource = dt;
        }

        private void GetDoctorInformation(DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1 || e.ColumnIndex != 3) return;

   
            DataGridViewRow dgRow = this.DataGridPatientApp.Rows[e.RowIndex];
            int doctorId = Convert.ToInt32(dgRow.Cells[3].Value.ToString());

            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Doctors where DoctorId=" + doctorId;
            SqlDataReader reader = search.ExecuteReader();
            reader.Read();

            doctorCode = doctorId.ToString();
            doctorName = reader["DoctorName"].ToString();
            doctorTel = reader["DoctorTel"].ToString();
            doctorHiringDate = reader["HiringDate"].ToString();
            doctorSpeciality = reader["DoctorSpecialism"].ToString();
      
            Doctor_Management doctorForm = new Doctor_Management();
            doctorForm.Show();

            reader.Close();
            connection.Close();
        }

        private void GetAppointmentInformation(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 2) return;
            DataGridViewRow dgRow = this.DataGridPatientApp.Rows[e.RowIndex];
            int appointmentId = Convert.ToInt32(dgRow.Cells[0].Value.ToString());
            int doctorId = Convert.ToInt32(dgRow.Cells[3].Value.ToString());
            string appointmentDate = dgRow.Cells[1].Value.ToString();
            string appointmentTime = dgRow.Cells[2].Value.ToString();

            GetDoctorCodes();

            this.TboxAppCode.Text = appointmentId.ToString();
            this.TboxAppDate.Text = appointmentDate;
            this.MtboxAppTime.Text = appointmentTime;
            this.CboxDoctorCode.Text = doctorId.ToString();
            
        }

        private void GetDoctorCodes()
        {
            //Clear all the doctors codes everytime we click on a cell so they dont stack up
            this.CboxDoctorCode.Items.Clear();

            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select DoctorId from Doctors", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            do
            {
                while (reader.Read())
                {
                    this.CboxDoctorCode.Items.Add(reader["DoctorId"].ToString());
                }
            } while (reader.NextResult());

            connection.Close();
            reader.Close();
        }


        private Boolean ValidateTime()
        {
            string text = this.MtboxAppTime.Text;
            string[] parts = text.Split(":");
            int Hours = Convert.ToInt32(parts[0]);
            int Minutes = Convert.ToInt32(parts[1]);

            if (Hours > 24)
            {
                MessageBox.Show("Please enter the appointment hour in 00-24 only", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Minutes > 60)
            {
                MessageBox.Show("Please enter the appointment minutes in 00-60 only", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void EditAppointment()
        {
            if (!ValidateTime()) return; 
            int appointmentCode = Convert.ToInt32(this.TboxAppCode.Text);
            int patientCode = Convert.ToInt32(this.TboxPatientCode.Text);

            // Search in DB
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            try
            {
                SqlCommand edit = new SqlCommand();
                edit.Connection = connection;
                edit.CommandText = "UPDATE Appointments Set AppointmentDate = @param1, AppointmentTime = @param2, DoctorId = @param3 WHERE AppointmentCode=" + appointmentCode;
                edit.Parameters.AddWithValue("@param3", this.CboxDoctorCode.Text);
                edit.Parameters.AddWithValue("@param2", this.MtboxAppTime.Text);
                edit.Parameters.AddWithValue("@param1", Convert.ToDateTime(this.TboxAppDate.Text));
               
                edit.ExecuteNonQuery();
                MessageBox.Show("Appointment Successfully edited", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                GetPatientAppointments(connection, patientCode);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

        }

        private void DeleteAppointment()
        {
            int appointmentCode = Convert.ToInt32(this.TboxAppCode.Text);
            int patientCode = Convert.ToInt32(this.TboxPatientCode.Text);
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandText = "Delete from Appointments where AppointmentCode=" + appointmentCode;
                delete.ExecuteNonQuery();
                MessageBox.Show("Appointment Successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                GetPatientAppointments(connection, patientCode);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }


    }
}
