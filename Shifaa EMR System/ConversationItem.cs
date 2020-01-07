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

        public ConversationItem()
        {
            InitializeComponent();
            MessageContentBox.AutoSize = true;
            this.AutoSize = true;

        }





        #region Properties

        private string _messageContent;
        private DateTime _date;
        private string _senderName;
        private string _receiverName;
        private string _subject;

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
            set { _date = value; }
        }

        public string SenderName
        {
            get { return _senderName; }
            set { _senderName = value; }
        }

        public string ReceiverName
        {
            get { return _receiverName; }
            set { _receiverName = value; }
        }

        public string Subject
        {
            get { return _subject; }
        }


        #endregion



        private void ConversationItem_Load(object sender, EventArgs e)
        {
            this.MessageContentBox.Text = _messageContent;
            this.SenderLabel.Text = _senderName;
            this.ReceiverNameLabel.Text = _receiverName;
            this.DateTimeSent.Text = _date.ToString("dddd, d/MM/yyyy h:mm tt");


        }
    }
}
