namespace Shifaa_EMR_System
{
    partial class NewLabOrder
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
            this.NewLabLabel = new System.Windows.Forms.Label();
            this.LabNameLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.LabNameBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.LabNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LabNameToolTip.SetToolTip(LabNameBox, "Enter the lab test name. Ex: 2 Hour, 75 gram Glucose Tolerance Test, Pregnancy");
            this.DetailsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsToolTip.SetToolTip(DetailsBox, "Enter details about the lab, additional things to screen for, comments, etc.");
            this.DateScheduledLabel = new System.Windows.Forms.Label();
            this.ScheduledDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.DateScheduledToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateScheduledToolTip.SetToolTip(ScheduledDatePicker, "Pick the date that the test is scheduled for");
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.NewLabLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 45);
            this.panel1.TabIndex = 0;
            // 
            // NewLabLabel
            // 
            this.NewLabLabel.AutoSize = true;
            this.NewLabLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLabLabel.Location = new System.Drawing.Point(12, 9);
            this.NewLabLabel.Name = "NewLabLabel";
            this.NewLabLabel.Size = new System.Drawing.Size(133, 23);
            this.NewLabLabel.TabIndex = 29;
            this.NewLabLabel.Text = "New Lab Order";
            this.NewLabLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LabNameLabel
            // 
            this.LabNameLabel.AutoSize = true;
            this.LabNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameLabel.Location = new System.Drawing.Point(23, 63);
            this.LabNameLabel.Name = "LabNameLabel";
            this.LabNameLabel.Size = new System.Drawing.Size(52, 19);
            this.LabNameLabel.TabIndex = 35;
            this.LabNameLabel.Text = "Name";
            this.LabNameToolTip.SetToolTip(this.LabNameLabel, "Choose either the brand or generic drug name");
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(23, 152);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(60, 19);
            this.DetailsLabel.TabIndex = 36;
            this.DetailsLabel.Text = "Details";
            this.DetailsToolTip.SetToolTip(this.DetailsLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // LabNameBox
            // 
            this.LabNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameBox.Location = new System.Drawing.Point(172, 65);
            this.LabNameBox.Name = "LabNameBox";
            this.LabNameBox.Size = new System.Drawing.Size(226, 23);
            this.LabNameBox.TabIndex = 40;
            this.LabNameToolTip.SetToolTip(this.LabNameBox, "Enter the name of the scan or procedure. Ex: MRI");
            // 
            // DetailsBox
            // 
            this.DetailsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.Location = new System.Drawing.Point(172, 103);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(226, 120);
            this.DetailsBox.TabIndex = 41;
            this.DetailsToolTip.SetToolTip(this.DetailsBox, "Description of procedure. Ex: Static Perimetry for Glaucoma Diagnostic");
            // 
            // DateScheduledLabel
            // 
            this.DateScheduledLabel.AutoSize = true;
            this.DateScheduledLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateScheduledLabel.Location = new System.Drawing.Point(23, 244);
            this.DateScheduledLabel.Name = "DateScheduledLabel";
            this.DateScheduledLabel.Size = new System.Drawing.Size(123, 19);
            this.DateScheduledLabel.TabIndex = 42;
            this.DateScheduledLabel.Text = "Date Scheduled";
            this.DetailsToolTip.SetToolTip(this.DateScheduledLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // ScheduledDatePicker
            // 
            this.ScheduledDatePicker.Location = new System.Drawing.Point(172, 239);
            this.ScheduledDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.ScheduledDatePicker.Name = "ScheduledDatePicker";
            this.ScheduledDatePicker.Size = new System.Drawing.Size(226, 29);
            this.ScheduledDatePicker.TabIndex = 43;
            // 
            // NewLabOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 292);
            this.ControlBox = false;
            this.Controls.Add(this.ScheduledDatePicker);
            this.Controls.Add(this.DateScheduledLabel);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.LabNameBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.LabNameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLabOrder";
            this.Text = "NewPrescriptionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabNameLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox LabNameBox;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.ToolTip LabNameToolTip;
        private System.Windows.Forms.ToolTip DetailsToolTip;
        private System.Windows.Forms.Label NewLabLabel;
        private System.Windows.Forms.Label DateScheduledLabel;
        private MetroFramework.Controls.MetroDateTime ScheduledDatePicker;
        private System.Windows.Forms.ToolTip DateScheduledToolTip;
    }
}