using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class ConversationItem : UserControl
    {

        public ConversationItem(string conversationID , int messageID)
        {
            InitializeComponent();
            MessageContentBox.AutoSize = true;
            this.AutoSize = true;
            this.ConversationID = conversationID;
            this.MessageID = messageID;

            EditDraftButton.Hide();

            if(_status == "Draft")
            {
                ReplyButton.Hide();
                ForwardButton.Hide();
                MessageContentBox.ReadOnly = true;
                EditDraftButton.Show();
                EditDraftButton.Click += new EventHandler(this.EditDraftButtonClick);

            }

        }





        #region Properties

        private string _messageContent;
        private DateTime _date;
        private string _senderName;
        private string _receiverName;
        private string _subject;
        private string _readOrNotRead;
        private string _status;
        private string _senderID;
    

        public Button GetReplyButton
        {
            get { return this.ReplyButton; }
        }

        public Button GetForwardButton
        {
            get { return this.ForwardButton; }
        }

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; DateTimeSent.Text = value.ToString("dddd, d/MM/yyyy h:mm tt"); }
        }

        public string SenderName
        {
            get { return _senderName; }
            set { _senderName = value; }
        }
        public string SenderID
        {
            get { return _senderID; }
            set { _senderID = value; }
        }

        public string ReceiverName
        {
            get { return _receiverName; }
            set { _receiverName = value; }
        }

        public string Subject
        { 
            get { return _subject; }
            set { _subject = value; }
        }

        public string ReadOrNotRead
        {
            get { return _readOrNotRead; }
            set { _readOrNotRead = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }



        public string ConversationID { get; }

        public int MessageID { get; }
        public string ReceiverID { get; internal set; }

        #endregion

        #region Functions


        private void ConversationItem_Load(object sender, EventArgs e)
        {
            this.MessageContentBox.Text = _messageContent;
            this.SenderLabel.Text = _senderName;
            this.ReceiverNameLabel.Text = _receiverName;
            this.DateTimeSent.Text = _date.ToString("dddd, d/MM/yyyy h:mm tt");


        }

        private void EditDraftButtonClick(object sender, EventArgs e)
        {
            this.Hide();
        }


        #endregion

        private void MessageContentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
