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
    public partial class NewAppointment : Form 
    {
        DataClasses1DataContext doAction = new DataClasses1DataContext();
        DateTime superAppointmentDate; 


        public NewAppointment()
        { 
     
            InitializeComponent();
          
        }


        private void NewAppointment_Load(object sender, EventArgs e)
        {
         DateTime newAppointmentDate = ((SchedulerMain)this.MdiParent).getDate();


            int h = 1;
            int m = 1;

            for (h = 1; h <= 12; h++)
            {
                hourBox1.Items.Add(h);
                hourBox2.Items.Add(h);

            }

            for (m = 1; m <= 59; m++)
            {
                minuteBox1.Items.Add(m);
                minuteBox2.Items.Add(m);
            }

            superAppointmentDate = newAppointmentDate;



            }

        private void hourBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                doAction.CreateAppointment(AppointmentTitle.Text, AppointmentDetails.Text, superAppointmentDate, hourBox1.SelectedValue + ":" +
                    minuteBox1.SelectedValue, hourBox2.SelectedValue + ":" + minuteBox2.SelectedValue);

            }
            catch
            {
                Exception ex; 
            }
                

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void minuteBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hourBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void minuteBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

