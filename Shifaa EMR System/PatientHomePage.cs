using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class PatientHomePage : Form
    {

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");


        int thisPatientID;
        readonly ProviderMain thisProviderMain;
        readonly AppointmentListView thisAppointmentList;
        ToolStripMenuItem thisGenerateReport;
        ToolStripMenuItem thisPrintPrescriptions;


        public PatientHomePage(string name, string number, string gender, string age, DateTime DOB, int selectedPatientID, ProviderMain providerMain)
        {
            InitializeComponent();
            this.PatientNameLabel.Text = name;
            this.PhoneNumberLabel.Text = "Phone Number: " + number;
            this.PatientGenderLabel.Text = gender;
            this.PatientAgeLabel.Text = "Age: " + age;
            this.DOBLabel.Text = "DOB: " + DOB.ToShortDateString();

            setVitals(selectedPatientID);

            thisPatientID = selectedPatientID;
            this.thisProviderMain = providerMain;
            this.FinishVisitButton.Hide();


            thisGenerateReport = new ToolStripMenuItem("Generate Report");

            thisGenerateReport.Click += new System.EventHandler(GenerateReportClick);
            thisPrintPrescriptions = new ToolStripMenuItem("Print Prescriptions");
            thisPrintPrescriptions.Click += new System.EventHandler(PrintPrescriptionsClick);
            thisProviderMain.menuStrip2.Items.Add(thisGenerateReport);
            thisProviderMain.menuStrip2.Items.Add(thisPrintPrescriptions);


        }

        public PatientHomePage(string name, string number, string gender, string age, DateTime DOB, int selectedPatientID, ProviderMain providerMain,  AppointmentListView appointmentList)
        {
            InitializeComponent();
            this.PatientNameLabel.Text = name;
            this.PhoneNumberLabel.Text = "Phone Number: " + number;
            this.PatientGenderLabel.Text = gender;
            this.PatientAgeLabel.Text = "Age: " + age;
            this.DOBLabel.Text = "DOB: " + DOB.ToShortDateString();

            setVitals(selectedPatientID);

            thisPatientID = selectedPatientID;
            this.thisProviderMain = providerMain;
            this.thisAppointmentList = appointmentList;
            this.FinishVisitButton.Show();

            this.NoteHistoryTable.AutoGenerateColumns = false;
            this.LabsTable.AutoGenerateColumns = false;
            this.AllergiesTable.AutoGenerateColumns = false;
            this.VitalHistoryTable.AutoGenerateColumns = false;
            this.ScansTable.AutoGenerateColumns = false;
            this.ProblemListView.AutoGenerateColumns = false;
            this.MedicationsListDataGridView.AutoGenerateColumns = false;

            thisGenerateReport = new ToolStripMenuItem("Generate Report");

            thisGenerateReport.Click += new System.EventHandler(GenerateReportClick);
            thisPrintPrescriptions = new ToolStripMenuItem("Print Prescriptions");
            thisPrintPrescriptions.Click += new System.EventHandler(PrintPrescriptionsClick);
            thisProviderMain.menuStrip2.Items.Add(thisGenerateReport);
            thisProviderMain.menuStrip2.Items.Add(thisPrintPrescriptions);

            this.WindowState = FormWindowState.Maximized;
           
        }


        private void GenerateReportClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["PrintableReport"] as PrintableReport == null)
            {
                PrintableReport report = new PrintableReport(thisPatientID, thisProviderMain.getProviderID());
                Center(report);
                report.Show();
            }
        }

       private void PrintPrescriptionsClick(object sender, EventArgs e)
       {
            if (Application.OpenForms["PrintableReport"] as PrintableReport == null)
            {
                PrintPrescriptionsForm printPrescriptions = new PrintPrescriptionsForm(thisPatientID, thisProviderMain.getProviderID());
                Center(printPrescriptions);
                printPrescriptions.Show();
            }
       }

            private void setVitals(int selectedPatientID)
        {
            ISingleResult<getLatestPatientVitalsResult> result = doAction.getLatestPatientVitals(selectedPatientID);

            foreach (getLatestPatientVitalsResult vital in result)
            {
                this.BloodPressureValueLabel.Text = vital.BloodPressure + " mm Hg";
                this.PulseValueLabel.Text = vital.Pulse.ToString() + " bpm";
                this.TemperatureValueLabel.Text = vital.Temperature.ToString() + " °C";
                this.WeightValueLabel.Text = vital.Weight.ToString() + " Kg";
                this.HeightValueLabel.Text = vital.Height.ToString() + " cm";
                this.BMIValueLabel.Text = Math.Round((Double)vital.BMI, 2).ToString() + " Kg/m²";
             

            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void NoteHistoryLabel_Click(object sender, EventArgs e)
        {

        }

        public int getPatientID()
        {
            return thisPatientID;
        }

        

        private void PatientHomePage_Load(object sender, EventArgs e)
        {
  

            this.AllergiesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.NoteHistoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.VitalHistoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ScansTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MedicationsListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.LabsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AllergiesTable.MultiSelect = false;
            this.NoteHistoryTable.MultiSelect = false;
            this.VitalHistoryTable.MultiSelect = false;
            this.ScansTable.MultiSelect = false;
            this.MedicationsListDataGridView.MultiSelect = false;
            this.AppointmentListView1.MultiSelect = false;
            this.LabsTable.MultiSelect = false;


            this.WindowState = FormWindowState.Maximized;




            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed
            this.patientNoteTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);
            this.vitalSignsTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.VitalSigns, thisPatientID);
            this.allergieTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Allergie, thisPatientID);
            this.patientLabTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientLab, thisPatientID);
            this.prescriptionTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Prescription, thisPatientID);
            this.patientScanTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientScan, thisPatientID);
            this.problemTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Problem, thisPatientID);
            this.appointmentTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Appointment, thisPatientID);



        }


        private void PatientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientAgeLabel_Click(object sender, EventArgs e)
        {

        }



        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAppointmentFromPatientView"] as NewAppointmentFromPatientView == null)
            {

                NewAppointmentFromPatientView newAppointment = new NewAppointmentFromPatientView(thisPatientID , thisProviderMain.getProviderID() , 
                    thisProviderMain.getProviderName());
                Center(newAppointment);
                newAppointment.Show();

            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }




        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMIValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void BMILabel_Click(object sender, EventArgs e)
        {

        }

        private void WeightValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void TemperatureValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void PulseValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressureValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void TemperatureLabel_Click(object sender, EventArgs e)
        {

        }

        private void PulseLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressureLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MedicationsListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewNote"] as NewNote == null)
            {
                NewNote newNoteForm = new NewNote(thisPatientID, thisProviderMain.getProviderName(),
                    thisProviderMain.getProviderID() , this);
                Center(newNoteForm);
                newNoteForm.Show();

            }
        }

        private void AddMedicationButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewPrescriptionForm"] as NewPrescriptionForm == null)
            {
                NewPrescriptionForm newPrescription = new NewPrescriptionForm(thisPatientID, thisProviderMain.getProviderName(),
                thisProviderMain.getProviderID());
                newPrescription.Owner = this;
                Center(newPrescription);
                newPrescription.Show();
            }
        }

        private void AddAllergieButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAllergie"] as NewAllergie == null)
            {
                NewAllergie newAllergie = new NewAllergie(thisPatientID, thisProviderMain.getProviderID(),
                    thisProviderMain.getProviderName());
                newAllergie.Owner = this;
                Center(newAllergie);
                newAllergie.Show();
            }
        }

        private void AddNewScanButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewScanOrder"] as NewScanOrder == null)
            {
                NewScanOrder newScan = new NewScanOrder(thisPatientID, thisProviderMain.getProviderName(),
                    thisProviderMain.getProviderID());
                newScan.Owner = this;
                Center(newScan);
                newScan.Show();
            }
        }

        private void AddLabButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewLabOrder"] as NewLabOrder == null)
            {
                NewLabOrder newLabOrder = new NewLabOrder(thisPatientID, thisProviderMain.getProviderID(),
                    thisProviderMain.getProviderName());
                newLabOrder.Owner = this;
                Center(newLabOrder);
                newLabOrder.Show();
            }

        }

        private void AddNewVitalButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewVital"] as NewVital == null)
            {
                NewVital newVital = new NewVital(thisPatientID, thisProviderMain.getProviderName(),
                    thisProviderMain.getProviderID());
                newVital.Owner = this;
                Center(newVital);
                newVital.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewAppointmentButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAppointmentFromPatientView"] as NewAppointmentFromPatientView == null)
            {
                NewAppointmentFromPatientView newAppointment = new NewAppointmentFromPatientView(thisPatientID, thisProviderMain.getProviderID(),
                    thisProviderMain.getProviderName());
                newAppointment.Owner = this;
                Center(newAppointment);
                newAppointment.Show();
            }
        }

        private void patientClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VitalHistoryLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            thisProviderMain.menuStrip2.Items.Remove(thisGenerateReport);
            thisProviderMain.menuStrip2.Items.Remove(thisPrintPrescriptions);
            thisProviderMain.AutoScroll = false;
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void NoteHistoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            if (AppointmentListView1.SelectedRows.Count > 0)
            {
                int currentRow = AppointmentListView1.CurrentRow.Index;

                int selectedAppointmentID = (Int32)AppointmentListView1["appointmentID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this appointment?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        AppointmentListView1.Rows.RemoveAt(currentRow);
                        doAction.deleteAppointment(selectedAppointmentID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }

        }

        private void deletePrescriptionButton_Click(object sender, EventArgs e)
        {
            if (MedicationsListDataGridView.SelectedRows.Count > 0)
            {


                int currentRow = MedicationsListDataGridView.CurrentRow.Index;

                int selectedPrescriptionID = (Int32)MedicationsListDataGridView["prescriptionID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this Prescription?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        MedicationsListDataGridView.Rows.RemoveAt(currentRow);
                        doAction.deletePatientPrescription(selectedPrescriptionID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void deleteAllergyButton_Click(object sender, EventArgs e)
        {
            if (AllergiesTable.SelectedRows.Count > 0)
            {


                int currentRow = AllergiesTable.CurrentRow.Index;

                int selectedAllergyID = (Int32)AllergiesTable["PatientAllergieID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this Allergy?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        AllergiesTable.Rows.RemoveAt(currentRow);
                        doAction.deletePatientAllergy(selectedAllergyID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void deleteScanButton_Click(object sender, EventArgs e)
        {
            int currentRow = ScansTable.CurrentRow.Index;

            int selectedScanID = (Int32)ScansTable["PatientScanID", currentRow].Value;
            if (MessageBox.Show(string.Format("Are you sure you want to delete this scan or procedure?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ScansTable.Rows.RemoveAt(currentRow);
                    doAction.deletePatientScan(selectedScanID);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void deleteLabButton_Click(object sender, EventArgs e)
        {
            if (LabsTable.SelectedRows.Count > 0)
            {

                int currentRow = LabsTable.CurrentRow.Index;

                int selectedLabID = (Int32)LabsTable["PatientLabID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this lab?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        LabsTable.Rows.RemoveAt(currentRow);
                        doAction.deletePatientLab(selectedLabID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (NoteHistoryTable.SelectedRows.Count > 0)
            {

                int currentRow = NoteHistoryTable.CurrentRow.Index;

                int selectedNoteID = (Int32)NoteHistoryTable["NoteID", currentRow].Value;

                DateTime noteDate = (DateTime)NoteHistoryTable["Date", currentRow].Value;
                string noteDateString = noteDate.ToShortDateString();


                if(noteDateString != DateTime.Today.ToShortDateString())
                {
                    MessageBox.Show("You can only delete notes from today.");

                    return; 
                }

                if (MessageBox.Show(string.Format("Are you sure you want to delete this note?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        NoteHistoryTable.Rows.RemoveAt(currentRow);
                        doAction.deletePatientNote(selectedNoteID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void deleteVitalButton_Click(object sender, EventArgs e)
        {
            if (VitalHistoryTable.SelectedRows.Count > 0)
            {

                int currentRow = VitalHistoryTable.CurrentRow.Index;

                int selectedVitalID = (Int32)VitalHistoryTable["VitalSignID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this vital sign entry?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        VitalHistoryTable.Rows.RemoveAt(currentRow);
                        doAction.deleteVitalSigns(selectedVitalID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void addProblemButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewProblem"] as NewProblem == null)
            {
                NewProblem newProblem = new NewProblem(thisPatientID, thisProviderMain.getProviderName(),
                    thisProviderMain.getProviderID());
                newProblem.Owner = this;
                Center(newProblem);
                newProblem.Show();
            }
        }

        private void removeProblemButton_Click(object sender, EventArgs e)
        {
            if (ProblemListView.SelectedRows.Count > 0)
            {

                int currentRow = ProblemListView.CurrentRow.Index;

                int selectedProblemID = (Int32)ProblemListView["ProblemID", currentRow].Value;
                if (MessageBox.Show(string.Format("Are you sure you want to delete this problem entry?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ProblemListView.Rows.RemoveAt(currentRow);
                        doAction.deleteProblem(selectedProblemID);
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void UpdateProblemButton_Click(object sender, EventArgs e)
        {

            if (ProblemListView.SelectedRows.Count > 0) {
                int currentRow = ProblemListView.CurrentRow.Index;

                int selectedProblemID = (Int32)ProblemListView["ProblemID", currentRow].Value;
                string problemName = (String)ProblemListView["ProblemName", currentRow].Value;
                string problemDescription = (String)ProblemListView["ProblemDescription", currentRow].Value;

                if (Application.OpenForms["UpdateProblem"] as UpdateProblem == null)
                {
                    UpdateProblem updateProblem = new UpdateProblem(selectedProblemID, problemName, problemDescription, thisPatientID);
                    updateProblem.Owner = this;
                    Center(updateProblem);
                    updateProblem.Show();
                }
            }

        }

        private void FinishVisitButton_Click(object sender, EventArgs e)
        {
            // TO DO: Complete the Checked Out Button
            string checkedOut = "Complete at: " + DateTime.Now.ToString("HH:mm");
            doAction.updateAppointment(checkedOut, thisAppointmentList.getSelectedAppointmentID());
        }

        private void ProblemListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditMedicationButton_Click(object sender, EventArgs e)
        {
            if (MedicationsListDataGridView.SelectedRows.Count > 0)
            {
                int currentRow = MedicationsListDataGridView.CurrentRow.Index;

                int selectedPrescriptionID = (Int32)MedicationsListDataGridView["PrescriptionID", currentRow].Value;
                string medicationName = (String)MedicationsListDataGridView["MedicationName", currentRow].Value;
                string amount = (String)MedicationsListDataGridView["Amount", currentRow].Value;
                string strength = (String)MedicationsListDataGridView["Strength", currentRow].Value;
                string route = (String)MedicationsListDataGridView["Route", currentRow].Value;
                string frequency = (String)MedicationsListDataGridView["Frequency", currentRow].Value;
                string refills = null;
                double? doubleRefills = null; 
                //TODO: Fix the refills 


                if (Application.OpenForms["UpdatePrescription"] as UpdatePrescription == null)
                {
                    UpdatePrescription updatePrescription = new UpdatePrescription(medicationName, amount, strength, frequency, doubleRefills, route, selectedPrescriptionID, thisPatientID);
                    Center(updatePrescription);
                    updatePrescription.Owner = this;
                    updatePrescription.Show();
                }
            }
        }

        private void PrintPrescriptionsButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PrintPrescriptionsForm"] as PrintPrescriptionsForm == null)
            {
                PrintPrescriptionsForm printPrescriptions = new PrintPrescriptionsForm(thisPatientID, thisProviderMain.getProviderID());
                Center(printPrescriptions);
                printPrescriptions.Show();
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PrintableReport"] as PrintableReport == null)
            {
                PrintableReport printableReport = new PrintableReport(thisPatientID, thisProviderMain.getProviderID());
                Center(printableReport);
                printableReport.Show();
            }
        }

        private void ProblemListView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
