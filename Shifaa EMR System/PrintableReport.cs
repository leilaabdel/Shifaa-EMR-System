using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Linq;
using System.Drawing.Printing;



namespace Shifaa_EMR_System
{
    public partial class PrintableReport : Form
    {

        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly int thisPatientID;
        readonly string thisProviderID;

        public PrintableReport(int patientID, string providerID)
        {
            InitializeComponent();
            this.thisPatientID = patientID;
            this.thisProviderID = providerID;
            _printDocument.BeginPrint += PrintDocument_BeginPrint;
            _printDocument.PrintPage += PrintDocument_PrintPage;
            report = new RichTextBoxEx();
            
  
        }

        readonly RichTextBoxEx report;

        private readonly PrintDocument _printDocument = new PrintDocument();
        private int _checkPrint;
       

      

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            _checkPrint = report.Print(_checkPrint, report.TextLength, e);

            // Check for more pages
            e.HasMorePages = _checkPrint < report.TextLength;
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            _checkPrint = 0;
        }


        private void PrintableReport_Load(object sender, EventArgs e)
        {
           
            dateTimePicker1.Value = DateTime.Today;
            foreach (Control con in Controls)
            {
                con.Hide();
            }

            PrintButton.Show();
            CancelButton.Show();
            panel1.Show();

            this.Controls.Add(report);
            report.BringToFront();
            report.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;


        }

        private void SetPatientInformation()
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

        private void SetProviderInformation()
        {
            ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(thisProviderID);
            foreach (getProviderInfoResult r in result)
            {
                AttendingPhysicianLabel.Text = r.FirstName + " " + r.LastName + " " + r.Title;
                PhysicianNumberLabel.Text = "Phone Number: " + r.PhoneNumber;
            }
        }

        private void SetPatientVitals()
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

        private void SetProblems(RichTextBoxEx report)
        {

            report.SelectionBullet = true;
            report.BulletIndent = 5;
            ISingleResult<selectProblemsForReportResult> result = doAction.selectProblemsForReport("Ongoing", thisPatientID);
            foreach( selectProblemsForReportResult r in result)
            {
                report.SelectionIndent = 60;
                report.SelectionFont = new Font("Bahnschrift Light" , 13);
                report.SelectedText = r.DateDiagnosed.ToShortDateString() + ": " + r.ProblemName + "\n";
            }

            report.SelectionBullet = false;
        }

        private void SetNotes(RichTextBoxEx report)
        {
            ISingleResult<selectNotesForReportResult> result = doAction.selectNotesForReport(thisPatientID, "Signed", dateTimePicker1.Value);
            foreach(selectNotesForReportResult r in result)
            {
                report.SelectionFont = new Font("Bahnschrift Bold", 12);
                report.SelectedText = r.NoteTitle + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 12);
                report.SelectedText = r.NoteContent + "\n\n";

            }
        }

        private void SetMedications(RichTextBoxEx report)
        {




            ISingleResult<selectMedicationForReportResult> result = doAction.selectMedicationForReport("Ongoing", thisPatientID);
            foreach (selectMedicationForReportResult r in result)
            {

                report.SelectionBullet = false;
                report.SelectionIndent = 60;
                Console.WriteLine(r.MedicationName);
                report.SelectionFont = new Font("Bahnschrift Bold", 12);
                report.SelectedText = r.MedicationName  + "\n";

                report.SelectionBullet = true;
                report.SelectionIndent = 90;
                report.SelectionFont = new Font("Bahnschrift Light", 12);
                report.SelectedText = "     Strength: " + r.Strength + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 12);
                report.SelectedText = "     Frequency: " + r.Frequency + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 12);
                report.SelectedText = "     Route: " + r.Route + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 12);
                report.SelectedText = "     Refills: " + r.Refills.ToString()  + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 12);


                report.SelectionBullet = false;
                report.SelectedText = "\n\n";


                //report.SelectionIndent = 5;

            }
        }
       

     
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
                _printDocument.Print();
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Font header = new Font("Bahnschrift Bold", 15);
            Font smallheader = new Font("Bahnschrift Bold", 14);
            Font smallheadernonbold = new Font("Bahnschrift Light", 14);

            Font content = new Font("Bahnschrift Light", 12);
            Font nonBoldHeader = new Font("Bahnschrift Light", 15);

            report.Clear();

            report.SelectedText = "Date: " + dateTimePicker1.Value.ToShortDateString() + "\n\n";

            SetProviderInformation();
            SetPatientInformation();

            report.BorderStyle = BorderStyle.None;
            report.Multiline = true;
            report.ScrollBars = RichTextBoxScrollBars.Vertical;

            report.SelectionFont = smallheadernonbold;
            report.SelectionFont = header;
            report.SelectedText = (PatientNameLabel.Text + "\n");
            report.SelectionFont = nonBoldHeader;
            report.SelectedText = PhoneNumberLabel.Text + "\n\n";


            //Add Attending info

            report.SelectionFont = smallheader;
            report.SelectedText = "Attending: " + AttendingPhysicianLabel.Text + "\n";
            report.SelectionFont = content;
            report.SelectedText = PhysicianNumberLabel.Text + "\n\n";

            //Add background info

            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;

            report.SelectionFont = smallheader;
            report.SelectionIndent = 30;
            report.SelectedText = "Patient Background Information" + "\n";

            report.SelectionIndent = 60;
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = PatientGenderLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = MaritalStatusLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            if (PatientGenderLabel.Text == "Female") report.SelectedText = PregnantLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = PatientAgeLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = (DOBLabel.Text) + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "\n";

            report.SelectionIndent = 0;
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;

            report.SelectionFont = smallheader;
            report.SelectionIndent = 30;
            report.SelectedText = "Patient Vitals" + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectionBullet = true;
            report.SelectionIndent = 60;
            report.SelectedText = "Blood Pressure: " + BloodPressureValueLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "Pulse: " + PulseValueLabel.Text + " \n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "Temperature: " + TemperatureValueLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "Height: " + HeightValueLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "Weight: " + WeightValueLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = "BMI: " + BMIValueLabel.Text + "\n";
            report.SelectionBullet = false;
            report.SelectedText = "\n";

            report.SelectionIndent = 0;
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;
            report.SelectionFont = smallheader;
            report.SelectionIndent = 30;
            report.SelectedText = "Problems List" + "\n";
            report.SelectionFont = smallheadernonbold;
            SetProblems(report);

            report.SelectedText = "\n";
            report.SelectionIndent = 0;
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";

            report.SelectionAlignment = HorizontalAlignment.Left;
            report.SelectionIndent = 30;
            report.SelectionFont = smallheader;
            report.SelectedText = "Notes" + "\n";
            report.SelectionFont = content;
            SetNotes(report);
            report.SelectedText = "\n";

            report.SelectionIndent = 0;
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;
            report.SelectionFont = smallheader;
            report.SelectionIndent = 30;
            report.SelectedText = "Medication List" + "\n";
            SetMedications(report);

            report.SelectedText = "\n";



            report.Size = new Size(738, 1377);
            report.Location = new Point(14, 64);

        }
    }
}
