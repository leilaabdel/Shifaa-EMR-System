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

 
    public partial class NewAllergie : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);

        readonly int thispatientID;
        readonly string thisProviderID;
        readonly string thisProviderName;

        public NewAllergie(int patientID, string providerID , string providerName)
        {
            InitializeComponent();
            this.thispatientID = patientID;
            this.thisProviderID = providerID;
            this.thisProviderName = providerName;
            this.WindowState = FormWindowState.Normal;


            AllergyNameBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AllergyNameBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AllergyNameBox.AutoCompleteCustomSource = AutoComplete.AllergyNameAutoComplete();

        }

        private void DetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(AllergyNameBox.Text)) MessageBox.Show("Please enter a valid allergy name");
            else
            {


                try
                {
                    doAction.createNewAllergy(thispatientID, AllergyNameBox.Text, DetailsBox.Text, thisProviderID, thisProviderName, DateTime.Today);
                    ((PatientHomePage)this.Owner).allergieTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.Allergie, thispatientID);
                    this.Close();
                }
                catch(Exception ex)
                {
                    throw (ex);
                }
            }

          
        
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllergyNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewAllergie_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
