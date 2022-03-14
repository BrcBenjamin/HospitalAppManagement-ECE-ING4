using System.Data.SqlClient;

namespace Asignement2_BRICE_DENIS
{
    partial class MainForm
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointementManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAPatientsAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementSystemToolStripMenuItem,
            this.consulationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1486, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorManagementToolStripMenuItem,
            this.patientManagementToolStripMenuItem,
            this.appointementManagementToolStripMenuItem});
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.doctorManagementToolStripMenuItem.Text = "Doctor Management";
            this.doctorManagementToolStripMenuItem.Click += new System.EventHandler(this.doctorManagementToolStripMenuItem_Click);
            // 
            // patientManagementToolStripMenuItem
            // 
            this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
            this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.patientManagementToolStripMenuItem.Text = "Patient Management";
            this.patientManagementToolStripMenuItem.Click += new System.EventHandler(this.patientManagementToolStripMenuItem_Click);
            // 
            // appointementManagementToolStripMenuItem
            // 
            this.appointementManagementToolStripMenuItem.Name = "appointementManagementToolStripMenuItem";
            this.appointementManagementToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.appointementManagementToolStripMenuItem.Text = "Appointement Management";
            this.appointementManagementToolStripMenuItem.Click += new System.EventHandler(this.appointementManagementToolStripMenuItem_Click);
            // 
            // consulationToolStripMenuItem
            // 
            this.consulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.searchAppointmentByDateToolStripMenuItem,
            this.showAPatientsAppointmentsToolStripMenuItem});
            this.consulationToolStripMenuItem.Name = "consulationToolStripMenuItem";
            this.consulationToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.consulationToolStripMenuItem.Text = "Consultation";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(477, 44);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // searchAppointmentByDateToolStripMenuItem
            // 
            this.searchAppointmentByDateToolStripMenuItem.Name = "searchAppointmentByDateToolStripMenuItem";
            this.searchAppointmentByDateToolStripMenuItem.Size = new System.Drawing.Size(477, 44);
            this.searchAppointmentByDateToolStripMenuItem.Text = "Search appointment by date";
            this.searchAppointmentByDateToolStripMenuItem.Click += new System.EventHandler(this.searchAppointmentByDateToolStripMenuItem_Click);
            // 
            // showAPatientsAppointmentsToolStripMenuItem
            // 
            this.showAPatientsAppointmentsToolStripMenuItem.Name = "showAPatientsAppointmentsToolStripMenuItem";
            this.showAPatientsAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(477, 44);
            this.showAPatientsAppointmentsToolStripMenuItem.Text = "Show a patient\'s appointments";
            this.showAPatientsAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.showAPatientsAppointmentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementSystemToolStripMenuItem;
        private ToolStripMenuItem doctorManagementToolStripMenuItem;
        private ToolStripMenuItem patientManagementToolStripMenuItem;
        private ToolStripMenuItem appointementManagementToolStripMenuItem;
        private ToolStripMenuItem consulationToolStripMenuItem;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private ToolStripMenuItem searchAppointmentByDateToolStripMenuItem;
        private ToolStripMenuItem showAPatientsAppointmentsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}