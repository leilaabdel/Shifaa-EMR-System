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
    public partial class ProviderMain : Form
    {

        readonly string thisProviderName;
        readonly string thisProviderID;
        readonly List<DateTime> dateList = new List<DateTime>();


        public ProviderMain(string providerName , string providerID)
        {
            this.IsMdiContainer = true;
          
        
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



        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }




        public void Button2_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
            }

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





        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
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
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
            }

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

        }

        private void ContactsToolStripItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
            }

            if (Application.OpenForms["SystemContacts"] as SystemContacts == null)
            {
                SystemContacts systemContacts = new SystemContacts()
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
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != this && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
            }

            if (Application.OpenForms["MessagesView"] as MessagesView == null)
            {
                MessagesView messagesView = new MessagesView(this.thisProviderID)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                Center(messagesView);
                messagesView.Show();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
