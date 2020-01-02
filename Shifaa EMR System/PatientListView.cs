using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShifaaEMRSystem
{

    //TO DO: FUNCTIONALIZE FOR SCHEDULER LIST VIEW

    public partial class PatientListView : Form
    {
      

        public PatientListView(ProviderMain providerMain)
        {
           
                InitializeComponent();

                this.MdiParent = providerMain;
                this.WindowState = FormWindowState.Maximized;

                this.PatientListView1.Columns.Remove("PatientID");
                DataGridViewButtonColumn patientID = new DataGridViewButtonColumn
                {
                    DataPropertyName = "PatientID"
                };
                patientID.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10);
                patientID.Name = "ProviderpatientID";
                patientID.HeaderText = "Patient ID";


                this.PatientListView1.Columns.Insert(0, patientID);


        }

        public PatientListView(SchedulerMain schedulerMain)
        {
            this.MdiParent = schedulerMain;

        }






        private void PatientListView_Load_1(object sender, EventArgs e)
        {

            this.PatientListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientListView1.MultiSelect = false;

        }

        public void ActivateSearch()
        {
            // TODO: This line of code loads data into the 'eMRDatabasePatients.Patient' table. You can move, or remove it, as needed.
            string searchText = ((ProviderMain)this.MdiParent).GetSearchText();

            Console.WriteLine(searchText);

            this.WindowState = FormWindowState.Maximized;


            if (!Int32.TryParse(searchText, out int searchID))
            {
                searchID = -1;
            }

            try
            {
                Console.WriteLine("before");
                this.patientTableAdapter.FillBySearch(this.eMRDatabaseDataSet.Patient, searchID, searchText, searchText);
                Console.WriteLine("after");
            }
            catch(FieldAccessException ex)
            {

                Console.WriteLine(ex);

            }
        }

       

        private void PatientListView1_RowClick(object sender, DataGridViewCellEventArgs e)
        {

            
                if (e.RowIndex >= 0 && PatientListView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    this.PatientListView1.Rows[e.RowIndex].Selected = true;



                    int selectedPatientID = (int)this.PatientListView1["PatientID", e.RowIndex].Value;


                    EMRDatabaseDataSet.PatientDataTable selectedPatient = this.patientTableAdapter.GetDataByPatientID(selectedPatientID);

                    string name = (String)selectedPatient[0]["FirstName"] + " " + (String)selectedPatient[0]["LastName"];
                    string phoneNumber = (String)selectedPatient[0]["PhoneNumber"];
                    string gender = (String)selectedPatient[0]["Gender"];
                    string age = (String)selectedPatient[0]["Age"];
                    DateTime DOB = (DateTime)selectedPatient[0]["DOB"];

                    if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
                    {
                        PatientHomePage patientHome = new PatientHomePage(name, phoneNumber, gender, age, DOB, selectedPatientID, (ProviderMain)this.MdiParent)
                        {
                            MdiParent = (ProviderMain)this.MdiParent
                        };
                        patientHome.Show();
                     

                    }

                    Console.WriteLine("clicked");
                }
            

        }

  

 

        private void PatientListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
