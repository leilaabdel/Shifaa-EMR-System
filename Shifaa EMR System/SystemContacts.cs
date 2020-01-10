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
    public partial class SystemContacts : Form
    {
        public SystemContacts()
        {
            InitializeComponent();
        }

        private void SystemContacts_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.AllEmployees' table. You can move, or remove it, as needed.
            this.allEmployeesTableAdapter.Fill(this.eMRDatabaseDataSet.AllEmployees);

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.allEmployeesTableAdapter.FillBySearch(this.eMRDatabaseDataSet.AllEmployees,
                searchBox.Text, searchBox.Text, searchBox.Text, searchBox.Text);
        }

        private void SearchBoxClicked(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Contacts") searchBox.Text = null;
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
