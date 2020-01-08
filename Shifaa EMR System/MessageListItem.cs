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
    public partial class MessageListItem : UserControl
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);

        public MessageListItem()
        {
            InitializeComponent();

           
           
        }

        #region Properties




        private string _senderName;
        private string _subject;
        private string _messageContent;
        private Color _readLabelColor;
        private string _readOrNotRead;
        private Color _messagePanelMainColor;
        private int _messageID;
        private string _conversatioID;
        



        public string SenderName
        {
            get { return _senderName;  }
            set { _senderName = value; }


        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; }
        }

        public Color ReadLabelColor
        {
            get { return _readLabelColor; }
            set { _readLabelColor = value; ReadPanel.BackColor = value; }
        }

        public string ReadOrNotRead
        {
            get { return _readOrNotRead; }
            set { _readOrNotRead = value; }
        }

        public Color MessagePanelMainColor
        {
            get { return _messagePanelMainColor; }
            set { _messagePanelMainColor = value; MessageMainPanel.BackColor = value; }
        }

        public int MessageID
        {
            get { return _messageID; }
            set { _messageID = value; }
        }

        public string ConversationID
        {
            get { return _conversatioID; }
            set { _conversatioID = value; }
        }
      

        #endregion

        #region Functions

        private void MessageMainPanelClick(object sender, EventArgs e)
        {
            MessageMainPanel.BackColor = Color.LightBlue;
            ReadPanel.BackColor = Color.DarkBlue;
            
            if(this.ReadOrNotRead == "Not_Read")
            {
                doAction.updateMessageReadOrNotRead(_messageID, "Read");
                this._readOrNotRead = "Read";
            }

           


        }

        private void MessageMainPanelMouseHover(object sender, EventArgs e)
        {
            MessageMainPanel.BackColor = Color.Beige;
            ContentLabel.BackColor = Color.Beige;
            SenderLabel.BackColor = Color.Beige;
            SubjectLabel.BackColor = Color.Beige;
            DeleteMessageButton.BackColor = Color.Beige;
            DeleteMessageButton.Show();

            if(this.ReadOrNotRead == "Not_Read")
            {
                MarkAsNotReadButton.Hide();
                MarkAsReadButton.BackColor = Color.Beige;
                MarkAsReadButton.Show();
            }
            if(this.ReadOrNotRead == "Read")
            {
                MarkAsReadButton.Hide();
                MarkAsNotReadButton.BackColor = Color.Beige;
                MarkAsNotReadButton.Show();
            }
            

            
        }



        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageListItem_Load(object sender, EventArgs e)
        {
            if (this.ReadOrNotRead == "Not_Read")
            {
                SenderLabel.Font = new Font("Bahnschrift Bold", SenderLabel.Font.Size);
                SubjectLabel.ForeColor = Color.DarkBlue;
                SubjectLabel.Font = new Font("Bahnschrift Bold", SubjectLabel.Font.Size);
                ReadPanel.BackColor = Color.DarkBlue;
            }
            else
            {
                ReadPanel.BackColor = Color.AliceBlue;
            }
            this.Click += new EventHandler(this.MessageMainPanelClick);
            this.MouseHover += new EventHandler(this.MessageMainPanelMouseHover);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doAction.updateMessageReadOrNotRead(this._messageID , "Read");
        }

        private void DeleteMessageButton_Click(object sender, EventArgs e)
        {

        }

        private void MessageMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarkAsNotReadButton_Click(object sender, EventArgs e)
        {
            doAction.updateMessageReadOrNotRead(this._messageID, "Not_Read");
            SenderLabel.Font = new Font("Bahnschrift Bold" , SenderLabel.Font.Size);
            SubjectLabel.ForeColor = Color.DarkBlue;
            SubjectLabel.Font = new Font("Bahnschrift Bold", SubjectLabel.Font.Size);

        }
    }
}
