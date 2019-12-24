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
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hourBox1 = new System.Windows.Forms.ComboBox();
            this.minuteBox1 = new System.Windows.Forms.ComboBox();
            this.hourBox2 = new System.Windows.Forms.ComboBox();
            this.minuteBox2 = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.PatientIDNum = new System.Windows.Forms.TextBox();
            this.PatientListView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.DateSelectionLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.patientTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PatientListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDescriptionLabel
            // 
            this.AppointmentDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppointmentDescriptionLabel.AutoSize = true;
            this.AppointmentDescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDescriptionLabel.Location = new System.Drawing.Point(252, 19);
            this.AppointmentDescriptionLabel.Name = "AppointmentDescriptionLabel";
            this.AppointmentDescriptionLabel.Size = new System.Drawing.Size(177, 25);
            this.AppointmentDescriptionLabel.TabIndex = 1;
            this.AppointmentDescriptionLabel.Text = "New Appointment";
            this.AppointmentDescriptionLabel.Click += new System.EventHandler(this.AppointmentDescriptionLabel_Click);
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppointmentDetails.BackColor = System.Drawing.SystemColors.Window;
            this.AppointmentDetails.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDetails.Location = new System.Drawing.Point(30, 402);
            this.AppointmentDetails.Multiline = true;
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.Size = new System.Drawing.Size(616, 190);
            this.AppointmentDetails.TabIndex = 2;
            this.AppointmentDetails.Text = "Appointment Details";
            this.AppointmentDetails.Click += new System.EventHandler(this.AppointmentDetailsClick);
            this.AppointmentDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(285, 820);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 43);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(580, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 43);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 746);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hourBox1
            // 
            this.hourBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hourBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourBox1.FormattingEnabled = true;
            this.hourBox1.Location = new System.Drawing.Point(215, 704);
            this.hourBox1.Name = "hourBox1";
            this.hourBox1.Size = new System.Drawing.Size(98, 27);
            this.hourBox1.TabIndex = 13;
            this.hourBox1.Text = "Hour";
            this.hourBox1.SelectedIndexChanged += new System.EventHandler(this.hourBox1_SelectedIndexChanged);
            this.hourBox1.TextChanged += new System.EventHandler(this.hourBox1_SelectedIndexChanged);
            this.hourBox1.Click += new System.EventHandler(this.hourBox1_Click);
            // 
            // minuteBox1
            // 
            this.minuteBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minuteBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.minuteBox1.FormattingEnabled = true;
            this.minuteBox1.Location = new System.Drawing.Point(331, 704);
            this.minuteBox1.Name = "minuteBox1";
            this.minuteBox1.Size = new System.Drawing.Size(98, 27);
            this.minuteBox1.TabIndex = 14;
            this.minuteBox1.Text = "Minute";
            this.minuteBox1.SelectedIndexChanged += new System.EventHandler(this.minuteBox1_SelectedIndexChanged);
            this.minuteBox1.TextChanged += new System.EventHandler(this.minuteBox1_SelectedIndexChanged);
            this.minuteBox1.Click += new System.EventHandler(this.minuteBox1_Click);
            // 
            // hourBox2
            // 
            this.hourBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hourBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.hourBox2.FormattingEnabled = true;
            this.hourBox2.Location = new System.Drawing.Point(215, 773);
            this.hourBox2.Name = "hourBox2";
            this.hourBox2.Size = new System.Drawing.Size(98, 27);
            this.hourBox2.TabIndex = 15;
            this.hourBox2.Text = "Hour";
            this.hourBox2.SelectedIndexChanged += new System.EventHandler(this.hourBox2_SelectedIndexChanged);
            this.hourBox2.TextChanged += new System.EventHandler(this.hourBox2_SelectedIndexChanged);
            this.hourBox2.Click += new System.EventHandler(this.hourBox2_Click);
            // 
            // minuteBox2
            // 
            this.minuteBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minuteBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.minuteBox2.FormattingEnabled = true;
            this.minuteBox2.Location = new System.Drawing.Point(331, 773);
            this.minuteBox2.Name = "minuteBox2";
            this.minuteBox2.Size = new System.Drawing.Size(98, 27);
            this.minuteBox2.TabIndex = 16;
            this.minuteBox2.Text = "Minute";
            this.minuteBox2.SelectedIndexChanged += new System.EventHandler(this.minuteBox2_SelectedIndexChanged);
            this.minuteBox2.TextChanged += new System.EventHandler(this.minuteBox2_SelectedIndexChanged);
            this.minuteBox2.Click += new System.EventHandler(this.minuteBox2_Click);
            // 
            // FirstName
            // 
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FirstName.BackColor = System.Drawing.SystemColors.Window;
            this.FirstName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F);
            this.FirstName.Location = new System.Drawing.Point(30, 64);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 26);
            this.FirstName.TabIndex = 17;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.FirstNameClick);
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LastName.BackColor = System.Drawing.SystemColors.Window;
            this.LastName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F);
            this.LastName.Location = new System.Drawing.Point(232, 64);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(212, 26);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.LastNameClick);
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(307, 605);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(43, 19);
            this.DateLabel.TabIndex = 20;
            this.DateLabel.Text = "Date";
            // 
            // DateBox
            // 
            this.DateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(280, 631);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(98, 27);
            this.DateBox.TabIndex = 21;
            this.DateBox.Click += new System.EventHandler(this.label5_Click);
            // 
            // PatientIDNum
            // 
            this.PatientIDNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientIDNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PatientIDNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PatientIDNum.BackColor = System.Drawing.SystemColors.Window;
            this.PatientIDNum.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F);
            this.PatientIDNum.Location = new System.Drawing.Point(450, 64);
            this.PatientIDNum.Name = "PatientIDNum";
            this.PatientIDNum.Size = new System.Drawing.Size(196, 26);
            this.PatientIDNum.TabIndex = 22;
            this.PatientIDNum.Text = "Patient ID #";
            this.PatientIDNum.Click += new System.EventHandler(this.PatientIDNum_Click);
            this.PatientIDNum.TextChanged += new System.EventHandler(this.PatientIDNum_TextChanged);
            // 
            // PatientListView
            // 
            this.PatientListView.AllowUserToAddRows = false;
            this.PatientListView.AllowUserToDeleteRows = false;
            this.PatientListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientListView.AutoGenerateColumns = false;
            this.PatientListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientListView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Gender,
            this.Age});
            this.PatientListView.DataSource = this.patientBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientListView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientListView.Location = new System.Drawing.Point(30, 96);
            this.PatientListView.Name = "PatientListView";
            this.PatientListView.ReadOnly = true;
            this.PatientListView.RowHeadersVisible = false;
            this.PatientListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PatientListView.Size = new System.Drawing.Size(616, 300);
            this.PatientListView.TabIndex = 23;
            this.PatientListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientListView_CellContentClick);
            this.PatientListView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.PatientListView_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn6.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn7.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
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
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // StartDate
            // 
            this.StartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDate.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(176, 631);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(98, 27);
            this.StartDate.TabIndex = 24;
            this.StartDate.Click += new System.EventHandler(this.StartDate_Click);
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndDate.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(384, 631);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(98, 27);
            this.EndDate.TabIndex = 25;
            this.EndDate.Click += new System.EventHandler(this.EndDate_Click);
            // 
            // DateSelectionLabel
            // 
            this.DateSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateSelectionLabel.AutoSize = true;
            this.DateSelectionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSelectionLabel.Location = new System.Drawing.Point(276, 605);
            this.DateSelectionLabel.Name = "DateSelectionLabel";
            this.DateSelectionLabel.Size = new System.Drawing.Size(114, 19);
            this.DateSelectionLabel.TabIndex = 26;
            this.DateSelectionLabel.Text = "Date Selection";
            this.DateSelectionLabel.Click += new System.EventHandler(this.DateSelectionLabel_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(315, 632);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 19);
            this.ToLabel.TabIndex = 27;
            this.ToLabel.Text = "to";
            this.ToLabel.Click += new System.EventHandler(this.ToLabel_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(688, 889);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.DateSelectionLabel);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.PatientListView);
            this.Controls.Add(this.PatientIDNum);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.minuteBox2);
            this.Controls.Add(this.hourBox2);
            this.Controls.Add(this.minuteBox1);
            this.Controls.Add(this.hourBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentDetails);
            this.Controls.Add(this.AppointmentDescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAppointment";
            this.Text = "New Appointment ";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentDescriptionLabel;
        private System.Windows.Forms.TextBox AppointmentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hourBox1;
        private System.Windows.Forms.ComboBox minuteBox1;
        private System.Windows.Forms.ComboBox hourBox2;
        private System.Windows.Forms.ComboBox minuteBox2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.TextBox PatientIDNum;
        private System.Windows.Forms.DataGridView PatientListView;
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
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label DateSelectionLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.BindingSource eMRDatabaseDataSetBindingSource;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private EMRDatabaseDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}