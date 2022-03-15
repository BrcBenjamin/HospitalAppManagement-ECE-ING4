using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignement2_BRICE_DENIS
{
    public partial class AppointmentManagement : Form
    {
        public AppointmentManagement()
        {
            InitializeComponent();
        }


        /* NATIVE FORM METHODS */

        // Add Appointment
        private void AddAppButton_Click(object sender, EventArgs e)
        {
            if (CheckEmptyValues())
            {
                MessageBox.Show("You must fill the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!ValidateTime()) return;
            AddAppointment();
        }


        //Exit Appointment
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            this.Close();
        }

        //NEW (Clear Appointment)
        private void NewAppButton_Click(object sender, EventArgs e)
        {
            ClearAppointmentValues();
        }

        //Patient Combo box click
        private void AppPatientCodeCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        // Doctor Combo box click
        private void AppDoctorCodecbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        //On Form Load
        private void AppointmentManagementGroupBox_Load(object sender, EventArgs e)
        {
            GetPatientCodes();
            GetDoctorCodes();
        }


        /* SQL - OTHER METHODS */
        private Boolean CheckEmptyValues()
        {
            if (string.IsNullOrWhiteSpace(this.AppPatientCodeCbox.Text) || string.IsNullOrWhiteSpace(this.AppPatientNameTbox.Text) || string.IsNullOrWhiteSpace(this.AppDoctorCodeCbox.Text)
                || string.IsNullOrWhiteSpace(this.AppDoctorNameTbox.Text) || string.IsNullOrWhiteSpace(this.AppDoctorSpecTbox.Text) || !this.AppTimeMtbox.MaskFull
                || (!AppPatientRadioGirl.Checked && !AppPatientRadioBoy.Checked)) return true;
            return false;
        }

        private void GetPatientCodes()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select PatientId from Patient", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            do
            {
                while (reader.Read())
                {
                    this.AppPatientCodeCbox.Items.Add(reader["PatientId"].ToString());
                }
            } while (reader.NextResult());
        }

        private void LoadPatientData()
        {
            int code = Convert.ToInt32(this.AppPatientCodeCbox.Text);
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Patient where PatientId=" + code;
            SqlDataReader reader = search.ExecuteReader();

            reader.Read();

            this.AppPatientNameTbox.Text = Convert.ToString(reader["PatientName"]);

            if (Convert.ToBoolean(reader["PatientGender"]) == true)
            {
                this.AppPatientRadioBoy.Checked = true;
                this.AppPatientRadioGirl.Checked = false;
            }
            else
            {
                this.AppPatientRadioBoy.Checked = false;
                this.AppPatientRadioGirl.Checked = true;
            }

            reader.Close();

        }

        private void GetDoctorCodes()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select DoctorId from Doctors", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            do
            {
                while (reader.Read())
                {
                    this.AppDoctorCodeCbox.Items.Add(reader["DoctorId"].ToString());
                }
            } while (reader.NextResult());

            connection.Close();
            reader.Close();
        }

        private void LoadDoctorData()
        {
            int code = Convert.ToInt32(this.AppDoctorCodeCbox.Text);
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Doctors where DoctorId=" + code;
            SqlDataReader reader = search.ExecuteReader();
            reader.Read();

            this.AppDoctorNameTbox.Text = Convert.ToString(reader["DoctorName"]);
            this.AppDoctorSpecTbox.Text = Convert.ToString(reader["DoctorSpecialism"]);

            reader.Close();

        }

        private void ClearAppointmentValues()
        {
            //patient values
            this.AppPatientCodeCbox.Text = string.Empty;
            this.AppPatientNameTbox.Text = string.Empty;
            this.AppPatientRadioBoy.Checked = false;
            this.AppPatientRadioGirl.Checked = false;
            //Doctor values
            this.AppDoctorCodeCbox.Text = string.Empty;
            this.AppDoctorNameTbox.Text = string.Empty;
            this.AppDoctorSpecTbox.Text = string.Empty;
            // Appointment values
            this.AppDateTbox.Text = string.Empty;
            this.AppTimeMtbox.Text = String.Empty;
        }

        private void AddAppointment()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO Appointments(AppointmentDate, AppointmentTime,DoctorId,PatientId)  VALUES(@param1,@param2,@param3,@param4)";
                insert.Parameters.AddWithValue("@param1", Convert.ToDateTime(this.AppDateTbox.Text));
                insert.Parameters.AddWithValue("@param2", this.AppTimeMtbox.Text);
                insert.Parameters.AddWithValue("@param3", this.AppDoctorCodeCbox.Text);
                insert.Parameters.AddWithValue("@param4", this.AppPatientCodeCbox.Text);
                insert.ExecuteNonQuery();
                MessageBox.Show("Appointment Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't add the appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e);
            }

            connection.Close();
        }

        private Boolean ValidateTime()
        {
            string text = this.AppTimeMtbox.Text;
            string[] parts = text.Split(":");
            int Hours = Convert.ToInt32(parts[0]); 
            int Minutes = Convert.ToInt32(parts[1]);
            
            if(Hours > 24)
            {
                MessageBox.Show("Please enter the appointment hour in 00-24 only", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(Minutes > 60)
            {
                MessageBox.Show("Please enter the appointment minutes in 00-60 only", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
