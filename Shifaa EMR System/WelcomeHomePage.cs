using System;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class WelcomeHomePage : Form
    {
        public WelcomeHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            PhysicianLoginForm pLogin = new PhysicianLoginForm();
            pLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchedulerLogin sLogin = new SchedulerLogin();
            sLogin.Show();

        }
    }
}
