using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shifaa_EMR_System
{
    public partial class SchedulerMain : Form
    {
        public SchedulerMain()
        {
            InitializeComponent();
        }

        public string type()
        {
            return "Scheduler";
        }


        private void ExistingAppointments_Click(object sender, EventArgs e)
        {
            PatientListView sOldAppointments = new PatientListView();
            sOldAppointments.MdiParent = this;
            sOldAppointments.Show();
        }

        private void NewAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment sForm = new NewAppointment();
            sForm.MdiParent = this;
            sForm.Show();


        }

        private void SchedulerMain_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!dateList.Contains(monthCalendar2.SelectionStart))
            {
                dateList.Add(monthCalendar2.SelectionStart);
            }

            foreach (DateTime date in dateList)
            {
                if (date.Ticks < monthCalendar2.SelectionStart.Ticks || date.Ticks > monthCalendar2.SelectionEnd.Ticks)
                {
                    dateList.Remove(date);
                }
            }
        }

        public DateTime getDate()
        {
            return monthCalendar2.SelectionStart.Date;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        
        List<DateTime> dateList = new List<DateTime>();

        public List<DateTime> getDateSelection()
        {

            return dateList;


        }

    }

}
