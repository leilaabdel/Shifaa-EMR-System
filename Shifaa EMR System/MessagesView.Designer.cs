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
            this.MessageTitleLabel = new System.Windows.Forms.Label();
            this.ConversationFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MessageTitleLabel);
            this.panel2.Controls.Add(this.NewMessageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 69);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.richTextBox1.Size = new System.Drawing.Size(0, 1550);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // MessageTitleLabel
            // 
            this.MessageTitleLabel.AutoSize = true;
            this.MessageTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.MessageTitleLabel.Location = new System.Drawing.Point(521, 31);
            this.MessageTitleLabel.Name = "MessageTitleLabel";
            this.MessageTitleLabel.Size = new System.Drawing.Size(173, 23);
            this.MessageTitleLabel.TabIndex = 0;
            this.MessageTitleLabel.Text = "This Message Label";
            this.MessageTitleLabel.Click += new System.EventHandler(this.MessageTitleLabel_Click);
            // 
            // ConversationFlowPanel
            // 
            this.ConversationFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConversationFlowPanel.Location = new System.Drawing.Point(513, 135);
            this.ConversationFlowPanel.Name = "ConversationFlowPanel";
            this.ConversationFlowPanel.Size = new System.Drawing.Size(725, 1575);
            this.ConversationFlowPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 972);
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
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 62);
            this.panel4.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(-33, 399);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(266, 175);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(262, 27);
            this.toolStripMenuItem1.Text = "Contacts";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(262, 27);
            this.toolStripMenuItem2.Text = "Messages";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(262, 27);
            this.toolStripMenuItem3.Text = "Fees";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(262, 27);
            this.toolStripMenuItem4.Text = "Reports";
            // 
            // MessagesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1480, 982);
            this.Controls.Add(this.messageListFlowPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConversationFlowPanel);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        public System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}