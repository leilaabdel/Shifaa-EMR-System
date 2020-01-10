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
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this.RecipientID , "Sent" , "In");
            _employeeInfo = this.allEmployeesTableAdapter1.GetDataByEmployeeID(recipientID);
            _employeeInfo.Columns.Add("EmployeeName", typeof(string), "FirstName + ' ' + LastName + ' | ' + JobType");

            RecipientName = (String)_employeeInfo.Rows[0]["EmployeeName"];
         

        }

        private DataTable _messagesTable;

        private void FormResize(object sender, EventArgs e)
        {
            foreach(Control c in ConversationFlowPanel.Controls)
            {
                c.Width = ConversationFlowPanel.Width - 10;
            }
            foreach(Control c in messageListFlowPanel.Controls)
            {
                c.Width = messageListFlowPanel.Width - 20;
            }
        }


        private void PopulateMessages(DataTable input)
        {
            messageListFlowPanel.Controls.Clear();


            for (int i = input.Rows.Count - 1; i >= 0; i--)
            {
                MessageListItem messageListItem = new MessageListItem
                {
                    SenderName = (String)input.Rows[i]["SenderName"],
                    Subject = (String)input.Rows[i]["MessageTitle"],
                    MessageContent = (String)input.Rows[i]["MessageContent"],
                    ReadOrNotRead = (String)input.Rows[i]["ReadOrNotRead"],
                    ConversationID = (String)input.Rows[i]["ConversationID"],
                    Width = messageListFlowPanel.Width - 40
                };

                if(TypeLabel.Text == "Drafts" || TypeLabel.Text == "Sent")
                {
                    messageListItem.SenderName = (String)input.Rows[i]["RecipientName"];
                }
                messageListItem.MouseClick += new MouseEventHandler(MessageListItemClick);
                messageListItem.SubjectLabel.MouseClick += new MouseEventHandler(MessageListItemContentClick);
                messageListItem.SenderLabel.MouseClick += new MouseEventHandler(MessageListItemContentClick);
                messageListItem.ContentLabel.MouseClick += new MouseEventHandler(MessageListItemContentClick);
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

            _conversationTable = messageTableAdapter.GetDataByConversationID(conversationID , RecipientID , "In");
          
            _conversationID = conversationID;
            Console.WriteLine("Populate message convo ID is" + _conversationID);
            for (int i = _conversationTable.Rows.Count - 1; i >= 0; i--)
            {
                if ((String)_conversationTable.Rows[i]["Status"] == "Sent")
                {


                    ConversationItem conversationItem = new ConversationItem(conversationID, (int)_conversationTable.Rows[i]["MessageIDNumber"])
                    {
                       
                       
                        Subject = (String)_conversationTable.Rows[i]["MessageTitle"],
                        MessageContent = (String)_conversationTable.Rows[i]["MessageContent"],
                        ReadOrNotRead = (String)_conversationTable.Rows[i]["ReadOrNotRead"],
                       
                        Date = (DateTime)_conversationTable.Rows[i]["DateTime"],
                        Status = (String)_conversationTable.Rows[i]["Status"],
                        Width = ConversationFlowPanel.Width - 10





                    };
                    if (TypeLabel.Text == "Inbox" || TypeLabel.Text == "Junk")
                    {
                        conversationItem.SenderName = (String)_conversationTable.Rows[i]["RecipientName"];
                        conversationItem.SenderID = (String)_conversationTable.Rows[i]["RecipientID"];
                        conversationItem.ReceiverName = (String)_conversationTable.Rows[i]["SenderName"];
                        conversationItem.ReceiverID = (String)_conversationTable.Rows[i]["SenderID"];
                    }
                    if (TypeLabel.Text == "Drafts" || TypeLabel.Text == "Sent")
                    {
                        conversationItem.SenderName = (String)_conversationTable.Rows[i]["SenderName"];
                        conversationItem.SenderID = (String)_conversationTable.Rows[i]["SenderID"];
                        conversationItem.ReceiverName = (String)_conversationTable.Rows[i]["RecipientName"];
                        conversationItem.ReceiverID = (String)_conversationTable.Rows[i]["RecipientID"];
                    }
                    
                   

                    conversationItem.EditDraftButton.Click += new EventHandler(EditDraftButtonClick);
                    conversationItem.ReplyButton.Click += new EventHandler(ReplyButtonClick);
                    conversationItem.ForwardButton.Click += new EventHandler(ForwardButtonClick);
                    ConversationFlowPanel.Controls.Add(conversationItem);

                }
                else
                {

                    NewMessageItem newMessage = new NewMessageItem(conversationID, (int)_conversationTable.Rows[i]["MessageIDNumber"], MessageTitleLabel)
                    {

                        SenderName = (String)_conversationTable.Rows[i]["SenderName"],
                        SenderID = (String)_conversationTable.Rows[i]["SenderID"],
                        Subject = (String)_conversationTable.Rows[i]["MessageTitle"],
                        MessageContent = (String)_conversationTable.Rows[i]["MessageContent"],
                        ReceiverName = (String)_conversationTable.Rows[i]["RecipientName"],
                        ReceiverID = (String)_conversationTable.Rows[i]["RecipientID"],
                        Date = (DateTime)_conversationTable.Rows[i]["DateTime"],
                        Width = ConversationFlowPanel.Width - 10





                    };

                    ConversationFlowPanel.Controls.Add(newMessage);
                }
        
            }


        }


        private void ListItemDeleteButtonClick(object sender, EventArgs e)
        {
            Button thisDeleteButton = (Button)sender;
            MessageListItem listItem = (MessageListItem)thisDeleteButton.Parent;
            string conversationID = listItem.ConversationID;
            doAction.deleteConversation(conversationID);


            for(int i = 0; i < ConversationFlowPanel.Controls.Count; i++)
            {
               
                if(ConversationFlowPanel.Controls[i].GetType() == typeof(ConversationItem))
                {
                    ConversationItem item = (ConversationItem)ConversationFlowPanel.Controls[i];
                    item.Hide();
                    item.Dispose();

                }
                else
                {
                    NewMessageItem item = (NewMessageItem)ConversationFlowPanel.Controls[i];
                    item.Hide();
                    item.Dispose();

                }

            }
        }

        private void ReplyButtonClick(object sender, EventArgs e)
        {
            Button replyButton = (Button)sender;
            ConversationItem priorMessage = (ConversationItem)replyButton.Parent;


            NewMessageItem replyMessage = new NewMessageItem(_conversationID , MessageTitleLabel)
            {
                ReceiverName = priorMessage.SenderName,
                ReceiverID = priorMessage.SenderID,
                SenderID = this.RecipientID,
                SenderName = this.RecipientName,
                Width = ConversationFlowPanel.Width



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


            NewMessageItem forwardMessage = new NewMessageItem(_conversationID , MessageTitleLabel)
            {
                ReceiverName = priorMessage.SenderName,
                ReceiverID = priorMessage.SenderID,
                SenderID = this.RecipientID,
                SenderName = this.RecipientName,
                Width = ConversationFlowPanel.Width


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
            DataTable _messageForID = messageTableAdapter.GetDataByMessageIDNumber(item.MessageID, "In");




            NewMessageItem draftToEdit = new NewMessageItem(_conversationID, MessageTitleLabel)
            {
                Subject = (String)_messageForID.Rows[0]["MessageTitle"],
                SenderName = (String)_messageForID.Rows[0]["SenderName"],
                SenderID = (String)_messageForID.Rows[0]["SenderID"],
                ReceiverName = (String)_messageForID.Rows[0]["RecipientName"],
                ReceiverID = (String)_messageForID.Rows[0]["RecipientID"],
                MessageContent = (String)_messageForID.Rows[0]["MessageContent"],
                Width = ConversationFlowPanel.Width - 10


            };

            ConversationFlowPanel.Controls.Add(draftToEdit);
            draftToEdit.Width = ConversationFlowPanel.Width - 10;

  

            item.Dispose();
            
        }

        private void MessageListItemContentClick(object sender, EventArgs e)
        {
            Console.WriteLine("Messageclick");
            Label thisLabel = (Label)sender;
            MessageListItem thisMessageItem = (MessageListItem)thisLabel.Parent;
            _conversationID = thisMessageItem.ConversationID;
            Console.WriteLine("This covo id is " + _conversationID);
            if (!String.IsNullOrWhiteSpace(thisMessageItem.Subject))
            {
                MessageTitleLabel.Text = thisMessageItem.Subject;
            }
            else
            {
                MessageTitleLabel.Text = "No Subject";
            }

            PopulateMessageConversation(_conversationID);
        }

        private void MessageListItemClick(object sender, EventArgs e)
        {


            Console.WriteLine("Messageclick");
            MessageListItem thisMessageItem = (MessageListItem)sender;
            _conversationID = thisMessageItem.ConversationID;
            Console.WriteLine("This covo id is " + _conversationID);
            MessageTitleLabel.Text = thisMessageItem.Subject;

            PopulateMessageConversation(_conversationID);



        }

       

        private void MessagesView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ConversationFlowPanel.AutoScroll = false;
            this.ConversationFlowPanel.HorizontalScroll.Enabled = false;
            this.ConversationFlowPanel.AutoScroll = true;
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
            NewMessageItem newMessage = new NewMessageItem(MessageTitleLabel)
            {
                SenderID = this.RecipientID,
                SenderName = RecipientName,
                Width = ConversationFlowPanel.Width
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
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this.RecipientID ,"Sent" , "In");
            PopulateMessages(_messagesTable);
            TypeLabel.Text = "Inbox";
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataBySent(this.RecipientID, "Sent" , "Out");
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageListFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
