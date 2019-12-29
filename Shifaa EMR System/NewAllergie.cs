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
        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");

        int thispatientID;
        string thisProviderID;
        string thisProviderName;

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
            try
            {
                doAction.createNewAllergy(thispatientID, AllergyNameBox.Text, DetailsBox.Text, thisProviderID, thisProviderName);
                 this.allergieTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.Allergie, thispatientID);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter an allergy or close the current page");
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
