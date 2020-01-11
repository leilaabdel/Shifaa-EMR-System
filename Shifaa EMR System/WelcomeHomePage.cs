using System;
using System.Windows.Forms;
using System.Drawing;

namespace Shifaa_EMR_System
{
    public partial class WelcomeHomePage : Form
    {
        public WelcomeHomePage()
        {
            InitializeComponent();
        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            PhysicianLoginForm pLogin = new PhysicianLoginForm();
            pLogin.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchedulerLogin sLogin = new SchedulerLogin();
            sLogin.Show();

        }

        private void NewProviderAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewProviderAccount newProviderAccount = new CreateNewProviderAccount();
            Center(newProviderAccount);
            newProviderAccount.Show();

        }

        private void WelcomeHomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void NewSchedulerAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewSchedulerAccount newSchedulerAccount = new CreateNewSchedulerAccount();
            Center(newSchedulerAccount);
            newSchedulerAccount.Show();

        }
    }
}
