namespace Shifaa_EMR_System
{
    partial class NewMessageItem
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
            this.components = new System.ComponentModel.Container();
            this.ToLabel = new System.Windows.Forms.Label();
            this.MessageContentBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.ReceiverComboBox = new System.Windows.Forms.ComboBox();
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.allEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allEmployeesTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.AllEmployeesTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.BackColor = System.Drawing.Color.White;
            this.ToLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ToLabel.Location = new System.Drawing.Point(20, 14);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(25, 17);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To:";
            // 
            // MessageContentBox
            // 
            this.MessageContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageContentBox.BackColor = System.Drawing.Color.White;
            this.MessageContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageContentBox.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.MessageContentBox.Location = new System.Drawing.Point(35, 98);
            this.MessageContentBox.Name = "MessageContentBox";
            this.MessageContentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MessageContentBox.Size = new System.Drawing.Size(727, 204);
            this.MessageContentBox.TabIndex = 6;
            this.MessageContentBox.Text = "";
            this.MessageContentBox.TextChanged += new System.EventHandler(this.MessageContentBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 9;
            // 
            // SubjectBox
            // 
            this.SubjectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectBox.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubjectBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SubjectBox.Location = new System.Drawing.Point(23, 54);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(592, 17);
            this.SubjectBox.TabIndex = 10;
            this.SubjectBox.Text = "Add a subject";
            this.SubjectBox.Click += new System.EventHandler(this.SubjectBoxClick);
            this.SubjectBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.SubjectBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubjectKeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 2);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.DiscardButton);
            this.panel4.Controls.Add(this.SendMessageButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 50);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // DiscardButton
            // 
            this.DiscardButton.AutoSize = true;
            this.DiscardButton.BackColor = System.Drawing.Color.White;
            this.DiscardButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DiscardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiscardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscardButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.DiscardButton.ForeColor = System.Drawing.Color.Black;
            this.DiscardButton.Location = new System.Drawing.Point(128, 9);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(81, 32);
            this.DiscardButton.TabIndex = 54;
            this.DiscardButton.Text = "Discard";
            this.DiscardButton.UseVisualStyleBackColor = false;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.AutoSize = true;
            this.SendMessageButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SendMessageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SendMessageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SendMessageButton.ForeColor = System.Drawing.Color.White;
            this.SendMessageButton.Location = new System.Drawing.Point(23, 9);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(81, 32);
            this.SendMessageButton.TabIndex = 53;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButtonClick);
            // 
            // ReceiverComboBox
            // 
            this.ReceiverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ReceiverComboBox.FormattingEnabled = true;
            this.ReceiverComboBox.Location = new System.Drawing.Point(51, 12);
            this.ReceiverComboBox.Name = "ReceiverComboBox";
            this.ReceiverComboBox.Size = new System.Drawing.Size(713, 21);
            this.ReceiverComboBox.TabIndex = 13;
            this.ReceiverComboBox.SelectedIndexChanged += new System.EventHandler(this.ReceiverComboBox_SelectedIndexChanged);
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allEmployeesBindingSource
            // 
            this.allEmployeesBindingSource.DataMember = "AllEmployees";
            this.allEmployeesBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // allEmployeesTableAdapter
            // 
            this.allEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // NewMessageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReceiverComboBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessageContentBox);
            this.Controls.Add(this.ToLabel);
            this.Name = "NewMessageItem";
            this.Size = new System.Drawing.Size(800, 370);
            this.Load += new System.EventHandler(this.NewMessageItem_Load);
            this.VisibleChanged += new System.EventHandler(this.NewMessageVisibleChanged);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.RichTextBox MessageContentBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SubjectBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.ComboBox ReceiverComboBox;
        private System.Windows.Forms.BindingSource allEmployeesBindingSource;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private EMRDatabaseDataSetTableAdapters.AllEmployeesTableAdapter allEmployeesTableAdapter;
    }
}
