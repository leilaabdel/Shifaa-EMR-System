using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Shifaa_EMR_System

{


    public partial class NewAppointment : Form
    {

        private List<DateTime> dateList;
        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");



        public NewAppointment()
        {

            InitializeComponent();

        }

        Type a = typeof(ProviderMain);


        private void NewAppointment_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.eMRDatabaseDataSet.Patient);
    

            this.PatientListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientListView.MultiSelect = false;

            // TODO: This line of code loads data into the 'eMRDatabasePatients.Patient' table. You can move, or remove it, as needed.


         


            




            readDatabase();

            PatientIDAutoCompleteText();
            FirstNameAutoCompleteText();
            LastNameAutoCompleteText();


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


   



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Console.WriteLine("saveBlah");
            try
            {




                int rowIndex = PatientListView.CurrentRow.Index;
                var selectedPatientIDCell = this.PatientListView["PatientID", rowIndex];
                int selectedPatientID = (Int32)selectedPatientIDCell.Value;


                Console.WriteLine(selectedPatientID.ToString());

                



                doAction.CreateAppointment(FirstName.Text, LastName.Text, AppointmentDetails.Text, ScheduledDatePicker.Value, ScheduledTimePicker.Value.ToString(), DurationTimePicker.Value.ToString()
                    , selectedPatientID);
        



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



        private void label5_Click(object sender, EventArgs e)
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


        private AutoCompleteStringCollection patientIDColl = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection firstNameColl = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection lastNameColl = new AutoCompleteStringCollection();

        private void readDatabase()
        {

            AutoCompleteStringCollection[] collection = new AutoCompleteStringCollection[3];

            collection[0] = patientIDColl;
            collection[1] = firstNameColl;
            collection[2] = lastNameColl;


            string conString = @"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!";
            string Query = "select PatientID,  FirstName , LastName from dbo.Patient ;";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand command = new SqlCommand(Query, conDataBase);
            SqlDataReader reader;


            try
            {
                conDataBase.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int patientID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);


                    foreach (AutoCompleteStringCollection coll in collection)
                    {
                        int i = Array.IndexOf(collection, coll);

                        switch (i)
                        {
                            case 0:
                                coll.Add(patientID.ToString());
                                break;
                            case 1:
                                coll.Add(firstName);
                                break;
                            case 2:
                                coll.Add(lastName);
                                break;
                        }
                    }
                }

                reader.Close();
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void PatientIDAutoCompleteText()
        {
            PatientIDNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PatientIDNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PatientIDNum.AutoCompleteCustomSource = patientIDColl;
        }


        private void FirstNameAutoCompleteText()
        {
            FirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            FirstName.AutoCompleteCustomSource = firstNameColl;
        }

        void LastNameAutoCompleteText()
        {
            LastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            LastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LastName.AutoCompleteCustomSource = lastNameColl;
        }



        private void PatientListView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // TO DO: Inseart Code Here 
        }


      
        private void PatientListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void fillBySearchToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void StartDate_Click(object sender, EventArgs e)
        {

        }

        private void ToLabel_Click(object sender, EventArgs e)
        {

        }

        private void EndDate_Click(object sender, EventArgs e)
        {

        }

        private void DateSelectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ScheduledDatePicker_ValueChanged(object sender, EventArgs e)
        {
  
        }
    }
}

