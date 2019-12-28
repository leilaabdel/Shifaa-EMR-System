using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Linq;


namespace Shifaa_EMR_System
{
    public partial class PhysicianLoginForm : Form
    {
        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        string thisProviderFirstName;
        string thisProviderLastName;
        string thisProviderID;
        string thisProviderTitle;

        public PhysicianLoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeHomePage welcome = new WelcomeHomePage();
            welcome.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Physician_Login_Info where USERNAME='" + UsernameBox.Text + "' and PASSCODE ='" + PassCodeBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(UsernameBox.Text);

                foreach (getProviderInfoResult r in result)
                {
                    thisProviderFirstName = r.FirstName;
                    thisProviderLastName = r.LastName;
                    thisProviderID = r.USERNAME;
                    thisProviderTitle = r.Title;

                }

                string ProviderFullName = thisProviderFirstName + " " + thisProviderLastName + " " + thisProviderTitle;

                ProviderMain providerName = new ProviderMain(ProviderFullName, thisProviderID);

                providerName.Show();

            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
