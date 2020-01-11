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
        public NewMessageItem(Label subjectLabel)
        {
            InitializeComponent();

            parentLabel = subjectLabel;
            this.ConversationID = Guid.NewGuid().ToString("N");
            isNewConversation = true;
            ReceiverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        public NewMessageItem(string conversationID , Label subjectLabel) 
        {
            InitializeComponent();
            parentLabel = subjectLabel;
            this.ConversationID = conversationID;
            isNewConversation = false;
            ReceiverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public bool isEditingDraft = false;

        public NewMessageItem(string conversationID, int messageID , Label subjectLabel)
        {
            InitializeComponent();
            parentLabel = subjectLabel;
            isNewConversation = false;
            ReceiverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this._messageIDNumber = messageID;
            this.ConversationID = conversationID;
            isEditingDraft = true;

        }



        #region Properties
        private Label parentLabel;
        private string _subject;
        private string _receiverName;
        private string _messageContent;
        private Timer _timer1;
        private string _senderName;
        private string _senderID;
        private string _conversationID;
        private int _messageIDNumber;
        private string _receiverID;
        private DateTime _date;



        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string ReceiverName
        {
            get { return _receiverName; }
            set { _receiverName = value; }
        }

        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value;  }
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

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


      


        #endregion

        #region Functions
        private void NewMessageVisibleChanged(object sender, EventArgs e)
        {
            _receiverName = ReceiverComboBox.Text;
            doAction.updateMessageDraft(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, ReceiverComboBox.Text, (String)ReceiverComboBox.SelectedValue, _messageIDNumber);

        }

        public void InitTime()
        {
            _timer1 = new Timer();
            _timer1.Tick += new EventHandler(Timer1_Tick);
            _timer1.Interval = 5000;
            _timer1.Start();
            if(this.Visible == false)
            {
                _timer1.Stop();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (this.Visible == false) return;

            string employeeID = ReceiverComboBox.SelectedValue.ToString();
            string employeeName = ReceiverComboBox.Text;

            Console.WriteLine("the update employyeeID is "
          + employeeID);
            Console.WriteLine("the update employeeName" + employeeName);


            doAction.updateMessageDraft(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, ReceiverComboBox.Text, (String)ReceiverComboBox.SelectedValue, _messageIDNumber);

        }

        private void SendMessageButtonClick(object sender, EventArgs e)
        {
           
            string employeeID = ReceiverComboBox.SelectedValue.ToString();
            string employeeName = ReceiverComboBox.Text;

            Console.WriteLine("the sent employyeeID is "
                + employeeID);
            Console.WriteLine("the send employeeName" + employeeName);


            try
            {
                //TODO: Fix the bug such that there are two seperate copies of the email in the two inboxes;
                doAction.SendMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, employeeName, (String)ReceiverComboBox.SelectedValue, _messageIDNumber);
                doAction.createNewMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, SenderName, SenderID, ReceiverComboBox.Text, (String)ReceiverComboBox.SelectedValue,
                        _conversationID, "Sent", (String)ReceiverComboBox.SelectedValue);


                this.Hide();
                this.Dispose();

            }
            catch(Exception ex)
            {

            }

            
        }

    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SubjectBox.Text)) parentLabel.Text = "No Subject";
            else
            {
                parentLabel.Text = SubjectBox.Text;
            }

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
            
                ReceiverComboBox.SelectedText = _receiverName;
                SubjectBox.Text = _subject;
                MessageContentBox.Text = _messageContent;


        


            MessageContentBox.AutoSize = true;
            this.ReceiverComboBox.AutoCompleteMode = AutoCompleteMode.None;
            this.ReceiverComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            DataTable source = allEmployeesTableAdapter.GetData();
            source.Columns.Add("EmployeeName", typeof(string), "Firstname + ' '+ LastName + ' | ' + JobType");
            this.ReceiverComboBox.DisplayMember = "EmployeeName";
            this.ReceiverComboBox.ValueMember = "EmployeeID";
            this.ReceiverComboBox.DataSource = source;

            if (!isEditingDraft)
            {
                _messageIDNumber = doAction.createNewMessage(SubjectBox.Text, MessageContentBox.Text, DateTime.Now, SenderName, SenderID, ReceiverComboBox.Text, (String)ReceiverComboBox.SelectedValue,
                        _conversationID, "Draft" , SenderID);
            }

            Console.WriteLine("The message ID # is" + _messageIDNumber);

            InitTime();


        }

        #endregion

     

        private void MessageContentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("the receiver ID is " + ReceiverComboBox.SelectedValue.ToString());
            Console.WriteLine("the receiver Name is " + ReceiverComboBox.Text);


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
