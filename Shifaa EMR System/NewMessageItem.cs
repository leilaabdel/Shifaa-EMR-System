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
        bool isNewConversation;
        public NewMessageItem()
        {
            InitializeComponent();
            
      
            this.ConversationID = Guid.NewGuid().ToString("N");
            isNewConversation = true;


        }
        public NewMessageItem(string conversationID) 
        {
            InitializeComponent();
           
            this.ConversationID = conversationID;
            isNewConversation = false;
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


            string employeeID = ReceiverComboBox.SelectedValue.ToString();
            string employeeName = ReceiverComboBox.Text;

               

                doAction.updateMessageDraft(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, employeeName,
                    employeeID, _messageIDNumber);

        }

        private void SendMessageButtonClick(object sender, EventArgs e)
        {
            string employeeID = ReceiverComboBox.SelectedValue.ToString();
            string employeeName = ReceiverComboBox.Text;

            doAction.SendMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, employeeName,
                    employeeID, _messageIDNumber);
        

            this.Hide();
            this.Dispose();
        }

    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubjectBoxClick(object sender, EventArgs e)
        {
            if (SubjectBox.Text == "Add a subject") SubjectBox.Text = null;
        }

        private void SubjectKeyPress(object sender, EventArgs e)
        {
            if (SubjectBox.Text == "Add a subject") SubjectBox.Text = null;
        }

        private void NewMessageItem_Load(object sender, EventArgs e)
        {
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            if(isNewConversation)
            ReceiverComboBox.Text = _receiverName;
            SubjectBox.Text = _subject;
            MessageContentBox.Text = _messageContent;

            MessageContentBox.AutoSize = true;
            this.SendMessageButton.Click += new EventHandler(this.SendMessageButtonClick);
            this.ReceiverComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ReceiverComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.ReceiverComboBox.AutoCompleteCustomSource = AutoComplete.EmployeeNamesAutoCompete();
            DataTable source = allEmployeesTableAdapter.GetData();
            source.Columns.Add("EmployeeName", typeof(string), "Firstname + ' '+ LastName + ' | ' + JobType");
            this.ReceiverComboBox.DisplayMember = "EmployeeName";
            this.ReceiverComboBox.ValueMember = "EmployeeID";
            this.ReceiverComboBox.DataSource = source;

            selectedEmployeeIDs.Add((String)ReceiverComboBox.SelectedValue, (String)ReceiverComboBox.SelectedText);
            _messageIDNumber = doAction.createNewMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, SenderName, SenderID, ReceiverComboBox.Text, (String)ReceiverComboBox.SelectedValue,
                    _conversationID, "Draft");

            selectedMessageID.Add(_messageIDNumber, (String)ReceiverComboBox.SelectedValue);

        }

        #endregion

     

        private void MessageContentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("the sender ID is " + SenderID);

        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            
            doAction.deleteMessage(_messageIDNumber);
            this.Hide();
            this.Dispose();
          

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
