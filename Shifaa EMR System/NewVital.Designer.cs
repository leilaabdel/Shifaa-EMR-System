namespace ShifaaEMRSystem
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
            this.CancelButton = new System.Windows.Forms.Button();
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NewVitalLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 39);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(305, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 49;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewVitalLabel
            // 
            this.NewVitalLabel.AutoSize = true;
            this.NewVitalLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewVitalLabel.Location = new System.Drawing.Point(12, 9);
            this.NewVitalLabel.Name = "NewVitalLabel";
            this.NewVitalLabel.Size = new System.Drawing.Size(76, 19);
            this.NewVitalLabel.TabIndex = 29;
            this.NewVitalLabel.Text = "New Vital";
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureLabel.Location = new System.Drawing.Point(23, 63);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(148, 16);
            this.BloodPressureLabel.TabIndex = 35;
            this.BloodPressureLabel.Text = "Blood Pressure (mm Hg)";
            this.BloodPressureToolTip.SetToolTip(this.BloodPressureLabel, "Choose either the brand or generic drug name");
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseLabel.Location = new System.Drawing.Point(23, 103);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(76, 16);
            this.PulseLabel.TabIndex = 36;
            this.PulseLabel.Text = "Pulse (bpm)";
            this.PulseToolTip.SetToolTip(this.PulseLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(23, 142);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(105, 16);
            this.TemperatureLabel.TabIndex = 37;
            this.TemperatureLabel.Text = "Temperature (°C)";
            this.TemperatureToolTip.SetToolTip(this.TemperatureLabel, "Dosage. Typically in mg or mL");
            // 
            // HeightLabel
            // 
            this.HeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(23, 182);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(72, 16);
            this.HeightLabel.TabIndex = 38;
            this.HeightLabel.Text = "Height (cm)";
            this.HeightToolTip.SetToolTip(this.HeightLabel, "Ex: 2 tablets per day for 3 weeks");
            // 
            // WeightLabel
            // 
            this.WeightLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(23, 222);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(71, 16);
            this.WeightLabel.TabIndex = 39;
            this.WeightLabel.Text = "Weight (Kg)";
            this.WeightToolTip.SetToolTip(this.WeightLabel, "Ex: 2");
            // 
            // BloodPressureBox
            // 
            this.BloodPressureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BloodPressureBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureBox.Location = new System.Drawing.Point(217, 65);
            this.BloodPressureBox.Name = "BloodPressureBox";
            this.BloodPressureBox.Size = new System.Drawing.Size(148, 23);
            this.BloodPressureBox.TabIndex = 40;
            this.BloodPressureToolTip.SetToolTip(this.BloodPressureBox, "Enter bp as systolic/diastolic");
            this.BloodPressureBox.TextChanged += new System.EventHandler(this.BloodPressureBox_TextChanged);
            // 
            // PulseBox
            // 
            this.PulseBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PulseBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseBox.Location = new System.Drawing.Point(217, 103);
            this.PulseBox.Name = "PulseBox";
            this.PulseBox.Size = new System.Drawing.Size(148, 23);
            this.PulseBox.TabIndex = 41;
            this.PulseToolTip.SetToolTip(this.PulseBox, "Enter pulse measured either manually or digitally");
            this.PulseBox.TextChanged += new System.EventHandler(this.PulseBox_TextChanged);
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemperatureBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureBox.Location = new System.Drawing.Point(217, 142);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.Size = new System.Drawing.Size(148, 23);
            this.TemperatureBox.TabIndex = 42;
            this.TemperatureToolTip.SetToolTip(this.TemperatureBox, "Enter temperature measured with thermometer (oral, ear, etc.");
            this.TemperatureBox.TextChanged += new System.EventHandler(this.TemperatureBox_TextChanged);
            // 
            // HeightBox
            // 
            this.HeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(217, 182);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(148, 23);
            this.HeightBox.TabIndex = 43;
            this.HeightToolTip.SetToolTip(this.HeightBox, "Enter height in centimeters");
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            // 
            // WeightBox
            // 
            this.WeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBox.Location = new System.Drawing.Point(217, 222);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(148, 23);
            this.WeightBox.TabIndex = 44;
            this.WeightToolTip.SetToolTip(this.WeightBox, "Enter weight in Kg");
            this.WeightBox.TextChanged += new System.EventHandler(this.WeightBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(161, 269);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 45;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NewVital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 381);
            this.ControlBox = false;
            this.Controls.Add(this.SubmitButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewVital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Vital";
            this.Load += new System.EventHandler(this.NewVital_Load);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}