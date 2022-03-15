namespace Asignement2_BRICE_DENIS
{
    partial class SearchAppByDate
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
            this.SearchAppDateGbox = new System.Windows.Forms.GroupBox();
            this.SearchAppCancelButton = new System.Windows.Forms.Button();
            this.SearchAppOkButton = new System.Windows.Forms.Button();
            this.SearchAppDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchAppDateGrid = new System.Windows.Forms.DataGridView();
            this.DoctorInfoGbox = new System.Windows.Forms.GroupBox();
            this.LabelDocSpec = new System.Windows.Forms.Label();
            this.LabelDocName = new System.Windows.Forms.Label();
            this.TboxDoctorSpec = new System.Windows.Forms.TextBox();
            this.TboxDoctorName = new System.Windows.Forms.TextBox();
            this.PatientInfoGbox = new System.Windows.Forms.GroupBox();
            this.LabelPatientBirthDate = new System.Windows.Forms.Label();
            this.LabelPatientName = new System.Windows.Forms.Label();
            this.TboxPatientBirth = new System.Windows.Forms.MaskedTextBox();
            this.TboxPatientName = new System.Windows.Forms.TextBox();
            this.SearchAppDateGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAppDateGrid)).BeginInit();
            this.DoctorInfoGbox.SuspendLayout();
            this.PatientInfoGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchAppDateGbox
            // 
            this.SearchAppDateGbox.Controls.Add(this.SearchAppCancelButton);
            this.SearchAppDateGbox.Controls.Add(this.SearchAppOkButton);
            this.SearchAppDateGbox.Controls.Add(this.SearchAppDatePicker);
            this.SearchAppDateGbox.Location = new System.Drawing.Point(81, 80);
            this.SearchAppDateGbox.Name = "SearchAppDateGbox";
            this.SearchAppDateGbox.Size = new System.Drawing.Size(1450, 194);
            this.SearchAppDateGbox.TabIndex = 0;
            this.SearchAppDateGbox.TabStop = false;
            this.SearchAppDateGbox.Text = "Choose the date";
            // 
            // SearchAppCancelButton
            // 
            this.SearchAppCancelButton.Location = new System.Drawing.Point(1112, 118);
            this.SearchAppCancelButton.Name = "SearchAppCancelButton";
            this.SearchAppCancelButton.Size = new System.Drawing.Size(202, 42);
            this.SearchAppCancelButton.TabIndex = 2;
            this.SearchAppCancelButton.Text = "Cancel";
            this.SearchAppCancelButton.UseVisualStyleBackColor = true;
            this.SearchAppCancelButton.Click += new System.EventHandler(this.SearchAppCancelButton_Click);
            // 
            // SearchAppOkButton
            // 
            this.SearchAppOkButton.Location = new System.Drawing.Point(1112, 38);
            this.SearchAppOkButton.Name = "SearchAppOkButton";
            this.SearchAppOkButton.Size = new System.Drawing.Size(202, 48);
            this.SearchAppOkButton.TabIndex = 1;
            this.SearchAppOkButton.Text = "Ok";
            this.SearchAppOkButton.UseVisualStyleBackColor = true;
            this.SearchAppOkButton.Click += new System.EventHandler(this.SearchAppOkButton_Click);
            // 
            // SearchAppDatePicker
            // 
            this.SearchAppDatePicker.Location = new System.Drawing.Point(86, 88);
            this.SearchAppDatePicker.Name = "SearchAppDatePicker";
            this.SearchAppDatePicker.Size = new System.Drawing.Size(374, 39);
            this.SearchAppDatePicker.TabIndex = 0;
            // 
            // SearchAppDateGrid
            // 
            this.SearchAppDateGrid.AllowUserToAddRows = false;
            this.SearchAppDateGrid.AllowUserToDeleteRows = false;
            this.SearchAppDateGrid.AllowUserToOrderColumns = true;
            this.SearchAppDateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchAppDateGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SearchAppDateGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchAppDateGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchAppDateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchAppDateGrid.Location = new System.Drawing.Point(81, 322);
            this.SearchAppDateGrid.Name = "SearchAppDateGrid";
            this.SearchAppDateGrid.ReadOnly = true;
            this.SearchAppDateGrid.RowHeadersWidth = 82;
            this.SearchAppDateGrid.RowTemplate.Height = 41;
            this.SearchAppDateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchAppDateGrid.ShowEditingIcon = false;
            this.SearchAppDateGrid.Size = new System.Drawing.Size(1450, 260);
            this.SearchAppDateGrid.TabIndex = 1;
            this.SearchAppDateGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchAppDateGrid_CellDoubleClick);
            this.SearchAppDateGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchAppDateGrid_CellDoubleClick);
            // 
            // DoctorInfoGbox
            // 
            this.DoctorInfoGbox.Controls.Add(this.LabelDocSpec);
            this.DoctorInfoGbox.Controls.Add(this.LabelDocName);
            this.DoctorInfoGbox.Controls.Add(this.TboxDoctorSpec);
            this.DoctorInfoGbox.Controls.Add(this.TboxDoctorName);
            this.DoctorInfoGbox.Location = new System.Drawing.Point(99, 622);
            this.DoctorInfoGbox.Name = "DoctorInfoGbox";
            this.DoctorInfoGbox.Size = new System.Drawing.Size(442, 252);
            this.DoctorInfoGbox.TabIndex = 2;
            this.DoctorInfoGbox.TabStop = false;
            this.DoctorInfoGbox.Text = "Doctor";
            // 
            // LabelDocSpec
            // 
            this.LabelDocSpec.AutoSize = true;
            this.LabelDocSpec.Location = new System.Drawing.Point(6, 156);
            this.LabelDocSpec.Name = "LabelDocSpec";
            this.LabelDocSpec.Size = new System.Drawing.Size(115, 32);
            this.LabelDocSpec.TabIndex = 3;
            this.LabelDocSpec.Text = "Speciality";
            // 
            // LabelDocName
            // 
            this.LabelDocName.AutoSize = true;
            this.LabelDocName.Location = new System.Drawing.Point(6, 88);
            this.LabelDocName.Name = "LabelDocName";
            this.LabelDocName.Size = new System.Drawing.Size(78, 32);
            this.LabelDocName.TabIndex = 2;
            this.LabelDocName.Text = "Name";
            // 
            // TboxDoctorSpec
            // 
            this.TboxDoctorSpec.Location = new System.Drawing.Point(166, 156);
            this.TboxDoctorSpec.Name = "TboxDoctorSpec";
            this.TboxDoctorSpec.ReadOnly = true;
            this.TboxDoctorSpec.Size = new System.Drawing.Size(188, 39);
            this.TboxDoctorSpec.TabIndex = 1;
            // 
            // TboxDoctorName
            // 
            this.TboxDoctorName.Location = new System.Drawing.Point(166, 88);
            this.TboxDoctorName.Name = "TboxDoctorName";
            this.TboxDoctorName.ReadOnly = true;
            this.TboxDoctorName.Size = new System.Drawing.Size(188, 39);
            this.TboxDoctorName.TabIndex = 0;
            // 
            // PatientInfoGbox
            // 
            this.PatientInfoGbox.Controls.Add(this.LabelPatientBirthDate);
            this.PatientInfoGbox.Controls.Add(this.LabelPatientName);
            this.PatientInfoGbox.Controls.Add(this.TboxPatientBirth);
            this.PatientInfoGbox.Controls.Add(this.TboxPatientName);
            this.PatientInfoGbox.Location = new System.Drawing.Point(1071, 622);
            this.PatientInfoGbox.Name = "PatientInfoGbox";
            this.PatientInfoGbox.Size = new System.Drawing.Size(460, 252);
            this.PatientInfoGbox.TabIndex = 3;
            this.PatientInfoGbox.TabStop = false;
            this.PatientInfoGbox.Text = "Patient";
            // 
            // LabelPatientBirthDate
            // 
            this.LabelPatientBirthDate.AutoSize = true;
            this.LabelPatientBirthDate.Location = new System.Drawing.Point(30, 163);
            this.LabelPatientBirthDate.Name = "LabelPatientBirthDate";
            this.LabelPatientBirthDate.Size = new System.Drawing.Size(114, 32);
            this.LabelPatientBirthDate.TabIndex = 3;
            this.LabelPatientBirthDate.Text = "BirthDate";
            // 
            // LabelPatientName
            // 
            this.LabelPatientName.AutoSize = true;
            this.LabelPatientName.Location = new System.Drawing.Point(30, 100);
            this.LabelPatientName.Name = "LabelPatientName";
            this.LabelPatientName.Size = new System.Drawing.Size(78, 32);
            this.LabelPatientName.TabIndex = 2;
            this.LabelPatientName.Text = "Name";
            // 
            // TboxPatientBirth
            // 
            this.TboxPatientBirth.Location = new System.Drawing.Point(194, 163);
            this.TboxPatientBirth.Mask = "00/00/0000";
            this.TboxPatientBirth.Name = "TboxPatientBirth";
            this.TboxPatientBirth.ReadOnly = true;
            this.TboxPatientBirth.Size = new System.Drawing.Size(200, 39);
            this.TboxPatientBirth.TabIndex = 1;
            this.TboxPatientBirth.ValidatingType = typeof(System.DateTime);
            // 
            // TboxPatientName
            // 
            this.TboxPatientName.Location = new System.Drawing.Point(194, 97);
            this.TboxPatientName.Name = "TboxPatientName";
            this.TboxPatientName.ReadOnly = true;
            this.TboxPatientName.Size = new System.Drawing.Size(200, 39);
            this.TboxPatientName.TabIndex = 0;
            // 
            // SearchAppByDate
            // 
            this.AcceptButton = this.SearchAppOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SearchAppCancelButton;
            this.ClientSize = new System.Drawing.Size(1612, 966);
            this.Controls.Add(this.PatientInfoGbox);
            this.Controls.Add(this.DoctorInfoGbox);
            this.Controls.Add(this.SearchAppDateGrid);
            this.Controls.Add(this.SearchAppDateGbox);
            this.MinimumSize = new System.Drawing.Size(1630, 1030);
            this.Name = "SearchAppByDate";
            this.Text = "Search_Appointment";
            this.Load += new System.EventHandler(this.SearchAppByDate_Load);
            this.SearchAppDateGbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchAppDateGrid)).EndInit();
            this.DoctorInfoGbox.ResumeLayout(false);
            this.DoctorInfoGbox.PerformLayout();
            this.PatientInfoGbox.ResumeLayout(false);
            this.PatientInfoGbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SearchAppDateGbox;
        private Button SearchAppCancelButton;
        private Button SearchAppOkButton;
        private DateTimePicker SearchAppDatePicker;
        private DataGridView SearchAppDateGrid;
        private GroupBox DoctorInfoGbox;
        private Label LabelDocSpec;
        private Label LabelDocName;
        private TextBox TboxDoctorSpec;
        private TextBox TboxDoctorName;
        private GroupBox PatientInfoGbox;
        private Label LabelPatientBirthDate;
        private Label LabelPatientName;
        private MaskedTextBox TboxPatientBirth;
        private TextBox TboxPatientName;
    }
}