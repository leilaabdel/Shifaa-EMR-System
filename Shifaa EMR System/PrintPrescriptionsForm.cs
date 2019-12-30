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
    public partial class PrintPrescriptionsForm : Form
    {
        public PrintPrescriptionsForm()
        {
            InitializeComponent();
        }

        private void PrintPrescriptionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.eMRDatabaseDataSet.Prescription);

        }
    }
}
