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
    public partial class NewMessageItem : UserControl
    {
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);

        public NewMessageItem()
        {
            InitializeComponent();
            MessageContentBox.AutoSize = true;
            this.SendMessageButton.Click += new EventHandler(this.SendMessageButtonClick);
            this.DiscardButton.Click += new EventHandler(this.DiscardButtonClick);
            this.ReceiverComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ReceiverComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.ReceiverComboBox.AutoCompleteCustomSource = AutoComplete.EmployeeNamesAutoCompete();
            this.ReceiverComboBox.DataSource = allEmployeesTableAdapter.GetEmployeeData();
            this.ReceiverComboBox.DisplayMember = "EmployeeName";
            this.ReceiverComboBox.ValueMember = "EmployeeID";
            this.ConversationID = Guid.NewGuid().ToString("N");


        }
        public NewMessageItem(string conversationID) 
        {
            InitializeComponent();
            MessageContentBox.AutoSize = true;
            this.SendMessageButton.Click += new EventHandler(this.SendMessageButtonClick);
            this.DiscardButton.Click += new EventHandler(this.DiscardButtonClick);
            this.ReceiverComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ReceiverComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.ReceiverComboBox.AutoCompleteCustomSource = AutoComplete.EmployeeNamesAutoCompete();
            this.ReceiverComboBox.DataSource = allEmployeesTableAdapter.GetEmployeeData();
            this.ReceiverComboBox.DisplayMember = "EmployeeName";
            this.ReceiverComboBox.ValueMember = "EmployeeID";
            this.ConversationID = conversationID;
        }

        #region Properties

        private string _subject;
        private string _receiverName;
        private string _messageContent;
        private Timer _timer1;
        private string _senderName;
        private string _senderID;
        private Dictionary<string, string> selectedEmployeeIDs = new Dictionary<string, string>();
        private Dictionary<int, string> selectedMessageID = new Dictionary<int, string>();
        private string _conversationID;
        private int _messageIDNumber = 0;
        private string _receiverID;



        public string Subject
        {
            get { return _subject; }
            set { _subject = value; SubjectBox.Text = value; }
        }

        public string ReceiverName
        {
            get { return _receiverName; }
            set { _receiverName = value; ReceiverComboBox.Text = value; }
        }

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; MessageContentBox.Text = value; }
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

        public string ConversationID
        {
            get { return _conversationID; }
            set { _conversationID = value; }
        }

        public string ReceiverID
        {
            get { return _receiverID; }
            set { _receiverID = value; }
        }



      


        #endregion

        #region Functions

        public void InitTime()
        {
            _timer1 = new Timer();
            _timer1.Tick += new EventHandler(Timer1_Tick);
            _timer1.Interval = 5000;
            _timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            foreach( int _messageIDNumber in selectedMessageID.Keys)
            {

                string employeeID = selectedMessageID[_messageIDNumber];
                string employeeName = selectedEmployeeIDs[employeeID];


                doAction.updateMessageDraft(_subject, MessageContentBox.Text, DateTime.Now, employeeName,
                    employeeID, _messageIDNumber);

            }
        }

        private void SendMessageButtonClick(object sender, EventArgs e)
        {
            foreach(int _messageIDNumber in selectedMessageID.Keys)
            {
                string employeeID = selectedMessageID[_messageIDNumber];
                string employeeName = selectedEmployeeIDs[employeeID];

                doAction.SendMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, employeeName,
                    employeeID, _messageIDNumber);
            }
        }

        private void DiscardButtonClick(object sender , EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SubjectBox.Text)) SubjectBox.Text = "Add a subject";
        }

        private void NewMessageItem_Load(object sender, EventArgs e)
        {
            ReceiverComboBox.Text = _receiverName;
            SubjectBox.Text = _subject;
            MessageContentBox.Text = _messageContent;

        }

        #endregion

     

        private void MessageContentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
 

            if (!selectedEmployeeIDs.ContainsKey((String)ReceiverComboBox.SelectedValue))
            {
                selectedEmployeeIDs.Add((String)ReceiverComboBox.SelectedValue , (String)ReceiverComboBox.SelectedText);
                _messageIDNumber = doAction.createNewMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, _senderName, _senderID, (String)ReceiverComboBox.SelectedValue,
                        (String)ReceiverComboBox.SelectedText, _conversationID, "Draft");

                selectedMessageID.Add(_messageIDNumber , (String)ReceiverComboBox.SelectedValue);
                ReceiverComboBox.Text += " , " + ReceiverComboBox.SelectedText;

                
            }
            else
            {
                selectedEmployeeIDs.Remove((String)ReceiverComboBox.SelectedValue);
                foreach (int messageID in selectedMessageID.Keys)
                {
                    doAction.deleteMessage(messageID , (String)ReceiverComboBox.SelectedValue);
                }

                ReceiverComboBox.Text = ReceiverComboBox.Text.Replace(" , " + ReceiverComboBox.SelectedText, "");

               
            }
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            foreach (int messageID in selectedMessageID.Keys)
            {
                doAction.deleteMessage(messageID, (String)ReceiverComboBox.SelectedValue);
                this.Hide();
                this.Dispose();
            }

        }
    }
}
