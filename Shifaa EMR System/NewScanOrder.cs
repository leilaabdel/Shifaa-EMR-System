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
    public partial class NewScanOrder : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly int thisPatientID;
        readonly string thisProviderName;
        readonly string thisProviderID;

        public NewScanOrder(int patientID , string providerName , string providerID)
        {
            InitializeComponent();
            this.thisPatientID = patientID;
            this.thisProviderName = providerName;
            this.thisProviderID = providerID;


            ScanNameBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ScanNameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ScanNameBox.AutoCompleteCustomSource = AutoComplete.ScanNameAutoComplete();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(ScanNameBox.Text)) MessageBox.Show("Please enter a valid scan or procedure name");
            else
            {
                try
                {
                    doAction.createNewScanOrProcedureOrder(ScanNameBox.Text, DetailsBox.Text, thisProviderName, thisProviderID, thisPatientID, ScheduledDatePicker.Value, DateTime.Today);
                    ((PatientHomePage)this.Owner).patientScanTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.PatientScan, thisPatientID);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
          
        }

        private void NewScanOrder_Load(object sender, EventArgs e)
        {

        }

        private void ScanNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
