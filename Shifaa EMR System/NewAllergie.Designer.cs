namespace Shifaa_EMR_System
{
    partial class NewAllergie
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
            this.NewAllergieLabel = new System.Windows.Forms.Label();
            this.AllergyNameLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.AllergyNameBox = new System.Windows.Forms.TextBox();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.AllergyNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NewAllergieLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 39);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(207, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 47;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewAllergieLabel
            // 
            this.NewAllergieLabel.AutoSize = true;
            this.NewAllergieLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewAllergieLabel.Location = new System.Drawing.Point(12, 9);
            this.NewAllergieLabel.Name = "NewAllergieLabel";
            this.NewAllergieLabel.Size = new System.Drawing.Size(97, 19);
            this.NewAllergieLabel.TabIndex = 29;
            this.NewAllergieLabel.Text = "New Allergy";
            // 
            // AllergyNameLabel
            // 
            this.AllergyNameLabel.AutoSize = true;
            this.AllergyNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AllergyNameLabel.Location = new System.Drawing.Point(23, 54);
            this.AllergyNameLabel.Name = "AllergyNameLabel";
            this.AllergyNameLabel.Size = new System.Drawing.Size(93, 17);
            this.AllergyNameLabel.TabIndex = 35;
            this.AllergyNameLabel.Text = "Allergy Name";
            this.AllergyNameToolTip.SetToolTip(this.AllergyNameLabel, "Choose either the brand or generic drug name");
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DetailsLabel.Location = new System.Drawing.Point(23, 128);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(52, 17);
            this.DetailsLabel.TabIndex = 36;
            this.DetailsLabel.Text = "Details";
            this.DetailsToolTip.SetToolTip(this.DetailsLabel, "Optional. Typically in number of tablets, sprays, etc.");
            this.DetailsLabel.Click += new System.EventHandler(this.DetailsLabel_Click);
            // 
            // AllergyNameBox
            // 
            this.AllergyNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyNameBox.Location = new System.Drawing.Point(131, 52);
            this.AllergyNameBox.Name = "AllergyNameBox";
            this.AllergyNameBox.Size = new System.Drawing.Size(127, 23);
            this.AllergyNameBox.TabIndex = 40;
            this.AllergyNameToolTip.SetToolTip(this.AllergyNameBox, "Ex: Latex");
            // 
            // DetailsBox
            // 
            this.DetailsBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBox.Location = new System.Drawing.Point(131, 90);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(127, 114);
            this.DetailsBox.TabIndex = 41;
            this.DetailsToolTip.SetToolTip(this.DetailsBox, "Ex: severity, family history, etc.");
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(111, 222);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 42;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NewAllergie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 273);
            this.ControlBox = false;
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DetailsBox);
            this.Controls.Add(this.AllergyNameBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.AllergyNameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAllergie";
            this.Text = "NewPrescriptionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AllergyNameLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox AllergyNameBox;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.ToolTip AllergyNameToolTip;
        private System.Windows.Forms.ToolTip DetailsToolTip;
        private System.Windows.Forms.Label NewAllergieLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}