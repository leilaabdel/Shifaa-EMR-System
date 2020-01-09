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
    public partial class MessagesView : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        private DataTable _conversationTable;
        private string _conversationID;
        private DataTable _employeeInfo;

        #region Properties

        public string RecipientID { get; }
        public string RecipientName { get; }

        #endregion

        public MessagesView(string recipientID)
        {
            InitializeComponent();
            RecipientID = recipientID;
            Console.WriteLine(recipientID);
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this.RecipientID);
            _employeeInfo = this.allEmployeesTableAdapter1.GetDataByEmployeeID(recipientID);
            _employeeInfo.Columns.Add("EmployeeName", typeof(string), "FirstName + ' ' + LastName + ' | ' + JobType");

            RecipientName = (String)_employeeInfo.Rows[0]["EmployeeName"];
         

        }

        private DataTable _messagesTable;

        private void PopulateMessages(DataTable input)
        {
            messageListFlowPanel.Controls.Clear();


            for(int i = 0; i < input.Rows.Count; i++)
            {
                MessageListItem messageListItem = new MessageListItem
                {
                    SenderName = (String)input.Rows[i]["SenderName"],
                    Subject = (String)input.Rows[i]["MessageTitle"],
                    MessageContent = (String)input.Rows[i]["MessageContent"],
                    ReadOrNotRead = (String)input.Rows[i]["ReadOrNotRead"],
                    ConversationID = (String)input.Rows[i]["ConversationID"]
                };
                messageListItem.Click += new EventHandler(MessageListItemClick);
                messageListItem.DeleteMessageButton.Click += new EventHandler(ListItemDeleteButtonClick);
                if (messageListFlowPanel.Controls.Count < 0)
                {
                    messageListFlowPanel.Controls.Clear();
                }
                else
                messageListFlowPanel.Controls.Add(messageListItem);


            }

        }

        private void PopulateMessageConversation(string conversationID)
        {

            ConversationFlowPanel.Controls.Clear();

            _conversationTable = messageTableAdapter.GetDataByConversationID(conversationID);
            _conversationID = conversationID;

            for(int i = 0; i <_conversationTable.Rows.Count; i++)
            {
                ConversationItem conversationItem = new ConversationItem(conversationID, (int)_conversationTable.Rows[i]["MessageIDNumber"])
                {

                    SenderName = (String)_conversationTable.Rows[i]["SenderName"],
                    SenderID  = (String)_conversationTable.Rows[i]["SenderID"],
                    Subject = (String)_conversationTable.Rows[i]["MessageTitle"],
                    MessageContent = (String)_conversationTable.Rows[i]["MessageContent"],
                    ReadOrNotRead = (String)_conversationTable.Rows[i]["ReadOrNotRead"],
                    ReceiverName = (String)_conversationTable.Rows[i]["RecipientName"],
                    ReceiverID = (String)_conversationTable.Rows[i]["RecipientID"],
                    Date = (DateTime)_conversationTable.Rows[i]["DateTime"],
                    Status = (String)_conversationTable.Rows[i]["Status"],
                 
              
                    

                };
                conversationItem.EditDraftButton.Click += new EventHandler(EditDraftButtonClick);
                conversationItem.ReplyButton.Click += new EventHandler(ReplyButtonClick);
                conversationItem.ForwardButton.Click += new EventHandler(ForwardButtonClick);

            }

        }
        private void ListItemDeleteButtonClick(object sender, EventArgs e)
        {
            Button thisDeleteButton = (Button)sender;
            MessageListItem listItem = (MessageListItem)thisDeleteButton.Parent;
            string conversationID = listItem.ConversationID;
            doAction.deleteConversation(conversationID);

            foreach(ConversationItem item in ConversationFlowPanel.Controls)
            {
                if(item.ConversationID == conversationID)
                {
                    item.Hide();
                    item.Dispose(); 
                }
            }
        }

        private void ReplyButtonClick(object sender, EventArgs e)
        {
            Button replyButton = (Button)sender;
            ConversationItem priorMessage = (ConversationItem)replyButton.Parent;


            NewMessageItem replyMessage = new NewMessageItem(_conversationID)
            {
                ReceiverName = priorMessage.SenderName,
                ReceiverID = priorMessage.SenderID,
                SenderID = this.RecipientID,
                SenderName = this.RecipientName,
           

            };

            int prevIndex = ConversationFlowPanel.Controls.IndexOf(priorMessage);
            ConversationFlowPanel.Controls.Add(replyMessage);
            ConversationFlowPanel.Controls.SetChildIndex(replyMessage, prevIndex + 1);
            ConversationFlowPanel.ScrollControlIntoView(replyMessage);

        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            Button forwardButton = (Button)sender;
            ConversationItem priorMessage = (ConversationItem)forwardButton.Parent;


            NewMessageItem forwardMessage = new NewMessageItem(_conversationID)
            {
                ReceiverName = priorMessage.SenderName,
                ReceiverID = priorMessage.SenderID,
                SenderID = this.RecipientID,
                SenderName = this.RecipientName,



            };

            int prevIndex = ConversationFlowPanel.Controls.IndexOf(priorMessage);
            ConversationFlowPanel.Controls.Add(forwardMessage);
            ConversationFlowPanel.Controls.SetChildIndex(forwardMessage, prevIndex + 1);
            ConversationFlowPanel.ScrollControlIntoView(forwardMessage);

        }

        private void EditDraftButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ConversationItem item = (ConversationItem)clickedButton.Parent;
            DataTable _messageForID = messageTableAdapter.GetDataByMessageIDNumber(item.MessageID);




            NewMessageItem draftToEdit = new NewMessageItem(_conversationID)
            {
                Subject = (String)_messageForID.Rows[0]["MessageTitle"],
                SenderName = (String)_messageForID.Rows[0]["SenderName"],
                SenderID = (String)_messageForID.Rows[0]["SenderID"],
                ReceiverName = (String)_messageForID.Rows[0]["RecipientName"],
                ReceiverID = (String)_messageForID.Rows[0]["RecipientID"],
                MessageContent = (String)_messageForID.Rows[0]["MessageContent"]

            };

            ConversationFlowPanel.Controls.Add(draftToEdit);

  

            item.Dispose();
            
        }

        private void MessageListItemClick(object sender, EventArgs e)
        {
          
            

            MessageListItem thisMessageItem = (MessageListItem)sender;
            thisMessageItem.BackColor = Color.Azure;
            _conversationID = thisMessageItem.ConversationID;

            PopulateMessageConversation(_conversationID);



        }

        private void MessagesView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PopulateMessages(_messagesTable);


        }



     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MessageListFlowPanelClick(object sender, EventArgs e)
        {

        }

        private void NewMessageButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RecipientName);
            ConversationFlowPanel.Controls.Clear();
            NewMessageItem newMessage = new NewMessageItem()
            {
                SenderID = this.RecipientID,
                SenderName = RecipientName
            };


            ConversationFlowPanel.Controls.Add(newMessage);
            ConversationFlowPanel.ScrollControlIntoView(newMessage);
 


        }

        private void MessageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void InboxButton_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this.RecipientID);
            PopulateMessages(_messagesTable);
            TypeLabel.Text = "Inbox";
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataBySent(this.RecipientID);
            PopulateMessages(_messagesTable);
            TypeLabel.Text = "Sent";

        }

        private void DraftsButton_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByDraft(this.RecipientID);
            PopulateMessages(_messagesTable);
            TypeLabel.Text = "Drafts";
        }

        private void JunkButton_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByJunk(this.RecipientID);
            PopulateMessages(_messagesTable);
            TypeLabel.Text = "Junk";
        }
    }
}
