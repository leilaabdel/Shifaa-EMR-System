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
        
        public PatientHomePage(string name , string number , string gender, string age , DateTime DOB , int selectedPatientID, ProviderMain providerMain)
        {
            InitializeComponent();
            this.PatientNameLabel.Text = name;
            this.PhoneNumberLabel.Text = "Phone Number: " + number;
            this.PatientGenderLabel.Text = gender;
            this.PatientAgeLabel.Text = "Age: " +  age;
            this.DOBLabel.Text = "DOB: " + DOB.ToShortDateString();

            setVitals(selectedPatientID);

            thisPatientID = selectedPatientID;
            this.thisProviderMain = providerMain;
        }


        private void setVitals(int selectedPatientID)
        {
            ISingleResult<getPatientVitalsResult> result = doAction.getPatientVitals(selectedPatientID);

            foreach (getPatientVitalsResult vital in result)
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
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.VitalSigns' table. You can move, or remove it, as needed.
            this.vitalSignsTableAdapter.Fill(this.eMRDatabaseDataSet.VitalSigns);

            this.WindowState = FormWindowState.Maximized;

            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.eMRDatabaseDataSet.Prescription);

            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Appointment , thisPatientID);
            this.patientNoteTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);
            this.vitalSignsTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.VitalSigns, thisPatientID);


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

        private void fillByPatientIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vitalSignsTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.VitalSigns, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
