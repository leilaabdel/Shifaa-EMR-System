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

    public partial class NewPatient : Form
    {

        public SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");

        public NewPatient()
        {
            InitializeComponent();
       
        }

    
        private bool checkIfPatientExists(int newPatientID)
        {
            return true;

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private int getAge()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Today;
            DateTime DOB = dateTimePicker1.Value;
            TimeSpan span = today - DOB;
            int years = (zeroTime + span).Year - 1; 
            return years;
        }

        private string getGender()
        {
            if(checkBox1.Checked && !checkBox2.Checked)
            {
                return checkBox1.Text;
            } else if (checkBox2.Checked && !checkBox1.Checked)
            {
                return checkBox2.Text;
            } else
            {
                return "";
            }
        }

        private double getBMI()
        {
            double BMI = getWeight() / Math.Pow(getHeight(), 2);
            return BMI;
        }

        private double getWeight()
        {
            double weight = 0;
            double.TryParse(textBox3.Text, out weight);
            return weight;
           
        }

        private double getHeight()
        {
            double height = 0;
            double.TryParse(textBox4.Text, out height);
            return height;
        }
   

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
               
                doAction.createNewPatient(textBox1.Text, textBox2.Text, dateTimePicker1.Value, getAge(), getGender(), getWeight(), getHeight(), getBMI(), textBox6.Text);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
