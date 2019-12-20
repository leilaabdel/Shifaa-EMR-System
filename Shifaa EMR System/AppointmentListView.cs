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
    public partial class AppointmentListView : Form
    {
        public AppointmentListView()
        {
            InitializeComponent();
        }

        private void AppointmentListView_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'eMRDatabaseDataSet1.Appointment' table. You can move, or remove it, as needed.
            try
            {

                this.appointmentTableAdapter1.FillByDate(this.eMRDatabaseDataSet1.Appointment, ((ProviderMain)this.MdiParent).getDate().ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("There are no appointments for this date");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByDateToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillByDateToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
