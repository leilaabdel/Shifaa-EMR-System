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
        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int thisPatientID;
        string thisProviderName;
        string thisProviderID;

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
            doAction.createNewScanOrProcedureOrder(ScanNameBox.Text, DetailsBox.Text, thisProviderName, thisProviderID, thisPatientID, ScheduledDatePicker.Value , DateTime.Today);
            ((PatientHomePage)this.Owner).patientScanTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.PatientScan, thisPatientID);
            this.Close();
        }

        private void NewScanOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
