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
    public partial class Show_All : Form
    {

        public Show_All()
        {
            InitializeComponent();
        }

        // get all doctors
        private void RadioShowAllDoctors_CheckedChanged(object sender, EventArgs e)
        {
            GetDoctors();
        }

        // get all patients
        private void RadioShowAllPatients_CheckedChanged(object sender, EventArgs e)
        {
            GetPatients();
        }

        // get all appointments
        private void RadioShowAllApps_CheckedChanged(object sender, EventArgs e)
        {
            GetAppointments();
        }

        private void GetAppointments()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctors", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            ShowAllDataGridView.DataSource = dt;

            reader.Close();
            connection.Close();

        }

        private void GetDoctors()
        {
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Appointments", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            ShowAllDataGridView.DataSource = dt;

            reader.Close();
            connection.Close();

        }

        private void GetPatients()
        {

            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

  /*          foreach(DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["PatientGender"]) == false)
                {
                    row["PatientGender"] = "Male";
                }else
                {
                    row["PatientGender"] = "Female";
                }
            }*/

            ShowAllDataGridView.DataSource = dt;

            reader.Close();
            connection.Close();
        }
    }
}
