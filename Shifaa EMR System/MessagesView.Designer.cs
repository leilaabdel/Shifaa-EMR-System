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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesView));
            this.MessageTable = new System.Windows.Forms.DataGridView();
            this.MessageIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.StatusButtonToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.messageTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.MessageTableAdapter();
            this.MessageContentViewBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MessagesToolStrip = new System.Windows.Forms.MenuStrip();
            this.SentItemsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DraftsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InboxToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletedItemsMenuToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMedicationButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ToLabel = new System.Windows.Forms.Label();
            this.MessageContent1 = new System.Windows.Forms.RichTextBox();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SaveDraftButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DraftPanel = new System.Windows.Forms.Panel();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.ReplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MessagesToolStrip.SuspendLayout();
            this.DraftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTable
            // 
            this.MessageTable.AllowUserToAddRows = false;
            this.MessageTable.AllowUserToDeleteRows = false;
            this.MessageTable.AutoGenerateColumns = false;
            this.MessageTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MessageTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MessageTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MessageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageTable.ColumnHeadersVisible = false;
            this.MessageTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageIDNumber,
            this.SenderName,
            this.SenderID,
            this.RecipientName,
            this.RecipientID,
            this.DateTimeSent,
            this.Status,
            this.MessageTitle,
            this.MessageContent});
            this.MessageTable.DataSource = this.messageBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MessageTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.MessageTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageTable.Location = new System.Drawing.Point(216, 103);
            this.MessageTable.Name = "MessageTable";
            this.MessageTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MessageTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MessageTable.RowHeadersVisible = false;
            this.MessageTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTable.Size = new System.Drawing.Size(395, 736);
            this.MessageTable.TabIndex = 53;
            this.MessageTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessageTable_CellClick);
            this.MessageTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessageTable_CellContentClick);
            // 
            // MessageIDNumber
            // 
            this.MessageIDNumber.DataPropertyName = "MessageIDNumber";
            this.MessageIDNumber.HeaderText = "MessageIDNumber";
            this.MessageIDNumber.Name = "MessageIDNumber";
            this.MessageIDNumber.ReadOnly = true;
            this.MessageIDNumber.Visible = false;
            // 
            // SenderName
            // 
            this.SenderName.DataPropertyName = "SenderName";
            this.SenderName.HeaderText = "From";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            // 
            // SenderID
            // 
            this.SenderID.DataPropertyName = "SenderID";
            this.SenderID.HeaderText = "SenderID";
            this.SenderID.Name = "SenderID";
            this.SenderID.ReadOnly = true;
            this.SenderID.Visible = false;
            // 
            // RecipientName
            // 
            this.RecipientName.DataPropertyName = "RecipientName";
            this.RecipientName.HeaderText = "RecipientName";
            this.RecipientName.Name = "RecipientName";
            this.RecipientName.ReadOnly = true;
            this.RecipientName.Visible = false;
            // 
            // RecipientID
            // 
            this.RecipientID.DataPropertyName = "RecipientID";
            this.RecipientID.HeaderText = "RecipientID";
            this.RecipientID.Name = "RecipientID";
            this.RecipientID.ReadOnly = true;
            this.RecipientID.Visible = false;
            // 
            // DateTimeSent
            // 
            this.DateTimeSent.DataPropertyName = "DateTimeSent";
            this.DateTimeSent.HeaderText = "Date";
            this.DateTimeSent.Name = "DateTimeSent";
            this.DateTimeSent.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // MessageTitle
            // 
            this.MessageTitle.DataPropertyName = "MessageTitle";
            this.MessageTitle.HeaderText = "Title";
            this.MessageTitle.Name = "MessageTitle";
            this.MessageTitle.ReadOnly = true;
            // 
            // MessageContent
            // 
            this.MessageContent.DataPropertyName = "MessageContent";
            this.MessageContent.HeaderText = "MessageContent";
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.ReadOnly = true;
            this.MessageContent.Visible = false;
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // MessageContentViewBox
            // 
            this.MessageContentViewBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageContentViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageContentViewBox.Location = new System.Drawing.Point(0, 0);
            this.MessageContentViewBox.Name = "MessageContentViewBox";
            this.MessageContentViewBox.Size = new System.Drawing.Size(723, 678);
            this.MessageContentViewBox.TabIndex = 54;
            this.MessageContentViewBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MessageContentViewBox);
            this.panel1.Location = new System.Drawing.Point(622, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 678);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MessagesToolStrip);
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 733);
            this.panel2.TabIndex = 57;
            // 
            // MessagesToolStrip
            // 
            this.MessagesToolStrip.AutoSize = false;
            this.MessagesToolStrip.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MessagesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MessagesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SentItemsToolStrip,
            this.DraftsToolStripItem,
            this.InboxToolStripItem,
            this.DeletedItemsMenuToolStripItem});
            this.MessagesToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MessagesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MessagesToolStrip.Name = "MessagesToolStrip";
            this.MessagesToolStrip.Size = new System.Drawing.Size(207, 175);
            this.MessagesToolStrip.TabIndex = 58;
            this.MessagesToolStrip.Text = "menuStrip2";
            // 
            // SentItemsToolStrip
            // 
            this.SentItemsToolStrip.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentItemsToolStrip.Name = "SentItemsToolStrip";
            this.SentItemsToolStrip.Size = new System.Drawing.Size(203, 27);
            this.SentItemsToolStrip.Text = "Sent Items";
            this.SentItemsToolStrip.Click += new System.EventHandler(this.SentItemsToolStrip_Click);
            // 
            // DraftsToolStripItem
            // 
            this.DraftsToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DraftsToolStripItem.Name = "DraftsToolStripItem";
            this.DraftsToolStripItem.Size = new System.Drawing.Size(203, 27);
            this.DraftsToolStripItem.Text = "Drafts";
            this.DraftsToolStripItem.Click += new System.EventHandler(this.DraftsToolStripItem_Click);
            // 
            // InboxToolStripItem
            // 
            this.InboxToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.InboxToolStripItem.Name = "InboxToolStripItem";
            this.InboxToolStripItem.Size = new System.Drawing.Size(203, 27);
            this.InboxToolStripItem.Text = "Inbox";
            // 
            // DeletedItemsMenuToolStripItem
            // 
            this.DeletedItemsMenuToolStripItem.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DeletedItemsMenuToolStripItem.Name = "DeletedItemsMenuToolStripItem";
            this.DeletedItemsMenuToolStripItem.Size = new System.Drawing.Size(203, 27);
            this.DeletedItemsMenuToolStripItem.Text = "Junk";
            this.DeletedItemsMenuToolStripItem.Click += new System.EventHandler(this.DeletedItemsMenuToolStripItem_Click);
            // 
            // EditMedicationButton
            // 
            this.EditMedicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditMedicationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditMedicationButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditMedicationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditMedicationButton.BackgroundImage")));
            this.EditMedicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditMedicationButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.EditMedicationButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.EditMedicationButton.FlatAppearance.BorderSize = 0;
            this.EditMedicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditMedicationButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMedicationButton.ForeColor = System.Drawing.Color.DimGray;
            this.EditMedicationButton.Location = new System.Drawing.Point(1028, 33);
            this.EditMedicationButton.Name = "EditMedicationButton";
            this.EditMedicationButton.Size = new System.Drawing.Size(38, 31);
            this.EditMedicationButton.TabIndex = 56;
            this.EditMedicationButton.UseVisualStyleBackColor = false;
            this.EditMedicationButton.Click += new System.EventHandler(this.EditMedicationButton_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.Exit.Location = new System.Drawing.Point(1072, 29);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 35);
            this.Exit.TabIndex = 52;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.ToLabel.Location = new System.Drawing.Point(43, 42);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(32, 19);
            this.ToLabel.TabIndex = 58;
            this.ToLabel.Text = "To: ";
            this.ToLabel.Visible = false;
            // 
            // MessageContent1
            // 
            this.MessageContent1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageContent1.Location = new System.Drawing.Point(20, 140);
            this.MessageContent1.Name = "MessageContent1";
            this.MessageContent1.Size = new System.Drawing.Size(684, 581);
            this.MessageContent1.TabIndex = 59;
            this.MessageContent1.Text = "";
            // 
            // DestinationBox
            // 
            this.DestinationBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.DestinationBox.Location = new System.Drawing.Point(81, 39);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(305, 27);
            this.DestinationBox.TabIndex = 60;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.BackColor = System.Drawing.SystemColors.Control;
            this.SendButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.SendButton.Location = new System.Drawing.Point(423, 31);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(98, 35);
            this.SendButton.TabIndex = 58;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SaveDraftButton
            // 
            this.SaveDraftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDraftButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveDraftButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveDraftButton.FlatAppearance.BorderSize = 0;
            this.SaveDraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDraftButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.SaveDraftButton.Location = new System.Drawing.Point(542, 31);
            this.SaveDraftButton.Name = "SaveDraftButton";
            this.SaveDraftButton.Size = new System.Drawing.Size(98, 35);
            this.SaveDraftButton.TabIndex = 61;
            this.SaveDraftButton.Text = "Save Draft";
            this.SaveDraftButton.UseVisualStyleBackColor = false;
            this.SaveDraftButton.Click += new System.EventHandler(this.SaveDraftButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.CancelButton.Location = new System.Drawing.Point(675, 34);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(32, 35);
            this.CancelButton.TabIndex = 58;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // DraftPanel
            // 
            this.DraftPanel.Controls.Add(this.SubjectBox);
            this.DraftPanel.Controls.Add(this.SubjectLabel);
            this.DraftPanel.Controls.Add(this.CancelButton);
            this.DraftPanel.Controls.Add(this.SaveDraftButton);
            this.DraftPanel.Controls.Add(this.SendButton);
            this.DraftPanel.Controls.Add(this.DestinationBox);
            this.DraftPanel.Controls.Add(this.MessageContent1);
            this.DraftPanel.Controls.Add(this.ToLabel);
            this.DraftPanel.Location = new System.Drawing.Point(622, 103);
            this.DraftPanel.Name = "DraftPanel";
            this.DraftPanel.Size = new System.Drawing.Size(726, 739);
            this.DraftPanel.TabIndex = 55;
            // 
            // SubjectBox
            // 
            this.SubjectBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.SubjectBox.Location = new System.Drawing.Point(112, 93);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(592, 27);
            this.SubjectBox.TabIndex = 63;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.SubjectLabel.Location = new System.Drawing.Point(43, 96);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(67, 19);
            this.SubjectLabel.TabIndex = 62;
            this.SubjectLabel.Text = "Subject:";
            this.SubjectLabel.Visible = false;
            // 
            // ReplyButton
            // 
            this.ReplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplyButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReplyButton.FlatAppearance.BorderSize = 0;
            this.ReplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplyButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.ReplyButton.Location = new System.Drawing.Point(1213, 92);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(98, 35);
            this.ReplyButton.TabIndex = 58;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // MessagesView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1387, 802);
            this.ControlBox = false;
            this.Controls.Add(this.ReplyButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditMedicationButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MessageTable);
            this.Controls.Add(this.DraftPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessagesView";
            this.Padding = new System.Windows.Forms.Padding(30, 100, 30, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MessagesView_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MessageTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MessagesToolStrip.ResumeLayout(false);
            this.MessagesToolStrip.PerformLayout();
            this.DraftPanel.ResumeLayout(false);
            this.DraftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.DataGridView MessageTable;
        private System.Windows.Forms.ToolTip StatusButtonToolTIp;
        public EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private EMRDatabaseDataSetTableAdapters.MessageTableAdapter messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageContent;
        private System.Windows.Forms.RichTextBox MessageContentViewBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.MenuStrip MessagesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SentItemsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DraftsToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem InboxToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem DeletedItemsMenuToolStripItem;
        private System.Windows.Forms.Button EditMedicationButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.RichTextBox MessageContent1;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button SaveDraftButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel DraftPanel;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.TextBox SubjectBox;
        private System.Windows.Forms.Label SubjectLabel;
    }
}