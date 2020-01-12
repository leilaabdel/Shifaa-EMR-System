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

        private string schedulerID;
        private string[] providerID;
       
        public SchedulerMain(string schedulerID)
        {
            InitializeComponent();
            this.schedulerID = schedulerID;
        }


        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        public string GetSchedulerID()
        {
            return this.schedulerID;
        }


        private void ExistingAppointments_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["SchedulingCalendar"] as SchedulingCalendar == null)
            {
                SchedulingCalendar schedulingCalendar = new SchedulingCalendar(this.schedulerID , this)
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
            MdiClient schedulerMain;

            this.MaximizeBox = false;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    schedulerMain = (MdiClient)ctl;
                    schedulerMain.BackColor = this.BackColor;

                }
                catch (InvalidCastException exc)
                {

                }

            }
        }

        PatientListView globalPatientList;

        private void SetPatientListView(PatientListView patientListView)
        {
            this.globalPatientList = patientListView;
            this.globalPatientList.MdiParent = this;
            this.globalPatientList.WindowState = FormWindowState.Maximized;
            this.globalPatientList.StartPosition = FormStartPosition.CenterScreen;
            this.globalPatientList.Show();

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

        private void ContactsToolStripItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SystemContacts"] as SystemContacts == null)
            {
                SystemContacts systemContacts = new SystemContacts(schedulerID)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                Center(systemContacts);
                systemContacts.Show();
            }
        }

        private void MessagesToolStripItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["MessagesView"] as MessagesView == null)
            {
                MessagesView messagesView = new MessagesView(this.schedulerID)
                {
                    MdiParent = this

                };
                Center(messagesView);
                messagesView.Show();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["SchedulingCalendar"] as SchedulingCalendar != null)
            {
                SchedulingCalendar s = (SchedulingCalendar)Application.OpenForms["SchedulingCalendar"];
                s.Close();
            }


            if (Application.OpenForms["NewPatient"] as NewPatient == null)
            {
                NewPatient newPatient = new NewPatient(this)
                {
                    MdiParent = this
                    
                };
                Center(newPatient);
                newPatient.Show();
               
            }
           
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(globalPatientList != null)
            {
                globalPatientList.ActivateSearch();
            }
        }

        private void SearchBoxClick(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Patient ID/Name") searchBox.Text = null;
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage"
                     && Application.OpenForms[i].Name != "PatientListView")
                {
                    Application.OpenForms[i].Close();
                }
            }

            if (e.KeyChar == (char)Keys.Return && Application.OpenForms["PatientListView"] as PatientListView == null)

            {
                PatientListView patientListView = new PatientListView(this);
                SetPatientListView(patientListView);
                globalPatientList.ActivateSearch();

            }

            if (e.KeyChar == (char)Keys.Return)
            {
                globalPatientList.ActivateSearch();
            }


        }

        private void ThisFormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public string GetSearchText()
        {
            return searchBox.Text;
        }

    }
}
