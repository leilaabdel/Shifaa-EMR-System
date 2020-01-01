namespace Shifaa_EMR_System
{
    partial class PrintPrescriptionsForm
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
            this.PrintButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhysicianNumberLabel = new System.Windows.Forms.Label();
            this.AttendingPhysicianLabel = new System.Windows.Forms.Label();
            this.PhoneNumberValueLabel = new System.Windows.Forms.Label();
            this.PatientNameValueLabel = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicationsBox = new System.Windows.Forms.RichTextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.prescriptionTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 48);
            this.panel1.TabIndex = 64;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.Azure;
            this.PrintButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.PrintButton.Location = new System.Drawing.Point(552, 12);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(94, 26);
            this.PrintButton.TabIndex = 65;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.Azure;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(652, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 64;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Shifaa_EMR_System.Properties.Resources.RxSign;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(30, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 81);
            this.panel2.TabIndex = 65;
            // 
            // PhysicianNumberLabel
            // 
            this.PhysicianNumberLabel.AutoSize = true;
            this.PhysicianNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhysicianNumberLabel.Location = new System.Drawing.Point(293, 101);
            this.PhysicianNumberLabel.Name = "PhysicianNumberLabel";
            this.PhysicianNumberLabel.Size = new System.Drawing.Size(168, 19);
            this.PhysicianNumberLabel.TabIndex = 67;
            this.PhysicianNumberLabel.Text = "Phone: XXX-XXX-XXXX";
            // 
            // AttendingPhysicianLabel
            // 
            this.AttendingPhysicianLabel.AutoSize = true;
            this.AttendingPhysicianLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingPhysicianLabel.Location = new System.Drawing.Point(301, 66);
            this.AttendingPhysicianLabel.Name = "AttendingPhysicianLabel";
            this.AttendingPhysicianLabel.Size = new System.Drawing.Size(160, 25);
            this.AttendingPhysicianLabel.TabIndex = 66;
            this.AttendingPhysicianLabel.Text = "Physician Name";
            // 
            // PhoneNumberValueLabel
            // 
            this.PhoneNumberValueLabel.AutoSize = true;
            this.PhoneNumberValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.PhoneNumberValueLabel.Location = new System.Drawing.Point(181, 219);
            this.PhoneNumberValueLabel.Name = "PhoneNumberValueLabel";
            this.PhoneNumberValueLabel.Size = new System.Drawing.Size(118, 19);
            this.PhoneNumberValueLabel.TabIndex = 69;
            this.PhoneNumberValueLabel.Text = " XXX-XXX-XXXX";
            // 
            // PatientNameValueLabel
            // 
            this.PatientNameValueLabel.AutoSize = true;
            this.PatientNameValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameValueLabel.Location = new System.Drawing.Point(154, 177);
            this.PatientNameValueLabel.Name = "PatientNameValueLabel";
            this.PatientNameValueLabel.Size = new System.Drawing.Size(136, 25);
            this.PatientNameValueLabel.TabIndex = 68;
            this.PatientNameValueLabel.Text = "Patient Name";
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.Location = new System.Drawing.Point(1, 144);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(753, 2);
            this.Divider.TabIndex = 70;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(12, 177);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(141, 25);
            this.PatientNameLabel.TabIndex = 71;
            this.PatientNameLabel.Text = "Patient Name:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(150, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 2);
            this.label2.TabIndex = 72;
            // 
            // MedicationsBox
            // 
            this.MedicationsBox.BackColor = System.Drawing.Color.White;
            this.MedicationsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicationsBox.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationsBox.Location = new System.Drawing.Point(30, 374);
            this.MedicationsBox.Name = "MedicationsBox";
            this.MedicationsBox.ReadOnly = true;
            this.MedicationsBox.Size = new System.Drawing.Size(695, 476);
            this.MedicationsBox.TabIndex = 73;
            this.MedicationsBox.Text = "";
            this.MedicationsBox.TextChanged += new System.EventHandler(this.MedicationsBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(12, 213);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.PhoneNumberLabel.TabIndex = 74;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(168, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 2);
            this.label4.TabIndex = 75;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.eMRDatabaseDataSet;
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
            // PrintPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 881);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.MedicationsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.PhoneNumberValueLabel);
            this.Controls.Add(this.PatientNameValueLabel);
            this.Controls.Add(this.PhysicianNumberLabel);
            this.Controls.Add(this.AttendingPhysicianLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintPrescriptionsForm";
            this.Text = "Print Prescriptions";
            this.Load += new System.EventHandler(this.PrintPrescriptionsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PhysicianNumberLabel;
        private System.Windows.Forms.Label AttendingPhysicianLabel;
        private System.Windows.Forms.Label PhoneNumberValueLabel;
        private System.Windows.Forms.Label PatientNameValueLabel;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MedicationsBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label label4;
    }
}