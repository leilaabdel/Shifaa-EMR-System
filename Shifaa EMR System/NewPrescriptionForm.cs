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
    public partial class NewPrescriptionForm : Form
    {

        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        readonly int thisPatientID;
        readonly string thisProviderName;
        readonly string thisProviderID;


        public NewPrescriptionForm(int patientID , string  providerName , string providerID)
        {
            InitializeComponent();
            this.thisPatientID = patientID;
            this.thisProviderName = providerName;
            this.thisProviderID = providerID;


            MedicationBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MedicationBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MedicationBox.AutoCompleteCustomSource = AutoComplete.PrescriptionNameAutoComplete();


        }

        private void MedicationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPrescriptionForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MedicationBox.Text)) MessageBox.Show("Please enter a valid medication name");
            else
            {

                try
                {
                    doAction.createNewPrescription(MedicationBox.Text, AmountBox.Text, StrengthBox.Text,
                    RouteBox.Text, FrequencyBox.Text, RefillsBox.Text, thisPatientID, thisProviderName, thisProviderID, DateTime.Today);
                    ((PatientHomePage)this.Owner).prescriptionTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.Prescription, thisPatientID);

                }
                catch
                {
                    MessageBox.Show("Please enter the medication name");
                }
            }
       
            
            this.Close();
        }

        private void RouteLabel_Click(object sender, EventArgs e)
        {

        }

        private void RefillsBox_TextChanged(object sender, EventArgs e)
        {
            if(!RefillsBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid integer refill number");
                RefillsBox.Text = null;
            }
        }
    }
}
