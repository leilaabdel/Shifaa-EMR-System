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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.PatientAgeLabel = new System.Windows.Forms.Label();
            this.PatientGenderLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.AttendingPhysicianLabel = new System.Windows.Forms.Label();
            this.PhysicianNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VitalLabel = new System.Windows.Forms.Label();
            this.BMIValueLabel = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.WeightValueLabel = new System.Windows.Forms.Label();
            this.HeightValueLabel = new System.Windows.Forms.Label();
            this.TemperatureValueLabel = new System.Windows.Forms.Label();
            this.PulseValueLabel = new System.Windows.Forms.Label();
            this.BloodPressureValueLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.PulseLabel = new System.Windows.Forms.Label();
            this.BloodPressureLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.DOBLabel.Location = new System.Drawing.Point(30, 156);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(131, 19);
            this.DOBLabel.TabIndex = 37;
            this.DOBLabel.Text = "DOB: XX/XX/XXXX";
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PatientAgeLabel.Location = new System.Drawing.Point(30, 126);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(88, 19);
            this.PatientAgeLabel.TabIndex = 36;
            this.PatientAgeLabel.Text = "X Years Old";
            // 
            // PatientGenderLabel
            // 
            this.PatientGenderLabel.AutoSize = true;
            this.PatientGenderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PatientGenderLabel.Location = new System.Drawing.Point(30, 96);
            this.PatientGenderLabel.Name = "PatientGenderLabel";
            this.PatientGenderLabel.Size = new System.Drawing.Size(64, 19);
            this.PatientGenderLabel.TabIndex = 35;
            this.PatientGenderLabel.Text = "Female";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(30, 66);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(168, 19);
            this.PhoneNumberLabel.TabIndex = 34;
            this.PhoneNumberLabel.Text = "Phone: XXX-XXX-XXXX";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(29, 30);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(136, 25);
            this.PatientNameLabel.TabIndex = 33;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // AttendingPhysicianLabel
            // 
            this.AttendingPhysicianLabel.AutoSize = true;
            this.AttendingPhysicianLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingPhysicianLabel.Location = new System.Drawing.Point(612, 30);
            this.AttendingPhysicianLabel.Name = "AttendingPhysicianLabel";
            this.AttendingPhysicianLabel.Size = new System.Drawing.Size(160, 25);
            this.AttendingPhysicianLabel.TabIndex = 38;
            this.AttendingPhysicianLabel.Text = "Physician Name";
            // 
            // PhysicianNumberLabel
            // 
            this.PhysicianNumberLabel.AutoSize = true;
            this.PhysicianNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhysicianNumberLabel.Location = new System.Drawing.Point(604, 66);
            this.PhysicianNumberLabel.Name = "PhysicianNumberLabel";
            this.PhysicianNumberLabel.Size = new System.Drawing.Size(168, 19);
            this.PhysicianNumberLabel.TabIndex = 39;
            this.PhysicianNumberLabel.Text = "Phone: XXX-XXX-XXXX";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BMIValueLabel);
            this.panel1.Controls.Add(this.VitalLabel);
            this.panel1.Controls.Add(this.BMILabel);
            this.panel1.Controls.Add(this.BloodPressureLabel);
            this.panel1.Controls.Add(this.WeightValueLabel);
            this.panel1.Controls.Add(this.PulseLabel);
            this.panel1.Controls.Add(this.HeightValueLabel);
            this.panel1.Controls.Add(this.TemperatureLabel);
            this.panel1.Controls.Add(this.HeightLabel);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Location = new System.Drawing.Point(34, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 218);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VitalLabel
            // 
            this.VitalLabel.AutoSize = true;
            this.VitalLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitalLabel.Location = new System.Drawing.Point(4, 9);
            this.VitalLabel.Name = "VitalLabel";
            this.VitalLabel.Size = new System.Drawing.Size(64, 25);
            this.VitalLabel.TabIndex = 41;
            this.VitalLabel.Text = "Vitals";
            // 
            // BMIValueLabel
            // 
            this.BMIValueLabel.AutoSize = true;
            this.BMIValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIValueLabel.Location = new System.Drawing.Point(131, 185);
            this.BMIValueLabel.Name = "BMIValueLabel";
            this.BMIValueLabel.Size = new System.Drawing.Size(63, 19);
            this.BMIValueLabel.TabIndex = 54;
            this.BMIValueLabel.Text = "0 kg/m²";
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(8, 185);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(35, 19);
            this.BMILabel.TabIndex = 53;
            this.BMILabel.Text = "BMI";
            // 
            // WeightValueLabel
            // 
            this.WeightValueLabel.AutoSize = true;
            this.WeightValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightValueLabel.Location = new System.Drawing.Point(131, 160);
            this.WeightValueLabel.Name = "WeightValueLabel";
            this.WeightValueLabel.Size = new System.Drawing.Size(38, 19);
            this.WeightValueLabel.TabIndex = 52;
            this.WeightValueLabel.Text = "0 kg";
            // 
            // HeightValueLabel
            // 
            this.HeightValueLabel.AutoSize = true;
            this.HeightValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightValueLabel.Location = new System.Drawing.Point(131, 132);
            this.HeightValueLabel.Name = "HeightValueLabel";
            this.HeightValueLabel.Size = new System.Drawing.Size(43, 19);
            this.HeightValueLabel.TabIndex = 51;
            this.HeightValueLabel.Text = "0 cm";
            // 
            // TemperatureValueLabel
            // 
            this.TemperatureValueLabel.AutoSize = true;
            this.TemperatureValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValueLabel.Location = new System.Drawing.Point(165, 296);
            this.TemperatureValueLabel.Name = "TemperatureValueLabel";
            this.TemperatureValueLabel.Size = new System.Drawing.Size(37, 19);
            this.TemperatureValueLabel.TabIndex = 50;
            this.TemperatureValueLabel.Text = "0 °C";
            // 
            // PulseValueLabel
            // 
            this.PulseValueLabel.AutoSize = true;
            this.PulseValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseValueLabel.Location = new System.Drawing.Point(165, 271);
            this.PulseValueLabel.Name = "PulseValueLabel";
            this.PulseValueLabel.Size = new System.Drawing.Size(53, 19);
            this.PulseValueLabel.TabIndex = 49;
            this.PulseValueLabel.Text = "0 bpm";
            // 
            // BloodPressureValueLabel
            // 
            this.BloodPressureValueLabel.AutoSize = true;
            this.BloodPressureValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureValueLabel.Location = new System.Drawing.Point(165, 243);
            this.BloodPressureValueLabel.Name = "BloodPressureValueLabel";
            this.BloodPressureValueLabel.Size = new System.Drawing.Size(72, 19);
            this.BloodPressureValueLabel.TabIndex = 48;
            this.BloodPressureValueLabel.Text = "0 mm Hg";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(8, 160);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(58, 19);
            this.WeightLabel.TabIndex = 47;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(8, 132);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(56, 19);
            this.HeightLabel.TabIndex = 46;
            this.HeightLabel.Text = "Height";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(8, 103);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(103, 19);
            this.TemperatureLabel.TabIndex = 45;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseLabel.Location = new System.Drawing.Point(10, 78);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(50, 19);
            this.PulseLabel.TabIndex = 44;
            this.PulseLabel.Text = "Pulse";
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureLabel.Location = new System.Drawing.Point(8, 52);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(121, 19);
            this.BloodPressureLabel.TabIndex = 43;
            this.BloodPressureLabel.Text = "Blood Pressure";
            // 
            // PrintableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 997);
            this.Controls.Add(this.TemperatureValueLabel);
            this.Controls.Add(this.PulseValueLabel);
            this.Controls.Add(this.BloodPressureValueLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PhysicianNumberLabel);
            this.Controls.Add(this.AttendingPhysicianLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.PatientAgeLabel);
            this.Controls.Add(this.PatientGenderLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Name = "PrintableReport";
            this.Text = "PrintableReport";
            this.Load += new System.EventHandler(this.PrintableReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VitalLabel;
        private System.Windows.Forms.Label BMIValueLabel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label WeightValueLabel;
        private System.Windows.Forms.Label HeightValueLabel;
        private System.Windows.Forms.Label TemperatureValueLabel;
        private System.Windows.Forms.Label PulseValueLabel;
        private System.Windows.Forms.Label BloodPressureValueLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label PulseLabel;
        private System.Windows.Forms.Label BloodPressureLabel;
    }
}