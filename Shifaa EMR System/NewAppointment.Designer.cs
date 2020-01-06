namespace Shifaa_EMR_System
{
    partial class NewAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.AppointmentDetails = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PatientIDNum = new System.Windows.Forms.TextBox();
            this.PatientListView = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientTableAdapter();
            this.Exit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.Label();
            this.ChooseProviderLabel = new System.Windows.Forms.Label();
            this.ProviderForPatientList = new System.Windows.Forms.ComboBox();
            this.patientProviderRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientProviderRelationTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientProviderRelationTableAdapter();
            this.columnNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PatientListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientProviderRelationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDescriptionLabel
            // 
            this.AppointmentDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppointmentDescriptionLabel.AutoSize = true;
            this.AppointmentDescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDescriptionLabel.Location = new System.Drawing.Point(261, 17);
            this.AppointmentDescriptionLabel.Name = "AppointmentDescriptionLabel";
            this.AppointmentDescriptionLabel.Size = new System.Drawing.Size(177, 25);
            this.AppointmentDescriptionLabel.TabIndex = 1;
            this.AppointmentDescriptionLabel.Text = "New Appointment";
            this.AppointmentDescriptionLabel.Click += new System.EventHandler(this.AppointmentDescriptionLabel_Click);
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentDetails.BackColor = System.Drawing.SystemColors.Window;
            this.AppointmentDetails.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AppointmentDetails.Location = new System.Drawing.Point(53, 188);
            this.AppointmentDetails.Multiline = true;
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AppointmentDetails.Size = new System.Drawing.Size(572, 118);
            this.AppointmentDetails.TabIndex = 2;
            this.AppointmentDetails.Text = "Appointment Details";
            this.AppointmentDetails.Click += new System.EventHandler(this.AppointmentDetailsClick);
            this.AppointmentDetails.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(301, 521);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 43);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FirstName.BackColor = System.Drawing.SystemColors.Window;
            this.FirstName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.FirstName.Location = new System.Drawing.Point(55, 64);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 24);
            this.FirstName.TabIndex = 17;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.FirstNameClick);
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LastName.BackColor = System.Drawing.SystemColors.Window;
            this.LastName.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.LastName.Location = new System.Drawing.Point(257, 64);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(212, 24);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.LastNameClick);
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // PatientIDNum
            // 
            this.PatientIDNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientIDNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PatientIDNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PatientIDNum.BackColor = System.Drawing.SystemColors.Window;
            this.PatientIDNum.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.PatientIDNum.Location = new System.Drawing.Point(473, 64);
            this.PatientIDNum.Name = "PatientIDNum";
            this.PatientIDNum.Size = new System.Drawing.Size(152, 24);
            this.PatientIDNum.TabIndex = 22;
            this.PatientIDNum.Text = "Patient ID #";
            this.PatientIDNum.Click += new System.EventHandler(this.PatientIDNum_Click);
            this.PatientIDNum.TextChanged += new System.EventHandler(this.PatientIDNum_TextChanged);
            // 
            // PatientListView
            // 
            this.PatientListView.AllowUserToAddRows = false;
            this.PatientListView.AllowUserToDeleteRows = false;
            this.PatientListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientListView.AutoGenerateColumns = false;
            this.PatientListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientListView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumberDataGridViewTextBoxColumn,
            this.PatientID,
            this.FirstName1,
            this.LastName1,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.genderDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn});
            this.PatientListView.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientListView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientListView.Location = new System.Drawing.Point(53, 96);
            this.PatientListView.Name = "PatientListView";
            this.PatientListView.ReadOnly = true;
            this.PatientListView.RowHeadersVisible = false;
            this.PatientListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PatientListView.Size = new System.Drawing.Size(572, 86);
            this.PatientListView.TabIndex = 23;
            this.PatientListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientListView_CellContentClick);
            this.PatientListView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.PatientListView_RowStateChanged);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.eMRDatabaseDataSet;
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
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.Exit.Location = new System.Drawing.Point(578, 17);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 35);
            this.Exit.TabIndex = 51;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy - HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy - HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(315, 463);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.AutoSize = true;
            this.StartTimePicker.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.StartTimePicker.Location = new System.Drawing.Point(195, 400);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(50, 17);
            this.StartTimePicker.TabIndex = 54;
            this.StartTimePicker.Text = "Starts:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.AutoSize = true;
            this.EndDatePicker.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.EndDatePicker.Location = new System.Drawing.Point(195, 465);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(42, 17);
            this.EndDatePicker.TabIndex = 55;
            this.EndDatePicker.Text = "Ends:";
            // 
            // ChooseProviderLabel
            // 
            this.ChooseProviderLabel.AutoSize = true;
            this.ChooseProviderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChooseProviderLabel.Location = new System.Drawing.Point(118, 336);
            this.ChooseProviderLabel.Name = "ChooseProviderLabel";
            this.ChooseProviderLabel.Size = new System.Drawing.Size(154, 17);
            this.ChooseProviderLabel.TabIndex = 56;
            this.ChooseProviderLabel.Text = "Choose the Provider(s)";
            // 
            // ProviderForPatientList
            // 
            this.ProviderForPatientList.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ProviderForPatientList.FormattingEnabled = true;
            this.ProviderForPatientList.Location = new System.Drawing.Point(315, 336);
            this.ProviderForPatientList.Name = "ProviderForPatientList";
            this.ProviderForPatientList.Size = new System.Drawing.Size(220, 24);
            this.ProviderForPatientList.TabIndex = 57;
            this.ProviderForPatientList.SelectedIndexChanged += new System.EventHandler(this.ProviderForPatientList_SelectedIndexChanged);
            // 
            // patientProviderRelationBindingSource
            // 
            this.patientProviderRelationBindingSource.DataMember = "PatientProviderRelation";
            this.patientProviderRelationBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // patientProviderRelationTableAdapter
            // 
            this.patientProviderRelationTableAdapter.ClearBeforeFill = true;
            // 
            // columnNumberDataGridViewTextBoxColumn
            // 
            this.columnNumberDataGridViewTextBoxColumn.DataPropertyName = "ColumnNumber";
            this.columnNumberDataGridViewTextBoxColumn.HeaderText = "ColumnNumber";
            this.columnNumberDataGridViewTextBoxColumn.Name = "columnNumberDataGridViewTextBoxColumn";
            this.columnNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // FirstName1
            // 
            this.FirstName1.DataPropertyName = "FirstName";
            this.FirstName1.HeaderText = "First Name";
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.ReadOnly = true;
            // 
            // LastName1
            // 
            this.LastName1.DataPropertyName = "LastName";
            this.LastName1.HeaderText = "Last Name";
            this.LastName1.Name = "LastName1";
            this.LastName1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn8.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn9.HeaderText = "Age";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Visible = false;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Visible = false;
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            this.bMIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bMIDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalityDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Visible = false;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.maritalStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(679, 612);
            this.ControlBox = false;
            this.Controls.Add(this.ProviderForPatientList);
            this.Controls.Add(this.ChooseProviderLabel);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PatientListView);
            this.Controls.Add(this.PatientIDNum);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AppointmentDetails);
            this.Controls.Add(this.AppointmentDescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewAppointment";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment ";
            this.Deactivate += new System.EventHandler(this.LostFormFocus);
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientProviderRelationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentDescriptionLabel;
        private System.Windows.Forms.TextBox AppointmentDetails;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PatientIDNum;
        private System.Windows.Forms.DataGridView PatientListView;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private EMRDatabaseDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pregancyStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label StartTimePicker;
        private System.Windows.Forms.Label EndDatePicker;
        private System.Windows.Forms.Label ChooseProviderLabel;
        private System.Windows.Forms.ComboBox ProviderForPatientList;
        private System.Windows.Forms.BindingSource patientProviderRelationBindingSource;
        private EMRDatabaseDataSetTableAdapters.PatientProviderRelationTableAdapter patientProviderRelationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
    }
}