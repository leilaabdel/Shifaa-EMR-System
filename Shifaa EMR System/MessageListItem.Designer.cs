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
            this.MessageMainPanel = new System.Windows.Forms.Panel();
            this.MarkAsNotReadButton = new System.Windows.Forms.Button();
            this.MarkAsReadButton = new System.Windows.Forms.Button();
            this.DeleteMessageButton = new System.Windows.Forms.Button();
            this.MessageMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.BackColor = System.Drawing.Color.White;
            this.SenderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SenderLabel.Location = new System.Drawing.Point(31, 10);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(55, 17);
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
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.White;
            this.SubjectLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubjectLabel.Location = new System.Drawing.Point(31, 32);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(65, 17);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "> Subejct";
            // 
            // ContentLabel
            // 
            this.ContentLabel.BackColor = System.Drawing.Color.White;
            this.ContentLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ContentLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ContentLabel.Location = new System.Drawing.Point(31, 55);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(68, 17);
            this.ContentLabel.TabIndex = 5;
            this.ContentLabel.Text = "Content...";
            // 
            // MessageMainPanel
            // 
            this.MessageMainPanel.BackColor = System.Drawing.Color.White;
            this.MessageMainPanel.Controls.Add(this.MarkAsNotReadButton);
            this.MessageMainPanel.Controls.Add(this.MarkAsReadButton);
            this.MessageMainPanel.Controls.Add(this.DeleteMessageButton);
            this.MessageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageMainPanel.Location = new System.Drawing.Point(0, 0);
            this.MessageMainPanel.Name = "MessageMainPanel";
            this.MessageMainPanel.Size = new System.Drawing.Size(286, 85);
            this.MessageMainPanel.TabIndex = 6;
            this.MessageMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MessageMainPanel_Paint);
            // 
            // MarkAsNotReadButton
            // 
            this.MarkAsNotReadButton.BackColor = System.Drawing.Color.White;
            this.MarkAsNotReadButton.BackgroundImage = global::Shifaa_EMR_System.Properties.Resources.ClosedLetter;
            this.MarkAsNotReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkAsNotReadButton.FlatAppearance.BorderSize = 0;
            this.MarkAsNotReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkAsNotReadButton.Location = new System.Drawing.Point(246, 12);
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
            this.MarkAsReadButton.Location = new System.Drawing.Point(245, 6);
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
            this.DeleteMessageButton.Location = new System.Drawing.Point(225, 10);
            this.DeleteMessageButton.Name = "DeleteMessageButton";
            this.DeleteMessageButton.Size = new System.Drawing.Size(15, 17);
            this.DeleteMessageButton.TabIndex = 0;
            this.DeleteMessageButton.Text = " ";
            this.DeleteMessageButton.UseVisualStyleBackColor = false;
            this.DeleteMessageButton.Click += new System.EventHandler(this.DeleteMessageButton_Click);
            // 
            // MessageListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ReadPanel);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.MessageMainPanel);
            this.Name = "MessageListItem";
            this.Size = new System.Drawing.Size(286, 85);
            this.Load += new System.EventHandler(this.MessageListItem_Load);
            this.MessageMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Panel ReadPanel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Panel MessageMainPanel;
        private System.Windows.Forms.Button MarkAsReadButton;
        private System.Windows.Forms.Button DeleteMessageButton;
        private System.Windows.Forms.Button MarkAsNotReadButton;
    }
}
