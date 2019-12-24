using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class SchedulerLogin : Form
    {
        public SchedulerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Scheduling_Login where USERNAME='" + textBox1.Text + "' and PASSCODE ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                SchedulerMain sMain = new SchedulerMain();
                sMain.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
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

        }
    }
}
