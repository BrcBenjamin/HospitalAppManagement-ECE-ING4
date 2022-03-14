namespace Asignement2_BRICE_DENIS
{
    partial class AppointmentManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppointmentManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.NewAppButton = new System.Windows.Forms.Button();
            this.AddAppButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AppTimeMtbox = new System.Windows.Forms.MaskedTextBox();
            this.AppDateTbox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AppDoctorCodeCbox = new System.Windows.Forms.ComboBox();
            this.AppDoctorSpecTbox = new System.Windows.Forms.TextBox();
            this.AppDoctorNameTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppPatientRadioBoy = new System.Windows.Forms.RadioButton();
            this.AppPatientRadioGirl = new System.Windows.Forms.RadioButton();
            this.AppPatientNameTbox = new System.Windows.Forms.TextBox();
            this.AppPatientCodeCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentManagementGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentManagementGroupBox
            // 
            this.AppointmentManagementGroupBox.AutoSize = true;
            this.AppointmentManagementGroupBox.Controls.Add(this.ExitAppButton);
            this.AppointmentManagementGroupBox.Controls.Add(this.NewAppButton);
            this.AppointmentManagementGroupBox.Controls.Add(this.AddAppButton);
            this.AppointmentManagementGroupBox.Controls.Add(this.groupBox3);
            this.AppointmentManagementGroupBox.Controls.Add(this.groupBox2);
            this.AppointmentManagementGroupBox.Controls.Add(this.groupBox1);
            this.AppointmentManagementGroupBox.Location = new System.Drawing.Point(55, 50);
            this.AppointmentManagementGroupBox.MinimumSize = new System.Drawing.Size(1470, 830);
            this.AppointmentManagementGroupBox.Name = "AppointmentManagementGroupBox";
            this.AppointmentManagementGroupBox.Size = new System.Drawing.Size(1470, 838);
            this.AppointmentManagementGroupBox.TabIndex = 0;
            this.AppointmentManagementGroupBox.TabStop = false;
            this.AppointmentManagementGroupBox.Text = "Appointment Management";
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.AutoSize = true;
            this.ExitAppButton.Location = new System.Drawing.Point(1060, 678);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(268, 42);
            this.ExitAppButton.TabIndex = 5;
            this.ExitAppButton.Text = "Exit";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // NewAppButton
            // 
            this.NewAppButton.AutoSize = true;
            this.NewAppButton.Location = new System.Drawing.Point(1060, 624);
            this.NewAppButton.Name = "NewAppButton";
            this.NewAppButton.Size = new System.Drawing.Size(268, 42);
            this.NewAppButton.TabIndex = 4;
            this.NewAppButton.Text = "New";
            this.NewAppButton.UseVisualStyleBackColor = true;
            this.NewAppButton.Click += new System.EventHandler(this.NewAppButton_Click);
            // 
            // AddAppButton
            // 
            this.AddAppButton.AutoSize = true;
            this.AddAppButton.Location = new System.Drawing.Point(1060, 562);
            this.AddAppButton.Name = "AddAppButton";
            this.AddAppButton.Size = new System.Drawing.Size(268, 42);
            this.AddAppButton.TabIndex = 3;
            this.AddAppButton.Text = "Add Appointment";
            this.AddAppButton.UseVisualStyleBackColor = true;
            this.AddAppButton.Click += new System.EventHandler(this.AddAppButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AppTimeMtbox);
            this.groupBox3.Controls.Add(this.AppDateTbox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(86, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // AppTimeMtbox
            // 
            this.AppTimeMtbox.Location = new System.Drawing.Point(260, 158);
            this.AppTimeMtbox.Mask = "00:00";
            this.AppTimeMtbox.Name = "AppTimeMtbox";
            this.AppTimeMtbox.Size = new System.Drawing.Size(342, 39);
            this.AppTimeMtbox.TabIndex = 3;
            this.AppTimeMtbox.ValidatingType = typeof(System.DateTime);
            // 
            // AppDateTbox
            // 
            this.AppDateTbox.CustomFormat = "dd MMMM yyyy";
            this.AppDateTbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppDateTbox.Location = new System.Drawing.Point(262, 73);
            this.AppDateTbox.Name = "AppDateTbox";
            this.AppDateTbox.Size = new System.Drawing.Size(340, 39);
            this.AppDateTbox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Appointment Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Appointment Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppDoctorCodeCbox);
            this.groupBox2.Controls.Add(this.AppDoctorSpecTbox);
            this.groupBox2.Controls.Add(this.AppDoctorNameTbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(824, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // AppDoctorCodeCbox
            // 
            this.AppDoctorCodeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppDoctorCodeCbox.FormattingEnabled = true;
            this.AppDoctorCodeCbox.Location = new System.Drawing.Point(248, 81);
            this.AppDoctorCodeCbox.Name = "AppDoctorCodeCbox";
            this.AppDoctorCodeCbox.Size = new System.Drawing.Size(208, 40);
            this.AppDoctorCodeCbox.Sorted = true;
            this.AppDoctorCodeCbox.TabIndex = 5;
            this.AppDoctorCodeCbox.SelectedIndexChanged += new System.EventHandler(this.AppDoctorCodecbox_SelectedIndexChanged);
            // 
            // AppDoctorSpecTbox
            // 
            this.AppDoctorSpecTbox.Location = new System.Drawing.Point(248, 215);
            this.AppDoctorSpecTbox.Name = "AppDoctorSpecTbox";
            this.AppDoctorSpecTbox.Size = new System.Drawing.Size(208, 39);
            this.AppDoctorSpecTbox.TabIndex = 4;
            // 
            // AppDoctorNameTbox
            // 
            this.AppDoctorNameTbox.Location = new System.Drawing.Point(248, 147);
            this.AppDoctorNameTbox.Name = "AppDoctorNameTbox";
            this.AppDoctorNameTbox.Size = new System.Drawing.Size(208, 39);
            this.AppDoctorNameTbox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doctor Speciality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doctor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doctor Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppPatientRadioBoy);
            this.groupBox1.Controls.Add(this.AppPatientRadioGirl);
            this.groupBox1.Controls.Add(this.AppPatientNameTbox);
            this.groupBox1.Controls.Add(this.AppPatientCodeCbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(86, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AppPatientRadioBoy
            // 
            this.AppPatientRadioBoy.AutoSize = true;
            this.AppPatientRadioBoy.Location = new System.Drawing.Point(244, 272);
            this.AppPatientRadioBoy.Name = "AppPatientRadioBoy";
            this.AppPatientRadioBoy.Size = new System.Drawing.Size(67, 36);
            this.AppPatientRadioBoy.TabIndex = 6;
            this.AppPatientRadioBoy.TabStop = true;
            this.AppPatientRadioBoy.Text = "M";
            this.AppPatientRadioBoy.UseVisualStyleBackColor = true;
            // 
            // AppPatientRadioGirl
            // 
            this.AppPatientRadioGirl.AutoSize = true;
            this.AppPatientRadioGirl.Location = new System.Drawing.Point(244, 230);
            this.AppPatientRadioGirl.Name = "AppPatientRadioGirl";
            this.AppPatientRadioGirl.Size = new System.Drawing.Size(57, 36);
            this.AppPatientRadioGirl.TabIndex = 5;
            this.AppPatientRadioGirl.TabStop = true;
            this.AppPatientRadioGirl.Text = "F";
            this.AppPatientRadioGirl.UseVisualStyleBackColor = true;
            // 
            // AppPatientNameTbox
            // 
            this.AppPatientNameTbox.Location = new System.Drawing.Point(244, 164);
            this.AppPatientNameTbox.Name = "AppPatientNameTbox";
            this.AppPatientNameTbox.Size = new System.Drawing.Size(216, 39);
            this.AppPatientNameTbox.TabIndex = 4;
            // 
            // AppPatientCodeCbox
            // 
            this.AppPatientCodeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppPatientCodeCbox.FormattingEnabled = true;
            this.AppPatientCodeCbox.Location = new System.Drawing.Point(244, 80);
            this.AppPatientCodeCbox.Name = "AppPatientCodeCbox";
            this.AppPatientCodeCbox.Size = new System.Drawing.Size(216, 40);
            this.AppPatientCodeCbox.Sorted = true;
            this.AppPatientCodeCbox.TabIndex = 3;
            this.AppPatientCodeCbox.SelectedIndexChanged += new System.EventHandler(this.AppPatientCodeCbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Code";
            // 
            // AppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 979);
            this.Controls.Add(this.AppointmentManagementGroupBox);
            this.MinimumSize = new System.Drawing.Size(1600, 1050);
            this.Name = "AppointmentManagement";
            this.Text = "Appointment_Management";
            this.Load += new System.EventHandler(this.AppointmentManagementGroupBox_Load);
            this.AppointmentManagementGroupBox.ResumeLayout(false);
            this.AppointmentManagementGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox AppointmentManagementGroupBox;
        private Button ExitAppButton;
        private Button NewAppButton;
        private Button AddAppButton;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private MaskedTextBox AppTimeMtbox;
        private DateTimePicker AppDateTbox;
        private Label label8;
        private Label label7;
        private ComboBox AppDoctorCodeCbox;
        private TextBox AppDoctorSpecTbox;
        private TextBox AppDoctorNameTbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton AppPatientRadioBoy;
        private RadioButton AppPatientRadioGirl;
        private TextBox AppPatientNameTbox;
        private ComboBox AppPatientCodeCbox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}