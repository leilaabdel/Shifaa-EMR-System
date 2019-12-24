using System;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{

    //TO DO: FUNCTIONALIZE FOR SCHEDULER LIST VIEW

    public partial class PatientListView : Form
    {
        public PatientListView()
        {
            InitializeComponent();
        }

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");





        private void PatientListView_Load_1(object sender, EventArgs e)
        {

            this.PatientListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientListView1.MultiSelect = false;

        }

        public void activateSearch()
        {
            // TODO: This line of code loads data into the 'eMRDatabasePatients.Patient' table. You can move, or remove it, as needed.
            string searchText = ((ProviderMain)this.MdiParent).getSearchText();

            Console.WriteLine(searchText);

            this.WindowState = FormWindowState.Maximized;

            int searchID = 0;

            if (!Int32.TryParse(searchText, out searchID))
            {
                searchID = -1;
            }

            try
            {
                Console.WriteLine("before");
                this.patientTableAdapter.FillBySearch(this.eMRDatabaseDataSet.Patient, searchID, searchText, searchText);
                Console.WriteLine("after");
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex);

            }
        }

       

        private void PatientListView1_RowDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.PatientListView1.Rows[e.RowIndex].Selected = true;



            int selectedPatientID = (Int32)this.PatientListView1["PatientID", e.RowIndex].Value;


            EMRDatabaseDataSet.PatientDataTable selectedPatient = this.patientTableAdapter.GetDataByPatientID(selectedPatientID);

            string name = (String)selectedPatient[0]["FirstName"] + " " + (String)selectedPatient[0]["LastName"];
            string phoneNumber = (String)selectedPatient[0]["PhoneNumber"];
            string gender = (String)selectedPatient[0]["Gender"];
            string age = (String)selectedPatient[0]["Age"];
            DateTime DOB = (DateTime)selectedPatient[0]["DOB"];

            if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
            {
                PatientHomePage patientHome = new PatientHomePage(name, phoneNumber, gender, age, DOB, selectedPatientID, (ProviderMain)this.MdiParent);
                patientHome.MdiParent = (ProviderMain)this.MdiParent;
                patientHome.Show();
            }

            Console.WriteLine("clicked");



        }

        private void Exit_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

      
    }




}
