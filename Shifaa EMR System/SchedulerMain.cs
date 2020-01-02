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
            globalAppointmentList = new AppointmentListView(this);
            globalNewAppointment = new NewAppointment(this , globalAppointmentList);
        }

        public static string type() => "Scheduler";

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        private NewAppointment globalNewAppointment;


        public void setNewAppointment(NewAppointment newAppointment)
        {
            this.globalNewAppointment = newAppointment;
            this.globalNewAppointment.MdiParent = this;

            this.globalNewAppointment.Show();
        }


        private void ExistingAppointments_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AppointmentListView"] as AppointmentListView == null)
            {
                DataGridViewTextBoxColumn TextBoxCell = new DataGridViewTextBoxColumn();
                AppointmentListView appointmentListView = new AppointmentListView(this);
                setAppointmentListView(appointmentListView);
                for (int i = 0; i < globalAppointmentList.getAppointmentListView().Rows.Count - 1; i++)
                {
                    globalAppointmentList.getAppointmentListView()["PatientID", i] = new DataGridViewTextBoxCell();
                    globalAppointmentList.getAppointmentListView()["Status", i] = new DataGridViewButtonCell();
                }

                globalAppointmentList.fillByDate();
                this.globalAppointmentList.Show();


            }
        }

        AppointmentListView globalAppointmentList;

        private void setAppointmentListView(AppointmentListView appointmentListView)
        {
            this.globalAppointmentList = appointmentListView;
            this.globalAppointmentList.MdiParent = this;
            this.globalAppointmentList.WindowState = FormWindowState.Maximized;
            this.globalAppointmentList.StartPosition = FormStartPosition.CenterScreen;
         

        }


        private void NewAppointment_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null)
            {
                NewAppointment newAppointment = new NewAppointment(this , globalAppointmentList);
                Center(newAppointment);
                setNewAppointment(newAppointment);

            }

        }

        private void SchedulerMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateList.Clear();
            for (var dt = monthCalendar2.SelectionStart; dt <= monthCalendar2.SelectionEnd; dt = dt.AddDays(1))
            {
                dateList.Add(dt);
            }

            globalNewAppointment.MdiParent = this;


            globalAppointmentList.MdiParent = this;
            globalAppointmentList.fillByDate();
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
