namespace Shifaa_EMR_System
{
    partial class CredentialVerification
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PassCodeLabel = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PassCodeBox = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(61, 47);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 19);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username ";
            // 
            // PassCodeLabel
            // 
            this.PassCodeLabel.AutoSize = true;
            this.PassCodeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCodeLabel.Location = new System.Drawing.Point(66, 96);
            this.PassCodeLabel.Name = "PassCodeLabel";
            this.PassCodeLabel.Size = new System.Drawing.Size(82, 19);
            this.PassCodeLabel.TabIndex = 3;
            this.PassCodeLabel.Text = "Passcode ";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(184, 51);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(189, 27);
            this.UsernameBox.TabIndex = 4;
            // 
            // PassCodeBox
            // 
            this.PassCodeBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCodeBox.Location = new System.Drawing.Point(184, 96);
            this.PassCodeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassCodeBox.Name = "PassCodeBox";
            this.PassCodeBox.Size = new System.Drawing.Size(189, 27);
            this.PassCodeBox.TabIndex = 5;
            // 
            // VerifyButton
            // 
            this.VerifyButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.Location = new System.Drawing.Point(229, 151);
            this.VerifyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(75, 35);
            this.VerifyButton.TabIndex = 6;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(109, 151);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CredentialVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 235);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.PassCodeBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PassCodeLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CredentialVerification";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PassCodeLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PassCodeBox;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

