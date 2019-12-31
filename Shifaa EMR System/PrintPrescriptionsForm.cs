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


    public partial class PrintPrescriptionsForm : Form
    {
        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        readonly int thisPatientID;
        readonly string thisProviderID;
        public PrintPrescriptionsForm(int patientID , string providerID)
        {
            InitializeComponent();
            this.thisPatientID = patientID;
            this.thisProviderID = providerID; 
        }

        private void PrintPrescriptionsForm_Load(object sender, EventArgs e)
        {
            setProviderInformation();
            setPatientInformation();
            setMedications();
            
        }

        private void setMedications()
        {
            MedicationsBox.SelectionBullet = true;
            MedicationsBox.BulletIndent = 5;
            ISingleResult<selectPrescriptionforPrintResult> result = doAction.selectPrescriptionforPrint("Ongoing", thisPatientID, DateTime.Today);
            foreach (selectPrescriptionforPrintResult r in result)
            {
                MedicationsBox.SelectedText = r.MedicationName + "\n";
                MedicationsBox.BulletIndent = 15;
                MedicationsBox.SelectedText = "Strength: " + r.Strength + "\n";
                MedicationsBox.SelectedText = "Frequency: " + r.Frequency + "\n";
                MedicationsBox.SelectedText = "Route: " + r.Route + "\n";
                MedicationsBox.SelectedText = "Refills: " + r.Refills;
                MedicationsBox.SelectionBullet = false;
                MedicationsBox.SelectedText = "\n\n";
                MedicationsBox.SelectionBullet = true;
                MedicationsBox.SelectionIndent = 5;

            }
        }

        private void setPatientInformation()
        {
            ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(thisPatientID);
            foreach (getPatientByIDResult r in result)
            {
                string firstName = r.FirstName;
                string lastName = r.LastName;

                PatientNameValueLabel.Text = firstName + " " + lastName;
                PhoneNumberValueLabel.Text =  r.PhoneNumber;
   
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

        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            CancelButton.Hide();
            PrintButton.Hide();
            printTest();
            CancelButton.Show();
            PrintButton.Show();
        }
    }
}
