namespace Shifaa_EMR_System
{
    partial class NewPrescriptionForm
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
            this.NewPrescriptionLabel = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.NewPrescriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 39);
            this.panel1.TabIndex = 0;
            // 
            // NewPrescriptionLabel
            // 
            this.NewPrescriptionLabel.AutoSize = true;
            this.NewPrescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewPrescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.NewPrescriptionLabel.Name = "NewPrescriptionLabel";
            this.NewPrescriptionLabel.Size = new System.Drawing.Size(133, 19);
            this.NewPrescriptionLabel.TabIndex = 29;
            this.NewPrescriptionLabel.Text = "New Prescription";
            // 
            // MedicationNameLabel
            // 
            this.MedicationNameLabel.AutoSize = true;
            this.MedicationNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.MedicationNameLabel.Location = new System.Drawing.Point(15, 51);
            this.MedicationNameLabel.Name = "MedicationNameLabel";
            this.MedicationNameLabel.Size = new System.Drawing.Size(117, 17);
            this.MedicationNameLabel.TabIndex = 35;
            this.MedicationNameLabel.Text = "Medication Name";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AmountLabel.Location = new System.Drawing.Point(15, 91);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(58, 17);
            this.AmountLabel.TabIndex = 36;
            this.AmountLabel.Text = "Amount";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.StrengthLabel.Location = new System.Drawing.Point(15, 130);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(65, 17);
            this.StrengthLabel.TabIndex = 37;
            this.StrengthLabel.Text = "Strength";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.FrequencyLabel.Location = new System.Drawing.Point(15, 170);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(76, 17);
            this.FrequencyLabel.TabIndex = 38;
            this.FrequencyLabel.Text = "Frequency";
            // 
            // RefillsLabel
            // 
            this.RefillsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.RefillsLabel.AutoSize = true;
            this.RefillsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.RefillsLabel.Location = new System.Drawing.Point(15, 210);
            this.RefillsLabel.Name = "RefillsLabel";
            this.RefillsLabel.Size = new System.Drawing.Size(116, 17);
            this.RefillsLabel.TabIndex = 39;
            this.RefillsLabel.Text = "Number of Refills";
            // 
            // MedicationBox
            // 
            this.MedicationBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationBox.Location = new System.Drawing.Point(161, 53);
            this.MedicationBox.Name = "MedicationBox";
            this.MedicationBox.Size = new System.Drawing.Size(127, 23);
            this.MedicationBox.TabIndex = 40;
            this.MedicationNameToolTip.SetToolTip(this.MedicationBox, "Choose either the brand or generic drug name");
            this.MedicationBox.TextChanged += new System.EventHandler(this.MedicationBox_TextChanged);
            // 
            // AmountBox
            // 
            this.AmountBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountBox.Location = new System.Drawing.Point(161, 91);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(127, 23);
            this.AmountBox.TabIndex = 41;
            this.AmountToolTip.SetToolTip(this.AmountBox, "Enter the total amount. Ex: 30 tablets, 2 injections");
            // 
            // StrengthBox
            // 
            this.StrengthBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthBox.Location = new System.Drawing.Point(161, 130);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.Size = new System.Drawing.Size(127, 23);
            this.StrengthBox.TabIndex = 42;
            this.StrengthToolTip.SetToolTip(this.StrengthBox, "Dosage. Typically in mg or mL");
            // 
            // FrequencyBox
            // 
            this.FrequencyBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyBox.Location = new System.Drawing.Point(161, 170);
            this.FrequencyBox.Name = "FrequencyBox";
            this.FrequencyBox.Size = new System.Drawing.Size(127, 23);
            this.FrequencyBox.TabIndex = 43;
            this.FrequencyToolTip.SetToolTip(this.FrequencyBox, "Ex: 2 tablets per day for 3 weeks");
            // 
            // RefillsBox
            // 
            this.RefillsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefillsBox.Location = new System.Drawing.Point(161, 210);
            this.RefillsBox.Name = "RefillsBox";
            this.RefillsBox.Size = new System.Drawing.Size(127, 23);
            this.RefillsBox.TabIndex = 44;
            this.RefillsToolTip.SetToolTip(this.RefillsBox, "Ex: 2");
            // 
            // NewPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 255);
            this.ControlBox = false;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPrescriptionForm";
            this.Text = "NewPrescriptionForm";
            this.Load += new System.EventHandler(this.NewPrescriptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label NewPrescriptionLabel;
    }
}