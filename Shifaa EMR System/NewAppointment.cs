using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Shifaa_EMR_System

{


    public partial class NewAppointment : Form 
    {
        
        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        DateTime superAppointmentDate; 


        public NewAppointment()
        { 
     
            InitializeComponent();
          
        }


        private void NewAppointment_Load(object sender, EventArgs e)

        {
            DateTime newAppointmentDate;
            Type a = typeof(ProviderMain);
         

            if(this.MdiParent.GetType().Equals(a))
            {
                 newAppointmentDate = ((ProviderMain)this.MdiParent).getDate();
            } else 
            {
                 newAppointmentDate = ((SchedulerMain)this.MdiParent).getDate();
            }


            int h = 1;
            int m = 1;

            for (h = 1; h <= 12; h++)
            {
                hourBox1.Items.Add(h);
                hourBox2.Items.Add(h);

            }

            for (m = 0; m <= 59; m++)
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
          

                string makeTime = hourBox1.SelectedItem.ToString() + ":" + minuteBox1.SelectedItem.ToString();
                string makeDuration = hourBox2.SelectedValue.ToString() + ":" + minuteBox2.SelectedValue.ToString();



                doAction.CreateAppointment(FirstName.Text, LastName.Text ,  AppointmentDetails.Text, superAppointmentDate, makeTime, makeDuration);
      

                this.Close();
                
            }
            catch (Exception ex)
            {

                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
               
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

        private void AppointmentDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

