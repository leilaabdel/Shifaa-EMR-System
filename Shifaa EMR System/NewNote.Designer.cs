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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewNotePanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewNoteLabel = new System.Windows.Forms.Label();
            this.NoteHistoryTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewNoteTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.SaveDraftButton = new System.Windows.Forms.Button();
            this.patientNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientNoteTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter();
            this.patientNoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emrDatabaseDataSet1 = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientNoteTableAdapter1 = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SignButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddendumButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHistoryTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.NewNoteTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emrDatabaseDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.NoteHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.NoteTitle,
            this.Status});
            this.NoteHistoryTable.DataSource = this.patientNoteBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteHistoryTable.DefaultCellStyle = dataGridViewCellStyle19;
            this.NoteHistoryTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.NoteHistoryTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteHistoryTable.Location = new System.Drawing.Point(0, 0);
            this.NoteHistoryTable.Name = "NoteHistoryTable";
            this.NoteHistoryTable.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.NoteHistoryTable.RowHeadersVisible = false;
            this.NoteHistoryTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteHistoryTable.Size = new System.Drawing.Size(364, 767);
            this.NoteHistoryTable.TabIndex = 46;
            this.NoteHistoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_CellContentClick);
            this.NoteHistoryTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_DoubleClick);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NewNoteTabControl
            // 
            this.NewNoteTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNoteTabControl.Controls.Add(this.tabPage1);
            this.NewNoteTabControl.Controls.Add(this.tabPage2);
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // patientNoteTableAdapter
            // 
            this.patientNoteTableAdapter.ClearBeforeFill = true;
            // 
            // patientNoteBindingSource1
            // 
            this.patientNoteBindingSource1.DataMember = "PatientNote";
            this.patientNoteBindingSource1.DataSource = this.emrDatabaseDataSet1;
            // 
            // emrDatabaseDataSet1
            // 
            this.emrDatabaseDataSet1.DataSetName = "EMRDatabaseDataSet";
            this.emrDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientNoteTableAdapter1
            // 
            this.patientNoteTableAdapter1.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 71.06599F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // NoteTitle
            // 
            this.NoteTitle.DataPropertyName = "NoteTitle";
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteTitle.DefaultCellStyle = dataGridViewCellStyle18;
            this.NoteTitle.FillWeight = 128.934F;
            this.NoteTitle.HeaderText = "Title";
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.AddendumButton);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.SignButton1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(752, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 440);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(740, 283);
            this.textBox3.TabIndex = 57;
            // 
            // SignButton1
            // 
            this.SignButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SignButton1.FlatAppearance.BorderSize = 0;
            this.SignButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SignButton1.Location = new System.Drawing.Point(523, 49);
            this.SignButton1.Name = "SignButton1";
            this.SignButton1.Size = new System.Drawing.Size(94, 26);
            this.SignButton1.TabIndex = 56;
            this.SignButton1.Text = "Sign";
            this.SignButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Note:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 100);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(738, 308);
            this.textBox4.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label2.Location = new System.Drawing.Point(100, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "XX/XX/XXXX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(103, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(268, 23);
            this.textBox5.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Note Title:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddendumButton
            // 
            this.AddendumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddendumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddendumButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddendumButton.FlatAppearance.BorderSize = 0;
            this.AddendumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddendumButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AddendumButton.Location = new System.Drawing.Point(523, 49);
            this.AddendumButton.Name = "AddendumButton";
            this.AddendumButton.Size = new System.Drawing.Size(94, 26);
            this.AddendumButton.TabIndex = 60;
            this.AddendumButton.Text = "Addendum";
            this.AddendumButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label5.Location = new System.Drawing.Point(10, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Addendum";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.button1.Location = new System.Drawing.Point(632, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 62;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel1.ResumeLayout(false);
            this.NewNoteTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emrDatabaseDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.Panel NewNotePanel;
        private System.Windows.Forms.Label NewNoteLabel;
        private System.Windows.Forms.DataGridView NoteHistoryTable;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientNoteBindingSource;
        private EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter patientNoteTableAdapter;
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
        private System.Windows.Forms.BindingSource patientNoteBindingSource1;
        private EMRDatabaseDataSet emrDatabaseDataSet1;
        private EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter patientNoteTableAdapter1;
        private System.Windows.Forms.TextBox PlanBox;
        private System.Windows.Forms.TextBox AssesmentBox;
        private System.Windows.Forms.TextBox ObjectiveNoteBox;
        private System.Windows.Forms.Button SaveDraftButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddendumButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SignButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}