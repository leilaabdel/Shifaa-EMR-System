using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Shifaa_EMR_System
{
    public partial class SystemContacts : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        private readonly string thisEmployeeID;
        private  NewMessageItem globalNewMessage;
        private int messageID;
        public SystemContacts(string employeeID)
        {
            InitializeComponent();
            thisEmployeeID = employeeID;

        }

        private void SystemContacts_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Hide();
            this.StartPosition = FormStartPosition.CenterParent;
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.AllEmployees' table. You can move, or remove it, as needed.
            this.allEmployeesTableAdapter.Fill(this.eMRDatabaseDataSet.AllEmployees);
            this.ContactListView.MultiSelect = false;
            this.ContactListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void ContactDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("clicked");
            if (ContactListView.Rows.Count > 0)
            {
                string employeeID = (String)ContactListView["EmployeeID", e.RowIndex].Value;
                if (this.Controls["NewMessageItem"] as NewMessageItem == null)
                {
                    Label l = new Label();
                    string employeeName = "";
                    ISingleResult<getEmployeeNameByIDResult> result = doAction.getEmployeeNameByID(thisEmployeeID);
                    foreach (getEmployeeNameByIDResult r in result)
                    {
                        employeeName = r.EmployeeName;
                    }


                    globalNewMessage= new NewMessageItem(l)
                    {
                        SenderID = thisEmployeeID,
                        SenderName = employeeName


                    };

                   
                    panel1.Show();
                    panel1.Controls.Add(globalNewMessage);
                    globalNewMessage.Show();
                    globalNewMessage.ReceiverComboBox.SelectedValue = employeeID;

                }
            }
        }

           
        
   





            
        


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.allEmployeesTableAdapter.FillBySearch(this.eMRDatabaseDataSet.AllEmployees,
                searchBox.Text, searchBox.Text, searchBox.Text, searchBox.Text);
        }

        private void SearchBoxClicked(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Contacts") searchBox.Text = null;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentListView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            messageID = doAction.createNewMessage(globalNewMessage.Subject, globalNewMessage.MessageContent,
                DateTime.Now, globalNewMessage.SenderName, globalNewMessage.SenderID,
                globalNewMessage.ReceiverComboBox.Text, (String)globalNewMessage.ReceiverComboBox.SelectedValue,
                globalNewMessage.ConversationID, "Draft", globalNewMessage.SenderID);


            doAction.SendMessage(globalNewMessage.Subject, globalNewMessage.MessageContent,
                DateTime.Now, globalNewMessage.ReceiverComboBox.Text, (String)globalNewMessage.ReceiverComboBox.SelectedValue,
                messageID);
             doAction.createNewMessage(globalNewMessage.Subject, globalNewMessage.MessageContent,
                DateTime.Now, globalNewMessage.SenderName, globalNewMessage.SenderID,
                globalNewMessage.ReceiverComboBox.Text, (String)globalNewMessage.ReceiverComboBox.SelectedValue,
                globalNewMessage.ConversationID, "Sent", (String)globalNewMessage.ReceiverComboBox.SelectedValue);
            
            globalNewMessage.Dispose();

            panel1.Hide();

        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            doAction.deleteMessage(messageID);
            globalNewMessage.Dispose();
        }
    }
}
