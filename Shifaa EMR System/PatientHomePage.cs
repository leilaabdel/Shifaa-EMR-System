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

        private void PatientHomePage_Load(object sender, EventArgs e)
        {




            this.WindowState = FormWindowState.Maximized;




            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Appointment, thisPatientID);
            this.patientNoteTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);
            this.vitalSignsTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.VitalSigns, thisPatientID);
            this.allergieTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Allergie, thisPatientID);
            this.patientLabTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientLab, thisPatientID);
            this.prescriptionTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Prescription, thisPatientID);
            this.patientScanTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientScan, thisPatientID);
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
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null)
            {

                NewAppointment newAppointment = new NewAppointment();
                thisProviderMain.setNewAppointment(newAppointment);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                NewNote newNoteForm = new NewNote(thisPatientID, thisProviderMain.getProviderName(), thisProviderMain.getProviderID());
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

                Center(newPrescription);
                newPrescription.Show();
            }
        }

        private void AddAllergieButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAllergie"] as NewAllergie == null)
            {
                NewAllergie newAllergie = new NewAllergie(thisPatientID, thisProviderMain.getProviderID() ,
                    thisProviderMain.getProviderName());

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
                newAppointment.MdiParent = thisProviderMain;
                newAppointment.StartPosition = FormStartPosition.CenterParent;
                newAppointment.Show();
            }
        }

        private void patientClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VitalHistoryLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
