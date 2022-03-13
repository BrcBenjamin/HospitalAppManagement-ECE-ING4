﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignement2_BRICE_DENIS
{
    internal class Doctor_Management:Form
    {
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;

        public Doctor_Management()
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
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.comboBox1.Text = string.Empty;
            this.dateTimePicker1.Text = string.Empty;

        }

        //SEARCH
        private void button2_Click(object sender, EventArgs e)
        {
            //Get code
            int code= Convert.ToInt32(this.textBox1.Text);
            // Search in DB
            SqlConnection con = new SqlConnection(Program.strConnexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctors where DoctorId="+code,con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Load in box
            this.textBox2.Text = Convert.ToString(reader["DoctorName"]);
            this.textBox3.Text = Convert.ToString(reader["DoctorTel"]);
            this.dateTimePicker1.Text = Convert.ToString(reader["HiringDate"]);
            this.comboBox1.Text= Convert.ToString(reader["DoctorSpecialism"]);
            con.Close();
            
        }

        //ADD
        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.textBox1.Text) == false && string.IsNullOrWhiteSpace(this.textBox2.Text) == false && string.IsNullOrWhiteSpace(this.textBox3.Text) == false
                && string.IsNullOrWhiteSpace(this.dateTimePicker1.Text) == false && string.IsNullOrWhiteSpace(this.comboBox1.Text) == false){
                int code = Convert.ToInt32(this.textBox1.Text);
                // Search in DB
                SqlConnection con = new SqlConnection(Program.strConnexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Doctors where DoctorId=" + code, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    ShowMessageBox("Patient Code error: already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    AddDoctor(con);
                    ShowMessageBox("Doctor Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.Close();
                }
                
            }

        }

        private void AddDoctor(SqlConnection connection)
        {
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandText = "INSERT INTO Doctors(DoctorId, DoctorName, DoctorTel,HiringDate,DoctorSpecialism)  VALUES(@param1,@param2,@param3,@param4,@param5)";
            insert.Parameters.AddWithValue("@param1", this.textBox1.Text);
            insert.Parameters.AddWithValue("@param2", this.textBox2.Text);
            insert.Parameters.AddWithValue("@param3", this.textBox3.Text);
            insert.Parameters.AddWithValue("@param4", Convert.ToDateTime(this.dateTimePicker1.Text));
            insert.Parameters.AddWithValue("@param5", this.comboBox1.Text);
            insert.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1000, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Management";
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
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(667, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(297, 42);
            this.button6.TabIndex = 10;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(667, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(297, 42);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(667, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(297, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(667, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(667, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(667, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "\"MM\'/\'dd\'/\'yyyy\"";
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 287);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(377, 39);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2000, 9, 20, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(231, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 40);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(377, 39);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(377, 39);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 39);
            this.textBox1.TabIndex = 0;
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
    }
}
