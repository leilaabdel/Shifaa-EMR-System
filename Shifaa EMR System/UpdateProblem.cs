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
    public partial class UpdateProblem : Form
    {

        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");

        int thisProblemID;
        int thisPatientID;

        public UpdateProblem(int problemID, string problemName, string problemDescription , int patientID)
        {
            InitializeComponent();
            this.thisProblemID = problemID;
            this.ProblemBox.Text = problemName;
            this.DescriptionBox.Text = problemDescription;
            this.thisPatientID = patientID;

            ProblemBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ProblemBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ProblemBox.AutoCompleteCustomSource = AutoComplete.ProblemAutoComplete();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            string status = null;
            DateTime? updateDate = null;

            if (OngoingBox.Checked && !ResolvedBox.Checked)
            {
                status = "Ongoing";
            }

            if (!OngoingBox.Checked && ResolvedBox.Checked)
            {
                status = "Resolved";
                updateDate = DateTime.Today;
            }
            else if (OngoingBox.Checked && ResolvedBox.Checked)
            {
                OngoingBox.Checked = false;
                ResolvedBox.Checked = false;
                MessageBox.Show("Please choose only ongoing or resolved");
            }



                try
                {

                    doAction.updateExistingProblem(thisProblemID, status, ProblemBox.Text, DescriptionBox.Text , updateDate);
                ((PatientHomePage)this.Owner).problemTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.Problem, thisPatientID);
                this.Close();

                }
                catch
                {
                    MessageBox.Show("Please enter a valid Problem Name");
                }
        }


        private void UpdateProblem_Load(object sender, EventArgs e)
        {

        }
    }
}
