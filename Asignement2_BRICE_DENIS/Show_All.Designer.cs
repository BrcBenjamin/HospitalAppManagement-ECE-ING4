namespace Asignement2_BRICE_DENIS
{
    partial class Show_All
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
            this.ShowAllGBox = new System.Windows.Forms.GroupBox();
            this.RadioShowAllApps = new System.Windows.Forms.RadioButton();
            this.RadioShowAllPatients = new System.Windows.Forms.RadioButton();
            this.RadioShowAllDoctors = new System.Windows.Forms.RadioButton();
            this.ShowAllDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowAllGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAllGBox
            // 
            this.ShowAllGBox.Controls.Add(this.RadioShowAllApps);
            this.ShowAllGBox.Controls.Add(this.RadioShowAllPatients);
            this.ShowAllGBox.Controls.Add(this.RadioShowAllDoctors);
            this.ShowAllGBox.Location = new System.Drawing.Point(97, 80);
            this.ShowAllGBox.Name = "ShowAllGBox";
            this.ShowAllGBox.Size = new System.Drawing.Size(1210, 200);
            this.ShowAllGBox.TabIndex = 0;
            this.ShowAllGBox.TabStop = false;
            this.ShowAllGBox.Text = "Choice";
            // 
            // RadioShowAllApps
            // 
            this.RadioShowAllApps.AutoSize = true;
            this.RadioShowAllApps.Location = new System.Drawing.Point(908, 56);
            this.RadioShowAllApps.Name = "RadioShowAllApps";
            this.RadioShowAllApps.Size = new System.Drawing.Size(269, 36);
            this.RadioShowAllApps.TabIndex = 2;
            this.RadioShowAllApps.Text = "All the appointments";
            this.RadioShowAllApps.UseVisualStyleBackColor = true;
            this.RadioShowAllApps.CheckedChanged += new System.EventHandler(this.RadioShowAllApps_CheckedChanged);
            // 
            // RadioShowAllPatients
            // 
            this.RadioShowAllPatients.AutoSize = true;
            this.RadioShowAllPatients.Location = new System.Drawing.Point(490, 56);
            this.RadioShowAllPatients.Name = "RadioShowAllPatients";
            this.RadioShowAllPatients.Size = new System.Drawing.Size(206, 36);
            this.RadioShowAllPatients.TabIndex = 1;
            this.RadioShowAllPatients.Text = "All the patients";
            this.RadioShowAllPatients.UseVisualStyleBackColor = true;
            this.RadioShowAllPatients.CheckedChanged += new System.EventHandler(this.RadioShowAllPatients_CheckedChanged);
            // 
            // RadioShowAllDoctors
            // 
            this.RadioShowAllDoctors.AutoSize = true;
            this.RadioShowAllDoctors.Location = new System.Drawing.Point(16, 56);
            this.RadioShowAllDoctors.Name = "RadioShowAllDoctors";
            this.RadioShowAllDoctors.Size = new System.Drawing.Size(208, 36);
            this.RadioShowAllDoctors.TabIndex = 0;
            this.RadioShowAllDoctors.Text = "All The Doctors";
            this.RadioShowAllDoctors.UseVisualStyleBackColor = true;
            this.RadioShowAllDoctors.CheckedChanged += new System.EventHandler(this.RadioShowAllDoctors_CheckedChanged);
            // 
            // ShowAllDataGridView
            // 
            this.ShowAllDataGridView.AllowUserToAddRows = false;
            this.ShowAllDataGridView.AllowUserToDeleteRows = false;
            this.ShowAllDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowAllDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ShowAllDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ShowAllDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ShowAllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowAllDataGridView.GridColor = System.Drawing.SystemColors.Info;
            this.ShowAllDataGridView.Location = new System.Drawing.Point(97, 328);
            this.ShowAllDataGridView.Name = "ShowAllDataGridView";
            this.ShowAllDataGridView.ReadOnly = true;
            this.ShowAllDataGridView.RowHeadersWidth = 82;
            this.ShowAllDataGridView.RowTemplate.Height = 41;
            this.ShowAllDataGridView.Size = new System.Drawing.Size(1210, 332);
            this.ShowAllDataGridView.TabIndex = 1;
            // 
            // Show_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 780);
            this.Controls.Add(this.ShowAllDataGridView);
            this.Controls.Add(this.ShowAllGBox);
            this.MinimumSize = new System.Drawing.Size(1400, 850);
            this.Name = "Show_All";
            this.Text = "Show_All";
            this.ShowAllGBox.ResumeLayout(false);
            this.ShowAllGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ShowAllGBox;
        private RadioButton RadioShowAllApps;
        private RadioButton RadioShowAllPatients;
        private RadioButton RadioShowAllDoctors;
        private DataGridView ShowAllDataGridView;
    }
}