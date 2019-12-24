using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shifaa_EMR_System
{



    //TO DO: FUNCTIONALIZE FOR SCHEDULER VIEW 
    public partial class AppointmentListView : Form

    {

     

        public AppointmentListView()
        {

            InitializeComponent();

        }

        Type a = typeof(ProviderMain);

        private void AppointmentListView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.eMRDatabaseDataSet.Appointment);

            this.AppointmentListView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentListView1.MultiSelect = true;


            fillByDate();

           


        }



        public void fillByDate()
        {
            int type = 1;

            Type parentType = this.MdiParent.GetType();
            if(parentType == typeof(ProviderMain)) type = 0;

            List<DateTime> selection;


            switch (type)
            {
                case 0:
                    selection = ((ProviderMain)this.MdiParent).getDateSelection();
                    break;
                default:
                    selection = ((SchedulerMain)this.MdiParent).getDateSelection();
                    break;

            }
            

            this.appointmentTableAdapter.FillByDate(this.eMRDatabaseDataSet.Appointment, selection[0].ToString(), selection[selection.Count - 1].ToString());
                
                

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
