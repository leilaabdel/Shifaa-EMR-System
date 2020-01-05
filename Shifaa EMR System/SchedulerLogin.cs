using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Shifaa_EMR_System
{
    public partial class SchedulerLogin : Form
    {

        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        public SchedulerLogin()
        {

            
            InitializeComponent();
            PasscodeBox.UseSystemPasswordChar = true;
        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(doAction.authenticateScheduler(UserNameBox.Text , PasscodeBox.Text) == 0)
            {
                this.Hide();
                SchedulerMain sMain = new SchedulerMain(UserNameBox.Text);
                sMain.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeHomePage welcome = new WelcomeHomePage();
            welcome.Show();
        }

        private void SchedulerLogin_Load(object sender, EventArgs e)
        {
            Center(this);
        }
    }
}
