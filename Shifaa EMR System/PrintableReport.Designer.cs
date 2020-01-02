namespace Shifaa_EMR_System
{
    partial class PrintableReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintableReport));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.PatientAgeLabel = new System.Windows.Forms.Label();
            this.PatientGenderLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.AttendingPhysicianLabel = new System.Windows.Forms.Label();
            this.PhysicianNumberLabel = new System.Windows.Forms.Label();
            this.TemperatureValueLabel = new System.Windows.Forms.Label();
            this.PulseValueLabel = new System.Windows.Forms.Label();
            this.BloodPressureValueLabel = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrimaryProblemsBox = new System.Windows.Forms.RichTextBox();
            this.PrimaryProblemsLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.MedicationsListLabel = new System.Windows.Forms.Label();
            this.MaritalStatusLabel = new System.Windows.Forms.Label();
            this.PregnantLabel = new System.Windows.Forms.Label();
            this.MedicationsBox = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.HeightValueLabel = new System.Windows.Forms.Label();
            this.PulseLabel = new System.Windows.Forms.Label();
            this.WeightValueLabel = new System.Windows.Forms.Label();
            this.BloodPressureLabel = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.VitalLabel = new System.Windows.Forms.Label();
            this.BMIValueLabel = new System.Windows.Forms.Label();
            this.Seperator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.DOBLabel.Location = new System.Drawing.Point(13, 250);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(131, 19);
            this.DOBLabel.TabIndex = 37;
            this.DOBLabel.Text = "DOB: XX/XX/XXXX";
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PatientAgeLabel.Location = new System.Drawing.Point(13, 221);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(88, 19);
            this.PatientAgeLabel.TabIndex = 36;
            this.PatientAgeLabel.Text = "X Years Old";
            // 
            // PatientGenderLabel
            // 
            this.PatientGenderLabel.AutoSize = true;
            this.PatientGenderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PatientGenderLabel.Location = new System.Drawing.Point(13, 130);
            this.PatientGenderLabel.Name = "PatientGenderLabel";
            this.PatientGenderLabel.Size = new System.Drawing.Size(64, 19);
            this.PatientGenderLabel.TabIndex = 35;
            this.PatientGenderLabel.Text = "Female";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 100);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(168, 19);
            this.PhoneNumberLabel.TabIndex = 34;
            this.PhoneNumberLabel.Text = "Phone: XXX-XXX-XXXX";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(12, 64);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(136, 25);
            this.PatientNameLabel.TabIndex = 33;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // AttendingPhysicianLabel
            // 
            this.AttendingPhysicianLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendingPhysicianLabel.AutoSize = true;
            this.AttendingPhysicianLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingPhysicianLabel.Location = new System.Drawing.Point(464, 64);
            this.AttendingPhysicianLabel.Name = "AttendingPhysicianLabel";
            this.AttendingPhysicianLabel.Size = new System.Drawing.Size(160, 25);
            this.AttendingPhysicianLabel.TabIndex = 38;
            this.AttendingPhysicianLabel.Text = "Physician Name";
            // 
            // PhysicianNumberLabel
            // 
            this.PhysicianNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhysicianNumberLabel.AutoSize = true;
            this.PhysicianNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhysicianNumberLabel.Location = new System.Drawing.Point(456, 100);
            this.PhysicianNumberLabel.Name = "PhysicianNumberLabel";
            this.PhysicianNumberLabel.Size = new System.Drawing.Size(168, 19);
            this.PhysicianNumberLabel.TabIndex = 39;
            this.PhysicianNumberLabel.Text = "Phone: XXX-XXX-XXXX";
            // 
            // TemperatureValueLabel
            // 
            this.TemperatureValueLabel.AutoSize = true;
            this.TemperatureValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValueLabel.Location = new System.Drawing.Point(139, 406);
            this.TemperatureValueLabel.Name = "TemperatureValueLabel";
            this.TemperatureValueLabel.Size = new System.Drawing.Size(37, 19);
            this.TemperatureValueLabel.TabIndex = 50;
            this.TemperatureValueLabel.Text = "0 °C";
            // 
            // PulseValueLabel
            // 
            this.PulseValueLabel.AutoSize = true;
            this.PulseValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseValueLabel.Location = new System.Drawing.Point(139, 381);
            this.PulseValueLabel.Name = "PulseValueLabel";
            this.PulseValueLabel.Size = new System.Drawing.Size(53, 19);
            this.PulseValueLabel.TabIndex = 49;
            this.PulseValueLabel.Text = "0 bpm";
            // 
            // BloodPressureValueLabel
            // 
            this.BloodPressureValueLabel.AutoSize = true;
            this.BloodPressureValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureValueLabel.Location = new System.Drawing.Point(139, 353);
            this.BloodPressureValueLabel.Name = "BloodPressureValueLabel";
            this.BloodPressureValueLabel.Size = new System.Drawing.Size(72, 19);
            this.BloodPressureValueLabel.TabIndex = 48;
            this.BloodPressureValueLabel.Text = "0 mm Hg";
            // 
            // NoteBox
            // 
            this.NoteBox.BackColor = System.Drawing.Color.White;
            this.NoteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteBox.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBox.Location = new System.Drawing.Point(14, 64);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.ReadOnly = true;
            this.NoteBox.Size = new System.Drawing.Size(738, 1377);
            this.NoteBox.TabIndex = 51;
            this.NoteBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.PrimaryProblemsBox);
            this.panel2.Controls.Add(this.PrimaryProblemsLabel);
            this.panel2.Location = new System.Drawing.Point(288, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 218);
            this.panel2.TabIndex = 55;
            // 
            // PrimaryProblemsBox
            // 
            this.PrimaryProblemsBox.BackColor = System.Drawing.Color.White;
            this.PrimaryProblemsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrimaryProblemsBox.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryProblemsBox.Location = new System.Drawing.Point(9, 37);
            this.PrimaryProblemsBox.Name = "PrimaryProblemsBox";
            this.PrimaryProblemsBox.ReadOnly = true;
            this.PrimaryProblemsBox.Size = new System.Drawing.Size(446, 167);
            this.PrimaryProblemsBox.TabIndex = 56;
            this.PrimaryProblemsBox.Text = "";
            // 
            // PrimaryProblemsLabel
            // 
            this.PrimaryProblemsLabel.AutoSize = true;
            this.PrimaryProblemsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryProblemsLabel.Location = new System.Drawing.Point(4, 9);
            this.PrimaryProblemsLabel.Name = "PrimaryProblemsLabel";
            this.PrimaryProblemsLabel.Size = new System.Drawing.Size(179, 25);
            this.PrimaryProblemsLabel.TabIndex = 41;
            this.PrimaryProblemsLabel.Text = "Primary Problems";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(12, 537);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(67, 25);
            this.NotesLabel.TabIndex = 57;
            this.NotesLabel.Text = "Notes";
            // 
            // MedicationsListLabel
            // 
            this.MedicationsListLabel.AutoSize = true;
            this.MedicationsListLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationsListLabel.Location = new System.Drawing.Point(26, 1186);
            this.MedicationsListLabel.Name = "MedicationsListLabel";
            this.MedicationsListLabel.Size = new System.Drawing.Size(126, 25);
            this.MedicationsListLabel.TabIndex = 58;
            this.MedicationsListLabel.Text = "Medications ";
            // 
            // MaritalStatusLabel
            // 
            this.MaritalStatusLabel.AutoSize = true;
            this.MaritalStatusLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.MaritalStatusLabel.Location = new System.Drawing.Point(13, 160);
            this.MaritalStatusLabel.Name = "MaritalStatusLabel";
            this.MaritalStatusLabel.Size = new System.Drawing.Size(113, 19);
            this.MaritalStatusLabel.TabIndex = 59;
            this.MaritalStatusLabel.Text = "Marital Status:";
            // 
            // PregnantLabel
            // 
            this.PregnantLabel.AutoSize = true;
            this.PregnantLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PregnantLabel.Location = new System.Drawing.Point(13, 192);
            this.PregnantLabel.Name = "PregnantLabel";
            this.PregnantLabel.Size = new System.Drawing.Size(80, 19);
            this.PregnantLabel.TabIndex = 60;
            this.PregnantLabel.Text = "Pregnant:";
            // 
            // MedicationsBox
            // 
            this.MedicationsBox.BackColor = System.Drawing.Color.White;
            this.MedicationsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicationsBox.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationsBox.Location = new System.Drawing.Point(17, 1214);
            this.MedicationsBox.Name = "MedicationsBox";
            this.MedicationsBox.ReadOnly = true;
            this.MedicationsBox.Size = new System.Drawing.Size(738, 254);
            this.MedicationsBox.TabIndex = 61;
            this.MedicationsBox.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Report";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(16, 459);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(58, 19);
            this.WeightLabel.TabIndex = 47;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(16, 431);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(56, 19);
            this.HeightLabel.TabIndex = 46;
            this.HeightLabel.Text = "Height";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(16, 402);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(103, 19);
            this.TemperatureLabel.TabIndex = 45;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // HeightValueLabel
            // 
            this.HeightValueLabel.AutoSize = true;
            this.HeightValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightValueLabel.Location = new System.Drawing.Point(139, 431);
            this.HeightValueLabel.Name = "HeightValueLabel";
            this.HeightValueLabel.Size = new System.Drawing.Size(43, 19);
            this.HeightValueLabel.TabIndex = 51;
            this.HeightValueLabel.Text = "0 cm";
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseLabel.Location = new System.Drawing.Point(18, 377);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(50, 19);
            this.PulseLabel.TabIndex = 44;
            this.PulseLabel.Text = "Pulse";
            // 
            // WeightValueLabel
            // 
            this.WeightValueLabel.AutoSize = true;
            this.WeightValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightValueLabel.Location = new System.Drawing.Point(139, 459);
            this.WeightValueLabel.Name = "WeightValueLabel";
            this.WeightValueLabel.Size = new System.Drawing.Size(38, 19);
            this.WeightValueLabel.TabIndex = 52;
            this.WeightValueLabel.Text = "0 kg";
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureLabel.Location = new System.Drawing.Point(16, 351);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(121, 19);
            this.BloodPressureLabel.TabIndex = 43;
            this.BloodPressureLabel.Text = "Blood Pressure";
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(16, 484);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(35, 19);
            this.BMILabel.TabIndex = 53;
            this.BMILabel.Text = "BMI";
            // 
            // VitalLabel
            // 
            this.VitalLabel.AutoSize = true;
            this.VitalLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitalLabel.Location = new System.Drawing.Point(12, 308);
            this.VitalLabel.Name = "VitalLabel";
            this.VitalLabel.Size = new System.Drawing.Size(64, 25);
            this.VitalLabel.TabIndex = 41;
            this.VitalLabel.Text = "Vitals";
            // 
            // BMIValueLabel
            // 
            this.BMIValueLabel.AutoSize = true;
            this.BMIValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIValueLabel.Location = new System.Drawing.Point(139, 484);
            this.BMIValueLabel.Name = "BMIValueLabel";
            this.BMIValueLabel.Size = new System.Drawing.Size(63, 19);
            this.BMIValueLabel.TabIndex = 54;
            this.BMIValueLabel.Text = "0 kg/m²";
            // 
            // Seperator
            // 
            this.Seperator.BackColor = System.Drawing.Color.Azure;
            this.Seperator.Location = new System.Drawing.Point(0, 284);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(769, 18);
            this.Seperator.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 48);
            this.panel1.TabIndex = 63;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.Azure;
            this.PrintButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.PrintButton.Location = new System.Drawing.Point(568, 12);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(94, 26);
            this.PrintButton.TabIndex = 65;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.Azure;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(668, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 64;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrintableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.BMIValueLabel);
            this.Controls.Add(this.MedicationsBox);
            this.Controls.Add(this.VitalLabel);
            this.Controls.Add(this.PregnantLabel);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.MaritalStatusLabel);
            this.Controls.Add(this.BloodPressureLabel);
            this.Controls.Add(this.WeightValueLabel);
            this.Controls.Add(this.MedicationsListLabel);
            this.Controls.Add(this.PulseLabel);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.HeightValueLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.TemperatureValueLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.PulseValueLabel);
            this.Controls.Add(this.BloodPressureValueLabel);
            this.Controls.Add(this.PhysicianNumberLabel);
            this.Controls.Add(this.AttendingPhysicianLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.PatientAgeLabel);
            this.Controls.Add(this.PatientGenderLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintableReport";
            this.Text = "Printable Report";
            this.Load += new System.EventHandler(this.PrintableReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label PatientAgeLabel;
        private System.Windows.Forms.Label PatientGenderLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label AttendingPhysicianLabel;
        private System.Windows.Forms.Label PhysicianNumberLabel;
        private System.Windows.Forms.Label TemperatureValueLabel;
        private System.Windows.Forms.Label PulseValueLabel;
        private System.Windows.Forms.Label BloodPressureValueLabel;
        private System.Windows.Forms.RichTextBox NoteBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox PrimaryProblemsBox;
        private System.Windows.Forms.Label PrimaryProblemsLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label MedicationsListLabel;
        private System.Windows.Forms.Label MaritalStatusLabel;
        private System.Windows.Forms.Label PregnantLabel;
        private System.Windows.Forms.RichTextBox MedicationsBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label HeightValueLabel;
        private System.Windows.Forms.Label PulseLabel;
        private System.Windows.Forms.Label WeightValueLabel;
        private System.Windows.Forms.Label BloodPressureLabel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label VitalLabel;
        private System.Windows.Forms.Label BMIValueLabel;
        private System.Windows.Forms.Panel Seperator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CancelButton;
    }
}