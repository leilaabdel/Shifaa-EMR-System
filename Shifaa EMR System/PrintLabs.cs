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
using System.Drawing.Text;
using System.IO;
using System.Net;

namespace Shifaa_EMR_System
{


    public partial class PrintLabs : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly int thisPatientID;
        readonly string thisProviderID;
        private RichTextBoxEx report;

        public PrintLabs(int patientID, string providerID)
        {
            InitializeComponent();


            this.thisPatientID = patientID;
            this.thisProviderID = providerID;
            _printDocument.BeginPrint += PrintDocument_BeginPrint;
            _printDocument.PrintPage += PrintDocument_PrintPage;

            Font smallheadernonbold = new Font("Bahnschrift Light", 14);

            report = new RichTextBoxEx
            {
                ScrollBars = RichTextBoxScrollBars.Vertical,
                SelectionAlignment = HorizontalAlignment.Center,
                Multiline = true,

                //Add Attending info

                SelectionFont = smallheadernonbold,
                SelectedText = "Date: " + dateTimePicker1.Value.ToShortDateString() + "\n\n"
            };


        }


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




        private void SetLabs(RichTextBoxEx report , DateTime date)
        {




            ISingleResult<getScheduledLabResult> result = doAction.getScheduledLab(thisPatientID, date);
            foreach (getScheduledLabResult r in result)
            {
                report.SelectionAlignment = HorizontalAlignment.Left;
                Console.WriteLine("0");
                report.SelectionBullet = true;
                report.SelectionIndent = 60;
                Console.WriteLine(r.LabTestName);
                report.SelectionFont = new Font("Bahnschrift Bold", 14);
                report.SelectedText = r.LabTestName + "\n";


            }

            report.SelectionBullet = false;
            report.SelectedText = "\n\n";

        }

        private void SetPatientInformation()
        {
            ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(thisPatientID);
            foreach (getPatientByIDResult r in result)
            {
                string firstName = r.FirstName;
                string lastName = r.LastName;

                PatientNameValueLabel.Text = firstName + " " + lastName;

                PhoneNumberValueLabel.Text = r.PhoneNumber;

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






        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
                _printDocument.Print();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicationsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintLabs_Load(object sender, EventArgs e)
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




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            SetProviderInformation();
            SetPatientInformation();

            Font header = new Font("Bahnschrift Bold", 15);
            Font smallheader = new Font("Bahnschrift Bold", 14);
            Font smallheadernonbold = new Font("Bahnschrift Light", 14);
            _ = new Font("Bahnschrift Light", 12);
            Font nonBoldHeader = new Font("Bahnschrift Light", 15);

            report.Clear();

            report.SelectionFont = smallheadernonbold;
            report.SelectionAlignment = HorizontalAlignment.Left;
            report.SelectedText = "Date: " + dateTimePicker1.Value.ToShortDateString() + "\n\n";

            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectionFont = header;
            report.SelectedText = "Attending: " + AttendingPhysicianLabel.Text + "\n"; 
            report.SelectionFont = nonBoldHeader;
            report.SelectedText = PhysicianNumberLabel.Text + "\n\n";


            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;


            //Add patient info
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectionFont = smallheader;
            report.SelectedText = PatientNameLabel.Text + " " + PatientNameValueLabel.Text + "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText = PhoneNumberLabel.Text + " " + PhoneNumberValueLabel.Text + "\n";




            report.SelectedText = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectedText = "\n\n";


            SetLabs(report, dateTimePicker1.Value);

            report.Size = new Size(738, 1377);
            report.Location = new Point(14, 64);



            report.BorderStyle = BorderStyle.None;


        }
    }
}
