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


            getAppointmentDate(a);


            int h = 1;
            int m = 1;

            for (h = 1; h <= 12; h++)
            {
                hourBox1.Items.Add(h);
                hourBox2.Items.Add(h);

            }

            for (m = 0; m <= 59; m++)
            {
                minuteBox1.Items.Add(m);
                minuteBox2.Items.Add(m);
            }






            readDatabase();

            PatientIDAutoCompleteText();
            FirstNameAutoCompleteText();
            LastNameAutoCompleteText();


        }


        public List<DateTime> DisplayAppointmentDates(List<DateTime> selection)
        {

            try
            {
                int selectionLength = 0;
                if (selection != null)
                    selectionLength = selection.Count;



                switch (selectionLength)
                {
                    case 1:
                        this.StartDate.Hide();
                        this.EndDate.Hide();
                        this.DateSelectionLabel.Hide();
                        this.ToLabel.Hide();

                        this.DateLabel.Show();
                        this.DateBox.Show();
                        DateBox.Text = selection[0].ToShortDateString();
                        return selection;

                    default:
                        this.DateLabel.Hide();
                        this.DateBox.Hide();

                        this.StartDate.Show();
                        this.StartDate.Text = selection[0].ToShortDateString();
                        this.EndDate.Show();
                        this.EndDate.Text = selection[selectionLength - 1].ToShortDateString();
                        this.DateSelectionLabel.Show();
                        this.ToLabel.Show();
                        return selection;

                }
            }
            catch (NullReferenceException ex)
            {
                return null;

            }
        }

        private List<DateTime> getAppointmentDate(Type a)
        {


            if (this.MdiParent.GetType().Equals(a))
            {

                List<DateTime> selection = ((ProviderMain)this.MdiParent).getDateSelection();

                return DisplayAppointmentDates(selection);

            }
            else
            {
                List<DateTime> selection = ((SchedulerMain)this.MdiParent).getDateSelection();
                return DisplayAppointmentDates(selection);
            }



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


        private void hourBox1_Click(object sender, EventArgs e)
        {
            while (hourBox1.Text == "Hour") hourBox1.Text = null;

        }

        private void hourBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int result = 1;

            try
            {
                if (!String.IsNullOrEmpty(hourBox1.Text))
                {
                    result = Int32.Parse(hourBox1.Text);
                }

                if (result < 1 || result > 24)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter an hour between 1 and 24.");
                    hourBox1.Text = null;
                }

            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid hour integer.");
                hourBox1.Text = null;
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


                string makeTime = hourBox1.Text + ":" + minuteBox1.Text;
                string makeDuration = hourBox2.Text + ":" + minuteBox2.Text;


                if (!makeTime.Any(Char.IsDigit)) makeTime = null;
                if (!makeDuration.Any(Char.IsDigit)) makeDuration = null;


                Console.WriteLine(makeTime + "blah");
                Console.WriteLine(makeDuration + "blah");


                int rowIndex = PatientListView.CurrentRow.Index;
                var selectedPatientIDCell = this.PatientListView["PatientID", rowIndex];
                int selectedPatientID = (Int32)selectedPatientIDCell.Value;


                Console.WriteLine(selectedPatientID.ToString());

                List<DateTime> selection;

                if (this.MdiParent.GetType() == typeof(ProviderMain))
                {
                    selection = ((ProviderMain)this.MdiParent).getDateSelection();
                }
                else
                {
                    selection = ((SchedulerMain)this.MdiParent).getDateSelection();
                }

                foreach (DateTime date in selection)
                {
                    doAction.CreateAppointment(FirstName.Text, LastName.Text, AppointmentDetails.Text, date, makeTime, makeDuration, selectedPatientID);
                }




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

        private void minuteBox1_Click(object sender, EventArgs e)
        {
            while (minuteBox1.Text == "Minute") minuteBox1.Text = null;

        }


        private void minuteBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = 1;

            try
            {
                if (!String.IsNullOrEmpty(minuteBox1.Text))
                {
                    result = Int32.Parse(minuteBox1.Text);
                }

                if (result >= 1 && result <= 60)
                {
                    return;
                }
                System.Windows.Forms.MessageBox.Show("Please enter a minute between 1 and 60.");
                minuteBox1.Text = null;

            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid minute integer.");
                minuteBox1.Text = null;
            }
        }

        private void hourBox2_Click(object sender, EventArgs e)
        {
            while (hourBox2.Text == "Hour") hourBox2.Text = null;

        }

        private void hourBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = 1;

            try
            {
                if (!String.IsNullOrEmpty(hourBox2.Text))
                {
                    result = Int32.Parse(hourBox2.Text);
                }

                if (result < 1 || result > 24)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter an hour between 1 and 24.");
                    hourBox2.Text = null;
                }

            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid hour integer.");
                hourBox2.Text = null;
            }
        }

        private void minuteBox2_Click(object sender, EventArgs e)
        {
            while (minuteBox2.Text == "Minute") minuteBox2.Text = null;

        }

        private void minuteBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = 1;

            try
            {
                if (!String.IsNullOrEmpty(minuteBox2.Text))
                {
                    result = Int32.Parse(minuteBox2.Text);
                }

                if (result < 1 || result > 60)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a minute between 1 and 60.");
                    minuteBox2.Text = null;
                }

            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid minute integer.");
                minuteBox2.Text = null;
            }
        }

        private void AppointmentDescriptionLabel_Click(object sender, EventArgs e)
        {

        }


        public Label GetDateLabel()
        {
            return DateBox;
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
            catch (Exception ex)
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
            catch (Exception ex)
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
                catch (Exception ex)
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
            catch (Exception ex)
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


        int selectedPatientID;

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
    }
}

