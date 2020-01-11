namespace Shifaa_EMR_System
{
    partial class ConversationItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversationItem));
            this.SenderLabel = new System.Windows.Forms.Label();
            this.ReceiverNameLabel = new System.Windows.Forms.Label();
            this.DateTimeSent = new System.Windows.Forms.Label();
            this.MessageContentBox = new System.Windows.Forms.RichTextBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.EditDraftButton = new System.Windows.Forms.Button();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.BackColor = System.Drawing.Color.White;
            this.SenderLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SenderLabel.Location = new System.Drawing.Point(63, 11);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(55, 17);
            this.SenderLabel.TabIndex = 3;
            this.SenderLabel.Text = "Sender";
            // 
            // ReceiverNameLabel
            // 
            this.ReceiverNameLabel.AutoSize = true;
            this.ReceiverNameLabel.BackColor = System.Drawing.Color.White;
            this.ReceiverNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.ReceiverNameLabel.Location = new System.Drawing.Point(48, 60);
            this.ReceiverNameLabel.Name = "ReceiverNameLabel";
            this.ReceiverNameLabel.Size = new System.Drawing.Size(53, 14);
            this.ReceiverNameLabel.TabIndex = 4;
            this.ReceiverNameLabel.Text = "Receiver";
            // 
            // DateTimeSent
            // 
            this.DateTimeSent.AutoSize = true;
            this.DateTimeSent.BackColor = System.Drawing.Color.White;
            this.DateTimeSent.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.DateTimeSent.ForeColor = System.Drawing.Color.Gray;
            this.DateTimeSent.Location = new System.Drawing.Point(20, 38);
            this.DateTimeSent.Name = "DateTimeSent";
            this.DateTimeSent.Size = new System.Drawing.Size(121, 14);
            this.DateTimeSent.TabIndex = 5;
            this.DateTimeSent.Text = "Mon 1/6/2020 5:43 PM";
            // 
            // MessageContentBox
            // 
            this.MessageContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageContentBox.BackColor = System.Drawing.Color.White;
            this.MessageContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageContentBox.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.MessageContentBox.Location = new System.Drawing.Point(23, 98);
            this.MessageContentBox.Name = "MessageContentBox";
            this.MessageContentBox.ReadOnly = true;
            this.MessageContentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MessageContentBox.Size = new System.Drawing.Size(616, 179);
            this.MessageContentBox.TabIndex = 6;
            this.MessageContentBox.Text = "";
            this.MessageContentBox.TextChanged += new System.EventHandler(this.MessageContentBox_TextChanged);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardButton.BackColor = System.Drawing.Color.White;
            this.ForwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardButton.BackgroundImage")));
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Location = new System.Drawing.Point(610, 61);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(17, 15);
            this.ForwardButton.TabIndex = 7;
            this.ForwardButton.Text = " ";
            this.ForwardButton.UseVisualStyleBackColor = false;
            // 
            // ReplyButton
            // 
            this.ReplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplyButton.BackColor = System.Drawing.Color.White;
            this.ReplyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReplyButton.BackgroundImage")));
            this.ReplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReplyButton.FlatAppearance.BorderSize = 0;
            this.ReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyButton.Location = new System.Drawing.Point(574, 60);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(25, 20);
            this.ReplyButton.TabIndex = 4;
            this.ReplyButton.Text = " ";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // EditDraftButton
            // 
            this.EditDraftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditDraftButton.BackColor = System.Drawing.Color.White;
            this.EditDraftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditDraftButton.BackgroundImage")));
            this.EditDraftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditDraftButton.FlatAppearance.BorderSize = 0;
            this.EditDraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDraftButton.Location = new System.Drawing.Point(580, 59);
            this.EditDraftButton.Name = "EditDraftButton";
            this.EditDraftButton.Size = new System.Drawing.Size(19, 20);
            this.EditDraftButton.TabIndex = 8;
            this.EditDraftButton.Text = " ";
            this.EditDraftButton.UseVisualStyleBackColor = false;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.BackColor = System.Drawing.Color.White;
            this.FromLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.FromLabel.Location = new System.Drawing.Point(18, 11);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(45, 17);
            this.FromLabel.TabIndex = 9;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel1
            // 
            this.ToLabel1.AutoSize = true;
            this.ToLabel1.BackColor = System.Drawing.Color.White;
            this.ToLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.ToLabel1.Location = new System.Drawing.Point(20, 60);
            this.ToLabel1.Name = "ToLabel1";
            this.ToLabel1.Size = new System.Drawing.Size(22, 14);
            this.ToLabel1.TabIndex = 10;
            this.ToLabel1.Text = "To:";
            // 
            // ConversationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ToLabel1);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.ReplyButton);
            this.Controls.Add(this.MessageContentBox);
            this.Controls.Add(this.DateTimeSent);
            this.Controls.Add(this.ReceiverNameLabel);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.EditDraftButton);
            this.Name = "ConversationItem";
            this.Size = new System.Drawing.Size(670, 301);
            this.Load += new System.EventHandler(this.ConversationItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label ReceiverNameLabel;
        private System.Windows.Forms.Label DateTimeSent;
        private System.Windows.Forms.RichTextBox MessageContentBox;
        public System.Windows.Forms.Button ReplyButton;
        public System.Windows.Forms.Button ForwardButton;
        public System.Windows.Forms.Button EditDraftButton;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel1;
    }
}