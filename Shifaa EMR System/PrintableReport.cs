using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Drawing.Printing;

namespace Shifaa_EMR_System
{
    public partial class PrintableReport : Form
    {

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        readonly int thisPatientID;
        readonly string thisProviderID;

        public PrintableReport(int patientID , string providerID)
        {
            InitializeComponent();
            this.thisPatientID = patientID;
            this.thisProviderID = providerID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrintableReport_Load(object sender, EventArgs e)
        {
            setPatientInformation();
            setPatientVitals();
            setProblems();
            setNotes();
            setMedications();
            setProviderInformation();
        }

        private void setPatientInformation()
        {
            ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(thisPatientID);
            foreach ( getPatientByIDResult r in result)
            {
                string firstName = r.FirstName;
                string lastName = r.LastName;

                PatientNameLabel.Text = firstName + " " + lastName;
                PhoneNumberLabel.Text = "Phone Number: " + r.PhoneNumber;
                PatientGenderLabel.Text = r.Gender;
                MaritalStatusLabel.Text = "Marital Status: " + r.MaritalStatus;
                if (r.Gender == "Male") PregnantLabel.Hide();
                PregnantLabel.Text = "Pregnancy Status: " + r.PregnancyStatus;
                PatientAgeLabel.Text = r.Age + " Years Old";
                DOBLabel.Text = "DOB: " + r.DOB.ToShortDateString();

            }
        }

        private void setProviderInformation()
        {
            ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(thisProviderID);
            foreach (getProviderInfoResult r in result)
            {
                AttendingPhysicianLabel.Text = r.FirstName + " " + r.LastName + " " + r.Title;
                PhysicianNumberLabel.Text = "Phone Number: " + r.PhoneNumber;
            }
        }

        private void setPatientVitals()
        {
            ISingleResult<getLatestPatientVitalsResult> result = doAction.getLatestPatientVitals(thisPatientID);
            foreach(getLatestPatientVitalsResult r in result)
            {
                BloodPressureValueLabel.Text = r.BloodPressure + " mm Hg";
                PulseValueLabel.Text = r.Pulse + " bpm";
                TemperatureValueLabel.Text = r.Temperature.ToString() + " °C";
                HeightValueLabel.Text = r.Height.ToString() + " cm";
                WeightValueLabel.Text = r.Weight.ToString() + " kg";
                BMIValueLabel.Text = r.BMI.ToString() + " kg/m²";
            }
        }

        private void setProblems()
        {

            PrimaryProblemsBox.SelectionBullet = true;
            PrimaryProblemsBox.BulletIndent = 5;
            ISingleResult<selectProblemsForReportResult> result = doAction.selectProblemsForReport("Ongoing", thisPatientID);
            foreach( selectProblemsForReportResult r in result)
            {
                PrimaryProblemsBox.SelectedText = r.DateDiagnosed.ToShortDateString() + ": " + r.ProblemName + "\n";
            }
        }

        private void setNotes()
        {
            ISingleResult<selectNotesForReportResult> result = doAction.selectNotesForReport(thisPatientID, "Signed", DateTime.Today);
            foreach(selectNotesForReportResult r in result)
            {
                NoteBox.SelectionFont = new Font("Bahnschrift Bold", 10);
                NoteBox.SelectedText = r.NoteTitle + "\n";
                NoteBox.SelectionFont = new Font("Bahnschrift Light", 8);
                NoteBox.SelectedText = r.NoteContent + "\n\n";

            }
        }

        private void setMedications()
        {
            MedicationsBox.SelectionBullet = true;
            MedicationsBox.BulletIndent = 5;
            ISingleResult<selectMedicationForReportResult> result = doAction.selectMedicationForReport("Ongoing", thisPatientID);
            foreach(selectMedicationForReportResult r in result)
            {
                MedicationsBox.SelectedText = r.MedicationName + "\n";
                MedicationsBox.BulletIndent = 15;
                MedicationsBox.SelectedText = "Strength: " + r.Strength + "\n";
                MedicationsBox.SelectedText = "Frequency: " + r.Frequency;
                MedicationsBox.SelectionBullet = false;
                MedicationsBox.SelectedText = "\n\n";
                MedicationsBox.SelectionBullet = true;
                MedicationsBox.SelectionIndent = 5;

            }
        }

        private void BMIValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void VitalLabel_Click(object sender, EventArgs e)
        {

        }

        private void PregnantLabel_Click(object sender, EventArgs e)
        {

        }

        private void BMILabel_Click(object sender, EventArgs e)
        {

        }

        private void MaritalStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressureLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeightValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void PulseLabel_Click(object sender, EventArgs e)
        {

        }

        private void NotesLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TemperatureLabel_Click(object sender, EventArgs e)
        {

        }

        private void Seperator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void TemperatureValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void PulseValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressureValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhysicianNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void AttendingPhysicianLabel_Click(object sender, EventArgs e)
        {

        }

        private void DOBLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientAgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MedicationsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedicationsListLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        private void PrintButton_Click(object sender, EventArgs e)
        {
            CancelButton.Hide();
            PrintButton.Hide();
            printTest();
            CancelButton.Show();
            PrintButton.Show();
        }

       

        public static void printTest()
        {
            PrintDialog printDialog1 = new PrintDialog();
            PrintDocument printDocument1 = new PrintDocument();

            printDialog1.Document = printDocument1;
            printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        static void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            Font font = new Font("Bahnschrift Light", 12);

            e.PageSettings.PaperSize = new PaperSize("A4", 850, 1100);

            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;

            float fontHeight = font.GetHeight();
            int startX = 40;
            int startY = 30;
            int offsetY = 40;

            for (int i = 0; i < 100; i++)
            {
                graphic.DrawString("Line: " + i, font, brush, startX, startY + offsetY);
                offsetY += (int)fontHeight;

                if (offsetY >= pageHeight)
                {
                    e.HasMorePages = true;
                    offsetY = 0;
                    return; 
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }

      
    }
}
