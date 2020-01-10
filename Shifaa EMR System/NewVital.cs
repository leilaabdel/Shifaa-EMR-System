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
    public partial class NewVital : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly int thisPatientID;
        private PatientHomePage ParentPatientHome;

        public NewVital(int patientID , PatientHomePage parent)
        {
            this.thisPatientID = patientID;
            this.ParentPatientHome = parent;
            InitializeComponent();
        }



        private double GetBMI()
        {
            if (Convert.ToDouble(WeightBox.Text) != 0.0 && Convert.ToDouble(HeightBox.Text) != 0.0)
            {
                double BMI = Convert.ToDouble(WeightBox.Text) / Math.Pow(Convert.ToDouble(HeightBox.Text) , 2) * 10000;
                return BMI;
            }

            return 0.0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                double? height = null;
                double? weight = null;
                double? BMI = null;

                string bpString = "-";
                string pulseString = "-";
                string tempString = "-";
                string heightString = "-";
                string weightString = "-";
                string BMIstring = "-";

                if (!String.IsNullOrWhiteSpace(BloodPressureBox.Text)) bpString = BloodPressureBox.Text;
                if (!String.IsNullOrWhiteSpace(PulseBox.Text)) pulseString = PulseBox.Text;
                if (!String.IsNullOrWhiteSpace(TemperatureBox.Text)) tempString = TemperatureBox.Text;
                if (!String.IsNullOrWhiteSpace(HeightBox.Text)) heightString = HeightBox.Text;
                if (!String.IsNullOrWhiteSpace(WeightBox.Text)) weightString = WeightBox.Text;
               

                if (!String.IsNullOrWhiteSpace(HeightBox.Text)) height = Convert.ToDouble(HeightBox.Text);
                if (!String.IsNullOrWhiteSpace(WeightBox.Text)) weight = Convert.ToDouble(WeightBox.Text);
                if(height != null && height != 0 && weight != null && weight != 0)
                {
                    BMI = GetBMI();
                }

                BMIstring = BMI.ToString();

                doAction.createNewVitalSign(thisPatientID, bpString, pulseString , tempString , heightString , weightString, BMIstring, DateTime.Today);
                ((PatientHomePage)this.Owner).vitalSignsTableAdapter.FillByPatientID(((PatientHomePage)this.Owner).eMRDatabaseDataSet.VitalSigns, thisPatientID);

                ParentPatientHome.BloodPressureValueLabel.Text = bpString;
                ParentPatientHome.PulseValueLabel.Text = pulseString;
                ParentPatientHome.TemperatureValueLabel.Text = tempString;
                ParentPatientHome.HeightValueLabel.Text = heightString;
                ParentPatientHome.WeightValueLabel.Text = weightString;
                ParentPatientHome.BMIValueLabel.Text = BMIstring;
                

                this.Close();
                doAction.Dispose();
            }
            catch
            {
                MessageBox.Show("Please enter vitals or exit the page.");
                doAction.Dispose();
            }
          


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewVital_Load(object sender, EventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(HeightBox.Text) && !double.TryParse(HeightBox.Text, out _) && HeightBox.Text != "-")
            {
                MessageBox.Show("Please enter a valid height in cm");
                HeightBox.Text = null;
            }
        }

        private void PulseBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PulseBox.Text) && !double.TryParse(PulseBox.Text , out _) && PulseBox.Text != "-")
            {
                MessageBox.Show("Please enter a valid pulse");
                PulseBox.Text = null;
            }
        }

        private void TemperatureBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TemperatureBox.Text) && !double.TryParse(TemperatureBox.Text, out _) && TemperatureBox.Text != "-")
            {
                MessageBox.Show("Please enter a valid temperature");
                TemperatureBox.Text = null;
            }
        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(WeightBox.Text) && !double.TryParse(WeightBox.Text, out _) && WeightBox.Text != "-")
            {
                MessageBox.Show("Please enter a valid weight in Kg");
                WeightBox.Text = null;
            }
        }

        private void BloodPressureBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
