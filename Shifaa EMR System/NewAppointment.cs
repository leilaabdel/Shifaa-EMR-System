using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.Calendar;
using System.Data.Linq;


namespace Shifaa_EMR_System

{


    public partial class NewAppointment : Form
    {

     
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");

        private  int  selectedPatientID;
        private readonly CalendarItem calendarItem;
        private readonly string providerID;
        private readonly int appointmentID;

        public NewAppointment(CalendarItem item , string providerID)
        {

            InitializeComponent();

            this.calendarItem = item;
            this.providerID = providerID;
            
        }

       
   


        private void NewAppointment_Load(object sender, EventArgs e)

        {
            this.patientTableAdapter.Fill(this.eMRDatabaseDataSet.Patient);
           

            this.WindowState = FormWindowState.Normal;
            this.PatientListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientListView.MultiSelect = false;

            PatientIDNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PatientIDNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PatientIDNum.AutoCompleteCustomSource = AutoComplete.PatientIDAutoComplete();


          
             FirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             FirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
             FirstName.AutoCompleteCustomSource = AutoComplete.PatientFirstNameAutoComplete();
     

         
             LastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             LastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
             LastName.AutoCompleteCustomSource = AutoComplete.PatientLastNameAutoComplete();








        }

     
        public string GetProviderName()
        {
            string name = "";
            ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(providerID);
            foreach (getProviderInfoResult r in result)
            {
                name =  r.FirstName + " " + r.LastName + " " + r.Title;
            }

            return name;
        }

        public int GetPatientID()
        {
            return selectedPatientID;
        }

        public int GetAppointmentID()
        {
            return appointmentID;
        }


        public string GetAppointmentDetails()
        {
            return this.AppointmentDetails.Text;
        }

        public string GetFirstName()
        {
            int rowIndex = this.PatientListView.CurrentRow.Index;
            return (String)this.PatientListView["FirstName1", rowIndex].Value;
        }

        public string GetLastName()
        {
            int rowIndex = this.PatientListView.CurrentRow.Index;
            return (String)this.PatientListView["LastName1", rowIndex].Value;
        }

        private void FirstNameClick(object sender, EventArgs e)
        {
            while (FirstName.Text == "First Name")
            {
                FirstName.Text = null;
            }
        }

        private void LastNameClick(object sender, EventArgs e)
        {
            while (LastName.Text == "Last Name")
            {
                LastName.Text = null;
            }
        }

        private void AppointmentDetailsClick(object sender, EventArgs e)
        {
            while (AppointmentDetails.Text == "Appointment Details")
            {
                AppointmentDetails.Text = null;
            }
        }


   



        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Console.WriteLine("saveBlah");
            try
            {




                int rowIndex = PatientListView.CurrentRow.Index;
                var selectedPatientIDCell = this.PatientListView["PatientID", rowIndex];
                selectedPatientID = (Int32)selectedPatientIDCell.Value;

                Console.WriteLine(selectedPatientID);

                Console.WriteLine(selectedPatientID.ToString());



                string firstName = (String)this.PatientListView["FirstName1", rowIndex].Value;
                string lastName = (String)this.PatientListView["LastName1", rowIndex].Value;
   
                doAction.CreateAppointment(firstName, lastName, AppointmentDetails.Text, calendarItem.StartDate, calendarItem.EndDate, selectedPatientID, DateTime.Now,
                    providerID);


                this.Close();

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("This patient is not in the system. Please add them as a new patient");
                this.Close();

                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;



            }


        }




        private void Exit_Click(object sender, EventArgs e)
        {

            Console.WriteLine("closeblah");

            this.Close();
        }

    
       
        private void AppointmentDescriptionLabel_Click(object sender, EventArgs e)
        {

        }



        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            while (LastName.Text.Any(Char.IsDigit))
            {
                LastName.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid last name");
            }

            int PatientIDNumInt = 0;

            while (!(String.IsNullOrEmpty(PatientIDNum.Text)) && PatientIDNum.Text != "Patient ID #")
            {
                PatientIDNumInt = Int32.Parse(PatientIDNum.Text);
            }

            try
            {

                this.patientTableAdapter.FillBySearch(this.eMRDatabaseDataSet.Patient, PatientIDNumInt, FirstName.Text, LastName.Text);
            }
            catch (FormatException ex)
            {

                //TO DO: Get rid of this when functional
                MessageBox.Show(ex.Message);

                Console.WriteLine("error");
            }


        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            while (FirstName.Text.Any(Char.IsDigit))
            {
                FirstName.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid first name");
            }

            int PatientIDNumInt = 0;

            while (!(String.IsNullOrEmpty(PatientIDNum.Text)) && PatientIDNum.Text != "Patient ID #")
            {
                PatientIDNumInt = Int32.Parse(PatientIDNum.Text);
            }



            try
            {

                this.patientTableAdapter.FillBySearch(this.eMRDatabaseDataSet.Patient, PatientIDNumInt, FirstName.Text, LastName.Text);

            }
            catch (FieldAccessException ex)
            {
                //TO DO: Get rid of this when functional
                MessageBox.Show(ex.Message);
            }


        }

        private void PatientIDNum_TextChanged(object sender, EventArgs e)
        {

            int patientIDNumInt;

            if (!(String.IsNullOrEmpty(PatientIDNum.Text)) && PatientIDNum.Text != "Patient ID #")
            {

                try
                {
                    patientIDNumInt = Int32.Parse(PatientIDNum.Text);
                    Console.WriteLine("parsed");
                }
                catch (FormatException)
                {
                    PatientIDNum.Text = null;
                    patientIDNumInt = 0;
                    MessageBox.Show("Please enter a valid patient ID number integer");
                }

                try
                {

                    this.patientTableAdapter.FillBySearch(this.eMRDatabaseDataSet.Patient, patientIDNumInt, FirstName.Text, LastName.Text);
                    Console.WriteLine("search tried");

                }
                catch (FieldAccessException ex)
                {
                    //TO DO: Get rid of this when functional
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void PatientIDNum_Click(object sender, EventArgs e)
        {
            if (PatientIDNum.Text == "Patient ID #") PatientIDNum.Text = null;
        }


   




      


        private void PatientListView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // TO DO: Insert Code Here 

      
        }


      
        private void PatientListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }


   
        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

