using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;



namespace Shifaa_EMR_System

{

    //TODO: FUNCTIONALIZE FOR SCHEDULER VIEW TOO

    public partial class NewPatient : Form
    {


        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);

        private ProviderMain providerMain;
        private SchedulerMain schedulerMain;
        private List<String> providerIDList = new List<String>();
        private int PatientID = 0;

        public NewPatient(ProviderMain providerMain)
        {
            InitializeComponent();
            PregnantBox.Hide();
            PregnantLabel.Hide();
            NotPregnantBox.Hide();
            ProviderList.Hide();
            ChooseProviderLabel.Hide();
            this.providerMain = providerMain;
            providerIDList.Add(providerMain.GetProviderID());


        }

        public NewPatient(ProviderMain providerMain, int patientID)
        {
            InitializeComponent();
            PregnantBox.Hide();
            PregnantLabel.Hide();
            NotPregnantBox.Hide();
            ProviderList.Hide();
            ChooseProviderLabel.Hide();
            this.providerMain = providerMain;
            providerIDList.Add(providerMain.GetProviderID());
            this.PatientID = patientID;


        }

        public NewPatient(SchedulerMain schedulerMain)
        {
            InitializeComponent();
            PregnantBox.Hide();
            PregnantLabel.Hide();
            NotPregnantBox.Hide();
            this.schedulerMain = schedulerMain;
            ProviderList.ValueMember = "ProviderID";
            ProviderList.DisplayMember = "ProviderName";
            ProviderList.DataSource = schedulersBelongingToProviderTableAdapter1.GetDataBySchedulerID(schedulerMain.GetSchedulerID());



        }
        public NewPatient(SchedulerMain schedulerMain, int patientID)
        {
            InitializeComponent();
            PregnantBox.Hide();
            PregnantLabel.Hide();
            NotPregnantBox.Hide();
            this.schedulerMain = schedulerMain;
            ProviderList.ValueMember = "ProviderID";
            ProviderList.DisplayMember = "ProviderName";
            ProviderList.DataSource = schedulersBelongingToProviderTableAdapter1.GetDataBySchedulerID(schedulerMain.GetSchedulerID());
            this.PatientID = patientID;



        }



        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }


        private string GetAge()
        {

            TimeSpan ts = DateTime.Now - Convert.ToDateTime(DOBPicker.Value);
            int age = Convert.ToInt32(ts.Days) / 365;
            if (age >= 1) return age.ToString();

            int monthsage = DateTime.Now.Month - DOBPicker.Value.Month;

            return monthsage +" Months";

        }

        private string GetGender()
        {
            if (FemaleCheckBox.Checked && !MaleCheckBox.Checked)
            {
                return FemaleCheckBox.Text;
            }
            else if (MaleCheckBox.Checked && !FemaleCheckBox.Checked)
            {
                return MaleCheckBox.Text;
            }
            else
            {
                return null;
            }
        }

        private double GetBMI()
        {
            if (GetWeight() != 0.0 && GetHeight() != 0.0)
            {
                double BMI = GetWeight() / Math.Pow(GetHeight(), 2) * 10000;
                return BMI;
            }

            return 0.0;
        }

        private double GetWeight()
        {

            _ = double.TryParse(WeightBox.Text, out double weight);
            return weight;

        }

        private Double GetHeight()
        {
            _ = double.TryParse(HeightBox.Text, out double height);

            return height;
        }


        string maritalStatus;
        string pregnancyStatus;

        private void Save_Click(object sender, EventArgs e)
        {

            if (MaleCheckBox.Checked && FemaleCheckBox.Checked)
            {
                MessageBox.Show("Please choose either male or female. Not both");
                return;

            }
            else if (SingleBox.Checked && MarriedBox.Checked)
            {
                MessageBox.Show("Please choose either single or married. Not both");
                return;

            }
            else if (!MaleCheckBox.Checked && !FemaleCheckBox.Checked)
            {
                MessageBox.Show("Please choose a gender");
                return;
            }
            else if (!SingleBox.Checked && !MarriedBox.Checked)
            {
                MessageBox.Show("Please choose a marital status");
            }
            else if (PregnantBox.Checked && NotPregnantBox.Checked && PregnantBox.Visible && NotPregnantBox.Visible)
            {
                MessageBox.Show("Please choose either pregnant or not pregnant. Not both");
                return;

            }
            else if (!PregnantBox.Checked && !NotPregnantBox.Checked && PregnantBox.Visible && NotPregnantBox.Visible)
            {
                MessageBox.Show("Please choose a pregnancy status");
                return;
            }



            else if (!String.IsNullOrWhiteSpace(PhoneNumberBox.Text))
            {
                var phoneNumberUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();

                try
                {

                    //TODO: FORMAT THE NUMBER USING ASYOUTYPE FORMATER
                    var phoneNumber = phoneNumberUtil.Parse(PhoneNumberBox.Text, null);

                }
                catch
                {
                    MessageBox.Show("Please enter a valid phone number with the country code \n An example is +13056136819");
                    PhoneNumberBox.Text = null;
                    return;
                }

            }

            try
            {

                string Height = "-";
                string Weight = "-";
                string BMI = "-";

                if (!String.IsNullOrWhiteSpace(HeightBox.Text)) Height = GetHeight().ToString();
                if (!String.IsNullOrWhiteSpace(WeightBox.Text)) Weight = GetWeight().ToString();
                if (!String.IsNullOrWhiteSpace(WeightBox.Text) && !String.IsNullOrWhiteSpace(HeightBox.Text)) BMI = Math.Round(GetBMI(), 2).ToString();
                if(PatientID != 0)
                {
                    doAction.updatePatient(FirstNameBox.Text, LastNameBox.Text, PhoneNumberBox.Text, DOBPicker.Value, GetAge(), GetGender(), maritalStatus,
                        pregnancyStatus, Weight, Height, BMI, NationalityBox.Text, DateTime.Today , PatientID);

                    foreach (string provider in providerIDList)
                    {
                        ISingleResult<getProviderInfoResult> providerInfo = doAction.getProviderInfo(provider);
                        foreach (getProviderInfoResult providerResult in providerInfo)
                        {
                            doAction.createPatientProviderRelation(PatientID, FirstNameBox.Text, LastNameBox.Text, provider,
                                providerResult.FirstName, providerResult.LastName, providerResult.Title, providerResult.JobRole);

                        }




                    }

                    doAction.createNewVitalSign(PatientID, "-", "-", "-", Height, Weight, BMI, DateTime.Today);

                    this.Close();
                

                }
                if (PatientID == 0)
                {
                    int newPatientActionResult = doAction.createNewPatient(FirstNameBox.Text, LastNameBox.Text, PhoneNumberBox.Text, DOBPicker.Value, GetAge(), GetGender(), maritalStatus,
                        pregnancyStatus, Weight, Height, BMI, NationalityBox.Text, DateTime.Today);


                    if (newPatientActionResult == 1)
                    {
                        MessageBox.Show("This patient already exists in the system.");
                        return;
                    }

                    ISingleResult<getNewPatientVitalsResult> newPatientVitals = doAction.getNewPatientVitals(FirstNameBox.Text, LastNameBox.Text, DOBPicker.Value);

                    int selectedPatientID = 0;

                    foreach (getNewPatientVitalsResult result in newPatientVitals)
                    {
                        selectedPatientID = result.PatientID;

                    }




                    Double BMiDouble = Math.Round(GetBMI(), 2);

                    doAction.createNewVitalSign(selectedPatientID, "-", "-", "-", Height, Weight, BMI, DateTime.Today);

                    foreach (string provider in providerIDList)
                    {
                        ISingleResult<getProviderInfoResult> providerInfo = doAction.getProviderInfo(provider);
                        foreach (getProviderInfoResult providerResult in providerInfo)
                        {
                            doAction.createPatientProviderRelation(selectedPatientID, FirstNameBox.Text, LastNameBox.Text, provider,
                                providerResult.FirstName, providerResult.LastName, providerResult.Title, providerResult.JobRole);

                        }




                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please make sure at least first name, last name, date of birth and gender are filled.");

                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;


            }


        }



        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {
            double result = 0;


            if (!String.IsNullOrWhiteSpace(WeightBox.Text) && !double.TryParse(WeightBox.Text, out result) || result <= 0)
            {
                WeightBox.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid weight in Kilograms");

            }

        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            while (FirstNameBox.Text.Any(char.IsDigit))
            {

                FirstNameBox.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid first name");

            }
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            while (LastNameBox.Text.Any(char.IsDigit))
            {
                LastNameBox.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid last name");
            }
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {
            while (DateTime.Compare(DOBPicker.Value, DateTime.Today) > 0)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid date of birth");
                DOBPicker.Value = DateTime.Today;
            }
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            double doubleresult = 0.0;



            if (!String.IsNullOrWhiteSpace(HeightBox.Text) && !double.TryParse(HeightBox.Text, out doubleresult) || doubleresult <= 0)
            {
                HeightBox.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid height in centimeters");

            }

        }

        private void NationalityBox_TextChanged(object sender, EventArgs e)
        {
            while (NationalityBox.Text.Any(char.IsDigit))
            {
                NationalityBox.Text = null;
                System.Windows.Forms.MessageBox.Show("Please enter a valid nationality");
            }

        }




        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {





        }

        private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleCheckBox.Checked && !MaleCheckBox.Checked)
            {
                PregnantLabel.Show();
                PregnantBox.Show();
                NotPregnantBox.Show();
                WeightLabel.Top = 382;
                WeightBox.Top = 382;
                kgLabel.Top = 385;
                HeightLabel.Top = 425;
                HeightBox.Top = 425;
                cmLabel.Top = 428;
                NationalityLabel.Top = 465;
                NationalityBox.Top = 465;

            }
        }

        private void NotPregnantBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NotPregnantBox.Checked && !PregnantBox.Checked) pregnancyStatus = "Not Pregnant";
        }

        private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!FemaleCheckBox.Checked && MaleCheckBox.Checked || (FemaleCheckBox.Checked && MaleCheckBox.Checked))
            {
                PregnantLabel.Hide();
                PregnantBox.Hide();
                NotPregnantBox.Hide();
                WeightLabel.Top = 338;
                WeightBox.Top = 338;
                kgLabel.Top = 342;
                HeightLabel.Top = 382;
                HeightBox.Top = 382;
                cmLabel.Top = 385;
                NationalityLabel.Top = 422;
                NationalityBox.Top = 422;

            }
        }

        private void PregnantBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!NotPregnantBox.Checked && PregnantBox.Checked) pregnancyStatus = "Pregnant";
        }

        private void SingleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SingleBox.Checked && !MarriedBox.Checked) maritalStatus = "Single";
        }

        private void MarriedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!SingleBox.Checked && MarriedBox.Checked) maritalStatus = "Married";
        }


        private void ProviderList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!providerIDList.Contains((String)ProviderList.SelectedValue))
            {
                providerIDList.Add((String)ProviderList.SelectedValue);

            }
            else
            {
                providerIDList.Remove((String)ProviderList.SelectedValue);
                doAction.deletePatientProviderRelation(PatientID, ((String)ProviderList.SelectedValue));
            }
        }
    }
}
