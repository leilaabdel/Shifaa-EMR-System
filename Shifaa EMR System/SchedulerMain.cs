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
    public partial class SchedulerMain : Form
    {
        public SchedulerMain()
        {
            InitializeComponent();

        }


        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        private NewAppointment globalNewAppointment;


        public void SetNewAppointment(NewAppointment newAppointment)
        {
            this.globalNewAppointment = newAppointment;
            this.globalNewAppointment.MdiParent = this;

            this.globalNewAppointment.Show();
        }


        private void ExistingAppointments_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["SchedulingCalendar"] as SchedulingCalendar == null)
            {
                SchedulingCalendar schedulingCalendar = new SchedulingCalendar(thisProviderID, this)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized




                };

                Center(schedulingCalendar);
                schedulingCalendar.Show();



            }
        }





        private void SchedulerMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        List<DateTime> dateList = new List<DateTime>();

        private void MonthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateList.Clear();


            for (var dt = monthCalendar2.SelectionStart; dt <= monthCalendar2.SelectionEnd; dt = dt.AddDays(1))
            {
                dateList.Add(dt);
            }



        }

        public List<DateTime> GetDateSelection()
        {
            return dateList;
        }

    }
}
