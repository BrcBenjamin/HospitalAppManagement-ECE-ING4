using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignement2_BRICE_DENIS
{
    internal class Patient_Management:Form
    {
        private Label label1;
        private Button PatientExitButton;
        private Button PatientDeleteButton;
        private Button PatientEditButton;
        private Button PatientAddButton;
        private Button PatientSearchButton;
        private Button PatientNewButton;
        private DateTimePicker PatientDatePicker;
        private TextBox PatientNameTbox;
        private TextBox PatientCodeTbox;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox PatientAddressTbox;
        private RadioButton PatientRadioBoy;
        private RadioButton PatientRadioGirl;
        private Label GenderLabel;
        private GroupBox groupBox1;

        public Patient_Management()
        {
            InitializeComponent();
        }

        private void ShowMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }

        //NEW
        private void button1_Click(object sender, EventArgs e)
        {
            this.PatientCodeTbox.Text = string.Empty;
            this.PatientNameTbox.Text = string.Empty;
            this.PatientAddressTbox.Text = string.Empty;            
            this.PatientDatePicker.Text = string.Empty;
            this.PatientRadioBoy.Checked = false;
            this.PatientRadioGirl.Checked = true;

        }

        //SEARCH
        private void button2_Click(object sender, EventArgs e)
        {
            //Get code
            int code= Convert.ToInt32(this.PatientCodeTbox.Text);
            // Search in DB
            SqlConnection con = new SqlConnection(Program.strConnexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctors where DoctorId="+code,con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Load in box
            this.PatientNameTbox.Text = Convert.ToString(reader["DoctorName"]);
            this.PatientAddressTbox.Text = Convert.ToString(reader["DoctorTel"]);
            this.PatientDatePicker.Text = Convert.ToString(reader["HiringDate"]);
            con.Close();
            
        }

        //ADD
        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.PatientCodeTbox.Text) == false && string.IsNullOrWhiteSpace(this.PatientNameTbox.Text) == false && string.IsNullOrWhiteSpace(this.PatientAddressTbox.Text) == false
                && string.IsNullOrWhiteSpace(this.PatientDatePicker.Text) == false ){

                int code = Convert.ToInt32(this.PatientCodeTbox.Text);

                // Search in DB
                SqlConnection con = new SqlConnection(Program.strConnexion);
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Patient where PatientId=" + code, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true) { 
                    ShowMessageBox("Patient Code error: already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                }
                else { 
                    reader.Close();
                    AddPatient(con);
                    ShowMessageBox("Patient Successfully added!","Success",MessageBoxButtons.OK,MessageBoxIcon.None);
                    con.Close();
                }
                
            }

        }

        private Boolean CheckGender()
        {
            if (this.PatientRadioBoy.Checked == true) {
                return true;
            }
            return false;
        }

        private void AddPatient(SqlConnection connection)
        {
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandText = "INSERT INTO Patient(PatientId, PatientName, PatientAddress,BirthDate,PatientGender)  VALUES(@param1,@param2,@param3,@param4,@param5)";
            insert.Parameters.AddWithValue("@param1", this.PatientCodeTbox.Text);
            insert.Parameters.AddWithValue("@param2", this.PatientNameTbox.Text);
            insert.Parameters.AddWithValue("@param3", this.PatientAddressTbox.Text);
            insert.Parameters.AddWithValue("@param4", Convert.ToDateTime(this.PatientDatePicker.Text));
            insert.Parameters.AddWithValue("@param5", this.CheckGender());
            insert.ExecuteNonQuery();
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioBoy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PatientCodeTbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientRadioBoy = new System.Windows.Forms.RadioButton();
            this.PatientRadioGirl = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.PatientAddressTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientExitButton = new System.Windows.Forms.Button();
            this.PatientDeleteButton = new System.Windows.Forms.Button();
            this.PatientEditButton = new System.Windows.Forms.Button();
            this.PatientAddButton = new System.Windows.Forms.Button();
            this.PatientSearchButton = new System.Windows.Forms.Button();
            this.PatientNewButton = new System.Windows.Forms.Button();
            this.PatientDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PatientNameTbox = new System.Windows.Forms.TextBox();
            this.PatientCodeTbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.PatientRadioBoy);
            this.groupBox1.Controls.Add(this.PatientRadioGirl);
            this.groupBox1.Controls.Add(this.GenderLabel);
            this.groupBox1.Controls.Add(this.PatientAddressTbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PatientExitButton);
            this.groupBox1.Controls.Add(this.PatientDeleteButton);
            this.groupBox1.Controls.Add(this.PatientEditButton);
            this.groupBox1.Controls.Add(this.PatientAddButton);
            this.groupBox1.Controls.Add(this.PatientSearchButton);
            this.groupBox1.Controls.Add(this.PatientNewButton);
            this.groupBox1.Controls.Add(this.PatientDatePicker);
            this.groupBox1.Controls.Add(this.PatientNameTbox);
            this.groupBox1.Controls.Add(this.PatientCodeTbox);
            this.groupBox1.Location = new System.Drawing.Point(208, 108);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1000, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 626);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Management";
            // 
            // PatientRadioBoy
            // 
            this.PatientRadioBoy.AutoSize = true;
            this.PatientRadioBoy.Location = new System.Drawing.Point(231, 516);
            this.PatientRadioBoy.Name = "PatientRadioBoy";
            this.PatientRadioBoy.Size = new System.Drawing.Size(153, 36);
            this.PatientRadioBoy.TabIndex = 20;
            this.PatientRadioBoy.Text = "Masculine";
            this.PatientRadioBoy.UseVisualStyleBackColor = true;
            this.PatientRadioBoy.CheckedChanged += new System.EventHandler(this.RadioBoy_CheckedChanged);
            // 
            // PatientRadioGirl
            // 
            this.PatientRadioGirl.AutoSize = true;
            this.PatientRadioGirl.Checked = true;
            this.PatientRadioGirl.Location = new System.Drawing.Point(231, 458);
            this.PatientRadioGirl.Name = "PatientRadioGirl";
            this.PatientRadioGirl.Size = new System.Drawing.Size(144, 36);
            this.PatientRadioGirl.TabIndex = 19;
            this.PatientRadioGirl.TabStop = true;
            this.PatientRadioGirl.Text = "Feminine";
            this.PatientRadioGirl.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(89, 458);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(92, 32);
            this.GenderLabel.TabIndex = 17;
            this.GenderLabel.Text = "Gender";
            // 
            // PatientAddressTbox
            // 
            this.PatientAddressTbox.Location = new System.Drawing.Point(231, 310);
            this.PatientAddressTbox.Multiline = true;
            this.PatientAddressTbox.Name = "PatientAddressTbox";
            this.PatientAddressTbox.Size = new System.Drawing.Size(352, 103);
            this.PatientAddressTbox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Birth Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code";
            // 
            // PatientExitButton
            // 
            this.PatientExitButton.AutoSize = true;
            this.PatientExitButton.Location = new System.Drawing.Point(667, 347);
            this.PatientExitButton.Name = "PatientExitButton";
            this.PatientExitButton.Size = new System.Drawing.Size(297, 42);
            this.PatientExitButton.TabIndex = 10;
            this.PatientExitButton.Text = "Exit";
            this.PatientExitButton.UseVisualStyleBackColor = true;
            this.PatientExitButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // PatientDeleteButton
            // 
            this.PatientDeleteButton.AutoSize = true;
            this.PatientDeleteButton.Location = new System.Drawing.Point(667, 299);
            this.PatientDeleteButton.Name = "PatientDeleteButton";
            this.PatientDeleteButton.Size = new System.Drawing.Size(297, 42);
            this.PatientDeleteButton.TabIndex = 9;
            this.PatientDeleteButton.Text = "Delete";
            this.PatientDeleteButton.UseVisualStyleBackColor = true;
            // 
            // PatientEditButton
            // 
            this.PatientEditButton.AutoSize = true;
            this.PatientEditButton.Location = new System.Drawing.Point(667, 251);
            this.PatientEditButton.Name = "PatientEditButton";
            this.PatientEditButton.Size = new System.Drawing.Size(297, 42);
            this.PatientEditButton.TabIndex = 8;
            this.PatientEditButton.Text = "Edit";
            this.PatientEditButton.UseVisualStyleBackColor = true;
            // 
            // PatientAddButton
            // 
            this.PatientAddButton.AutoSize = true;
            this.PatientAddButton.Location = new System.Drawing.Point(667, 203);
            this.PatientAddButton.Name = "PatientAddButton";
            this.PatientAddButton.Size = new System.Drawing.Size(297, 42);
            this.PatientAddButton.TabIndex = 7;
            this.PatientAddButton.Text = "Add";
            this.PatientAddButton.UseVisualStyleBackColor = true;
            this.PatientAddButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientSearchButton
            // 
            this.PatientSearchButton.AutoSize = true;
            this.PatientSearchButton.Location = new System.Drawing.Point(667, 162);
            this.PatientSearchButton.Name = "PatientSearchButton";
            this.PatientSearchButton.Size = new System.Drawing.Size(297, 42);
            this.PatientSearchButton.TabIndex = 6;
            this.PatientSearchButton.Text = "Search";
            this.PatientSearchButton.UseVisualStyleBackColor = true;
            this.PatientSearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PatientNewButton
            // 
            this.PatientNewButton.AutoSize = true;
            this.PatientNewButton.Location = new System.Drawing.Point(667, 110);
            this.PatientNewButton.Name = "PatientNewButton";
            this.PatientNewButton.Size = new System.Drawing.Size(297, 42);
            this.PatientNewButton.TabIndex = 5;
            this.PatientNewButton.Text = "New";
            this.PatientNewButton.UseVisualStyleBackColor = true;
            this.PatientNewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientDatePicker
            // 
            this.PatientDatePicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy\"";
            this.PatientDatePicker.Location = new System.Drawing.Point(231, 231);
            this.PatientDatePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.PatientDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PatientDatePicker.Name = "PatientDatePicker";
            this.PatientDatePicker.Size = new System.Drawing.Size(377, 39);
            this.PatientDatePicker.TabIndex = 4;
            this.PatientDatePicker.Value = new System.DateTime(2000, 9, 20, 0, 0, 0, 0);
            // 
            // PatientNameTbox
            // 
            this.PatientNameTbox.Location = new System.Drawing.Point(231, 155);
            this.PatientNameTbox.Name = "PatientNameTbox";
            this.PatientNameTbox.Size = new System.Drawing.Size(377, 39);
            this.PatientNameTbox.TabIndex = 1;
            // 
            // PatientCodeTbox
            // 
            this.PatientCodeTbox.Location = new System.Drawing.Point(231, 91);
            this.PatientCodeTbox.Name = "PatientCodeTbox";
            this.PatientCodeTbox.Size = new System.Drawing.Size(377, 39);
            this.PatientCodeTbox.TabIndex = 0;
            this.PatientCodeTbox.TextChanged += new System.EventHandler(this.PatientCodeTbox_TextChanged);
            // 
            // Patient_Management
            // 
            this.ClientSize = new System.Drawing.Size(1371, 767);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Patient_Management";
            this.Text = "Patient_Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
