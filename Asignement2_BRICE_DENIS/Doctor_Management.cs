using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignement2_BRICE_DENIS
{
    internal class Doctor_Management:Form
    {
        public Doctor_Management()
        {
            InitializeComponent();
        }



        //check if textbox values are not filled
        private Boolean CheckEmptyValues()
        {
            if (string.IsNullOrWhiteSpace(this.DoctorCodeTbox.Text) || string.IsNullOrWhiteSpace(this.DoctorNameTbox.Text)  || string.IsNullOrWhiteSpace(this.DoctorPhoneTbox.Text) 
              || string.IsNullOrWhiteSpace(this.DoctorSpecialityCbox.Text) ) return true;
            return false;
        }


        //NEW
        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearDoctorValues();
        }

        //SEARCH
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.DoctorCodeTbox.Text))
            {
                MessageBox.Show("Enter the id of the Doctor you want to search in the code textbox", "Search Doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Get code
            int code = Convert.ToInt32(this.DoctorCodeTbox.Text);
            // Search in DB
            SqlConnection con = new SqlConnection(Program.strConnexion);
            con.Open();
            SearchDoctor(con, code);
            con.Close();

        }

        //ADD
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckEmptyValues())
            {
                MessageBox.Show("You must fill the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            AddDoctor();
            ClearDoctorValues();
        }

        //EDIT
        private void DoctorEditButton_Click(object sender, EventArgs e)
        {
            if (CheckEmptyValues())
            {
                MessageBox.Show("You must first load a doctors information before editing it, try using the search button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to Edit this doctor's information?", "Edit Doctor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            EditDoctor();
        }

        //DELETE
        private void DoctorDeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.DoctorCodeTbox.Text))
            {
                MessageBox.Show("Enter the id of the doctor you want to delete in the Code textbox", "Delete Doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this doctor", "Delete Doctor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel) return;
            DeleteDoctor();
            ClearDoctorValues();
        }

        //EXIT
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            this.Close();
        }

        private void AddDoctor()
        {
            int code = Convert.ToInt32(this.DoctorCodeTbox.Text);

            // Search in DB
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from Doctors where DoctorId=" + code, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (this.DoctorPhoneTbox.Text.Length != 10) { 
                MessageBox.Show("Phone number must be 10 numbers long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }

            if (reader.Read() == true)
            {
                MessageBox.Show("Doctor Code error: already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close();
                return;
            }
            reader.Close();
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO Doctors(DoctorId, DoctorName, DoctorTel,HiringDate,DoctorSpecialism)  VALUES(@param1,@param2,@param3,@param4,@param5)";
                insert.Parameters.AddWithValue("@param1", this.DoctorCodeTbox.Text);
                insert.Parameters.AddWithValue("@param2", this.DoctorNameTbox.Text);
                insert.Parameters.AddWithValue("@param3", this.DoctorPhoneTbox.Text);
                insert.Parameters.AddWithValue("@param4", Convert.ToDateTime(this.DoctorDate.Text));
                insert.Parameters.AddWithValue("@param5", this.DoctorSpecialityCbox.Text);
                insert.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                MessageBox.Show("Error adding doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(this.DoctorPhoneTbox.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

        }


        private void SearchDoctor(SqlConnection connection, int code)
        {
            SqlCommand search = new SqlCommand();
            search.Connection = connection;
            search.CommandText = "Select * from Doctors where DoctorId=" + code;
            SqlDataReader reader = search.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Doctor Doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };


            this.DoctorNameTbox.Text = Convert.ToString(reader["DoctorName"]);
            this.DoctorPhoneTbox.Text = Convert.ToString(reader["DoctorTel"]);
            this.DoctorDate.Text = Convert.ToString(reader["HiringDate"]);
            this.DoctorSpecialityCbox.Text = Convert.ToString(reader["DoctorSpecialism"]);
 
            reader.Close();
        }


        private void EditDoctor()
        {
            int code = Convert.ToInt32(this.DoctorCodeTbox.Text);

            // Search in DB
            SqlConnection connection = new SqlConnection(Program.strConnexion);
            connection.Open();

            
            try
            {
                SqlCommand edit = new SqlCommand();
                edit.Connection = connection;
                edit.CommandText = "UPDATE Doctors Set DoctorName = @param1, DoctorTel = @param2, HiringDate = @param3, DoctorSpecialism = @param4 WHERE DoctorId=" + code;
                edit.Parameters.AddWithValue("@param1", this.DoctorNameTbox.Text);
                edit.Parameters.AddWithValue("@param2", this.DoctorPhoneTbox.Text);
                edit.Parameters.AddWithValue("@param3", Convert.ToDateTime(this.DoctorDate.Text));
                edit.Parameters.AddWithValue("@param4", this.DoctorSpecialityCbox.Text);
                edit.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Edited!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e);
            }

            connection.Close();

        }

        private void DeleteDoctor()
        {

            int code = Convert.ToInt32(this.DoctorCodeTbox.Text);

            SqlConnection con = new SqlConnection(Program.strConnexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctors where DoctorId=" + code, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Doctor Doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            reader.Close();

            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = con;
                delete.CommandText = "Delete from Doctors where DoctorId=" + code;
                delete.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Deleting the doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e);
            }

            con.Close();

        }

        private void ClearDoctorValues()
        {
            this.DoctorCodeTbox.Text = string.Empty;
            this.DoctorNameTbox.Text = string.Empty;
            this.DoctorPhoneTbox.Text = string.Empty;
            this.DoctorSpecialityCbox.Text = string.Empty;
            this.DoctorDate.Text = string.Empty;
        }



        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoctorPhoneTbox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorExitButton = new System.Windows.Forms.Button();
            this.DoctorDeleteButton = new System.Windows.Forms.Button();
            this.DoctorEditButton = new System.Windows.Forms.Button();
            this.DoctorAddButton = new System.Windows.Forms.Button();
            this.DoctorSearchButton = new System.Windows.Forms.Button();
            this.DoctorNewButton = new System.Windows.Forms.Button();
            this.DoctorDate = new System.Windows.Forms.DateTimePicker();
            this.DoctorSpecialityCbox = new System.Windows.Forms.ComboBox();
            this.DoctorNameTbox = new System.Windows.Forms.TextBox();
            this.DoctorCodeTbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoctorPhoneTbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DoctorExitButton);
            this.groupBox1.Controls.Add(this.DoctorDeleteButton);
            this.groupBox1.Controls.Add(this.DoctorEditButton);
            this.groupBox1.Controls.Add(this.DoctorAddButton);
            this.groupBox1.Controls.Add(this.DoctorSearchButton);
            this.groupBox1.Controls.Add(this.DoctorNewButton);
            this.groupBox1.Controls.Add(this.DoctorDate);
            this.groupBox1.Controls.Add(this.DoctorSpecialityCbox);
            this.groupBox1.Controls.Add(this.DoctorNameTbox);
            this.groupBox1.Controls.Add(this.DoctorCodeTbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1000, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Management";
            // 
            // DoctorPhoneTbox
            // 
            this.DoctorPhoneTbox.Location = new System.Drawing.Point(231, 226);
            this.DoctorPhoneTbox.Mask = "0000000000";
            this.DoctorPhoneTbox.Name = "DoctorPhoneTbox";
            this.DoctorPhoneTbox.Size = new System.Drawing.Size(378, 39);
            this.DoctorPhoneTbox.TabIndex = 16;
            this.DoctorPhoneTbox.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Specialty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hiring Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telephone";
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
            // DoctorExitButton
            // 
            this.DoctorExitButton.AutoSize = true;
            this.DoctorExitButton.Location = new System.Drawing.Point(667, 347);
            this.DoctorExitButton.Name = "DoctorExitButton";
            this.DoctorExitButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorExitButton.TabIndex = 10;
            this.DoctorExitButton.Text = "Exit";
            this.DoctorExitButton.UseVisualStyleBackColor = true;
            this.DoctorExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DoctorDeleteButton
            // 
            this.DoctorDeleteButton.AutoSize = true;
            this.DoctorDeleteButton.Location = new System.Drawing.Point(667, 299);
            this.DoctorDeleteButton.Name = "DoctorDeleteButton";
            this.DoctorDeleteButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorDeleteButton.TabIndex = 9;
            this.DoctorDeleteButton.Text = "Delete";
            this.DoctorDeleteButton.UseVisualStyleBackColor = true;
            this.DoctorDeleteButton.Click += new System.EventHandler(this.DoctorDeleteButton_Click);
            // 
            // DoctorEditButton
            // 
            this.DoctorEditButton.AutoSize = true;
            this.DoctorEditButton.Location = new System.Drawing.Point(667, 251);
            this.DoctorEditButton.Name = "DoctorEditButton";
            this.DoctorEditButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorEditButton.TabIndex = 8;
            this.DoctorEditButton.Text = "Edit";
            this.DoctorEditButton.UseVisualStyleBackColor = true;
            this.DoctorEditButton.Click += new System.EventHandler(this.DoctorEditButton_Click);
            // 
            // DoctorAddButton
            // 
            this.DoctorAddButton.AutoSize = true;
            this.DoctorAddButton.Location = new System.Drawing.Point(667, 158);
            this.DoctorAddButton.Name = "DoctorAddButton";
            this.DoctorAddButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorAddButton.TabIndex = 7;
            this.DoctorAddButton.Text = "Add";
            this.DoctorAddButton.UseVisualStyleBackColor = true;
            this.DoctorAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DoctorSearchButton
            // 
            this.DoctorSearchButton.AutoSize = true;
            this.DoctorSearchButton.Location = new System.Drawing.Point(667, 203);
            this.DoctorSearchButton.Name = "DoctorSearchButton";
            this.DoctorSearchButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorSearchButton.TabIndex = 6;
            this.DoctorSearchButton.Text = "Search";
            this.DoctorSearchButton.UseVisualStyleBackColor = true;
            this.DoctorSearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DoctorNewButton
            // 
            this.DoctorNewButton.AutoSize = true;
            this.DoctorNewButton.Location = new System.Drawing.Point(667, 110);
            this.DoctorNewButton.Name = "DoctorNewButton";
            this.DoctorNewButton.Size = new System.Drawing.Size(297, 42);
            this.DoctorNewButton.TabIndex = 5;
            this.DoctorNewButton.Text = "New";
            this.DoctorNewButton.UseVisualStyleBackColor = true;
            this.DoctorNewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DoctorDate
            // 
            this.DoctorDate.CustomFormat = "\"MM\'/\'dd\'/\'yyyy\"";
            this.DoctorDate.Location = new System.Drawing.Point(231, 287);
            this.DoctorDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.DoctorDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DoctorDate.Name = "DoctorDate";
            this.DoctorDate.Size = new System.Drawing.Size(377, 39);
            this.DoctorDate.TabIndex = 4;
            this.DoctorDate.Value = new System.DateTime(2000, 9, 20, 0, 0, 0, 0);
            // 
            // DoctorSpecialityCbox
            // 
            this.DoctorSpecialityCbox.FormattingEnabled = true;
            this.DoctorSpecialityCbox.Items.AddRange(new object[] {
            "",
            "Allergists",
            "Dermatologists",
            "Infectious disease Doctors",
            "Ophthalmologists",
            "Obstetrician/gynecologists",
            "Cardiologists",
            "Endocrinologists",
            "Gastroenterologists",
            "General Doctor"});
            this.DoctorSpecialityCbox.Location = new System.Drawing.Point(231, 360);
            this.DoctorSpecialityCbox.Name = "DoctorSpecialityCbox";
            this.DoctorSpecialityCbox.Size = new System.Drawing.Size(377, 40);
            this.DoctorSpecialityCbox.TabIndex = 3;
            // 
            // DoctorNameTbox
            // 
            this.DoctorNameTbox.Location = new System.Drawing.Point(231, 155);
            this.DoctorNameTbox.Name = "DoctorNameTbox";
            this.DoctorNameTbox.Size = new System.Drawing.Size(377, 39);
            this.DoctorNameTbox.TabIndex = 1;
            // 
            // DoctorCodeTbox
            // 
            this.DoctorCodeTbox.Location = new System.Drawing.Point(231, 91);
            this.DoctorCodeTbox.Name = "DoctorCodeTbox";
            this.DoctorCodeTbox.Size = new System.Drawing.Size(377, 39);
            this.DoctorCodeTbox.TabIndex = 0;
            // 
            // Doctor_Management
            // 
            this.ClientSize = new System.Drawing.Size(1077, 535);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Doctor_Management";
            this.Text = "Doctor_Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Declarations
        private Label label1;
        private Button DoctorExitButton;
        private Button DoctorDeleteButton;
        private Button DoctorEditButton;
        private Button DoctorAddButton;
        private Button DoctorSearchButton;
        private Button DoctorNewButton;
        private DateTimePicker DoctorDate;
        private ComboBox DoctorSpecialityCbox;
        private TextBox DoctorNameTbox;
        private TextBox DoctorCodeTbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox DoctorPhoneTbox;
        private GroupBox groupBox1;


    }
}
