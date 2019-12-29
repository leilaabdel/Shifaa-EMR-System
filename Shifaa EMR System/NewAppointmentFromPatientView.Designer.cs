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
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewAppointmentLabel = new System.Windows.Forms.Label();
            this.AppointmentDateTimeLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.AppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DurationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.AppointmentTableAdapter();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emrDatabaseDataSet1 = new Shifaa_EMR_System.EMRDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emrDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentDetails.BackColor = System.Drawing.SystemColors.Window;
            this.AppointmentDetails.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AppointmentDetails.Location = new System.Drawing.Point(53, 145);
            this.AppointmentDetails.Multiline = true;
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.Size = new System.Drawing.Size(506, 235);
            this.AppointmentDetails.TabIndex = 2;
            this.AppointmentDetails.Text = "Appointment Details";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SaveButton.Location = new System.Drawing.Point(269, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(514, 7);
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
            this.panel1.Size = new System.Drawing.Size(617, 40);
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
            this.AppointmentDateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentDateTimeLabel.AutoSize = true;
            this.AppointmentDateTimeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.AppointmentDateTimeLabel.Location = new System.Drawing.Point(56, 65);
            this.AppointmentDateTimeLabel.Name = "AppointmentDateTimeLabel";
            this.AppointmentDateTimeLabel.Size = new System.Drawing.Size(206, 19);
            this.AppointmentDateTimeLabel.TabIndex = 30;
            this.AppointmentDateTimeLabel.Text = "Appointment Date and Time";
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.DurationLabel.Location = new System.Drawing.Point(56, 102);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(167, 19);
            this.DurationLabel.TabIndex = 32;
            this.DurationLabel.Text = "Appointment Duration";
            // 
            // AppointmentDateTimePicker
            // 
            this.AppointmentDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentDateTimePicker.CustomFormat = " dd/MM/yyyy HH:mm";
            this.AppointmentDateTimePicker.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.AppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentDateTimePicker.Location = new System.Drawing.Point(405, 65);
            this.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            this.AppointmentDateTimePicker.ShowUpDown = true;
            this.AppointmentDateTimePicker.Size = new System.Drawing.Size(154, 25);
            this.AppointmentDateTimePicker.TabIndex = 33;
            this.AppointmentDateTimePicker.ValueChanged += new System.EventHandler(this.AppointmentDateTimePicker_ValueChanged);
            // 
            // DurationTimePicker
            // 
            this.DurationTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationTimePicker.CustomFormat = "HH:mm";
            this.DurationTimePicker.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.DurationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationTimePicker.Location = new System.Drawing.Point(451, 102);
            this.DurationTimePicker.Name = "DurationTimePicker";
            this.DurationTimePicker.ShowUpDown = true;
            this.DurationTimePicker.Size = new System.Drawing.Size(108, 25);
            this.DurationTimePicker.TabIndex = 34;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.emrDatabaseDataSet1;
            // 
            // emrDatabaseDataSet1
            // 
            this.emrDatabaseDataSet1.DataSetName = "EMRDatabaseDataSet";
            this.emrDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewAppointmentFromPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(617, 475);
            this.ControlBox = false;
            this.Controls.Add(this.DurationTimePicker);
            this.Controls.Add(this.AppointmentDateTimePicker);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.AppointmentDateTimeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AppointmentDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewAppointmentFromPatientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment ";
            this.Load += new System.EventHandler(this.NewAppointmentFromPatientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emrDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AppointmentDetails;
        private System.Windows.Forms.Button SaveButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NewAppointmentLabel;
        private System.Windows.Forms.Label AppointmentDateTimeLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.DateTimePicker AppointmentDateTimePicker;
        private System.Windows.Forms.DateTimePicker DurationTimePicker;
        private EMRDatabaseDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private EMRDatabaseDataSet emrDatabaseDataSet1;
    }
}