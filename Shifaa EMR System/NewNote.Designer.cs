namespace Shifaa_EMR_System
{
    partial class NewNote
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
            this.NewNotePanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewNoteLabel = new System.Windows.Forms.Label();
            this.NoteHistoryTable = new System.Windows.Forms.DataGridView();
            this.patientNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewNoteTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveDraftButton = new System.Windows.Forms.Button();
            this.PlanBox = new System.Windows.Forms.TextBox();
            this.AssesmentBox = new System.Windows.Forms.TextBox();
            this.ObjectiveNoteBox = new System.Windows.Forms.TextBox();
            this.SignButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SubjectiveNoteBox = new System.Windows.Forms.TextBox();
            this.NewNoteDateValue = new System.Windows.Forms.Label();
            this.NewNoteTitleBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NoteTitleLabel = new System.Windows.Forms.Label();
            this.patientNoteTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter();
            this.NoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHistoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.NewNoteTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewNotePanel
            // 
            this.NewNotePanel.BackColor = System.Drawing.Color.AliceBlue;
            this.NewNotePanel.Controls.Add(this.CancelButton);
            this.NewNotePanel.Controls.Add(this.NewNoteLabel);
            this.NewNotePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewNotePanel.Location = new System.Drawing.Point(0, 0);
            this.NewNotePanel.Name = "NewNotePanel";
            this.NewNotePanel.Size = new System.Drawing.Size(1145, 39);
            this.NewNotePanel.TabIndex = 1;
            this.NewNotePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NewNotePanel_Paint);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(1048, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 46;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewNoteLabel
            // 
            this.NewNoteLabel.AutoSize = true;
            this.NewNoteLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.NewNoteLabel.Location = new System.Drawing.Point(12, 9);
            this.NewNoteLabel.Name = "NewNoteLabel";
            this.NewNoteLabel.Size = new System.Drawing.Size(78, 19);
            this.NewNoteLabel.TabIndex = 29;
            this.NewNoteLabel.Text = "New Note";
            this.NewNoteLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteHistoryTable
            // 
            this.NoteHistoryTable.AllowUserToAddRows = false;
            this.NoteHistoryTable.AllowUserToDeleteRows = false;
            this.NoteHistoryTable.AutoGenerateColumns = false;
            this.NoteHistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NoteHistoryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NoteHistoryTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NoteHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoteID,
            this.PatientID,
            this.ProviderName,
            this.NoteTitle,
            this.NoteContent,
            this.ColumnNumber,
            this.Date,
            this.Status,
            this.noteIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn,
            this.noteTitleDataGridViewTextBoxColumn,
            this.noteContentDataGridViewTextBoxColumn,
            this.columnNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.NoteHistoryTable.DataSource = this.patientNoteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteHistoryTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.NoteHistoryTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.NoteHistoryTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteHistoryTable.Location = new System.Drawing.Point(0, 0);
            this.NoteHistoryTable.Name = "NoteHistoryTable";
            this.NoteHistoryTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.NoteHistoryTable.RowHeadersVisible = false;
            this.NoteHistoryTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteHistoryTable.Size = new System.Drawing.Size(364, 767);
            this.NoteHistoryTable.TabIndex = 46;
            this.NoteHistoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_CellContentClick);
            this.NoteHistoryTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_DoubleClick);
            // 
            // patientNoteBindingSource
            // 
            this.patientNoteBindingSource.DataMember = "PatientNote";
            this.patientNoteBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NewNoteTabControl);
            this.panel1.Controls.Add(this.NoteHistoryTable);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 767);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // NewNoteTabControl
            // 
            this.NewNoteTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNoteTabControl.Controls.Add(this.tabPage1);
            this.NewNoteTabControl.Location = new System.Drawing.Point(370, 0);
            this.NewNoteTabControl.Name = "NewNoteTabControl";
            this.NewNoteTabControl.SelectedIndex = 0;
            this.NewNoteTabControl.Size = new System.Drawing.Size(760, 767);
            this.NewNoteTabControl.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveDraftButton);
            this.tabPage1.Controls.Add(this.PlanBox);
            this.tabPage1.Controls.Add(this.AssesmentBox);
            this.tabPage1.Controls.Add(this.ObjectiveNoteBox);
            this.tabPage1.Controls.Add(this.SignButton);
            this.tabPage1.Controls.Add(this.NoteLabel);
            this.tabPage1.Controls.Add(this.SubjectiveNoteBox);
            this.tabPage1.Controls.Add(this.NewNoteDateValue);
            this.tabPage1.Controls.Add(this.NewNoteTitleBox);
            this.tabPage1.Controls.Add(this.DateLabel);
            this.tabPage1.Controls.Add(this.NoteTitleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Note";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // SaveDraftButton
            // 
            this.SaveDraftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDraftButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveDraftButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveDraftButton.FlatAppearance.BorderSize = 0;
            this.SaveDraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDraftButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SaveDraftButton.Location = new System.Drawing.Point(514, 44);
            this.SaveDraftButton.Name = "SaveDraftButton";
            this.SaveDraftButton.Size = new System.Drawing.Size(94, 26);
            this.SaveDraftButton.TabIndex = 49;
            this.SaveDraftButton.Text = "Save Draft";
            this.SaveDraftButton.UseVisualStyleBackColor = false;
            this.SaveDraftButton.Click += new System.EventHandler(this.SaveDraftButton_Click);
            // 
            // PlanBox
            // 
            this.PlanBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanBox.Location = new System.Drawing.Point(6, 563);
            this.PlanBox.Multiline = true;
            this.PlanBox.Name = "PlanBox";
            this.PlanBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlanBox.Size = new System.Drawing.Size(740, 150);
            this.PlanBox.TabIndex = 48;
            this.PlanBox.Text = "Plan:";
            this.PlanBox.Click += new System.EventHandler(this.PlanBox_Click);
            // 
            // AssesmentBox
            // 
            this.AssesmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssesmentBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssesmentBox.Location = new System.Drawing.Point(6, 407);
            this.AssesmentBox.Multiline = true;
            this.AssesmentBox.Name = "AssesmentBox";
            this.AssesmentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AssesmentBox.Size = new System.Drawing.Size(740, 150);
            this.AssesmentBox.TabIndex = 47;
            this.AssesmentBox.Text = "Assessment:";
            this.AssesmentBox.Click += new System.EventHandler(this.AssesmentBox_Click);
            // 
            // ObjectiveNoteBox
            // 
            this.ObjectiveNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveNoteBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveNoteBox.Location = new System.Drawing.Point(6, 251);
            this.ObjectiveNoteBox.Multiline = true;
            this.ObjectiveNoteBox.Name = "ObjectiveNoteBox";
            this.ObjectiveNoteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ObjectiveNoteBox.Size = new System.Drawing.Size(740, 150);
            this.ObjectiveNoteBox.TabIndex = 46;
            this.ObjectiveNoteBox.Text = "Objective:";
            this.ObjectiveNoteBox.Click += new System.EventHandler(this.ObjectiveNoteBox_Click);
            this.ObjectiveNoteBox.TextChanged += new System.EventHandler(this.ObjectiveNoteBox_TextChanged);
            // 
            // SignButton
            // 
            this.SignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SignButton.FlatAppearance.BorderSize = 0;
            this.SignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SignButton.Location = new System.Drawing.Point(633, 44);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(94, 26);
            this.SignButton.TabIndex = 45;
            this.SignButton.Text = "Sign";
            this.SignButton.UseVisualStyleBackColor = false;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.NoteLabel.Location = new System.Drawing.Point(25, 70);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(42, 17);
            this.NoteLabel.TabIndex = 44;
            this.NoteLabel.Text = "Note:";
            this.NoteLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SubjectiveNoteBox
            // 
            this.SubjectiveNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectiveNoteBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectiveNoteBox.Location = new System.Drawing.Point(6, 95);
            this.SubjectiveNoteBox.Multiline = true;
            this.SubjectiveNoteBox.Name = "SubjectiveNoteBox";
            this.SubjectiveNoteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SubjectiveNoteBox.Size = new System.Drawing.Size(738, 150);
            this.SubjectiveNoteBox.TabIndex = 43;
            this.SubjectiveNoteBox.Text = "Subjective:";
            this.SubjectiveNoteBox.Click += new System.EventHandler(this.SubjectiveBox_Click);
            this.SubjectiveNoteBox.TextChanged += new System.EventHandler(this.NoteContentBox_TextChanged);
            // 
            // NewNoteDateValue
            // 
            this.NewNoteDateValue.AutoSize = true;
            this.NewNoteDateValue.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.NewNoteDateValue.Location = new System.Drawing.Point(100, 18);
            this.NewNoteDateValue.Name = "NewNoteDateValue";
            this.NewNoteDateValue.Size = new System.Drawing.Size(82, 17);
            this.NewNoteDateValue.TabIndex = 42;
            this.NewNoteDateValue.Text = "XX/XX/XXXX";
            this.NewNoteDateValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NewNoteTitleBox
            // 
            this.NewNoteTitleBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNoteTitleBox.Location = new System.Drawing.Point(103, 44);
            this.NewNoteTitleBox.Name = "NewNoteTitleBox";
            this.NewNoteTitleBox.Size = new System.Drawing.Size(268, 23);
            this.NewNoteTitleBox.TabIndex = 41;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DateLabel.Location = new System.Drawing.Point(25, 18);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(40, 17);
            this.DateLabel.TabIndex = 31;
            this.DateLabel.Text = "Date:";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteTitleLabel
            // 
            this.NoteTitleLabel.AutoSize = true;
            this.NoteTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.NoteTitleLabel.Location = new System.Drawing.Point(25, 44);
            this.NoteTitleLabel.Name = "NoteTitleLabel";
            this.NoteTitleLabel.Size = new System.Drawing.Size(72, 17);
            this.NoteTitleLabel.TabIndex = 30;
            this.NoteTitleLabel.Text = "Note Title:";
            this.NoteTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // patientNoteTableAdapter
            // 
            this.patientNoteTableAdapter.ClearBeforeFill = true;
            // 
            // NoteID
            // 
            this.NoteID.DataPropertyName = "NoteID";
            this.NoteID.HeaderText = "NoteID";
            this.NoteID.Name = "NoteID";
            this.NoteID.ReadOnly = true;
            this.NoteID.Visible = false;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            // 
            // ProviderName
            // 
            this.ProviderName.DataPropertyName = "ProviderName";
            this.ProviderName.HeaderText = "Provider";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.ReadOnly = true;
            // 
            // NoteTitle
            // 
            this.NoteTitle.DataPropertyName = "NoteTitle";
            this.NoteTitle.HeaderText = "Title";
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.ReadOnly = true;
            // 
            // NoteContent
            // 
            this.NoteContent.DataPropertyName = "NoteContent";
            this.NoteContent.HeaderText = "NoteContent";
            this.NoteContent.Name = "NoteContent";
            this.NoteContent.ReadOnly = true;
            this.NoteContent.Visible = false;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.DataPropertyName = "ColumnNumber";
            this.ColumnNumber.HeaderText = "ColumnNumber";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // noteIDDataGridViewTextBoxColumn
            // 
            this.noteIDDataGridViewTextBoxColumn.DataPropertyName = "NoteID";
            this.noteIDDataGridViewTextBoxColumn.HeaderText = "NoteID";
            this.noteIDDataGridViewTextBoxColumn.Name = "noteIDDataGridViewTextBoxColumn";
            this.noteIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            this.providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.HeaderText = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            this.providerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.providerNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteTitleDataGridViewTextBoxColumn
            // 
            this.noteTitleDataGridViewTextBoxColumn.DataPropertyName = "NoteTitle";
            this.noteTitleDataGridViewTextBoxColumn.HeaderText = "NoteTitle";
            this.noteTitleDataGridViewTextBoxColumn.Name = "noteTitleDataGridViewTextBoxColumn";
            this.noteTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteTitleDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteContentDataGridViewTextBoxColumn
            // 
            this.noteContentDataGridViewTextBoxColumn.DataPropertyName = "NoteContent";
            this.noteContentDataGridViewTextBoxColumn.HeaderText = "NoteContent";
            this.noteContentDataGridViewTextBoxColumn.Name = "noteContentDataGridViewTextBoxColumn";
            this.noteContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteContentDataGridViewTextBoxColumn.Visible = false;
            // 
            // columnNumberDataGridViewTextBoxColumn
            // 
            this.columnNumberDataGridViewTextBoxColumn.DataPropertyName = "ColumnNumber";
            this.columnNumberDataGridViewTextBoxColumn.HeaderText = "ColumnNumber";
            this.columnNumberDataGridViewTextBoxColumn.Name = "columnNumberDataGridViewTextBoxColumn";
            this.columnNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 866);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewNotePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Note";
            this.Load += new System.EventHandler(this.NewNote_Load);
            this.NewNotePanel.ResumeLayout(false);
            this.NewNotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHistoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.NewNoteTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.Panel NewNotePanel;
        private System.Windows.Forms.Label NewNoteLabel;
        private System.Windows.Forms.DataGridView NoteHistoryTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl NewNoteTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NoteTitleLabel;
        private System.Windows.Forms.TextBox SubjectiveNoteBox;
        private System.Windows.Forms.Label NewNoteDateValue;
        private System.Windows.Forms.TextBox NewNoteTitleBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.TextBox PlanBox;
        private System.Windows.Forms.TextBox AssesmentBox;
        private System.Windows.Forms.TextBox ObjectiveNoteBox;
        private System.Windows.Forms.Button SaveDraftButton;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientNoteBindingSource;
        private EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter patientNoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}