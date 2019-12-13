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
    public partial class DateViewAppointments : Form
    {
        public DateViewAppointments()
        {
            InitializeComponent();
        }

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        private void DateViewAppointments_Load(object sender, EventArgs e)
        {
          
            DateTime clickedAppointmentDate = ((SchedulerMain)this.MdiParent).getDate();

            // TODO: This line of code loads data into the 'dataSet1.Patient_Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.eMRDatabaseDataSet.Appointment);

            foreach (Appointment app in doAction.Appointments)
            {
                if (app.DateAppointment == clickedAppointmentDate)
                {
                    this.TopMost = true;
                   
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
    
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DateViewAppointments_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.eMRDatabaseDataSet.Appointment);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
