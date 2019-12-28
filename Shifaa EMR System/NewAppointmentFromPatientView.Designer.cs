namespace Shifaa_EMR_System
{
    partial class NewAppointmentFromPatientView
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
            this.components = new System.ComponentModel.Container();
            this.AppointmentDetails = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientTableAdapter();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppointmentDateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewAppointmentLabel = new System.Windows.Forms.Label();
            this.AppointmentDateTimeLabel = new System.Windows.Forms.Label();
            this.DurationTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.DurationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppointmentDetails.BackColor = System.Drawing.SystemColors.Window;
            this.AppointmentDetails.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AppointmentDetails.Location = new System.Drawing.Point(39, 145);
            this.AppointmentDetails.Multiline = true;
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.Size = new System.Drawing.Size(616, 199);
            this.AppointmentDetails.TabIndex = 2;
            this.AppointmentDetails.Text = "Appointment Details";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SaveButton.Location = new System.Drawing.Point(293, 360);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.eMRDatabaseDataSetBindingSource;
            // 
            // eMRDatabaseDataSetBindingSource
            // 
            this.eMRDatabaseDataSetBindingSource.DataSource = this.eMRDatabaseDataSet;
            this.eMRDatabaseDataSetBindingSource.Position = 0;
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // AppointmentDateTimePicker
            // 
            this.AppointmentDateTimePicker.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.AppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentDateTimePicker.Location = new System.Drawing.Point(293, 60);
            this.AppointmentDateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            this.AppointmentDateTimePicker.Size = new System.Drawing.Size(211, 29);
            this.AppointmentDateTimePicker.TabIndex = 28;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(585, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NewAppointmentLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 40);
            this.panel1.TabIndex = 29;
            // 
            // NewAppointmentLabel
            // 
            this.NewAppointmentLabel.AutoSize = true;
            this.NewAppointmentLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewAppointmentLabel.Location = new System.Drawing.Point(12, 11);
            this.NewAppointmentLabel.Name = "NewAppointmentLabel";
            this.NewAppointmentLabel.Size = new System.Drawing.Size(136, 19);
            this.NewAppointmentLabel.TabIndex = 29;
            this.NewAppointmentLabel.Text = "New Appointment";
            this.NewAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AppointmentDateTimeLabel
            // 
            this.AppointmentDateTimeLabel.AutoSize = true;
            this.AppointmentDateTimeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.AppointmentDateTimeLabel.Location = new System.Drawing.Point(61, 65);
            this.AppointmentDateTimeLabel.Name = "AppointmentDateTimeLabel";
            this.AppointmentDateTimeLabel.Size = new System.Drawing.Size(206, 19);
            this.AppointmentDateTimeLabel.TabIndex = 30;
            this.AppointmentDateTimeLabel.Text = "Appointment Date and Time";
            // 
            // DurationTimePicker
            // 
            this.DurationTimePicker.CustomFormat = "HH:mm";
            this.DurationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationTimePicker.Location = new System.Drawing.Point(293, 98);
            this.DurationTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DurationTimePicker.Name = "DurationTimePicker";
            this.DurationTimePicker.Size = new System.Drawing.Size(75, 29);
            this.DurationTimePicker.TabIndex = 31;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.DurationLabel.Location = new System.Drawing.Point(61, 102);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(167, 19);
            this.DurationLabel.TabIndex = 32;
            this.DurationLabel.Text = "Appointment Duration";
            // 
            // NewAppointmentFromPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(688, 432);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.DurationTimePicker);
            this.Controls.Add(this.AppointmentDateTimeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AppointmentDateTimePicker);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AppointmentDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAppointmentFromPatientView";
            this.Text = "New Appointment ";
            this.Load += new System.EventHandler(this.NewAppointmentFromPatientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AppointmentDetails;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource patientBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;

        private System.Windows.Forms.BindingSource patientBindingSource1;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource eMRDatabaseDataSetBindingSource;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private EMRDatabaseDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private MetroFramework.Controls.MetroDateTime AppointmentDateTimePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NewAppointmentLabel;
        private System.Windows.Forms.Label AppointmentDateTimeLabel;
        private MetroFramework.Controls.MetroDateTime DurationTimePicker;
        private System.Windows.Forms.Label DurationLabel;
    }
}