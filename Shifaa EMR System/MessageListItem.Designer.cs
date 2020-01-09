namespace Shifaa_EMR_System
{
    partial class MessageListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SenderLabel = new System.Windows.Forms.Label();
            this.ReadPanel = new System.Windows.Forms.Panel();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.MarkAsNotReadButton = new System.Windows.Forms.Button();
            this.MarkAsReadButton = new System.Windows.Forms.Button();
            this.DeleteMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.BackColor = System.Drawing.Color.White;
            this.SenderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SenderLabel.Location = new System.Drawing.Point(19, 10);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(146, 21);
            this.SenderLabel.TabIndex = 2;
            this.SenderLabel.Text = "Sender";
            // 
            // ReadPanel
            // 
            this.ReadPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReadPanel.Location = new System.Drawing.Point(0, 0);
            this.ReadPanel.Name = "ReadPanel";
            this.ReadPanel.Size = new System.Drawing.Size(10, 85);
            this.ReadPanel.TabIndex = 3;
            this.ReadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.BackColor = System.Drawing.Color.White;
            this.SubjectLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubjectLabel.Location = new System.Drawing.Point(19, 32);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(204, 23);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "> Subejct";
            this.SubjectLabel.Click += new System.EventHandler(this.SubjectLabel_Click);
            // 
            // ContentLabel
            // 
            this.ContentLabel.BackColor = System.Drawing.Color.White;
            this.ContentLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ContentLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ContentLabel.Location = new System.Drawing.Point(19, 55);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(204, 20);
            this.ContentLabel.TabIndex = 5;
            this.ContentLabel.Text = "Content...";
            this.ContentLabel.Click += new System.EventHandler(this.ContentLabel_Click);
            // 
            // MarkAsNotReadButton
            // 
            this.MarkAsNotReadButton.BackColor = System.Drawing.Color.White;
            this.MarkAsNotReadButton.BackgroundImage = global::Shifaa_EMR_System.Properties.Resources.ClosedLetter;
            this.MarkAsNotReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkAsNotReadButton.FlatAppearance.BorderSize = 0;
            this.MarkAsNotReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkAsNotReadButton.Location = new System.Drawing.Point(204, 14);
            this.MarkAsNotReadButton.Name = "MarkAsNotReadButton";
            this.MarkAsNotReadButton.Size = new System.Drawing.Size(19, 15);
            this.MarkAsNotReadButton.TabIndex = 3;
            this.MarkAsNotReadButton.Text = " ";
            this.MarkAsNotReadButton.UseVisualStyleBackColor = false;
            this.MarkAsNotReadButton.Click += new System.EventHandler(this.MarkAsNotReadButton_Click);
            // 
            // MarkAsReadButton
            // 
            this.MarkAsReadButton.BackColor = System.Drawing.Color.White;
            this.MarkAsReadButton.BackgroundImage = global::Shifaa_EMR_System.Properties.Resources.OpenLetter;
            this.MarkAsReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkAsReadButton.FlatAppearance.BorderSize = 0;
            this.MarkAsReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkAsReadButton.Location = new System.Drawing.Point(202, 7);
            this.MarkAsReadButton.Name = "MarkAsReadButton";
            this.MarkAsReadButton.Size = new System.Drawing.Size(24, 25);
            this.MarkAsReadButton.TabIndex = 2;
            this.MarkAsReadButton.Text = " ";
            this.MarkAsReadButton.UseVisualStyleBackColor = false;
            this.MarkAsReadButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteMessageButton
            // 
            this.DeleteMessageButton.BackColor = System.Drawing.Color.White;
            this.DeleteMessageButton.BackgroundImage = global::Shifaa_EMR_System.Properties.Resources.GarbageCan;
            this.DeleteMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteMessageButton.FlatAppearance.BorderSize = 0;
            this.DeleteMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMessageButton.Location = new System.Drawing.Point(183, 8);
            this.DeleteMessageButton.Name = "DeleteMessageButton";
            this.DeleteMessageButton.Size = new System.Drawing.Size(17, 21);
            this.DeleteMessageButton.TabIndex = 0;
            this.DeleteMessageButton.Text = " ";
            this.DeleteMessageButton.UseVisualStyleBackColor = false;
            this.DeleteMessageButton.Click += new System.EventHandler(this.DeleteMessageButton_Click);
            // 
            // MessageListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ReadPanel);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.DeleteMessageButton);
            this.Controls.Add(this.MarkAsNotReadButton);
            this.Controls.Add(this.MarkAsReadButton);
            this.Name = "MessageListItem";
            this.Size = new System.Drawing.Size(230, 85);
            this.Load += new System.EventHandler(this.MessageListItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label SenderLabel;
        public System.Windows.Forms.Panel ReadPanel;
        public System.Windows.Forms.Label SubjectLabel;
        public System.Windows.Forms.Label ContentLabel;
        public System.Windows.Forms.Button MarkAsReadButton;
        public System.Windows.Forms.Button DeleteMessageButton;
        public System.Windows.Forms.Button MarkAsNotReadButton;
    }
}
