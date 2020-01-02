using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShifaaEMRSystem
{
    public partial class ProviderMain : Form
    {

        readonly string thisProviderName;
        readonly string thisProviderID;
        readonly List<DateTime> dateList = new List<DateTime>();


        public ProviderMain(string providerName , string providerID)
        {
            this.IsMdiContainer = true;
            this.globalAppointmentList = new AppointmentListView(this);
            globalAppointmentList.MdiParent = this;
            this.globalNewAppointment = new NewAppointment(globalAppointmentList);
            globalNewAppointment.MdiParent = this;
           
            this.thisProviderName = providerName;
            this.thisProviderID = providerID;
            
            InitializeComponent();
        }

        public string GetProviderName()
        {
            return this.thisProviderName;
        }

        public string GetProviderID()
        {
            return this.thisProviderID;
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


        private NewAppointment globalNewAppointment;
 

        public void SetNewAppointment(NewAppointment newAppointment)
        {

          
            this.globalNewAppointment = newAppointment;
            this.globalNewAppointment.MdiParent = this;
            Center(globalNewAppointment);
            this.globalNewAppointment.Show();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            this.AutoScroll = false;
          

            if (Application.OpenForms["NewAppointment"] as NewAppointment == null)
            {
                NewAppointment newAppointment = new NewAppointment(globalAppointmentList)
                {
                    MdiParent = this
                };
                globalAppointmentList.Close();
                SetNewAppointment(newAppointment);
                
            }
        }



        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        AppointmentListView globalAppointmentList;

        private void SetAppointmentListView(AppointmentListView appointmentListView)
        {
            this.globalAppointmentList = appointmentListView;
            this.globalAppointmentList.MdiParent = this;
            this.globalAppointmentList.WindowState = FormWindowState.Maximized;
            this.globalAppointmentList.StartPosition = FormStartPosition.CenterScreen;
         
        }

        public void Button2_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["AppointmentListView"] as AppointmentListView == null)
            {
                AppointmentListView appointmentListView = new AppointmentListView(this)
                {
                    MdiParent = this
                };
                SetAppointmentListView(appointmentListView);
                for (int i = 0; i < globalAppointmentList.GetAppointmentListView().Rows.Count - 1; i++)
                {
                    globalAppointmentList.GetAppointmentListView()["Status", i] = new DataGridViewTextBoxCell();
                    globalAppointmentList.GetAppointmentListView()["PatientID", i] = new DataGridViewButtonCell();
                }

                globalAppointmentList.FillByDate();
                this.globalAppointmentList.Show();


            }



        }





        private void Button3_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["NewPatient"] as NewPatient == null)
            {
                NewPatient newPatient = new NewPatient
                {
                    MdiParent = this
                };
                Center(newPatient);
                newPatient.Show();
            }



        }




        public string GetSearchText()
        {
            return searchBox.Text;
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


        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && Application.OpenForms["PatientListView"] as PatientListView == null )

            {
                PatientListView patientListView = new PatientListView(this);
                SetPatientListView(patientListView);
                globalPatientList.ActivateSearch();
              
            }

            if(e.KeyChar == (char)Keys.Return)
            {
                globalPatientList.ActivateSearch();
            }

           
        }



     
        private void SearchBoxClick(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Patient ID/Name") searchBox.Text = null;
        }

        public List<DateTime> GetDateSelection()
        {
            return dateList;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


            dateList.Clear();


            for (var dt = monthCalendar1.SelectionStart; dt <= monthCalendar1.SelectionEnd; dt = dt.AddDays(1))
            {
                dateList.Add(dt);
            }

            globalNewAppointment.MdiParent = this;


            globalAppointmentList.MdiParent = this;
            globalAppointmentList.FillByDate();

        }

     
    }
}
