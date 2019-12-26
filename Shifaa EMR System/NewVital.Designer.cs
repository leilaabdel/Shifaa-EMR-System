namespace Shifaa_EMR_System
{
    partial class NewVital
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewVitalLabel = new System.Windows.Forms.Label();
            this.BloodPressureLabel = new System.Windows.Forms.Label();
            this.PulseLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BloodPressureBox = new System.Windows.Forms.TextBox();
            this.PulseBox = new System.Windows.Forms.TextBox();
            this.TemperatureBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.BloodPressureToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PulseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TemperatureToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BloodPressureToolTip.SetToolTip(BloodPressureBox, "Enter bp as systolic/diastolic");
            this.TemperatureToolTip.SetToolTip(TemperatureBox, "Enter temperature measured with thermometer (oral, ear, etc.");
            this.PulseToolTip.SetToolTip(PulseBox, "Enter pulse measured either manually or digitally");
            this.HeightToolTip.SetToolTip(HeightBox, "Enter height in centimeters");
            this.WeightToolTip.SetToolTip(WeightBox, "Enter weight in Kg");
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.NewVitalLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 45);
            this.panel1.TabIndex = 0;
            // 
            // NewVitalLabel
            // 
            this.NewVitalLabel.AutoSize = true;
            this.NewVitalLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVitalLabel.Location = new System.Drawing.Point(12, 9);
            this.NewVitalLabel.Name = "NewVitalLabel";
            this.NewVitalLabel.Size = new System.Drawing.Size(89, 23);
            this.NewVitalLabel.TabIndex = 29;
            this.NewVitalLabel.Text = "New Vital";
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureLabel.Location = new System.Drawing.Point(23, 63);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(185, 19);
            this.BloodPressureLabel.TabIndex = 35;
            this.BloodPressureLabel.Text = "Blood Pressure (mm Hg)";
            this.BloodPressureToolTip.SetToolTip(this.BloodPressureLabel, "Choose either the brand or generic drug name");
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseLabel.Location = new System.Drawing.Point(23, 103);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(95, 19);
            this.PulseLabel.TabIndex = 36;
            this.PulseLabel.Text = "Pulse (bpm)";
            this.PulseToolTip.SetToolTip(this.PulseLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(23, 142);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(132, 19);
            this.TemperatureLabel.TabIndex = 37;
            this.TemperatureLabel.Text = "Temperature (°C)";
            this.TemperatureToolTip.SetToolTip(this.TemperatureLabel, "Dosage. Typically in mg or mL");
            // 
            // HeightLabel
            // 
            this.HeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(23, 182);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(91, 19);
            this.HeightLabel.TabIndex = 38;
            this.HeightLabel.Text = "Height (cm)";
            this.HeightToolTip.SetToolTip(this.HeightLabel, "Ex: 2 tablets per day for 3 weeks");
            // 
            // WeightLabel
            // 
            this.WeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(23, 222);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(90, 19);
            this.WeightLabel.TabIndex = 39;
            this.WeightLabel.Text = "Weight (Kg)";
            this.WeightToolTip.SetToolTip(this.WeightLabel, "Ex: 2");
            // 
            // BloodPressureBox
            // 
            this.BloodPressureBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureBox.Location = new System.Drawing.Point(217, 65);
            this.BloodPressureBox.Name = "BloodPressureBox";
            this.BloodPressureBox.Size = new System.Drawing.Size(127, 23);
            this.BloodPressureBox.TabIndex = 40;
            // 
            // PulseBox
            // 
            this.PulseBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseBox.Location = new System.Drawing.Point(217, 103);
            this.PulseBox.Name = "PulseBox";
            this.PulseBox.Size = new System.Drawing.Size(127, 23);
            this.PulseBox.TabIndex = 41;
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureBox.Location = new System.Drawing.Point(217, 142);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.Size = new System.Drawing.Size(127, 23);
            this.TemperatureBox.TabIndex = 42;
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(217, 182);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(127, 23);
            this.HeightBox.TabIndex = 43;
            // 
            // WeightBox
            // 
            this.WeightBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBox.Location = new System.Drawing.Point(217, 222);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(127, 23);
            this.WeightBox.TabIndex = 44;
            // 
            // NewVital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 272);
            this.ControlBox = false;
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.TemperatureBox);
            this.Controls.Add(this.PulseBox);
            this.Controls.Add(this.BloodPressureBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.PulseLabel);
            this.Controls.Add(this.BloodPressureLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewVital";
            this.Text = "NewVital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BloodPressureLabel;
        private System.Windows.Forms.Label PulseLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox BloodPressureBox;
        private System.Windows.Forms.TextBox PulseBox;
        private System.Windows.Forms.TextBox TemperatureBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.ToolTip BloodPressureToolTip;
        private System.Windows.Forms.ToolTip PulseToolTip;
        private System.Windows.Forms.ToolTip TemperatureToolTip;
        private System.Windows.Forms.ToolTip HeightToolTip;
        private System.Windows.Forms.ToolTip WeightToolTip;
        private System.Windows.Forms.Label NewVitalLabel;
    }
}