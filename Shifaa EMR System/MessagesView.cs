using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class MessagesView : Form
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        private readonly string _recipientID;

        #region Properties

        public string RecipientID
        {
            get { return _recipientID; }
        }


        #endregion

        public MessagesView(string recipientID)
        {
            InitializeComponent();
            _recipientID = recipientID;
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this.RecipientID);

        }

        private DataTable _messagesTable;

        private void populateMessages(DataTable input)
        {
            messageListFlowPanel.Controls.Clear();


            for(int i = 0; i < input.Rows.Count; i++)
            {
                MessageListItem messageListItem = new MessageListItem();
                messageListItem.SenderName = (String)input.Rows[i]["SenderName"];
                messageListItem.Subject = (String)input.Rows[i]["MessageTitle"];
                messageListItem.MessageContent = (String)input.Rows[i]["MessageContent"];
                messageListItem.ReadOrNotRead = (String)input.Rows[i]["ReadOrNotRead"];
                messageListItem.Click += new EventHandler(MessageListItemClick);
               
                if (messageListFlowPanel.Controls.Count < 0)
                {
                    messageListFlowPanel.Controls.Clear();
                }
                else
                messageListFlowPanel.Controls.Add(messageListItem);


            }

        }

        private void populateMessageConversation(string conversationID)
        {

        }

        private void MessageListItemClick(object sender, EventArgs e)
        {
            ConversationFlowPanel.Controls.Clear();



        }

        private void MessagesView_Load(object sender, EventArgs e)
        {
            populateMessages(_messagesTable);


        }

        private void InboxToolStripItem_Click(object sender, EventArgs e)
        {

        }

        private void InboxToolStripItem_Click_1(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByRecipientID(this._recipientID);
            populateMessages(_messagesTable);
        }

        private void SentToolStripItem_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataBySent(this._recipientID);
            populateMessages(_messagesTable);
        }

        private void DraftsToolStripItem_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByDraft(this._recipientID);
            populateMessages(_messagesTable);
        }

        private void JunkToolStripItem_Click(object sender, EventArgs e)
        {
            _messagesTable = this.messageTableAdapter.GetDataByJunk(this._recipientID);
            populateMessages(_messagesTable);
        }
    }
}
