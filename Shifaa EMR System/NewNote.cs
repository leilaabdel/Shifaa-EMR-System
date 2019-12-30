using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifaa_EMR_System
{
    public partial class NewNote : Form
    {

        private SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        int thisPatientID;
        string thisProviderName;
        string thisProviderID;

        public NewNote(int patientID , string providerName , string providerID)
        {
            this.thisPatientID = patientID;
            this.thisProviderName = providerName;
            this.thisProviderID = providerID;
            InitializeComponent();
        }

        private void NewNote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMRDatabaseDataSet.PatientNote' table. You can move, or remove it, as needed.
            this.patientNoteTableAdapter.FillByPatientID(eMRDatabaseDataSet.PatientNote, thisPatientID);
            this.NoteHistoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.NoteHistoryTable.MultiSelect = false;
            this.NewNoteDateValue.Text = DateTime.Today.ToShortDateString();




        }

        private void AddendumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoteHistoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void NoteHistoryTable_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime existingNoteDate = (DateTime)NoteHistoryTable["Date", e.RowIndex].Value;
            String noteTitle = (String)NoteHistoryTable["NoteTitle", e.RowIndex].Value;
            String noteContent = "";
            String providerName = "";
            ISingleResult<getPatientNoteResult> result = doAction.getPatientNote(thisPatientID, existingNoteDate, noteTitle);

            foreach (getPatientNoteResult r in result){

                noteContent = r.NoteContent;
                providerName = r.ProviderName;

            }

            AddExistingNoteTab(existingNoteDate, noteTitle, noteContent, providerName);





        }




        private void AddExistingNoteTab(DateTime date, String noteTitle, String noteContent, String providerName)
        {
            TabPage newTab = new TabPage();
          


            Button newSignButton = new System.Windows.Forms.Button();
            Label newDateValueLabel = new System.Windows.Forms.Label();
            RichTextBox newAddendumBox = new System.Windows.Forms.RichTextBox();
            Label newTitleValueNameLabel = new System.Windows.Forms.Label();
            Button newAddendumButton = new System.Windows.Forms.Button();
            Label newNoteLabel = new System.Windows.Forms.Label();
            RichTextBox newNoteBox = new System.Windows.Forms.RichTextBox();
            Label newDateLabel = new System.Windows.Forms.Label();
            Label newNoteTitleLabel = new System.Windows.Forms.Label();
            Label newAddendumLabel = new System.Windows.Forms.Label();
            Button newExitButton = new System.Windows.Forms.Button();

            // SignButton1
            // 
            newSignButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            newSignButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            newSignButton.FlatAppearance.BorderSize = 0;
            newSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newSignButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newSignButton.Location = new System.Drawing.Point(423, 27);
            newSignButton.Name = "newSignButton";
            newSignButton.Size = new System.Drawing.Size(94, 26);
            newSignButton.TabIndex = 66;
            newSignButton.Text = "Sign";
            newSignButton.UseVisualStyleBackColor = false;
            newSignButton.Hide();
            newSignButton.Click += new System.EventHandler(ExistingSignButtonClick);
            // 
            // DateValueLabel1
            // 
            newDateValueLabel.AutoSize = true;
            newDateValueLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newDateValueLabel.Location = new System.Drawing.Point(101, 12);
            newDateValueLabel.Name = "newDateValueLabel";
            newDateValueLabel.Size = new System.Drawing.Size(82, 17);
            newDateValueLabel.TabIndex = 57;
            newDateValueLabel.Text = date.ToShortDateString();
            newDateValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddendumBox1
            // 
            newAddendumBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newAddendumBox.Location = new System.Drawing.Point(7, 314);
            newAddendumBox.Multiline = true;
            newAddendumBox.Name = "newAddendumBox";
            newAddendumBox.Size = new System.Drawing.Size(650, 254);
            newAddendumBox.TabIndex = 56;
            newAddendumBox.TextChanged += new System.EventHandler(this.AddendumBox_TextChanged);
            newAddendumBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            newAddendumBox.Hide();
            // 
            // TitleNameLabel
            // 
            newTitleValueNameLabel.AutoSize = true;
            newTitleValueNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newTitleValueNameLabel.Location = new System.Drawing.Point(101, 38);
            newTitleValueNameLabel.Name = "newTitleValueNameLabel";
            newTitleValueNameLabel.Size = new System.Drawing.Size(36, 17);
            newTitleValueNameLabel.TabIndex = 53;
            newTitleValueNameLabel.Text = noteTitle;
            newTitleValueNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddendumButton
            // 
            newAddendumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            newAddendumButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            newAddendumButton.FlatAppearance.BorderSize = 0;
            newAddendumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newAddendumButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newAddendumButton.Location = new System.Drawing.Point(423, 27);
            newAddendumButton.Name = "newAddendumButton";
            newAddendumButton.Size = new System.Drawing.Size(94, 26);
            newAddendumButton.TabIndex = 52;
            newAddendumButton.Text = "Addendum";
            newAddendumButton.UseVisualStyleBackColor = false;
            newAddendumButton.Click += new System.EventHandler(AddendumButtonClick);
            newAddendumButton.Show();
            // 
            // NoteLabel1
            // 
            newNoteLabel.AutoSize = true;
            newNoteLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newNoteLabel.Location = new System.Drawing.Point(26, 64);
            newNoteLabel.Name = "newNoteLabel";
            newNoteLabel.Size = new System.Drawing.Size(42, 17);
            newNoteLabel.TabIndex = 51;
            newNoteLabel.Text = "Note:";
            newNoteLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteBox1
            // 
            newNoteBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newNoteBox.Location = new System.Drawing.Point(7, 89);
            newNoteBox.Multiline = true;
            newNoteBox.Name = "newNoteBox";
            newNoteBox.Text = providerName + " wrote: " + noteContent;
            newNoteBox.Size = new System.Drawing.Size(650, 483);
            newNoteBox.TabIndex = 50;
            newNoteBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            // 

            // 
            // DateLabel1
            // 
            newDateLabel.AutoSize = true;
            newDateLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newDateLabel.Location = new System.Drawing.Point(26, 12);
            newDateLabel.Name = "newDateLabel";
            newDateLabel.Size = new System.Drawing.Size(40, 17);
            newDateLabel.TabIndex = 47;
            newDateLabel.Text = "Date:";
            newDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NoteTitleLabel1
            // 
            newNoteTitleLabel.AutoSize = true;
            newNoteTitleLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newNoteTitleLabel.Location = new System.Drawing.Point(26, 38);
            newNoteTitleLabel.Name = "newNoteTitleLabel";
            newNoteTitleLabel.Size = new System.Drawing.Size(72, 17);
            newNoteTitleLabel.TabIndex = 46;
            newNoteTitleLabel.Text = "Note Title:";
            newNoteTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;


            // newAddendumLabel
            // 
            newAddendumLabel.AutoSize = true;
            newAddendumLabel.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newAddendumLabel.Location = new System.Drawing.Point(24, 293);
            newAddendumLabel.Name = "newAddendumLabel";
            newAddendumLabel.Size = new System.Drawing.Size(77, 17);
            newAddendumLabel.TabIndex = 67;
            newAddendumLabel.Text = "Addendum";
            newAddendumLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            newAddendumLabel.Hide();

            //newExitButton

            newExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            newExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            newExitButton.FlatAppearance.BorderSize = 0;
            newExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            newExitButton.Location = new System.Drawing.Point(546, 27);
            newExitButton.Name = "ExitButton";
            newExitButton.Size = new System.Drawing.Size(94, 26);
            newExitButton.TabIndex = 52;
            newExitButton.Text = "Exit";
            newExitButton.UseVisualStyleBackColor = false;
            newExitButton.Click += new System.EventHandler(ExitButtonClick);


            newTab.Controls.Add(newExitButton);
            newTab.Controls.Add(newSignButton);
            newTab.Controls.Add(newDateValueLabel);
            newTab.Controls.Add(newAddendumBox);
            newTab.Controls.Add(newTitleValueNameLabel);
            newTab.Controls.Add(newAddendumButton);
            newTab.Controls.Add(newNoteLabel);
            newTab.Controls.Add(newNoteBox);
            newTab.Controls.Add(newDateLabel);
            newTab.Controls.Add(newNoteTitleLabel);
            newTab.Controls.Add(newAddendumLabel);
            newTab.Location = new System.Drawing.Point(4, 22);
            newTab.Padding = new System.Windows.Forms.Padding(3);
            newTab.Size = new System.Drawing.Size(669, 584);
            newTab.TabIndex = NewNoteTabControl.TabCount;
            newTab.Text = noteTitle;
            newTab.UseVisualStyleBackColor = true;

            NewNoteTabControl.TabPages.Add(newTab);
            NewNoteTabControl.SelectedTab = newTab;

         

        }

        private void AddendumButtonClick(object sender, EventArgs e)
        {
            //Hide the Addendum Button 
            Button thisAddendumButton = (Button)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumButton", false)[0];
            thisAddendumButton.Hide();
           


            //Show Sign Button
            Button thisSignButton = (Button)NewNoteTabControl.SelectedTab.Controls.Find("newSignButton", false)[0];
            thisSignButton.Show();

            //Change the dimensions of the addendum box
            RichTextBox thisAddendumBox = (RichTextBox)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumBox", false)[0];
            thisAddendumBox.Size = new System.Drawing.Size(650, 254);
            thisAddendumBox.Location = new Point(7, 314);
            thisAddendumBox.Show();

            //Change dimensions of original notebox
            RichTextBox thisOriginalNoteBox = (RichTextBox)NewNoteTabControl.SelectedTab.Controls.Find("newNoteBox", false)[0];
            thisOriginalNoteBox.Size = new System.Drawing.Size(650, 199);

            //Add Addendum Label
            Label thisAddendumLabel = (Label)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumLabel", false)[0];
            thisAddendumLabel.Show();

            
        }

        private void ExistingSignButtonClick(object sender, EventArgs e)
        {


            //Get AddendumTextBox Content 
            RichTextBox thisAddendumBox = (RichTextBox)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumBox", false)[0];
            String addendumText = thisAddendumBox.Text;

            //Add it to the Old Note TextBox Content (with provider name name and the current date)

            //TO DO: ADD THE PROVIDER NAME 
            RichTextBox thisOldNoteBox = (RichTextBox)NewNoteTabControl.SelectedTab.Controls.Find("newNoteBox", false)[0];
            String oldNoteContent = thisOldNoteBox.Text;
            String currentDate = DateTime.Today.ToShortDateString();
            thisOldNoteBox.AppendText("\n\n");
            thisOldNoteBox.Font = new Font("Bahnschrift Bold", 10F, FontStyle.Bold);
            thisOldNoteBox.AppendText(thisProviderName + " wrote on " + currentDate + "\n");
            thisOldNoteBox.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular);
            thisOldNoteBox.AppendText(addendumText);


            //Restore the Old Note Box the original size
            thisOldNoteBox.Size = new System.Drawing.Size(650, 483);

            //Clear the Addendum TextBox Content 
            thisAddendumBox.Clear();

            //Hide the Addendum TextBox 
            thisAddendumBox.Hide();

            //Hide the Addendum Label
            Label thisAddendumLabel = (Label)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumLabel", false)[0];
            thisAddendumLabel.Hide();


            //Hide the Sign Button 
            Button thisSignButton = (Button)NewNoteTabControl.SelectedTab.Controls.Find("newSignButton", false)[0];
            thisSignButton.Hide();

            //Show the Addendum Button 
            Button thisAddendumButton = (Button)NewNoteTabControl.SelectedTab.Controls.Find("newAddendumButton", false)[0];
            thisAddendumButton.Show();


            Label thisNoteTitleValueLabel = (Label)NewNoteTabControl.SelectedTab.Controls.Find("newTitleValueNameLabel", false)[0];
            Label thisNoteValueDate = (Label)NewNoteTabControl.SelectedTab.Controls.Find("newDateValueLabel", false)[0];


            try
            {
                doAction.updateExistingNote(thisPatientID, thisNoteTitleValueLabel.Text,
                    Convert.ToDateTime(thisNoteValueDate.Text), thisOldNoteBox.Text);
                this.patientNoteTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);
                this.patientNoteTableAdapter1.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);


            }
            catch (FieldAccessException)
            {
                MessageBox.Show("Please update the note or exit the page");
            }

            

        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            //Remove the selected tab when the exit button is clicked
            NewNoteTabControl.TabPages.Remove(NewNoteTabControl.SelectedTab);

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            String noteTitle = NewNoteTitleBox.Text;
            String noteContent = NoteContentBox.Text;


            try
            {

                doAction.createNewPatientNote(thisPatientID, thisProviderName, thisProviderID, noteTitle, noteContent);
                this.patientNoteTableAdapter.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);
                this.patientNoteTableAdapter1.FillByPatientID(this.eMRDatabaseDataSet.PatientNote, thisPatientID);

            }
            catch
            {
                MessageBox.Show("Please enter a valid note entry");
            }
          


           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void NewNotePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
