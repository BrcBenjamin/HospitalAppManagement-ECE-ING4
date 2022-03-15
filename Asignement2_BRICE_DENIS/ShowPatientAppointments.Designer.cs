namespace Asignement2_BRICE_DENIS
{
    partial class ShowPatientAppointments
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
            this.PatientCodeGbox = new System.Windows.Forms.GroupBox();
            this.ButtonCancelPatient = new System.Windows.Forms.Button();
            this.ButtonSearchPatient = new System.Windows.Forms.Button();
            this.TboxPatientCode = new System.Windows.Forms.TextBox();
            this.LabelPatientCode = new System.Windows.Forms.Label();
            this.PatientInfoGbox = new System.Windows.Forms.GroupBox();
            this.MtboxPatientBirth = new System.Windows.Forms.MaskedTextBox();
            this.TboxPatientAddress = new System.Windows.Forms.TextBox();
            this.TboxPatientName = new System.Windows.Forms.TextBox();
            this.LabelPatientAddress = new System.Windows.Forms.Label();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.LabelPatientName = new System.Windows.Forms.Label();
            this.DataGridPatientApp = new System.Windows.Forms.DataGridView();
            this.PatientAppointmentGbox = new System.Windows.Forms.GroupBox();
            this.ButtonAppDelete = new System.Windows.Forms.Button();
            this.ButtonAppSave = new System.Windows.Forms.Button();
            this.TboxAppDate = new System.Windows.Forms.DateTimePicker();
            this.MtboxAppTime = new System.Windows.Forms.MaskedTextBox();
            this.CboxDoctorCode = new System.Windows.Forms.ComboBox();
            this.TboxAppCode = new System.Windows.Forms.TextBox();
            this.LabelDoctorCode = new System.Windows.Forms.Label();
            this.LabelAppTime = new System.Windows.Forms.Label();
            this.LabelAppDate = new System.Windows.Forms.Label();
            this.LabelAppCode = new System.Windows.Forms.Label();
            this.PatientCodeGbox.SuspendLayout();
            this.PatientInfoGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPatientApp)).BeginInit();
            this.PatientAppointmentGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientCodeGbox
            // 
            this.PatientCodeGbox.Controls.Add(this.ButtonCancelPatient);
            this.PatientCodeGbox.Controls.Add(this.ButtonSearchPatient);
            this.PatientCodeGbox.Controls.Add(this.TboxPatientCode);
            this.PatientCodeGbox.Controls.Add(this.LabelPatientCode);
            this.PatientCodeGbox.Location = new System.Drawing.Point(105, 60);
            this.PatientCodeGbox.Name = "PatientCodeGbox";
            this.PatientCodeGbox.Size = new System.Drawing.Size(1496, 200);
            this.PatientCodeGbox.TabIndex = 0;
            this.PatientCodeGbox.TabStop = false;
            this.PatientCodeGbox.Text = "Enter Patient Code";
            // 
            // ButtonCancelPatient
            // 
            this.ButtonCancelPatient.Location = new System.Drawing.Point(1264, 125);
            this.ButtonCancelPatient.Name = "ButtonCancelPatient";
            this.ButtonCancelPatient.Size = new System.Drawing.Size(150, 46);
            this.ButtonCancelPatient.TabIndex = 3;
            this.ButtonCancelPatient.Text = "Cancel";
            this.ButtonCancelPatient.UseVisualStyleBackColor = true;
            this.ButtonCancelPatient.Click += new System.EventHandler(this.ButtonCancelPatient_Click);
            // 
            // ButtonSearchPatient
            // 
            this.ButtonSearchPatient.Location = new System.Drawing.Point(1264, 56);
            this.ButtonSearchPatient.Name = "ButtonSearchPatient";
            this.ButtonSearchPatient.Size = new System.Drawing.Size(150, 46);
            this.ButtonSearchPatient.TabIndex = 2;
            this.ButtonSearchPatient.Text = "Search";
            this.ButtonSearchPatient.UseVisualStyleBackColor = true;
            this.ButtonSearchPatient.Click += new System.EventHandler(this.ButtonSearchPatient_Click);
            // 
            // TboxPatientCode
            // 
            this.TboxPatientCode.Location = new System.Drawing.Point(214, 132);
            this.TboxPatientCode.Name = "TboxPatientCode";
            this.TboxPatientCode.Size = new System.Drawing.Size(280, 39);
            this.TboxPatientCode.TabIndex = 1;
            // 
            // LabelPatientCode
            // 
            this.LabelPatientCode.AutoSize = true;
            this.LabelPatientCode.Location = new System.Drawing.Point(6, 135);
            this.LabelPatientCode.Name = "LabelPatientCode";
            this.LabelPatientCode.Size = new System.Drawing.Size(150, 32);
            this.LabelPatientCode.TabIndex = 0;
            this.LabelPatientCode.Text = "Patient Code";
            // 
            // PatientInfoGbox
            // 
            this.PatientInfoGbox.Controls.Add(this.MtboxPatientBirth);
            this.PatientInfoGbox.Controls.Add(this.TboxPatientAddress);
            this.PatientInfoGbox.Controls.Add(this.TboxPatientName);
            this.PatientInfoGbox.Controls.Add(this.LabelPatientAddress);
            this.PatientInfoGbox.Controls.Add(this.LabelBirthDate);
            this.PatientInfoGbox.Controls.Add(this.LabelPatientName);
            this.PatientInfoGbox.Location = new System.Drawing.Point(117, 328);
            this.PatientInfoGbox.Name = "PatientInfoGbox";
            this.PatientInfoGbox.Size = new System.Drawing.Size(1488, 196);
            this.PatientInfoGbox.TabIndex = 1;
            this.PatientInfoGbox.TabStop = false;
            this.PatientInfoGbox.Text = "Patient Info";
            // 
            // MtboxPatientBirth
            // 
            this.MtboxPatientBirth.Location = new System.Drawing.Point(202, 116);
            this.MtboxPatientBirth.Name = "MtboxPatientBirth";
            this.MtboxPatientBirth.ReadOnly = true;
            this.MtboxPatientBirth.Size = new System.Drawing.Size(280, 39);
            this.MtboxPatientBirth.TabIndex = 5;
            // 
            // TboxPatientAddress
            // 
            this.TboxPatientAddress.Location = new System.Drawing.Point(930, 52);
            this.TboxPatientAddress.Multiline = true;
            this.TboxPatientAddress.Name = "TboxPatientAddress";
            this.TboxPatientAddress.ReadOnly = true;
            this.TboxPatientAddress.Size = new System.Drawing.Size(332, 103);
            this.TboxPatientAddress.TabIndex = 4;
            // 
            // TboxPatientName
            // 
            this.TboxPatientName.Location = new System.Drawing.Point(202, 52);
            this.TboxPatientName.Name = "TboxPatientName";
            this.TboxPatientName.ReadOnly = true;
            this.TboxPatientName.Size = new System.Drawing.Size(280, 39);
            this.TboxPatientName.TabIndex = 3;
            // 
            // LabelPatientAddress
            // 
            this.LabelPatientAddress.AutoSize = true;
            this.LabelPatientAddress.Location = new System.Drawing.Point(804, 52);
            this.LabelPatientAddress.Name = "LabelPatientAddress";
            this.LabelPatientAddress.Size = new System.Drawing.Size(98, 32);
            this.LabelPatientAddress.TabIndex = 2;
            this.LabelPatientAddress.Text = "Address";
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Location = new System.Drawing.Point(36, 123);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(124, 32);
            this.LabelBirthDate.TabIndex = 1;
            this.LabelBirthDate.Text = "Birth_Date";
            // 
            // LabelPatientName
            // 
            this.LabelPatientName.AutoSize = true;
            this.LabelPatientName.Location = new System.Drawing.Point(36, 60);
            this.LabelPatientName.Name = "LabelPatientName";
            this.LabelPatientName.Size = new System.Drawing.Size(78, 32);
            this.LabelPatientName.TabIndex = 0;
            this.LabelPatientName.Text = "Name";
            // 
            // DataGridPatientApp
            // 
            this.DataGridPatientApp.AllowUserToAddRows = false;
            this.DataGridPatientApp.AllowUserToDeleteRows = false;
            this.DataGridPatientApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPatientApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridPatientApp.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridPatientApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPatientApp.Location = new System.Drawing.Point(295, 564);
            this.DataGridPatientApp.Name = "DataGridPatientApp";
            this.DataGridPatientApp.ReadOnly = true;
            this.DataGridPatientApp.RowHeadersWidth = 82;
            this.DataGridPatientApp.RowTemplate.Height = 41;
            this.DataGridPatientApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridPatientApp.ShowEditingIcon = false;
            this.DataGridPatientApp.Size = new System.Drawing.Size(1148, 228);
            this.DataGridPatientApp.TabIndex = 2;
            this.DataGridPatientApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPatientApp_CellClick);
            // 
            // PatientAppointmentGbox
            // 
            this.PatientAppointmentGbox.Controls.Add(this.ButtonAppDelete);
            this.PatientAppointmentGbox.Controls.Add(this.ButtonAppSave);
            this.PatientAppointmentGbox.Controls.Add(this.TboxAppDate);
            this.PatientAppointmentGbox.Controls.Add(this.MtboxAppTime);
            this.PatientAppointmentGbox.Controls.Add(this.CboxDoctorCode);
            this.PatientAppointmentGbox.Controls.Add(this.TboxAppCode);
            this.PatientAppointmentGbox.Controls.Add(this.LabelDoctorCode);
            this.PatientAppointmentGbox.Controls.Add(this.LabelAppTime);
            this.PatientAppointmentGbox.Controls.Add(this.LabelAppDate);
            this.PatientAppointmentGbox.Controls.Add(this.LabelAppCode);
            this.PatientAppointmentGbox.Location = new System.Drawing.Point(119, 836);
            this.PatientAppointmentGbox.Name = "PatientAppointmentGbox";
            this.PatientAppointmentGbox.Size = new System.Drawing.Size(1486, 176);
            this.PatientAppointmentGbox.TabIndex = 3;
            this.PatientAppointmentGbox.TabStop = false;
            this.PatientAppointmentGbox.Text = "Appointment";
            // 
            // ButtonAppDelete
            // 
            this.ButtonAppDelete.Location = new System.Drawing.Point(1286, 115);
            this.ButtonAppDelete.Name = "ButtonAppDelete";
            this.ButtonAppDelete.Size = new System.Drawing.Size(150, 55);
            this.ButtonAppDelete.TabIndex = 9;
            this.ButtonAppDelete.Text = "Delete";
            this.ButtonAppDelete.UseVisualStyleBackColor = true;
            this.ButtonAppDelete.Click += new System.EventHandler(this.ButtonAppDelete_Click);
            // 
            // ButtonAppSave
            // 
            this.ButtonAppSave.Location = new System.Drawing.Point(1286, 53);
            this.ButtonAppSave.Name = "ButtonAppSave";
            this.ButtonAppSave.Size = new System.Drawing.Size(150, 48);
            this.ButtonAppSave.TabIndex = 8;
            this.ButtonAppSave.Text = "Save";
            this.ButtonAppSave.UseVisualStyleBackColor = true;
            this.ButtonAppSave.Click += new System.EventHandler(this.ButtonAppSave_Click);
            // 
            // TboxAppDate
            // 
            this.TboxAppDate.CustomFormat = "dd MMMM yyyy";
            this.TboxAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TboxAppDate.Location = new System.Drawing.Point(228, 122);
            this.TboxAppDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.TboxAppDate.MinDate = new System.DateTime(1969, 12, 31, 0, 0, 0, 0);
            this.TboxAppDate.Name = "TboxAppDate";
            this.TboxAppDate.Size = new System.Drawing.Size(324, 39);
            this.TboxAppDate.TabIndex = 7;
            this.TboxAppDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // MtboxAppTime
            // 
            this.MtboxAppTime.Location = new System.Drawing.Point(864, 53);
            this.MtboxAppTime.Mask = "00:00";
            this.MtboxAppTime.Name = "MtboxAppTime";
            this.MtboxAppTime.Size = new System.Drawing.Size(326, 39);
            this.MtboxAppTime.TabIndex = 6;
            this.MtboxAppTime.ValidatingType = typeof(System.DateTime);
            // 
            // CboxDoctorCode
            // 
            this.CboxDoctorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxDoctorCode.FormattingEnabled = true;
            this.CboxDoctorCode.Location = new System.Drawing.Point(864, 122);
            this.CboxDoctorCode.Name = "CboxDoctorCode";
            this.CboxDoctorCode.Size = new System.Drawing.Size(326, 40);
            this.CboxDoctorCode.Sorted = true;
            this.CboxDoctorCode.TabIndex = 5;
            // 
            // TboxAppCode
            // 
            this.TboxAppCode.Location = new System.Drawing.Point(228, 55);
            this.TboxAppCode.Name = "TboxAppCode";
            this.TboxAppCode.ReadOnly = true;
            this.TboxAppCode.Size = new System.Drawing.Size(324, 39);
            this.TboxAppCode.TabIndex = 4;
            // 
            // LabelDoctorCode
            // 
            this.LabelDoctorCode.AutoSize = true;
            this.LabelDoctorCode.Location = new System.Drawing.Point(620, 131);
            this.LabelDoctorCode.Name = "LabelDoctorCode";
            this.LabelDoctorCode.Size = new System.Drawing.Size(149, 32);
            this.LabelDoctorCode.TabIndex = 3;
            this.LabelDoctorCode.Text = "Doctor Code";
            // 
            // LabelAppTime
            // 
            this.LabelAppTime.AutoSize = true;
            this.LabelAppTime.Location = new System.Drawing.Point(620, 60);
            this.LabelAppTime.Name = "LabelAppTime";
            this.LabelAppTime.Size = new System.Drawing.Size(215, 32);
            this.LabelAppTime.TabIndex = 2;
            this.LabelAppTime.Text = "Appointment Time";
            // 
            // LabelAppDate
            // 
            this.LabelAppDate.AutoSize = true;
            this.LabelAppDate.Location = new System.Drawing.Point(10, 129);
            this.LabelAppDate.Name = "LabelAppDate";
            this.LabelAppDate.Size = new System.Drawing.Size(212, 32);
            this.LabelAppDate.TabIndex = 1;
            this.LabelAppDate.Text = "Appointment Date";
            // 
            // LabelAppCode
            // 
            this.LabelAppCode.AutoSize = true;
            this.LabelAppCode.Location = new System.Drawing.Point(8, 58);
            this.LabelAppCode.Name = "LabelAppCode";
            this.LabelAppCode.Size = new System.Drawing.Size(218, 32);
            this.LabelAppCode.TabIndex = 0;
            this.LabelAppCode.Text = "Appointment Code";
            // 
            // ShowPatientAppointments
            // 
            this.AcceptButton = this.ButtonSearchPatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1049);
            this.Controls.Add(this.PatientAppointmentGbox);
            this.Controls.Add(this.DataGridPatientApp);
            this.Controls.Add(this.PatientInfoGbox);
            this.Controls.Add(this.PatientCodeGbox);
            this.MinimumSize = new System.Drawing.Size(1720, 1120);
            this.Name = "ShowPatientAppointments";
            this.Text = "ShowPatientAppointments";
            this.Load += new System.EventHandler(this.ShowPatientAppointments_Load);
            this.PatientCodeGbox.ResumeLayout(false);
            this.PatientCodeGbox.PerformLayout();
            this.PatientInfoGbox.ResumeLayout(false);
            this.PatientInfoGbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPatientApp)).EndInit();
            this.PatientAppointmentGbox.ResumeLayout(false);
            this.PatientAppointmentGbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PatientCodeGbox;
        private Button ButtonCancelPatient;
        private Button ButtonSearchPatient;
        private TextBox TboxPatientCode;
        private Label LabelPatientCode;
        private GroupBox PatientInfoGbox;
        private MaskedTextBox MtboxPatientBirth;
        private TextBox TboxPatientAddress;
        private TextBox TboxPatientName;
        private Label LabelPatientAddress;
        private Label LabelBirthDate;
        private Label LabelPatientName;
        private DataGridView DataGridPatientApp;
        private GroupBox PatientAppointmentGbox;
        private Button ButtonAppDelete;
        private Button ButtonAppSave;
        private DateTimePicker TboxAppDate;
        private MaskedTextBox MtboxAppTime;
        private ComboBox CboxDoctorCode;
        private TextBox TboxAppCode;
        private Label LabelDoctorCode;
        private Label LabelAppTime;
        private Label LabelAppDate;
        private Label LabelAppCode;
    }
}