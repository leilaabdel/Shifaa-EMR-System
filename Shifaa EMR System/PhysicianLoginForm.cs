using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Linq;


namespace Shifaa_EMR_System
{
    public partial class PhysicianLoginForm : Form
    {
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        string thisProviderFirstName;
        string thisProviderLastName;
        string thisProviderID;
        string thisProviderTitle;

        public PhysicianLoginForm()
        {
            InitializeComponent();
            this.BringToFront();
            this.Focus();
            PassCodeBox.UseSystemPasswordChar = true;
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeHomePage welcome = new WelcomeHomePage();
            welcome.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            

            if(doAction.authenticateProvider(UsernameBox.Text , PassCodeBox.Text) == 0)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
