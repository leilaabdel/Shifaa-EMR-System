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
            this.MessageTitleLabel = new System.Windows.Forms.Label();
            this.NewMessageButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ConversationFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JunkButton = new System.Windows.Forms.Button();
            this.DraftsButton = new System.Windows.Forms.Button();
            this.SentButton = new System.Windows.Forms.Button();
            this.InboxButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.messageListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.MessageTableAdapter();
            this.ContactsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allEmployeesTableAdapter1 = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.AllEmployeesTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MessageTitleLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.NewMessageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1480, 69);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MessageTitleLabel
            // 
            this.MessageTitleLabel.AutoSize = true;
            this.MessageTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.MessageTitleLabel.Location = new System.Drawing.Point(521, 25);
            this.MessageTitleLabel.Name = "MessageTitleLabel";
            this.MessageTitleLabel.Size = new System.Drawing.Size(173, 23);
            this.MessageTitleLabel.TabIndex = 0;
            this.MessageTitleLabel.Text = "This Message Label";
            this.MessageTitleLabel.Click += new System.EventHandler(this.MessageTitleLabel_Click);
            // 
            // NewMessageButton
            // 
            this.NewMessageButton.AutoSize = true;
            this.NewMessageButton.BackColor = System.Drawing.Color.Azure;
            this.NewMessageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NewMessageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewMessageButton.FlatAppearance.BorderSize = 0;
            this.NewMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMessageButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.NewMessageButton.Location = new System.Drawing.Point(28, 17);
            this.NewMessageButton.Name = "NewMessageButton";
            this.NewMessageButton.Size = new System.Drawing.Size(142, 35);
            this.NewMessageButton.TabIndex = 52;
            this.NewMessageButton.Text = "New Message";
            this.NewMessageButton.UseVisualStyleBackColor = false;
            this.NewMessageButton.Click += new System.EventHandler(this.NewMessageButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(-107, 281);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(0, 846);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // ConversationFlowPanel
            // 
            this.ConversationFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConversationFlowPanel.AutoScroll = true;
            this.ConversationFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConversationFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConversationFlowPanel.Location = new System.Drawing.Point(482, 120);
            this.ConversationFlowPanel.Name = "ConversationFlowPanel";
            this.ConversationFlowPanel.Size = new System.Drawing.Size(831, 870);
            this.ConversationFlowPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.JunkButton);
            this.panel1.Controls.Add(this.DraftsButton);
            this.panel1.Controls.Add(this.SentButton);
            this.panel1.Controls.Add(this.InboxButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 871);
            this.panel1.TabIndex = 7;
            // 
            // JunkButton
            // 
            this.JunkButton.AutoSize = true;
            this.JunkButton.BackColor = System.Drawing.Color.Azure;
            this.JunkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.JunkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JunkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.JunkButton.FlatAppearance.BorderSize = 0;
            this.JunkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JunkButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.JunkButton.Location = new System.Drawing.Point(0, 167);
            this.JunkButton.Name = "JunkButton";
            this.JunkButton.Size = new System.Drawing.Size(198, 35);
            this.JunkButton.TabIndex = 56;
            this.JunkButton.Text = "Junk";
            this.JunkButton.UseVisualStyleBackColor = false;
            this.JunkButton.Click += new System.EventHandler(this.JunkButton_Click);
            // 
            // DraftsButton
            // 
            this.DraftsButton.AutoSize = true;
            this.DraftsButton.BackColor = System.Drawing.Color.Azure;
            this.DraftsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DraftsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraftsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DraftsButton.FlatAppearance.BorderSize = 0;
            this.DraftsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftsButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.DraftsButton.Location = new System.Drawing.Point(0, 132);
            this.DraftsButton.Name = "DraftsButton";
            this.DraftsButton.Size = new System.Drawing.Size(198, 35);
            this.DraftsButton.TabIndex = 55;
            this.DraftsButton.Text = "Drafts";
            this.DraftsButton.UseVisualStyleBackColor = false;
            this.DraftsButton.Click += new System.EventHandler(this.DraftsButton_Click);
            // 
            // SentButton
            // 
            this.SentButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.SentButton.AutoSize = true;
            this.SentButton.BackColor = System.Drawing.Color.Azure;
            this.SentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.SentButton.FlatAppearance.BorderSize = 0;
            this.SentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SentButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.SentButton.Location = new System.Drawing.Point(0, 97);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(198, 35);
            this.SentButton.TabIndex = 54;
            this.SentButton.Text = "Sent";
            this.SentButton.UseVisualStyleBackColor = false;
            this.SentButton.Click += new System.EventHandler(this.SentButton_Click);
            // 
            // InboxButton
            // 
            this.InboxButton.AutoSize = true;
            this.InboxButton.BackColor = System.Drawing.Color.Azure;
            this.InboxButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InboxButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InboxButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.InboxButton.FlatAppearance.BorderSize = 0;
            this.InboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InboxButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.InboxButton.Location = new System.Drawing.Point(0, 62);
            this.InboxButton.Name = "InboxButton";
            this.InboxButton.Size = new System.Drawing.Size(198, 35);
            this.InboxButton.TabIndex = 53;
            this.InboxButton.Text = "Inbox";
            this.InboxButton.UseVisualStyleBackColor = false;
            this.InboxButton.Click += new System.EventHandler(this.InboxButton_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 62);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.FilterButton);
            this.panel3.Controls.Add(this.TypeLabel);
            this.panel3.Location = new System.Drawing.Point(202, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 45);
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
            this.FilterButton.Location = new System.Drawing.Point(200, 3);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(72, 35);
            this.FilterButton.TabIndex = 53;
            this.FilterButton.Text = "Filter v";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.TypeLabel.Location = new System.Drawing.Point(18, 10);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(56, 23);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Inbox";
            // 
            // messageListFlowPanel
            // 
            this.messageListFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.messageListFlowPanel.AutoScroll = true;
            this.messageListFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageListFlowPanel.Location = new System.Drawing.Point(203, 120);
            this.messageListFlowPanel.Name = "messageListFlowPanel";
            this.messageListFlowPanel.Size = new System.Drawing.Size(286, 870);
            this.messageListFlowPanel.TabIndex = 9;
            this.messageListFlowPanel.Click += new System.EventHandler(this.MessageListFlowPanelClick);
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ContactsToolStripItem
            // 
            this.ContactsToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsToolStripItem.Name = "ContactsToolStripItem";
            this.ContactsToolStripItem.Size = new System.Drawing.Size(262, 27);
            this.ContactsToolStripItem.Text = "Contacts";
            // 
            // MessagesToolStripItem
            // 
            this.MessagesToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MessagesToolStripItem.Name = "MessagesToolStripItem";
            this.MessagesToolStripItem.Size = new System.Drawing.Size(262, 27);
            this.MessagesToolStripItem.Text = "Messages";
            // 
            // proceduresToolStripMenuItem
            // 
            this.proceduresToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.proceduresToolStripMenuItem.Name = "proceduresToolStripMenuItem";
            this.proceduresToolStripMenuItem.Size = new System.Drawing.Size(262, 27);
            this.proceduresToolStripMenuItem.Text = "Fees";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(262, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // allEmployeesTableAdapter1
            // 
            this.allEmployeesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1316, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 871);
            this.panel5.TabIndex = 10;
            // 
            // MessagesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1480, 990);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.messageListFlowPanel);
            this.Controls.Add(this.ConversationFlowPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagesView";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.Text = "MessagesView";
            this.Load += new System.EventHandler(this.MessagesView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.ToolStripMenuItem ContactsToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem proceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button JunkButton;
        private System.Windows.Forms.Button DraftsButton;
        private System.Windows.Forms.Button SentButton;
        private System.Windows.Forms.Button InboxButton;
        private EMRDatabaseDataSetTableAdapters.AllEmployeesTableAdapter allEmployeesTableAdapter1;
        private System.Windows.Forms.Panel panel5;
    }
}