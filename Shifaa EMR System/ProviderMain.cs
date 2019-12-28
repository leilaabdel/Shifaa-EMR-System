using System;
using System.Windows.Forms;
using System.Collections.Generic;



namespace Shifaa_EMR_System
{
    public partial class ProviderMain : Form
    {

        string thisProviderName;
        string thisProviderID;

        public ProviderMain(string providerName , string providerID)
        {

            this.thisProviderName = providerName;
            this.thisProviderID = providerID;
            InitializeComponent();
        }

        public string getProviderName()
        {
            return this.thisProviderName;
        }

        public string getProviderID()
        {
            return this.thisProviderID;
        }


       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        List<DateTime> dateList = new List<DateTime>();

        public List<DateTime> getDateSelection()
        {

            return dateList; 

            
        }





        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void patientClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProviderMain_Load(object sender, EventArgs e)
        {
            MdiClient providerMain;
            
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    providerMain = (MdiClient)ctl;
                    providerMain.BackColor = this.BackColor;

                }
                catch (InvalidCastException exc)
                {
                    
                }

                    

            }



        }


        private NewAppointment globalNewAppointment = new NewAppointment();
 

        public void setNewAppointment(NewAppointment newAppointment)
        {
            this.globalNewAppointment = newAppointment;
            this.globalNewAppointment.MdiParent = this;
            
            this.globalNewAppointment.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null)
            {
                NewAppointment newAppointment = new NewAppointment();

                setNewAppointment(newAppointment);

            }
        }





        AppointmentListView globalAppointmentList = new AppointmentListView();

        private void setAppointmentListView(AppointmentListView appointmentListView)
        {
            this.globalAppointmentList = appointmentListView;
            this.globalAppointmentList.MdiParent = this;
            this.globalAppointmentList.WindowState = FormWindowState.Maximized;
            this.globalAppointmentList.StartPosition = FormStartPosition.CenterScreen;
            this.globalAppointmentList.Show();
          
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AppointmentListView"] as AppointmentListView == null)
            {
                AppointmentListView appointmentListView = new AppointmentListView();
                setAppointmentListView(appointmentListView);
                globalAppointmentList.fillByDate()

              
;            }



        }





        private void Button3_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["NewPatient"] as NewPatient == null)
            {
                NewPatient newPatient = new NewPatient();
                newPatient.MdiParent = this;
                newPatient.WindowState = FormWindowState.Maximized;
                newPatient.Show();
            }



        }



        private void searchBox_TextChanged(object sender, EventArgs e)
        {


        }






        private void TextBoxKeyUp(object sender, EventArgs e)
        {

        }

        public string getSearchText()
        {
            return searchBox.Text;
        }


        PatientListView globalPatientList;

        private void setPatientListView(PatientListView patientListView)
        {
            this.globalPatientList = patientListView;
            this.globalPatientList.MdiParent = this;
            this.globalPatientList.WindowState = FormWindowState.Maximized;
            this.globalPatientList.StartPosition = FormStartPosition.CenterScreen;
            this.globalPatientList.Show();

        }


        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && Application.OpenForms["PatientListView"] as PatientListView == null )

            {
                PatientListView patientListView = new PatientListView();
                setPatientListView(patientListView);
                globalPatientList.activateSearch();
              
            }

            if(e.KeyChar == (char)Keys.Return)
            {
                globalPatientList.activateSearch();
            }

           
        }



        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchBoxClick(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Patient ID/Name") searchBox.Text = null;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            dateList.Clear();

            for(DateTime date = monthCalendar1.SelectionStart; date <= monthCalendar1.SelectionEnd; date = date.AddDays(1))
            {
                dateList.Add(date);
            }

            Console.WriteLine(dateList.Count);

            globalNewAppointment.MdiParent = this;
            globalNewAppointment.DisplayAppointmentDates(dateList);

            globalAppointmentList.MdiParent = this;
            globalAppointmentList.fillByDate();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
