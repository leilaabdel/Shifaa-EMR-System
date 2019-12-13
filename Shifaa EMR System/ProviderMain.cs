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
    public partial class ProviderMain : Form
    {
        public ProviderMain()
        {
            InitializeComponent();
        }

        public string type()
        {
            return "Provider";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
    
            
        }
        public DateTime getDate()
        {
            return monthCalendar1.SelectionStart.Date;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAppointment pForm = new NewAppointment();
            pForm.MdiParent = this;
            pForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateViewAppointments pOldAppointments = new DateViewAppointments();
            pOldAppointments.MdiParent = this;
            pOldAppointments.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPatient newPatientInstance = new NewPatient();
            newPatientInstance.MdiParent = this;
            newPatientInstance.Show();
        }
    }
}
