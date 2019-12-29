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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewNotePanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewNoteLabel = new System.Windows.Forms.Label();
            this.NoteHistoryTable = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.patientNoteTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.PatientNoteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewNoteTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SignButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteContentBox = new System.Windows.Forms.TextBox();
            this.NewNoteDateValue = new System.Windows.Forms.Label();
            this.NewNoteTitleBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NoteTitleLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddendumLabel = new System.Windows.Forms.Label();
            this.SignButton1 = new System.Windows.Forms.Button();
            this.DateValueLabel1 = new System.Windows.Forms.Label();
            this.AddendumBox1 = new System.Windows.Forms.TextBox();
            this.TitleNameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NoteLabel1 = new System.Windows.Forms.Label();
            this.NoteBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateLabel1 = new System.Windows.Forms.Label();
            this.NoteTitleLabel1 = new System.Windows.Forms.Label();
            this.NewNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHistoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.NewNoteTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.NewNotePanel.Size = new System.Drawing.Size(939, 39);
            this.NewNotePanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(831, 7);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.NoteHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.NoteTitle});
            this.NoteHistoryTable.DataSource = this.patientNoteBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteHistoryTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.NoteHistoryTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.NoteHistoryTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteHistoryTable.Location = new System.Drawing.Point(0, 0);
            this.NoteHistoryTable.Name = "NoteHistoryTable";
            this.NoteHistoryTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteHistoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.NoteHistoryTable.RowHeadersVisible = false;
            this.NoteHistoryTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteHistoryTable.Size = new System.Drawing.Size(254, 610);
            this.NoteHistoryTable.TabIndex = 46;
            this.NoteHistoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_CellContentClick);
            this.NoteHistoryTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteHistoryTable_DoubleClick);
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
            this.NoteTitle.FillWeight = 128.934F;
            this.NoteTitle.HeaderText = "Title";
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.NewNoteTabControl);
            this.panel1.Controls.Add(this.NoteHistoryTable);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 610);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NewNoteTabControl
            // 
            this.NewNoteTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewNoteTabControl.Controls.Add(this.tabPage1);
            this.NewNoteTabControl.Controls.Add(this.tabPage2);
            this.NewNoteTabControl.Location = new System.Drawing.Point(260, 0);
            this.NewNoteTabControl.Name = "NewNoteTabControl";
            this.NewNoteTabControl.SelectedIndex = 0;
            this.NewNoteTabControl.Size = new System.Drawing.Size(677, 610);
            this.NewNoteTabControl.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SignButton);
            this.tabPage1.Controls.Add(this.NoteLabel);
            this.tabPage1.Controls.Add(this.NoteContentBox);
            this.tabPage1.Controls.Add(this.NewNoteDateValue);
            this.tabPage1.Controls.Add(this.NewNoteTitleBox);
            this.tabPage1.Controls.Add(this.DateLabel);
            this.tabPage1.Controls.Add(this.NoteTitleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Note";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SignButton
            // 
            this.SignButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SignButton.FlatAppearance.BorderSize = 0;
            this.SignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SignButton.Location = new System.Drawing.Point(545, 33);
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
            // NoteContentBox
            // 
            this.NoteContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteContentBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteContentBox.Location = new System.Drawing.Point(6, 95);
            this.NoteContentBox.Multiline = true;
            this.NoteContentBox.Name = "NoteContentBox";
            this.NoteContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteContentBox.Size = new System.Drawing.Size(655, 483);
            this.NoteContentBox.TabIndex = 43;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddendumLabel);
            this.tabPage2.Controls.Add(this.SignButton1);
            this.tabPage2.Controls.Add(this.DateValueLabel1);
            this.tabPage2.Controls.Add(this.AddendumBox1);
            this.tabPage2.Controls.Add(this.TitleNameLabel);
            this.tabPage2.Controls.Add(this.ExitButton);
            this.tabPage2.Controls.Add(this.NoteLabel1);
            this.tabPage2.Controls.Add(this.NoteBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.DateLabel1);
            this.tabPage2.Controls.Add(this.NoteTitleLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Existing Note";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddendumLabel
            // 
            this.AddendumLabel.AutoSize = true;
            this.AddendumLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.AddendumLabel.Location = new System.Drawing.Point(24, 293);
            this.AddendumLabel.Name = "AddendumLabel";
            this.AddendumLabel.Size = new System.Drawing.Size(77, 17);
            this.AddendumLabel.TabIndex = 67;
            this.AddendumLabel.Text = "Addendum";
            this.AddendumLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SignButton1
            // 
            this.SignButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SignButton1.FlatAppearance.BorderSize = 0;
            this.SignButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SignButton1.Location = new System.Drawing.Point(423, 27);
            this.SignButton1.Name = "SignButton1";
            this.SignButton1.Size = new System.Drawing.Size(94, 26);
            this.SignButton1.TabIndex = 66;
            this.SignButton1.Text = "Sign";
            this.SignButton1.UseVisualStyleBackColor = false;
            this.SignButton1.Click += new System.EventHandler(this.SignButton1_Click);
            // 
            // DateValueLabel1
            // 
            this.DateValueLabel1.AutoSize = true;
            this.DateValueLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DateValueLabel1.Location = new System.Drawing.Point(101, 12);
            this.DateValueLabel1.Name = "DateValueLabel1";
            this.DateValueLabel1.Size = new System.Drawing.Size(82, 17);
            this.DateValueLabel1.TabIndex = 57;
            this.DateValueLabel1.Text = "XX/XX/XXXX";
            this.DateValueLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddendumBox1
            // 
            this.AddendumBox1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddendumBox1.Location = new System.Drawing.Point(7, 314);
            this.AddendumBox1.Multiline = true;
            this.AddendumBox1.Name = "AddendumBox1";
            this.AddendumBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddendumBox1.Size = new System.Drawing.Size(655, 254);
            this.AddendumBox1.TabIndex = 56;
            this.AddendumBox1.TextChanged += new System.EventHandler(this.AddendumBox_TextChanged);
            // 
            // TitleNameLabel
            // 
            this.TitleNameLabel.AutoSize = true;
            this.TitleNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.TitleNameLabel.Location = new System.Drawing.Point(101, 38);
            this.TitleNameLabel.Name = "TitleNameLabel";
            this.TitleNameLabel.Size = new System.Drawing.Size(36, 17);
            this.TitleNameLabel.TabIndex = 53;
            this.TitleNameLabel.Text = "Title";
            this.TitleNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ExitButton.Location = new System.Drawing.Point(546, 27);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 26);
            this.ExitButton.TabIndex = 52;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // NoteLabel1
            // 
            this.NoteLabel1.AutoSize = true;
            this.NoteLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.NoteLabel1.Location = new System.Drawing.Point(26, 64);
            this.NoteLabel1.Name = "NoteLabel1";
            this.NoteLabel1.Size = new System.Drawing.Size(42, 17);
            this.NoteLabel1.TabIndex = 51;
            this.NoteLabel1.Text = "Note:";
            this.NoteLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteBox1
            // 
            this.NoteBox1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBox1.Location = new System.Drawing.Point(7, 89);
            this.NoteBox1.Multiline = true;
            this.NoteBox1.Name = "NoteBox1";
            this.NoteBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteBox1.Size = new System.Drawing.Size(655, 199);
            this.NoteBox1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label4.Location = new System.Drawing.Point(101, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "XX/XX/XXXX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DateLabel1
            // 
            this.DateLabel1.AutoSize = true;
            this.DateLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DateLabel1.Location = new System.Drawing.Point(26, 12);
            this.DateLabel1.Name = "DateLabel1";
            this.DateLabel1.Size = new System.Drawing.Size(40, 17);
            this.DateLabel1.TabIndex = 47;
            this.DateLabel1.Text = "Date:";
            this.DateLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteTitleLabel1
            // 
            this.NoteTitleLabel1.AutoSize = true;
            this.NoteTitleLabel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.NoteTitleLabel1.Location = new System.Drawing.Point(26, 38);
            this.NoteTitleLabel1.Name = "NoteTitleLabel1";
            this.NoteTitleLabel1.Size = new System.Drawing.Size(72, 17);
            this.NoteTitleLabel1.TabIndex = 46;
            this.NoteTitleLabel1.Text = "Note Title:";
            this.NoteTitleLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 667);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NoteContentBox;
        private System.Windows.Forms.Label NewNoteDateValue;
        private System.Windows.Forms.TextBox NewNoteTitleBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteTitle;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Label DateValueLabel1;
        private System.Windows.Forms.TextBox AddendumBox1;
        private System.Windows.Forms.Label TitleNameLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label NoteLabel1;
        private System.Windows.Forms.TextBox NoteBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DateLabel1;
        private System.Windows.Forms.Label NoteTitleLabel1;
        private System.Windows.Forms.Button SignButton1;
        private System.Windows.Forms.Label AddendumLabel;
    }
}