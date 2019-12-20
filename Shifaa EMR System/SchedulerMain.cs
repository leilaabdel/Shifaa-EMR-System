using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        public DateTime getDate()
        {
           return  monthCalendar2.SelectionStart.Date;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
