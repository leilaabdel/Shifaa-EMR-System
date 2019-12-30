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

        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int selectedAppointmentID = 0;

        public int getSelectedAppointmentID()
        {
            return selectedAppointmentID;
        }

        public AppointmentListView()
        {

            InitializeComponent();

        }

        Type a = typeof(ProviderMain);

        private void AppointmentListView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.eMRDatabaseDataSet.Appointment);

            this.AppointmentListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentListView1.MultiSelect = true;


            fillByDate();

           


        }

        public DataGridView getAppointmentListView()
        {
            return this.AppointmentListView1;
        }



        public void fillByDate()
        {
            int type = 1;

            Type parentType = this.MdiParent.GetType();
            if(parentType == typeof(ProviderMain)) type = 0;

            List<DateTime> selection;


            switch (type)
            {
                case 0:
                    selection = ((ProviderMain)this.MdiParent).getDateSelection();
                    break;
                default:
                    selection = ((SchedulerMain)this.MdiParent).getDateSelection();
                    break;

            }
            

            this.appointmentTableAdapter.FillByDate(this.eMRDatabaseDataSet.Appointment, selection[0].ToString(), selection[selection.Count - 1].ToString());
                
                

        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var appointmentListGrid = (DataGridView)sender;
            selectedAppointmentID = (Int32)appointmentListGrid["appointmentID", e.RowIndex].Value;
            string checkedIn = null;



            if(e.RowIndex >= 0 && appointmentListGrid[e.ColumnIndex , e.RowIndex] is DataGridViewButtonCell &&
                appointmentListGrid.CurrentCell.ColumnIndex == 6)
            {

                try
                {
                    DataGridViewTextBoxCell TextBoxCell = new DataGridViewTextBoxCell();
                    checkedIn = "Checked in at: " + DateTime.Now.ToString("HH:mm");
                    appointmentListGrid[e.ColumnIndex, e.RowIndex].Value = checkedIn;
                    doAction.updateAppointment(checkedIn, selectedAppointmentID);
                    appointmentListGrid[e.ColumnIndex, e.RowIndex] = TextBoxCell;

                }
                catch
                {
                    MessageBox.Show("Error");
                }
               
            }

            if (e.RowIndex >= 0 && appointmentListGrid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell &&
                appointmentListGrid.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
                    {

                        int selectedPatientID = (Int32)AppointmentListView1["PatientID", e.RowIndex].Value;
                        string firstName = null;
                        string lastName = null;
                        string number = null;
                        string gender = null;
                        DateTime? DOB = null;
                        string age = null;

                        ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(selectedPatientID);
                        foreach (getPatientByIDResult r in result){
                            firstName = r.FirstName;
                            lastName = r.LastName;
                            number = r.PhoneNumber;
                            gender = r.Gender;
                            DOB = r.DOB;
                            age = r.Age;

                        }

                        string patientFullName = firstName + " " + lastName;

                        PatientHomePage newPatientHomePage = new PatientHomePage(patientFullName, number, gender, age, Convert.ToDateTime(DOB), selectedPatientID, (ProviderMain)this.MdiParent , this); 
                        Center(newPatientHomePage);
                        newPatientHomePage.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

        }

      
    }
}
