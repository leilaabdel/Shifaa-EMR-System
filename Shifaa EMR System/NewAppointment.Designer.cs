namespace Shifaa_EMR_System
{
    partial class NewAppointment
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
            this.AppointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.AppointmentDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.hourBox1 = new System.Windows.Forms.ComboBox();
            this.minuteBox1 = new System.Windows.Forms.ComboBox();
            this.hourBox2 = new System.Windows.Forms.ComboBox();
            this.minuteBox2 = new System.Windows.Forms.ComboBox();
            this.AppointmentTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AppointmentDescriptionLabel
            // 
            this.AppointmentDescriptionLabel.AutoSize = true;
            this.AppointmentDescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDescriptionLabel.Location = new System.Drawing.Point(57, 28);
            this.AppointmentDescriptionLabel.Name = "AppointmentDescriptionLabel";
            this.AppointmentDescriptionLabel.Size = new System.Drawing.Size(241, 25);
            this.AppointmentDescriptionLabel.TabIndex = 1;
            this.AppointmentDescriptionLabel.Text = "Appointment Description";
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDetails.Location = new System.Drawing.Point(62, 96);
            this.AppointmentDetails.Multiline = true;
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.Size = new System.Drawing.Size(414, 138);
            this.AppointmentDetails.TabIndex = 2;
            this.AppointmentDetails.Text = "Appointment Details";
            this.AppointmentDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(322, 293);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 43);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(403, 293);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 43);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duration";
            // 
            // hourBox1
            // 
            this.hourBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourBox1.FormattingEnabled = true;
            this.hourBox1.Location = new System.Drawing.Point(62, 271);
            this.hourBox1.Name = "hourBox1";
            this.hourBox1.Size = new System.Drawing.Size(98, 27);
            this.hourBox1.TabIndex = 13;
            this.hourBox1.Text = "Hour";
            this.hourBox1.SelectedIndexChanged += new System.EventHandler(this.hourBox1_SelectedIndexChanged);
            // 
            // minuteBox1
            // 
            this.minuteBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.minuteBox1.FormattingEnabled = true;
            this.minuteBox1.Location = new System.Drawing.Point(178, 271);
            this.minuteBox1.Name = "minuteBox1";
            this.minuteBox1.Size = new System.Drawing.Size(98, 27);
            this.minuteBox1.TabIndex = 14;
            this.minuteBox1.Text = "Minute";
            this.minuteBox1.SelectedIndexChanged += new System.EventHandler(this.minuteBox1_SelectedIndexChanged);
            // 
            // hourBox2
            // 
            this.hourBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.hourBox2.FormattingEnabled = true;
            this.hourBox2.Location = new System.Drawing.Point(62, 340);
            this.hourBox2.Name = "hourBox2";
            this.hourBox2.Size = new System.Drawing.Size(98, 27);
            this.hourBox2.TabIndex = 15;
            this.hourBox2.Text = "Hour";
            this.hourBox2.SelectedIndexChanged += new System.EventHandler(this.hourBox2_SelectedIndexChanged);
            // 
            // minuteBox2
            // 
            this.minuteBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.minuteBox2.FormattingEnabled = true;
            this.minuteBox2.Location = new System.Drawing.Point(178, 340);
            this.minuteBox2.Name = "minuteBox2";
            this.minuteBox2.Size = new System.Drawing.Size(98, 27);
            this.minuteBox2.TabIndex = 16;
            this.minuteBox2.Text = "Minute";
            this.minuteBox2.SelectedIndexChanged += new System.EventHandler(this.minuteBox2_SelectedIndexChanged);
            // 
            // AppointmentTitle
            // 
            this.AppointmentTitle.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F);
            this.AppointmentTitle.Location = new System.Drawing.Point(62, 64);
            this.AppointmentTitle.Name = "AppointmentTitle";
            this.AppointmentTitle.Size = new System.Drawing.Size(414, 26);
            this.AppointmentTitle.TabIndex = 17;
            this.AppointmentTitle.Text = "Appointment Title";
            this.AppointmentTitle.TextChanged += new System.EventHandler(this.AppointmentTitle_TextChanged);
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 385);
            this.Controls.Add(this.AppointmentTitle);
            this.Controls.Add(this.minuteBox2);
            this.Controls.Add(this.hourBox2);
            this.Controls.Add(this.minuteBox1);
            this.Controls.Add(this.hourBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentDetails);
            this.Controls.Add(this.AppointmentDescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewAppointment";
            this.Text = "New Appointment ";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentDescriptionLabel;
        private System.Windows.Forms.TextBox AppointmentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox hourBox1;
        private System.Windows.Forms.ComboBox minuteBox1;
        private System.Windows.Forms.ComboBox hourBox2;
        private System.Windows.Forms.ComboBox minuteBox2;
        private System.Windows.Forms.TextBox AppointmentTitle;
    }
}