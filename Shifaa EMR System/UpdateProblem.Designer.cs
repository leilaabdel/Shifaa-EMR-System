namespace ShifaaEMRSystem
{
    partial class UpdateProblem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UpdateProblemLabel = new System.Windows.Forms.Label();
            this.ProblemNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ProblemBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.eMRDatabaseDataSet = new ShifaaEMRSystem.EMRDatabaseDataSet();
            this.prescriptionTableAdapter = new ShifaaEMRSystem.EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OngoingBox = new System.Windows.Forms.CheckBox();
            this.ResolvedBox = new System.Windows.Forms.CheckBox();
            this.problemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.problemTableAdapter = new ShifaaEMRSystem.EMRDatabaseDataSetTableAdapters.ProblemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.UpdateProblemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 39);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.CancelButton.Location = new System.Drawing.Point(381, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 26);
            this.CancelButton.TabIndex = 49;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdateProblemLabel
            // 
            this.UpdateProblemLabel.AutoSize = true;
            this.UpdateProblemLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.UpdateProblemLabel.Location = new System.Drawing.Point(12, 9);
            this.UpdateProblemLabel.Name = "UpdateProblemLabel";
            this.UpdateProblemLabel.Size = new System.Drawing.Size(126, 19);
            this.UpdateProblemLabel.TabIndex = 29;
            this.UpdateProblemLabel.Text = "Update Problem";
            // 
            // ProblemNameLabel
            // 
            this.ProblemNameLabel.AutoSize = true;
            this.ProblemNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemNameLabel.Location = new System.Drawing.Point(15, 58);
            this.ProblemNameLabel.Name = "ProblemNameLabel";
            this.ProblemNameLabel.Size = new System.Drawing.Size(94, 16);
            this.ProblemNameLabel.TabIndex = 35;
            this.ProblemNameLabel.Text = "Problem Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(15, 150);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(74, 16);
            this.DescriptionLabel.TabIndex = 36;
            this.DescriptionLabel.Text = "Description";
            // 
            // ProblemBox
            // 
            this.ProblemBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemBox.Location = new System.Drawing.Point(161, 53);
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.Size = new System.Drawing.Size(299, 23);
            this.ProblemBox.TabIndex = 40;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(161, 99);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionBox.Size = new System.Drawing.Size(299, 115);
            this.DescriptionBox.TabIndex = 41;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.SubmitButton.Location = new System.Drawing.Point(196, 326);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 33);
            this.SubmitButton.TabIndex = 45;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(19, 254);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(45, 16);
            this.StatusLabel.TabIndex = 46;
            this.StatusLabel.Text = "Status";
            // 
            // OngoingBox
            // 
            this.OngoingBox.AutoSize = true;
            this.OngoingBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OngoingBox.Location = new System.Drawing.Point(196, 254);
            this.OngoingBox.Name = "OngoingBox";
            this.OngoingBox.Size = new System.Drawing.Size(73, 20);
            this.OngoingBox.TabIndex = 47;
            this.OngoingBox.Text = "Ongoing";
            this.OngoingBox.UseVisualStyleBackColor = true;
            // 
            // ResolvedBox
            // 
            this.ResolvedBox.AutoSize = true;
            this.ResolvedBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolvedBox.Location = new System.Drawing.Point(320, 254);
            this.ResolvedBox.Name = "ResolvedBox";
            this.ResolvedBox.Size = new System.Drawing.Size(81, 20);
            this.ResolvedBox.TabIndex = 48;
            this.ResolvedBox.Text = "Resolved";
            this.ResolvedBox.UseVisualStyleBackColor = true;
            // 
            // problemBindingSource
            // 
            this.problemBindingSource.DataMember = "Problem";
            this.problemBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // problemTableAdapter
            // 
            this.problemTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 406);
            this.ControlBox = false;
            this.Controls.Add(this.ResolvedBox);
            this.Controls.Add(this.OngoingBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.ProblemBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ProblemNameLabel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Problem";
            this.Load += new System.EventHandler(this.UpdateProblem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProblemNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ProblemBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label UpdateProblemLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private EMRDatabaseDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox OngoingBox;
        private System.Windows.Forms.CheckBox ResolvedBox;
        private System.Windows.Forms.BindingSource problemBindingSource;
        private EMRDatabaseDataSetTableAdapters.ProblemTableAdapter problemTableAdapter;
    }
}