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
            set { _senderName = value; SenderLabel.Text = value; }


        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; SubjectLabel.Text = value; }
        }

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; ContentLabel.Text = value; }
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

      

        

      


        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageListItem_Load(object sender, EventArgs e)
        {
            if (this.ReadOrNotRead == "Not_Read")
            {
                SenderLabel.Font = new Font("Bahnschrift Bold", SenderLabel.Font.Size);
                SubjectLabel.ForeColor = Color.FromArgb(185, 209, 234);
                SubjectLabel.Font = new Font("Bahnschrift Bold", SubjectLabel.Font.Size);
                SubjectLabel.Text = Subject;
                ReadPanel.BackColor = Color.FromArgb(185, 209, 234);
                MarkAsReadButton.Show();
                MarkAsNotReadButton.Hide();
            }
            else
            {
                SenderLabel.Font = new Font("Bahnschrift Light", SenderLabel.Font.Size);
                SubjectLabel.ForeColor = Color.Black;
                SubjectLabel.Font = new Font("Bahnschrift Light", SubjectLabel.Font.Size);
                ReadPanel.BackColor = Color.AliceBlue;
                MarkAsNotReadButton.Show();
                MarkAsReadButton.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doAction.updateMessageReadOrNotRead(this._messageID , "Read");
            SenderLabel.Font = new Font("Bahnschrift Light", SenderLabel.Font.Size);
            SubjectLabel.ForeColor = Color.Black;
            SubjectLabel.Font = new Font("Bahnschrift Light", SubjectLabel.Font.Size);
            ReadPanel.BackColor = Color.AliceBlue;
            MarkAsNotReadButton.Show();
            MarkAsReadButton.Hide();
        }

        private void DeleteMessageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void MessageMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarkAsNotReadButton_Click(object sender, EventArgs e)
        {
            doAction.updateMessageReadOrNotRead(this._messageID, "Not_Read");
            SenderLabel.Font = new Font("Bahnschrift Bold", SenderLabel.Font.Size);
            SubjectLabel.ForeColor = Color.FromArgb(185, 209, 234);
            SubjectLabel.Font = new Font("Bahnschrift Bold", SubjectLabel.Font.Size);
            ReadPanel.BackColor = Color.FromArgb(185, 209, 234);
            MarkAsReadButton.Show();
            MarkAsNotReadButton.Hide();

        }

        private void ContentLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubjectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
