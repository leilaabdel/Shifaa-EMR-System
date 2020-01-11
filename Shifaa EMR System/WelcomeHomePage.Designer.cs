namespace Shifaa_EMR_System
{
    partial class WelcomeHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeHomePage));
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.NewProviderAccountButton = new System.Windows.Forms.Button();
            this.NewSchedulerAccountButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(224, 156);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 114);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Provider ";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(450, 156);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(123, 114);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Scheduler";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // NewProviderAccountButton
            // 
            this.NewProviderAccountButton.BackColor = System.Drawing.SystemColors.Control;
            this.NewProviderAccountButton.FlatAppearance.BorderSize = 0;
            this.NewProviderAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProviderAccountButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProviderAccountButton.Location = new System.Drawing.Point(185, 316);
            this.NewProviderAccountButton.Name = "NewProviderAccountButton";
            this.NewProviderAccountButton.Size = new System.Drawing.Size(189, 56);
            this.NewProviderAccountButton.TabIndex = 2;
            this.NewProviderAccountButton.Text = "Create a New Provider Account";
            this.NewProviderAccountButton.UseVisualStyleBackColor = false;
            this.NewProviderAccountButton.Click += new System.EventHandler(this.NewProviderAccountButton_Click);
            // 
            // NewSchedulerAccountButton
            // 
            this.NewSchedulerAccountButton.BackColor = System.Drawing.SystemColors.Control;
            this.NewSchedulerAccountButton.FlatAppearance.BorderSize = 0;
            this.NewSchedulerAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSchedulerAccountButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSchedulerAccountButton.Location = new System.Drawing.Point(426, 316);
            this.NewSchedulerAccountButton.Name = "NewSchedulerAccountButton";
            this.NewSchedulerAccountButton.Size = new System.Drawing.Size(189, 56);
            this.NewSchedulerAccountButton.TabIndex = 3;
            this.NewSchedulerAccountButton.Text = "Create a New Scheduler Account";
            this.NewSchedulerAccountButton.UseVisualStyleBackColor = false;
            this.NewSchedulerAccountButton.Click += new System.EventHandler(this.NewSchedulerAccountButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(615, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 71);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewSchedulerAccountButton);
            this.Controls.Add(this.NewProviderAccountButton);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifaa Welcome";
            this.Load += new System.EventHandler(this.WelcomeHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button NewProviderAccountButton;
        private System.Windows.Forms.Button NewSchedulerAccountButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}