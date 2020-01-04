using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Windows.Forms.Calendar;

namespace Shifaa_EMR_System
{
    public partial class NewAppointmentFromPatientView : Form
    {
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        readonly int thisPatientID;
        readonly string providerID;
        readonly CalendarItem calendarItem;

        public NewAppointmentFromPatientView(int patientID , string providerID , CalendarItem calendarItem )
        {
            InitializeComponent();
 
            this.thisPatientID = patientID;
            this.providerID = providerID;
            this.calendarItem = calendarItem;

        }

        private void NewAppointmentFromPatientView_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string patientFirstName = "";
                string patientLastName = "";

              

                ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(thisPatientID);

                foreach (getPatientByIDResult r in result)
                {
                    patientFirstName = r.FirstName;
                    patientLastName = r.LastName;

                }

                doAction.CreateAppointment(patientFirstName, patientLastName, AppointmentDetails.Text, calendarItem.StartDate , 
                    calendarItem.EndDate , thisPatientID , DateTime.Now , providerID);
                //((PatientHomePage)this.Owner).appointmentTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.Appointment, thisPatientID);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter valid dates and times");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentDetails_Clicked(object sender, EventArgs e)
        {
            if(AppointmentDetails.Text == "Appointment Details")
            {
                AppointmentDetails.Text = null;
            }
        }
    }
}
