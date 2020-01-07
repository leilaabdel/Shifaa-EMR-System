namespace Shifaa_EMR_System
{
    partial class MessagesView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewMessageButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.InboxToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SentToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DraftsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JunkToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageTitleLabel = new System.Windows.Forms.Label();
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.ConversationFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.messageListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.MessageTableAdapter();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewMessageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 69);
            this.panel2.TabIndex = 3;
            // 
            // NewMessageButton
            // 
            this.NewMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewMessageButton.AutoSize = true;
            this.NewMessageButton.BackColor = System.Drawing.Color.Azure;
            this.NewMessageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NewMessageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewMessageButton.FlatAppearance.BorderSize = 0;
            this.NewMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMessageButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.NewMessageButton.Location = new System.Drawing.Point(38, 18);
            this.NewMessageButton.Name = "NewMessageButton";
            this.NewMessageButton.Size = new System.Drawing.Size(142, 35);
            this.NewMessageButton.TabIndex = 52;
            this.NewMessageButton.Text = "New Message";
            this.NewMessageButton.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(-107, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(0, 1055);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InboxToolStripItem,
            this.SentToolStripItem,
            this.DraftsToolStripItem,
            this.JunkToolStripItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(200, 175);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // InboxToolStripItem
            // 
            this.InboxToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InboxToolStripItem.Name = "InboxToolStripItem";
            this.InboxToolStripItem.Size = new System.Drawing.Size(196, 27);
            this.InboxToolStripItem.Text = "Inbox";
            this.InboxToolStripItem.Click += new System.EventHandler(this.InboxToolStripItem_Click_1);
            // 
            // SentToolStripItem
            // 
            this.SentToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.SentToolStripItem.Name = "SentToolStripItem";
            this.SentToolStripItem.Size = new System.Drawing.Size(196, 27);
            this.SentToolStripItem.Text = "Sent";
            this.SentToolStripItem.Click += new System.EventHandler(this.SentToolStripItem_Click);
            // 
            // DraftsToolStripItem
            // 
            this.DraftsToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DraftsToolStripItem.Name = "DraftsToolStripItem";
            this.DraftsToolStripItem.Size = new System.Drawing.Size(196, 27);
            this.DraftsToolStripItem.Text = "Drafts";
            this.DraftsToolStripItem.Click += new System.EventHandler(this.DraftsToolStripItem_Click);
            // 
            // JunkToolStripItem
            // 
            this.JunkToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.JunkToolStripItem.Name = "JunkToolStripItem";
            this.JunkToolStripItem.Size = new System.Drawing.Size(196, 27);
            this.JunkToolStripItem.Text = "Junk";
            this.JunkToolStripItem.Click += new System.EventHandler(this.JunkToolStripItem_Click);
            // 
            // MessageTitleLabel
            // 
            this.MessageTitleLabel.AutoSize = true;
            this.MessageTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.MessageTitleLabel.Location = new System.Drawing.Point(514, 81);
            this.MessageTitleLabel.Name = "MessageTitleLabel";
            this.MessageTitleLabel.Size = new System.Drawing.Size(173, 23);
            this.MessageTitleLabel.TabIndex = 0;
            this.MessageTitleLabel.Text = "This Message Label";
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConversationFlowPanel
            // 
            this.ConversationFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConversationFlowPanel.Location = new System.Drawing.Point(518, 120);
            this.ConversationFlowPanel.Name = "ConversationFlowPanel";
            this.ConversationFlowPanel.Size = new System.Drawing.Size(810, 1080);
            this.ConversationFlowPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1022);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FilterButton);
            this.panel3.Controls.Add(this.TypeLabel);
            this.panel3.Location = new System.Drawing.Point(206, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 45);
            this.panel3.TabIndex = 8;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.AutoSize = true;
            this.FilterButton.BackColor = System.Drawing.SystemColors.Control;
            this.FilterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FilterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.FilterButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.FilterButton.Location = new System.Drawing.Point(199, 6);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(72, 35);
            this.FilterButton.TabIndex = 53;
            this.FilterButton.Text = "Filter v";
            this.FilterButton.UseVisualStyleBackColor = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.TypeLabel.Location = new System.Drawing.Point(18, 12);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(56, 23);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Inbox";
            // 
            // messageListFlowPanel
            // 
            this.messageListFlowPanel.AutoScroll = true;
            this.messageListFlowPanel.Location = new System.Drawing.Point(203, 120);
            this.messageListFlowPanel.Name = "messageListFlowPanel";
            this.messageListFlowPanel.Size = new System.Drawing.Size(286, 971);
            this.messageListFlowPanel.TabIndex = 9;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "Message";
            this.messageBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // MessagesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1395, 982);
            this.Controls.Add(this.MessageTitleLabel);
            this.Controls.Add(this.messageListFlowPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConversationFlowPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagesView";
            this.Text = "MessagesView";
            this.Load += new System.EventHandler(this.MessagesView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem InboxToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem SentToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem DraftsToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem JunkToolStripItem;
        private System.Windows.Forms.Label MessageTitleLabel;
        private System.Windows.Forms.Button NewMessageButton;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private EMRDatabaseDataSetTableAdapters.MessageTableAdapter messageTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel ConversationFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.FlowLayoutPanel messageListFlowPanel;
    }
}