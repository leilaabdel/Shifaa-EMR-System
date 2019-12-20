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
    public partial class PatientListView : Form
    {
        public PatientListView()
        {
            InitializeComponent();
        }

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");





        private void PatientListView_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabasePatients.Patient' table. You can move, or remove it, as needed.
            string searchText = ((ProviderMain)this.MdiParent).getSearchText();
            int searchID = 0;
            if (!Int32.TryParse(searchText, out searchID))
            {
                searchID = -1;
            }

            try
            {
                this.patientTableAdapter.FillBySearch(this.eMRDatabasePatients.Patient, searchID, searchText, searchText);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("There are no patients based on your search critereon.");
            }
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
