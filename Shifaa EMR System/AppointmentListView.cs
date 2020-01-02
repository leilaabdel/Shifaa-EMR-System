using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shifaa_EMR_System
{



    //TO DO: FUNCTIONALIZE FOR SCHEDULER VIEW 
    public partial class AppointmentListView : Form

    {

        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int selectedAppointmentID = 0;
        ProviderMain thisProviderMain;


        public int GetSelectedAppointmentID()
        {
            return selectedAppointmentID;
        }



        public AppointmentListView(ProviderMain providerMain)
        {

            InitializeComponent();
          
            this.MdiParent = providerMain;
            this.WindowState = FormWindowState.Maximized;
            thisProviderMain = providerMain;
            this.AppointmentListView1.Columns.Remove("Status");
            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status"
            };
            status.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10);
            status.Name = "ProviderStatus";
            status.HeaderText = "Status";


           this.AppointmentListView1.Columns.Insert(7, status);




        }

        public AppointmentListView(SchedulerMain schedulerMain)
        {
      
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            this.AppointmentListView1.Columns.Remove("PatientID");
            DataGridViewTextBoxColumn patientID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientID",
                Name = "SchedulerPatientID",
                HeaderText = "Patient ID"
            };


            this.AppointmentListView1.Columns.Insert(0, patientID);


        }




        private void AppointmentListView_Load(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.eMRDatabaseDataSet.Appointment);

            this.AppointmentListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentListView1.MultiSelect = true;

            


            

            FillByDate();

        }




        // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.


        public DataGridView GetAppointmentListView()
        {
            return this.AppointmentListView1;
        }



        public void FillByDate()
        {
            int type = 1;

            Type parentType = this.MdiParent.GetType();
            if(parentType == typeof(ProviderMain)) type = 0;

            List<DateTime> selection;


            switch (type)
            {
                case 0:
                    selection = ((ProviderMain)this.MdiParent).GetDateSelection();
                    break;
                default:
                    selection = ((SchedulerMain)this.MdiParent).GetDateSelection();
                    break;

            }

            Console.WriteLine(selection.Count);

            if (selection.Count == 0) selection.Add(DateTime.Today);
           

            this.appointmentTableAdapter.FillByDate(this.eMRDatabaseDataSet.Appointment, selection[0].ToString(), selection[selection.Count - 1].ToString());


            selection.Clear();

           


        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AppointmentListView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var appointmentListGrid = (DataGridView)sender;
            selectedAppointmentID = (int)appointmentListGrid["appointmentID", e.RowIndex].Value;
            if (e.RowIndex >= 0 && appointmentListGrid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell &&
                appointmentListGrid.CurrentCell.ColumnIndex == 7 && (String)appointmentListGrid.CurrentCell.Value == "Scheduled")
            {

                try
                {
                    DataGridViewTextBoxCell TextBoxCell = new DataGridViewTextBoxCell();
                    string checkedIn = "Checked in at: " + DateTime.Now.ToString("HH:mm");
                    appointmentListGrid[e.ColumnIndex, e.RowIndex].Value = checkedIn;
                    doAction.updateAppointment(checkedIn, selectedAppointmentID);
                    appointmentListGrid[e.ColumnIndex, e.RowIndex] = TextBoxCell;
                  

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }

            }

            if (e.RowIndex >= 0 && appointmentListGrid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell &&
                appointmentListGrid.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
                    {
                 
                   

                        
                        int selectedPatientID = (int)AppointmentListView1["PatientID", e.RowIndex].Value;

                        Console.WriteLine("hello I passed");


                       
                        string firstName = null;
                        string lastName = null;
                        string number = null;
                        string gender = null;
                        DateTime? DOB = null;
                        string age = null;

                        ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(selectedPatientID);

                      
                        foreach (getPatientByIDResult r in result)
                        {
                            firstName = r.FirstName;
                            lastName = r.LastName;
                            number = r.PhoneNumber;
                            gender = r.Gender;
                            DOB = r.DOB;
                            age = r.Age;

                            Console.WriteLine(1);

                        }

                        string patientFullName = firstName + " " + lastName;

                        Console.WriteLine(patientFullName);
                      

                        PatientHomePage newPatientHomePage = new PatientHomePage(patientFullName, number, gender, age, Convert.ToDateTime(DOB), selectedPatientID, thisProviderMain, this)
                        {
                            MdiParent = thisProviderMain
                        };
                       

                        Center(newPatientHomePage);
                        newPatientHomePage.Show();
                     
                     
                    }
                }
                catch(Exception ex)
                {
                    //while (ex.InnerException != null) ex = ex.InnerException;
                    throw (ex);
                }
            }

        }
        private void AppointmentListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Close();
        }
    }
}
