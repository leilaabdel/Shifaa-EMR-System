using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{

    //TO DO: FUNCTIONALIZE FOR SCHEDULER LIST VIEW

    public partial class PatientListView : Form
    {
        private string parentType;
        private ProviderMain providerMain;
        private SchedulerMain schedulerMain;

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
                patientID.Name = "PatientID";
                patientID.HeaderText = "Patient ID";


                this.PatientListView1.Columns.Insert(0, patientID);
            parentType = "provider";
            this.providerMain = providerMain;
            
             


        }

        public PatientListView(SchedulerMain schedulerMain)
        {
            this.MdiParent = schedulerMain;
            parentType = "scheduler";
            this.schedulerMain = schedulerMain;

        }






        private void PatientListView_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
            this.PatientListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientListView1.MultiSelect = false;
            this.AutoScroll = false;

            // disable horizontal scrollbar
            this.HorizontalScroll.Enabled = false;

            // restore AutoScroll
            this.AutoScroll = true;

        }

        private void PatientListViewGotFocus(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScroll = false;

            // disable horizontal scrollbar
            this.HorizontalScroll.Enabled = false;

            // restore AutoScroll
            this.AutoScroll = true;
        }

        private void PatientListViewLostFocus(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

       

            this.AutoScroll = false;

            // disable horizontal scrollbar
            this.HorizontalScroll.Enabled = false;

            // restore AutoScroll
            this.AutoScroll = true;
        }

        public void ActivateSearch()
        {
            if (this.Visible == true)
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
                catch (FieldAccessException ex)
                {

                    Console.WriteLine(ex);

                }

            }
    
        }



        private void PatientListView1_RowClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex >= 0 && PatientListView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && e.ColumnIndex == 0)
                {
                    this.PatientListView1.Rows[e.RowIndex].Selected = true;



                    int selectedPatientID = (int)this.PatientListView1["PatientID", e.RowIndex].Value;


                    EMRDatabaseDataSet.PatientDataTable selectedPatient = this.patientTableAdapter.GetDataByPatientID(selectedPatientID);

                    string name = (String)selectedPatient[0]["FirstName"] + " " + (String)selectedPatient[0]["LastName"];
                    string phoneNumber = (String)selectedPatient[0]["PhoneNumber"];
                    string gender = (String)selectedPatient[0]["Gender"];
                    string age = (String)selectedPatient[0]["Age"];
                    string maritalStatus = (String)selectedPatient[0]["MaritalStatus"];    
                    DateTime DOB = (DateTime)selectedPatient[0]["DOB"];

             

                if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
                    {
                        PatientHomePage patientHome = new PatientHomePage(name, phoneNumber, gender, age, maritalStatus, DOB, selectedPatientID, this.providerMain)
                        {
                            MdiParent = (ProviderMain)this.MdiParent
                        };

                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "ProviderMain" && Application.OpenForms[i].Name != "WelcomeHomePage" &&
                            Application.OpenForms[i].Name != "SchedulerMain")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                    patientHome.Show();
                     

                    }

                    Console.WriteLine("clicked");
                }


            else if (e.RowIndex >= 0 && PatientListView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                this.PatientListView1.Rows[e.RowIndex].Selected = true;
                int selectedPatientID = (int)this.PatientListView1["PatientID", e.RowIndex].Value;
                EMRDatabaseDataSet.PatientDataTable selectedPatient = this.patientTableAdapter.GetDataByPatientID(selectedPatientID);

                string firstName = (String)selectedPatient[0]["FirstName"]; 
                string lastName = (String)selectedPatient[0]["LastName"];
                string phoneNumber = "";
                if (selectedPatient[0]["PhoneNumber"].GetType() != typeof(DBNull))
                {
                    phoneNumber = (String)selectedPatient[0]["PhoneNumber"];
                }
                string gender = (String)selectedPatient[0]["Gender"];
                string age = (String)selectedPatient[0]["Age"];
                string pregnancyStatus = "";
                if (selectedPatient[0]["PregnancyStatus"].GetType() != typeof(DBNull))
                {
                     pregnancyStatus = (String)selectedPatient[0]["PregnancyStatus"];
                }
               

                string maritalStatus = (String)selectedPatient[0]["MaritalStatus"];
                string height = (String)selectedPatient[0]["Height"];
                string weight = (String)selectedPatient[0]["Weight"];
                string nationality = (String)selectedPatient[0]["Nationality"];
                DateTime DOB = (DateTime)selectedPatient[0]["DOB"];

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage" &&
                        Application.OpenForms[i].Name != "ProviderMain" && Application.OpenForms[i].Name != "SchedulerMain")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
                this.Hide();

                if (Application.OpenForms["NewPatient"] as NewPatient == null)
                {
                    if(parentType == "provider")
                    {
                        NewPatient update = new NewPatient(providerMain , selectedPatientID)
                        {
                            MdiParent = (ProviderMain)this.MdiParent,
                        };

                        update.FirstNameBox.Text = firstName;
                        update.LastNameBox.Text = lastName;
                        update.PhoneNumberBox.Text = phoneNumber;
                        if (gender == "Male") update.MaleCheckBox.Checked = true;
                        else
                        {
                            update.FemaleCheckBox.Checked = true;
                            if (pregnancyStatus == "Pregnant") update.PregnantBox.Checked = true;
                            else update.NotPregnantBox.Checked = true;

                        }
                        if (maritalStatus == "Single") update.SingleBox.Checked = true;
                        else update.MarriedBox.Checked = true;
                        update.HeightBox.Text = height;
                        update.WeightBox.Text = weight;
                        update.NationalityBox.Text = nationality;
                        update.Focus();
                        this.Close();
                        this.Dispose();
                        update.Show();
                    }
                    if(parentType == "scheduler")
                    {
                        NewPatient update = new NewPatient(schedulerMain, selectedPatientID)
                        {
                            MdiParent = (ProviderMain)this.MdiParent,
                        };
                        this.Hide();
                        update.FirstNameBox.Text = firstName;
                        update.LastNameBox.Text = lastName;
                        update.PhoneNumberBox.Text = phoneNumber;
                        if (gender == "Male") update.MaleCheckBox.Checked = true;
                        else
                        {
                            update.FemaleCheckBox.Checked = true;
                            if (pregnancyStatus == "Pregnant") update.PregnantBox.Checked = true;
                            else update.NotPregnantBox.Checked = true;

                        }
                        if (maritalStatus == "Single") update.SingleBox.Checked = true;
                        else update.MarriedBox.Checked = true;
                        update.HeightBox.Text = height;
                        update.WeightBox.Text = weight;
                        update.NationalityBox.Text = nationality;
                        update.Focus();
                        this.Close();
                        this.Dispose();
                        update.Show();
                    }

                   


                }


            }



        }





        private void PatientListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }




}
