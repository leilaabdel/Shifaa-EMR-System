namespace Shifaa_EMR_System
{
    partial class UpdatePrescription
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
            this.UpdatePrescriptionLabel = new System.Windows.Forms.Label();
            this.MedicationNameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.RefillsLabel = new System.Windows.Forms.Label();
            this.MedicationBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.StrengthBox = new System.Windows.Forms.TextBox();
            this.FrequencyBox = new System.Windows.Forms.TextBox();
            this.RefillsBox = new System.Windows.Forms.TextBox();
            this.MedicationNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AmountToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StrengthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FrequencyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RefillsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RouteBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RouteLabel = new System.Windows.Forms.Label();
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.prescriptionTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter();
            this.PrescriptionCompleteLabel = new System.Windows.Forms.Label();
            this.YesBox = new System.Windows.Forms.CheckBox();
            this.NoBox = new System.Windows.Forms.CheckBox();
            this.DateCompletedLabel = new System.Windows.Forms.Label();
            this.DateCompletedPicker = new System.Windows.Forms.DateTimePicker();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.UpdatePrescriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 39);
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
            this.CancelButton.Location = new System.Drawing.Point(386, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 49;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdatePrescriptionLabel
            // 
            this.UpdatePrescriptionLabel.AutoSize = true;
            this.UpdatePrescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.UpdatePrescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.UpdatePrescriptionLabel.Name = "UpdatePrescriptionLabel";
            this.UpdatePrescriptionLabel.Size = new System.Drawing.Size(152, 19);
            this.UpdatePrescriptionLabel.TabIndex = 29;
            this.UpdatePrescriptionLabel.Text = "Update Prescription";
            // 
            // MedicationNameLabel
            // 
            this.MedicationNameLabel.AutoSize = true;
            this.MedicationNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationNameLabel.Location = new System.Drawing.Point(15, 51);
            this.MedicationNameLabel.Name = "MedicationNameLabel";
            this.MedicationNameLabel.Size = new System.Drawing.Size(105, 16);
            this.MedicationNameLabel.TabIndex = 35;
            this.MedicationNameLabel.Text = "Medication Name";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(15, 91);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(52, 16);
            this.AmountLabel.TabIndex = 36;
            this.AmountLabel.Text = "Amount";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(15, 130);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(58, 16);
            this.StrengthLabel.TabIndex = 37;
            this.StrengthLabel.Text = "Strength";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyLabel.Location = new System.Drawing.Point(15, 170);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(68, 16);
            this.FrequencyLabel.TabIndex = 38;
            this.FrequencyLabel.Text = "Frequency";
            // 
            // RefillsLabel
            // 
            this.RefillsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.RefillsLabel.AutoSize = true;
            this.RefillsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefillsLabel.Location = new System.Drawing.Point(15, 210);
            this.RefillsLabel.Name = "RefillsLabel";
            this.RefillsLabel.Size = new System.Drawing.Size(107, 16);
            this.RefillsLabel.TabIndex = 39;
            this.RefillsLabel.Text = "Number of Refills";
            // 
            // MedicationBox
            // 
            this.MedicationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicationBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationBox.Location = new System.Drawing.Point(161, 53);
            this.MedicationBox.Name = "MedicationBox";
            this.MedicationBox.Size = new System.Drawing.Size(304, 23);
            this.MedicationBox.TabIndex = 40;
            this.MedicationNameToolTip.SetToolTip(this.MedicationBox, "Choose either the brand or generic drug name");
            this.MedicationBox.TextChanged += new System.EventHandler(this.MedicationBox_TextChanged);
            // 
            // AmountBox
            // 
            this.AmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountBox.Location = new System.Drawing.Point(161, 91);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(304, 23);
            this.AmountBox.TabIndex = 41;
            this.AmountToolTip.SetToolTip(this.AmountBox, "Enter the total amount. Ex: 30 tablets, 2 injections");
            // 
            // StrengthBox
            // 
            this.StrengthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthBox.Location = new System.Drawing.Point(161, 130);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.Size = new System.Drawing.Size(304, 23);
            this.StrengthBox.TabIndex = 42;
            this.StrengthToolTip.SetToolTip(this.StrengthBox, "Dosage. Typically in mg or mL");
            // 
            // FrequencyBox
            // 
            this.FrequencyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencyBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyBox.Location = new System.Drawing.Point(161, 170);
            this.FrequencyBox.Name = "FrequencyBox";
            this.FrequencyBox.Size = new System.Drawing.Size(304, 23);
            this.FrequencyBox.TabIndex = 43;
            this.FrequencyToolTip.SetToolTip(this.FrequencyBox, "Ex: 2 tablets per day for 3 weeks");
            // 
            // RefillsBox
            // 
            this.RefillsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefillsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefillsBox.Location = new System.Drawing.Point(161, 210);
            this.RefillsBox.Name = "RefillsBox";
            this.RefillsBox.Size = new System.Drawing.Size(304, 23);
            this.RefillsBox.TabIndex = 44;
            this.RefillsToolTip.SetToolTip(this.RefillsBox, "Ex: 2");
            // 
            // RouteBox
            // 
            this.RouteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteBox.Location = new System.Drawing.Point(161, 248);
            this.RouteBox.Name = "RouteBox";
            this.RouteBox.Size = new System.Drawing.Size(304, 23);
            this.RouteBox.TabIndex = 46;
            this.RefillsToolTip.SetToolTip(this.RouteBox, "Ex: 2");
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(197, 422);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 45;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RouteLabel
            // 
            this.RouteLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.RouteLabel.AutoSize = true;
            this.RouteLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteLabel.Location = new System.Drawing.Point(15, 251);
            this.RouteLabel.Name = "RouteLabel";
            this.RouteLabel.Size = new System.Drawing.Size(41, 16);
            this.RouteLabel.TabIndex = 47;
            this.RouteLabel.Text = "Route";
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // PrescriptionCompleteLabel
            // 
            this.PrescriptionCompleteLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.PrescriptionCompleteLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionCompleteLabel.Location = new System.Drawing.Point(15, 307);
            this.PrescriptionCompleteLabel.Name = "PrescriptionCompleteLabel";
            this.PrescriptionCompleteLabel.Size = new System.Drawing.Size(130, 37);
            this.PrescriptionCompleteLabel.TabIndex = 48;
            this.PrescriptionCompleteLabel.Text = "Prescription Duration Complete?";
            // 
            // YesBox
            // 
            this.YesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YesBox.AutoSize = true;
            this.YesBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBox.Location = new System.Drawing.Point(225, 308);
            this.YesBox.Name = "YesBox";
            this.YesBox.Size = new System.Drawing.Size(47, 20);
            this.YesBox.TabIndex = 49;
            this.YesBox.Text = "Yes";
            this.YesBox.UseVisualStyleBackColor = true;
            this.YesBox.CheckedChanged += new System.EventHandler(this.YesBox_CheckedChanged);
            // 
            // NoBox
            // 
            this.NoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoBox.AutoSize = true;
            this.NoBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBox.Location = new System.Drawing.Point(331, 307);
            this.NoBox.Name = "NoBox";
            this.NoBox.Size = new System.Drawing.Size(43, 20);
            this.NoBox.TabIndex = 50;
            this.NoBox.Text = "No";
            this.NoBox.UseVisualStyleBackColor = true;
            this.NoBox.CheckedChanged += new System.EventHandler(this.NoBox_CheckedChanged);
            // 
            // DateCompletedLabel
            // 
            this.DateCompletedLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.DateCompletedLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCompletedLabel.Location = new System.Drawing.Point(15, 366);
            this.DateCompletedLabel.Name = "DateCompletedLabel";
            this.DateCompletedLabel.Size = new System.Drawing.Size(130, 37);
            this.DateCompletedLabel.TabIndex = 51;
            this.DateCompletedLabel.Text = "Date Completed";
            // 
            // DateCompletedPicker
            // 
            this.DateCompletedPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCompletedPicker.CustomFormat = "dddd dd/MM/yyyy ";
            this.DateCompletedPicker.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.DateCompletedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCompletedPicker.Location = new System.Drawing.Point(173, 359);
            this.DateCompletedPicker.Name = "DateCompletedPicker";
            this.DateCompletedPicker.Size = new System.Drawing.Size(250, 25);
            this.DateCompletedPicker.TabIndex = 52;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // UpdatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 577);
            this.ControlBox = false;
            this.Controls.Add(this.DateCompletedPicker);
            this.Controls.Add(this.DateCompletedLabel);
            this.Controls.Add(this.NoBox);
            this.Controls.Add(this.YesBox);
            this.Controls.Add(this.PrescriptionCompleteLabel);
            this.Controls.Add(this.RouteLabel);
            this.Controls.Add(this.RouteBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RefillsBox);
            this.Controls.Add(this.FrequencyBox);
            this.Controls.Add(this.StrengthBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.MedicationBox);
            this.Controls.Add(this.RefillsLabel);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.MedicationNameLabel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Prescription";
            this.Load += new System.EventHandler(this.UpdatePrescription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MedicationNameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.Label RefillsLabel;
        private System.Windows.Forms.TextBox MedicationBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.TextBox StrengthBox;
        private System.Windows.Forms.TextBox FrequencyBox;
        private System.Windows.Forms.TextBox RefillsBox;
        private System.Windows.Forms.ToolTip MedicationNameToolTip;
        private System.Windows.Forms.ToolTip AmountToolTip;
        private System.Windows.Forms.ToolTip StrengthToolTip;
        private System.Windows.Forms.ToolTip FrequencyToolTip;
        private System.Windows.Forms.ToolTip RefillsToolTip;
        private System.Windows.Forms.Label UpdatePrescriptionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox RouteBox;
        private System.Windows.Forms.Label RouteLabel;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.Label PrescriptionCompleteLabel;
        private System.Windows.Forms.CheckBox YesBox;
        private System.Windows.Forms.CheckBox NoBox;
        private System.Windows.Forms.Label DateCompletedLabel;
        private System.Windows.Forms.DateTimePicker DateCompletedPicker;
    }
}