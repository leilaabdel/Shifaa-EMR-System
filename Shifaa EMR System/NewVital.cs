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
        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int thisPatientID;
        string thisProviderName;
        string thisProviderID;

        public NewVital(int patientID , string providerName , string providerID)
        {
            this.thisPatientID = patientID;
            this.thisProviderName = providerName;
            this.thisProviderID = providerID;
            InitializeComponent();
        }



        private double getBMI()
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
              doAction.createNewVitalSign(thisPatientID, BloodPressureBox.Text, Convert.ToDouble(PulseBox.Text), Convert.ToDouble(TemperatureBox.Text), Convert.ToDouble(HeightBox.Text),
              Convert.ToDouble(WeightBox.Text), getBMI());
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please enter vitals or exit the page.");
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
            double num;

            if (!String.IsNullOrWhiteSpace(HeightBox.Text) && !double.TryParse(HeightBox.Text, out num))
            {
                MessageBox.Show("Please enter a valid height in cm");
                HeightBox.Text = null;
            }
        }

        private void PulseBox_TextChanged(object sender, EventArgs e)
        {

            double num;

            if (!String.IsNullOrWhiteSpace(PulseBox.Text) && !double.TryParse(PulseBox.Text , out num))
            {
                MessageBox.Show("Please enter a valid pulse");
                PulseBox.Text = null;
            }
        }

        private void TemperatureBox_TextChanged(object sender, EventArgs e)
        {
            double num;

            if (!String.IsNullOrWhiteSpace(TemperatureBox.Text) && !double.TryParse(TemperatureBox.Text, out num))
            {
                MessageBox.Show("Please enter a valid temperature");
                TemperatureBox.Text = null;
            }
        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {
            double num;

            if (!String.IsNullOrWhiteSpace(WeightBox.Text) && !double.TryParse(WeightBox.Text, out num))
            {
                MessageBox.Show("Please enter a valid weight in Kg");
                WeightBox.Text = null;
            }
        }
    }
}
