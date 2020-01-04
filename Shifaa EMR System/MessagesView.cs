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

//TODO: Configure so that you can reply to conversations an view conversation history

namespace Shifaa_EMR_System
{
    public partial class MessagesView : Form
    {
        readonly string userID;
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        private int messageID;


        public MessagesView(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.MessageTable.MultiSelect = false;
            this.MessageTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

       

        private void MessagesView_Load_1(object sender, EventArgs e)
        {
            this.messageTableAdapter.FillByRecipientID(this.eMRDatabaseDataSet.Message, userID);

        }

        private void SentItemsToolStrip_Click(object sender, EventArgs e)
        {
            this.messageTableAdapter.FillBySent(this.eMRDatabaseDataSet.Message, userID);


        }

        private void DraftsToolStripItem_Click(object sender, EventArgs e)
        {
            this.messageTableAdapter.FillByDraft(this.eMRDatabaseDataSet.Message, userID);
        }

        private void DeletedItemsMenuToolStripItem_Click(object sender, EventArgs e)
        {
            this.messageTableAdapter.FillByJunk(this.eMRDatabaseDataSet.Message, userID);
        }

        private void MessageTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MessageTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageTable.Rows.Count > 0)
            {
                messageID = (int)MessageTable["MessageIDNumber", e.RowIndex].Value;
                string title = (String)MessageTable["MessageTitle", e.RowIndex].Value;
                string senderName = (String)MessageTable["SenderName", e.RowIndex].Value;
                string messageContent = (String)MessageTable["MessageContent", e.RowIndex].Value;
                DateTime timeStamp = (DateTime)MessageTable["DateTimeSent", e.RowIndex].Value;
                string dateSent = timeStamp.ToShortDateString();
                string timeSent = timeStamp.ToShortTimeString();


                MessageContentViewBox.SelectionFont = new Font("Bahnschrift Light", 12);
                MessageContentViewBox.SelectedText = title + "\n\n";
                MessageContentViewBox.SelectionFont = new Font("Bahnschrift Light", 10);
                MessageContentViewBox.SelectedText = "On " + dateSent + " at " + timeSent + " " + senderName +  " wrote: \n ";
                MessageContentViewBox.SelectionFont = new Font("Bahnscrhift Light", 10);
                MessageContentViewBox.SelectedText = messageContent;


                SubjectBox.Text = (String)MessageTable["MessageTitle", MessageTable.CurrentRow.Index].Value;
                DestinationBox.Text = (String)MessageTable["RecipientName", MessageTable.CurrentRow.Index].Value;

            }
        }

        private void EditMedicationButton_Click(object sender, EventArgs e)
        {
            this.ShowWritingMessageContent();
            DestinationBox.Text = null;
            SubjectBox.Text = null;
        }



        private void ShowWritingMessageContent()
        {
            this.DraftPanel.Show();
            this.ToLabel.Show();
            this.SaveDraftButton.Show();
            this.CancelButton.Show();
            this.SendButton.Show();
            this.MessageContent1.Show();
            this.DestinationBox.Show();
            this.ReplyButton.Hide();
            this.SubjectBox.Hide();
            this.SubjectLabel.Hide();
        }


        private void HideWritingMessageContent()
        {
            this.DraftPanel.Hide();
            this.ToLabel.Hide();
            this.SaveDraftButton.Hide();
            this.CancelButton.Hide();
            this.SendButton.Hide();
            this.MessageContent1.Hide();
            this.DestinationBox.Hide();
            this.ReplyButton.Show();
            this.SubjectLabel.Show();
            this.SubjectBox.Show();

        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            HideWritingMessageContent();


            string[] destination = DestinationBox.Text.Split(' ');
            string firstName = destination[0];
            string lastName = destination[1];
            string jobType = destination[2];
            string destinationID = null;

            ISingleResult<convertNameToIDResult> result = doAction.convertNameToID(firstName,
                lastName, jobType);
            foreach (convertNameToIDResult r in result)
            {
                destinationID = r.EmployeeID;
            }

            string recipientFullName = firstName + " " + lastName;

            string userFirstName = null;
            string userLastName = null;
            ISingleResult<convertIDToNameResult> result1 = doAction.convertIDToName(userID);
            foreach (convertIDToNameResult r in result1)
            {
                userFirstName = r.FirstName;
                userLastName = r.LastName;
            }

            string userFullName = userFirstName + " " + userLastName;

            

            try
            {
                doAction.SendMessage(userID, userFullName, SubjectBox.Text, MessageContent1.Text, DateTime.Now, recipientFullName, destinationID, "Sent" , messageID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }

        private void SaveDraftButton_Click(object sender, EventArgs e)
        {
            HideWritingMessageContent();


            string[] destination = DestinationBox.Text.Split(' ');
            string firstName = destination[0];
            string lastName = destination[1];
            string jobType = destination[2];
            string destinationID = null;

            ISingleResult<convertNameToIDResult> result = doAction.convertNameToID(firstName,
                lastName, jobType);
            foreach (convertNameToIDResult r in result)
            {
                destinationID = r.EmployeeID;
            }

            string recipientFullName = firstName + " " + lastName;

            string userFirstName = null;
            string userLastName = null;
            ISingleResult<convertIDToNameResult> result1 = doAction.convertIDToName(userID);
            foreach (convertIDToNameResult r in result1)
            {
                userFirstName = r.FirstName;
                userLastName = r.LastName;
            }

            string userFullName = userFirstName + " " + userLastName;

            try
            {
                doAction.updateMessageDraft(userID, userFullName, SubjectBox.Text, MessageContent1.Text, DateTime.Now, recipientFullName, destinationID, "Draft");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }

        }

        private void ReplyButton_Click(object sender, EventArgs e)
        {
            ShowWritingMessageContent();

           
        }
    }
}
