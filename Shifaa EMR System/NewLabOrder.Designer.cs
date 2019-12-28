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
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewLabLabel = new System.Windows.Forms.Label();
            this.LabNameLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.LabNameBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.LabNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateScheduledLabel = new System.Windows.Forms.Label();
            this.ScheduledDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.DateScheduledToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NewLabLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 40);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(323, 6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewLabLabel
            // 
            this.NewLabLabel.AutoSize = true;
            this.NewLabLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewLabLabel.Location = new System.Drawing.Point(12, 11);
            this.NewLabLabel.Name = "NewLabLabel";
            this.NewLabLabel.Size = new System.Drawing.Size(116, 19);
            this.NewLabLabel.TabIndex = 29;
            this.NewLabLabel.Text = "New Lab Order";
            this.NewLabLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LabNameLabel
            // 
            this.LabNameLabel.AutoSize = true;
            this.LabNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.LabNameLabel.Location = new System.Drawing.Point(20, 51);
            this.LabNameLabel.Name = "LabNameLabel";
            this.LabNameLabel.Size = new System.Drawing.Size(45, 17);
            this.LabNameLabel.TabIndex = 35;
            this.LabNameLabel.Text = "Name";
            this.LabNameToolTip.SetToolTip(this.LabNameLabel, "Choose either the brand or generic drug name");
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DetailsLabel.Location = new System.Drawing.Point(20, 140);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(52, 17);
            this.DetailsLabel.TabIndex = 36;
            this.DetailsLabel.Text = "Details";
            this.DetailsToolTip.SetToolTip(this.DetailsLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // LabNameBox
            // 
            this.LabNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameBox.Location = new System.Drawing.Point(169, 53);
            this.LabNameBox.Name = "LabNameBox";
            this.LabNameBox.Size = new System.Drawing.Size(226, 23);
            this.LabNameBox.TabIndex = 40;
            this.LabNameToolTip.SetToolTip(this.LabNameBox, "Enter the name of the scan or procedure. Ex: MRI");
            // 
            // DetailsBox
            // 
            this.DetailsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.Location = new System.Drawing.Point(169, 91);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(226, 120);
            this.DetailsBox.TabIndex = 41;
            this.DetailsToolTip.SetToolTip(this.DetailsBox, "Description of procedure. Ex: Static Perimetry for Glaucoma Diagnostic");
            // 
            // DateScheduledLabel
            // 
            this.DateScheduledLabel.AutoSize = true;
            this.DateScheduledLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DateScheduledLabel.Location = new System.Drawing.Point(20, 232);
            this.DateScheduledLabel.Name = "DateScheduledLabel";
            this.DateScheduledLabel.Size = new System.Drawing.Size(107, 17);
            this.DateScheduledLabel.TabIndex = 42;
            this.DateScheduledLabel.Text = "Date Scheduled";
            this.DetailsToolTip.SetToolTip(this.DateScheduledLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // ScheduledDatePicker
            // 
            this.ScheduledDatePicker.CalendarFont = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduledDatePicker.Location = new System.Drawing.Point(169, 227);
            this.ScheduledDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.ScheduledDatePicker.Name = "ScheduledDatePicker";
            this.ScheduledDatePicker.Size = new System.Drawing.Size(226, 29);
            this.ScheduledDatePicker.TabIndex = 43;
            this.DateScheduledToolTip.SetToolTip(this.ScheduledDatePicker, "Pick the date that the test is scheduled for");
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(169, 278);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 44;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NewLabOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 333);
            this.ControlBox = false;
            this.Controls.Add(this.SubmitButton);
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
            this.Load += new System.EventHandler(this.NewLabOrder_Load);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}