namespace Shifaa_EMR_System
{
    partial class NewScanOrder
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
            this.NewScanLabel = new System.Windows.Forms.Label();
            this.LabNameLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ScanNameBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.ScanNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateScheduledLabel = new System.Windows.Forms.Label();
            this.ScheduleDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.DateScheduledToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NewScanLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 39);
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
            this.CancelButton.Location = new System.Drawing.Point(308, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 50;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewScanLabel
            // 
            this.NewScanLabel.AutoSize = true;
            this.NewScanLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewScanLabel.Location = new System.Drawing.Point(12, 9);
            this.NewScanLabel.Name = "NewScanLabel";
            this.NewScanLabel.Size = new System.Drawing.Size(224, 19);
            this.NewScanLabel.TabIndex = 29;
            this.NewScanLabel.Text = "New Scan or Procedure Order";
            this.NewScanLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LabNameLabel
            // 
            this.LabNameLabel.AutoSize = true;
            this.LabNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameLabel.Location = new System.Drawing.Point(22, 56);
            this.LabNameLabel.Name = "LabNameLabel";
            this.LabNameLabel.Size = new System.Drawing.Size(42, 16);
            this.LabNameLabel.TabIndex = 35;
            this.LabNameLabel.Text = "Name";
            this.ScanNameToolTip.SetToolTip(this.LabNameLabel, "Choose either the brand or generic drug name");
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(22, 145);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(49, 16);
            this.DetailsLabel.TabIndex = 36;
            this.DetailsLabel.Text = "Details";
            this.DetailsToolTip.SetToolTip(this.DetailsLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // ScanNameBox
            // 
            this.ScanNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanNameBox.Location = new System.Drawing.Point(162, 58);
            this.ScanNameBox.Name = "ScanNameBox";
            this.ScanNameBox.Size = new System.Drawing.Size(228, 23);
            this.ScanNameBox.TabIndex = 40;
            this.ScanNameToolTip.SetToolTip(this.ScanNameBox, "Enter the name of the scan or procedure. Ex: MRI");
            // 
            // DetailsBox
            // 
            this.DetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.Location = new System.Drawing.Point(162, 96);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(228, 120);
            this.DetailsBox.TabIndex = 41;
            this.DetailsToolTip.SetToolTip(this.DetailsBox, "Description of procedure. Ex: Static Perimetry for Glaucoma Diagnostic");
            // 
            // DateScheduledLabel
            // 
            this.DateScheduledLabel.AutoSize = true;
            this.DateScheduledLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DateScheduledLabel.Location = new System.Drawing.Point(22, 237);
            this.DateScheduledLabel.Name = "DateScheduledLabel";
            this.DateScheduledLabel.Size = new System.Drawing.Size(107, 17);
            this.DateScheduledLabel.TabIndex = 42;
            this.DateScheduledLabel.Text = "Date Scheduled";
            this.DetailsToolTip.SetToolTip(this.DateScheduledLabel, "Optional. Typically in number of tablets, sprays, etc.");
            // 
            // ScheduleDatePicker
            // 
            this.ScheduleDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDatePicker.Location = new System.Drawing.Point(164, 232);
            this.ScheduleDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.ScheduleDatePicker.Name = "ScheduleDatePicker";
            this.ScheduleDatePicker.Size = new System.Drawing.Size(226, 29);
            this.ScheduleDatePicker.TabIndex = 43;
            this.DateScheduledToolTip.SetToolTip(this.ScheduleDatePicker, "Pick the date where you aim to schedule the scan/procedure");
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(163, 280);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 46;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NewScanOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 353);
            this.ControlBox = false;
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ScheduleDatePicker);
            this.Controls.Add(this.DateScheduledLabel);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.ScanNameBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.LabNameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewScanOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Scan or Procedure";
            this.Load += new System.EventHandler(this.NewScanOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabNameLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox ScanNameBox;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.ToolTip ScanNameToolTip;
        private System.Windows.Forms.ToolTip DetailsToolTip;
        private System.Windows.Forms.Label NewScanLabel;
        private System.Windows.Forms.Label DateScheduledLabel;
        private MetroFramework.Controls.MetroDateTime ScheduleDatePicker;
        private System.Windows.Forms.ToolTip DateScheduledToolTip;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}