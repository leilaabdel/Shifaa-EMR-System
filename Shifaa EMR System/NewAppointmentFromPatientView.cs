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
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        
        readonly int thisPatientID;
        readonly string providerID;
        readonly CalendarItem calendarItem;
        Calendar calendar1;
        List<CalendarItem> items;
        private SchedulingCalendar schedulingCalendar;
        private PatientHomePage patientHome;

        public NewAppointmentFromPatientView(int patientID , string providerID , CalendarItem calendarItem  , Calendar calendar1 , List<CalendarItem> items , SchedulingCalendar schedulingCalendar, PatientHomePage patientHome)
        {
            InitializeComponent();
 
            this.thisPatientID = patientID;
            this.providerID = providerID;
            this.calendarItem = calendarItem;
            this.calendar1 = calendar1;
            this.items = items;
            this.schedulingCalendar = schedulingCalendar;
            this.patientHome = patientHome;




        }

        private void NewAppointmentFromPatientView_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = calendarItem.StartDate;
            dateTimePicker2.Value = calendarItem.EndDate;
        }


        public string GetProviderName()
        {
            string name = "";
            ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(providerID);
            foreach (getProviderInfoResult r in result)
            {
                name = r.FirstName + " " + r.LastName + " " + r.Title;
            }

            return name;
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

                doAction.CreateAppointment(patientFirstName, patientLastName, AppointmentDetails.Text, dateTimePicker1.Value, dateTimePicker2.Value, thisPatientID, System.DateTime.Now,
                    this.providerID);


                calendarItem.StartDate = dateTimePicker1.Value;
                calendarItem.EndDate = dateTimePicker2.Value;

                ISingleResult<getJustCreatedAppointmentIDResult> result1 = doAction.getJustCreatedAppointmentID();


                int apptID = 0;
                foreach (getJustCreatedAppointmentIDResult r in result1)
                {
                    apptID = r.appointmentID;
               
                }
                

                string apptText =  patientFirstName + " " + patientLastName + "\n" +
                GetProviderName() + "\n" + AppointmentDetails.Text;

                CalendarItem cal = new CalendarItem(calendar1, dateTimePicker1.Value,
                    dateTimePicker2.Value, apptText, patientFirstName , patientLastName , 
                    apptID, thisPatientID, this.providerID, "Scheduled");
                cal.BackgroundColor = Color.Blue;

                schedulingCalendar.GetCalendarItems().Add(cal);

                schedulingCalendar.PlaceItems(items);


                this.Close();

            }
            catch(Exception ex)
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
