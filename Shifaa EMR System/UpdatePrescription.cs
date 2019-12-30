using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class UpdatePrescription : Form
    {

        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int thisPrescriptionID;
        int thisPatientID;
        public UpdatePrescription(string prescriptionName, string amount, string strength , 
            string frequency , double numberOfRefills, string route, int prescriptionID, int patientID)
        {

            this.MedicationBox.Text = prescriptionName;
            this.AmountBox.Text = amount;
            this.StrengthBox.Text = strength;
            this.FrequencyBox.Text = frequency;
            this.RefillsBox.Text = numberOfRefills.ToString();
            this.RouteBox.Text = route;
            this.thisPrescriptionID = prescriptionID;
            this.thisPatientID = patientID;
            InitializeComponent();
        }

        string status = null;

        private void UpdatePrescription_Load(object sender, EventArgs e)
        {
            DateCompletedLabel.Hide();
            DateCompletedPicker.Hide();
            
        }

        private void YesBox_CheckedChanged(object sender, EventArgs e)
        {
            if(YesBox.Checked && !NoBox.Checked)
            {
                DateCompletedLabel.Show();
                DateCompletedPicker.Show();
                status = "Complete";
            }
        }

        private void NoBox_CheckedChanged(object sender, EventArgs e)
        {
            if(!YesBox.Checked && NoBox.Checked)
            {
                DateCompletedPicker.Hide();
                DateCompletedLabel.Hide();
                status = "Ongoing";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (YesBox.Checked && NoBox.Checked)
            {
                MessageBox.Show("You can only pick yes or no, not both");
            }
            else
            {

                DateTime? dateCompleted = null;
                if (DateCompletedPicker.Visible) dateCompleted = DateCompletedPicker.Value;

                try
                {
                    doAction.updatePrescription(thisPrescriptionID, MedicationBox.Text, AmountBox.Text, StrengthBox.Text, RouteBox.Text, FrequencyBox.Text, Double.Parse(RefillsBox.Text), dateCompleted, status);
                    prescriptionTableAdapter.FillByPatientID(eMRDatabaseDataSet.Prescription, thisPatientID);
                    this.Close();


                }
                catch
                {
                    MessageBox.Show("Error: the Medication Name cannot be empty");
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
