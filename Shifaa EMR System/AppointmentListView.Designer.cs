namespace Shifaa_EMR_System
{
    partial class AppointmentListView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.AppointmentTableAdapter();
            this.patientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByDateToolStrip = new System.Windows.Forms.ToolStrip();
            this.dateAppointmentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateAppointmentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByDateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet1 = new Shifaa_EMR_System.EMRDatabaseDataSet1();
            this.appointmentTableAdapter1 = new Shifaa_EMR_System.EMRDatabaseDataSet1TableAdapters.AppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.fillByDateToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientID,
            this.FirstName,
            this.LastName,
            this.detailsDataGridViewTextBoxColumn,
            this.dateAppointmentDataGridViewTextBoxColumn,
            this.timeAppointmentDataGridViewTextBoxColumn,
            this.durationAppointmentDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // patientID
            // 
            this.patientID.DataPropertyName = "patientID";
            this.patientID.HeaderText = "Patient ID";
            this.patientID.Name = "patientID";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // fillByDateToolStrip
            // 
            this.fillByDateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateAppointmentToolStripLabel,
            this.dateAppointmentToolStripTextBox,
            this.fillByDateToolStripButton});
            this.fillByDateToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByDateToolStrip.Name = "fillByDateToolStrip";
            this.fillByDateToolStrip.Size = new System.Drawing.Size(1050, 25);
            this.fillByDateToolStrip.TabIndex = 1;
            this.fillByDateToolStrip.Text = "fillByDateToolStrip";
            this.fillByDateToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByDateToolStrip_ItemClicked);
            // 
            // dateAppointmentToolStripLabel
            // 
            this.dateAppointmentToolStripLabel.Name = "dateAppointmentToolStripLabel";
            this.dateAppointmentToolStripLabel.Size = new System.Drawing.Size(105, 22);
            this.dateAppointmentToolStripLabel.Text = "DateAppointment:";
            // 
            // dateAppointmentToolStripTextBox
            // 
            this.dateAppointmentToolStripTextBox.Name = "dateAppointmentToolStripTextBox";
            this.dateAppointmentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByDateToolStripButton
            // 
            this.fillByDateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByDateToolStripButton.Name = "fillByDateToolStripButton";
            this.fillByDateToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.fillByDateToolStripButton.Text = "FillByDate";
            this.fillByDateToolStripButton.Click += new System.EventHandler(this.fillByDateToolStripButton_Click);
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // dateAppointmentDataGridViewTextBoxColumn
            // 
            this.dateAppointmentDataGridViewTextBoxColumn.DataPropertyName = "DateAppointment";
            this.dateAppointmentDataGridViewTextBoxColumn.HeaderText = "Appointment Date";
            this.dateAppointmentDataGridViewTextBoxColumn.Name = "dateAppointmentDataGridViewTextBoxColumn";
            // 
            // timeAppointmentDataGridViewTextBoxColumn
            // 
            this.timeAppointmentDataGridViewTextBoxColumn.DataPropertyName = "TimeAppointment";
            this.timeAppointmentDataGridViewTextBoxColumn.HeaderText = "Appointment Time";
            this.timeAppointmentDataGridViewTextBoxColumn.Name = "timeAppointmentDataGridViewTextBoxColumn";
            // 
            // durationAppointmentDataGridViewTextBoxColumn
            // 
            this.durationAppointmentDataGridViewTextBoxColumn.DataPropertyName = "DurationAppointment";
            this.durationAppointmentDataGridViewTextBoxColumn.HeaderText = "Appointment Duration";
            this.durationAppointmentDataGridViewTextBoxColumn.Name = "durationAppointmentDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "Appointment";
            this.appointmentBindingSource1.DataSource = this.eMRDatabaseDataSet1;
            // 
            // eMRDatabaseDataSet1
            // 
            this.eMRDatabaseDataSet1.DataSetName = "EMRDatabaseDataSet1";
            this.eMRDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // AppointmentListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 488);
            this.Controls.Add(this.fillByDateToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentListView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppointmentListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.fillByDateToolStrip.ResumeLayout(false);
            this.fillByDateToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private EMRDatabaseDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private EMRDatabaseDataSet1 eMRDatabaseDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private EMRDatabaseDataSet1TableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByDateToolStrip;
        private System.Windows.Forms.ToolStripLabel dateAppointmentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateAppointmentToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByDateToolStripButton;
    }
}