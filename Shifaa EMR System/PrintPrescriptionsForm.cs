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


    public partial class PrintPrescriptionsForm : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly int thisPatientID;
        readonly string thisProviderID;
        private RichTextBoxEx report;
        public PrintPrescriptionsForm(int patientID , string providerID)
        {
            InitializeComponent();

          
            this.thisPatientID = patientID;
            this.thisProviderID = providerID;
            _printDocument.BeginPrint += PrintDocument_BeginPrint;
            _printDocument.PrintPage += PrintDocument_PrintPage;


        }

        private void PrintPrescriptionsForm_Load(object sender, EventArgs e)
        {
            SetPatientInformation();
            SetProviderInformation();

            foreach (Control con in Controls)
            {
                con.Hide();
            }

            PrintButton.Show();
            CancelButton.Show();
            panel1.Show();


            Font header = new Font("Bahnschrift Bold", 15);
            Font smallheader = new Font("Bahnschrift Bold", 14);
            Font smallheadernonbold = new Font("Bahnschrift Light", 14);
            _ = new Font("Bahnschrift Light", 12);
            Font nonBoldHeader = new Font("Bahnschrift Light", 15);


            report = new RichTextBoxEx
            {
                ScrollBars = RichTextBoxScrollBars.Vertical,
                SelectionAlignment = HorizontalAlignment.Center,
                Multiline = true,

                //Add Attending info
               
                SelectionFont = header,
                SelectedText = "Attending: " + AttendingPhysicianLabel.Text + "\n"
            };
            report.SelectionFont = nonBoldHeader;
            report.SelectedText = PhysicianNumberLabel.Text + "\n\n";


            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectedText = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectionAlignment = HorizontalAlignment.Left;


            //Add patient info
            report.SelectionAlignment = HorizontalAlignment.Center;
            report.SelectionFont = smallheader;
            report.SelectedText = PatientNameLabel.Text + " " +  PatientNameValueLabel.Text +  "\n";
            report.SelectionFont = smallheadernonbold;
            report.SelectedText =   PhoneNumberLabel.Text + " " +  PhoneNumberValueLabel.Text + "\n";




            report.SelectedText = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
            report.SelectedText = "\n\n         ";

            Clipboard.Clear();

            DataFormats.Format df = DataFormats.GetFormat(DataFormats.Bitmap);

            Image img;

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://i.etsystatic.com/13221305/r/il/62d971/1484186367/il_1588xN.1484186367_7h0c.jpg");
            MemoryStream ms = new MemoryStream(bytes);
            img = System.Drawing.Image.FromStream(ms);

            
            //FromFile("C:/Users/coder/Source/Repos/lxa215/Shifaa-EMR-System/Shifaa EMR System/RxIcon.png");

            report.SelectionAlignment = HorizontalAlignment.Left;

            img = ResizeImage(img, new Size(104, 91));
            Clipboard.SetImage(img);
            report.Paste(df);

            Clipboard.Clear();
  
            


            report.SelectedText = "\n\n";


            SetMedications(report);


            report.Size = new Size(738, 1377);
            report.Location = new Point(14, 64);
            
          
           
            report.BorderStyle = BorderStyle.None;
            this.Controls.Add(report);

            report.Show();


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


        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

      

        private void SetMedications(RichTextBoxEx report)
        {

          
         
           
            ISingleResult<selectPrescriptionforPrintResult> result = doAction.selectPrescriptionforPrint("Ongoing", thisPatientID , DateTime.Today);
            foreach (selectPrescriptionforPrintResult r in result)
            {
                Console.WriteLine("0");
                report.SelectionBullet = false;
                report.SelectionIndent = 60;
                Console.WriteLine(r.MedicationName);
                report.SelectionFont = new Font("Bahnschrift Bold", 14);
                report.SelectedText = r.MedicationName + "\n";

                report.SelectionBullet = true;
                report.SelectionIndent = 90;
                report.SelectionFont = new Font("Bahnschrift Light", 14);
                report.SelectedText = "     Strength: " + r.Strength + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 14);
                report.SelectedText = "     Frequency: " + r.Frequency + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 14);
                report.SelectedText = "     Route: " + r.Route + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 14);
                report.SelectedText = "     Refills: " + r.Refills + "\n";
                report.SelectionFont = new Font("Bahnschrift Light", 14);


                report.SelectionBullet = false;
                report.SelectedText = "\n\n";
                
               
              
            }
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

 
    }
}
