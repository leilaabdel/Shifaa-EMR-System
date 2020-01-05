using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using System.Xml.Serialization;
using System.IO;
using System.Data.Linq;


namespace Shifaa_EMR_System
{
    public partial class SchedulingCalendar : Form
    {
        private List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        readonly string thisProviderID = null;
        readonly int thisPatientID = 0;
        int selectedAppointmentID = 0;
        readonly ProviderMain providerMain;
        private List<String> providerIDList = new List<String>();


        SchedulerMain schedulerMain;
        public SchedulingCalendar(string providerID , ProviderMain providerMain)
        {
            InitializeComponent();
            this.thisProviderID = providerID;

            providerIDList.Add(thisProviderID);

            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            //Initialize only double clicking for physicians
            this.calendar1.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);

            this.providerMain = providerMain ?? new ProviderMain(thisProviderID , thisProviderID);

            ProviderComboBox.Hide();
            SelectProviderLabel.Hide();
            panel1.Hide();
            calendar1.Location =  new Point(213, 0);
          

            calendar1.SetViewRange(DateTime.Today , DateTime.Today.Add(new TimeSpan(7, 0 , 0 , 0)));

            this.MdiParent = providerMain;
            this.WindowState = FormWindowState.Maximized;


        }

        public SchedulingCalendar(string schedulerID , SchedulerMain schedulerMain)
        {
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            this.schedulerMain = schedulerMain ?? new SchedulerMain("123");
            this.WindowState = FormWindowState.Maximized;

            DataTable providersForScheduler = schedulersBelongingToProviderTableAdapter.GetDataBySchedulerID(schedulerID);

            ProviderComboBox.DisplayMember = "ProviderName";
            ProviderComboBox.ValueMember = "ProviderID";

            ProviderComboBox.DataSource = providersForScheduler;
      
            calendar1.Location = new Point(213, 75);


            calendar1.SetViewRange(DateTime.Today, DateTime.Today.Add(new TimeSpan(7, 0, 0, 0)));

            this.MdiParent = schedulerMain;
            this.WindowState = FormWindowState.Maximized;
        }

        public SchedulingCalendar(int patientID)
        {
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            thisPatientID = patientID;
            this.WindowState = FormWindowState.Maximized;


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            _items.Clear();


            this.WindowState = FormWindowState.Maximized;
            calendar1.Dock = DockStyle.Top;

            foreach (string provider in providerIDList)
            {

                ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(provider);

                foreach (getAppointmentForCurrentProviderResult r in result)
                {

                    DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                    DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                    string patientName = r.FirstName + " " + r.LastName;
                    int patientID = r.patientID;

                    string itemText = patientName + "\n" + r.Details;
                    CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, itemText, patientName, r.appointmentID, r.patientID, r.ProviderID);

                    Color c = Color.FromName(r.Color);
                    cal.BackgroundColor = c;


                    _items.Add(cal);
                }

                PlaceItems(_items);
            }
                

           




        }

   

        public List<CalendarItem> GetCalendarItems()
        {
            return _items;
        }

        public void SetCalendarItems(List<CalendarItem> items)
        {
            this._items = items;
        }


        public int GetAppointmentID()
        {
            return selectedAppointmentID;
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems(_items);
        }

        public void PlaceItems(List<CalendarItem> items)
        {
            foreach (CalendarItem item in items)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void calender1_DragOver(object sender, DragEventArgs e)
        {
            if(calendar1.State == Calendar.CalendarState.DraggingTimeSelection)
            {

            }
        }

        private void calendar1_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null && thisPatientID == 0)
            {
                NewAppointment newAppointment = new NewAppointment(e.Item, thisProviderID , calendar1 , _items , this);
                newAppointment.Show();


                
                
            }

            if (Application.OpenForms["NewAppointmentFromPatientView"] as NewAppointmentFromPatientView == null && thisPatientID != 0)
            {
                NewAppointmentFromPatientView newAppointment = new NewAppointmentFromPatientView(thisPatientID, thisProviderID, e.Item , calendar1, _items, this);
                newAppointment.Show();



            
              }


        }


        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<CalendarItem> list = (List<CalendarItem>)calendar1.GetSelectedItems();
            Console.WriteLine(list.Count);
            foreach (CalendarItem i in list)
            {
                Console.WriteLine(i.AppointmentID.ToString());
                doAction.deleteAppointment(i.AppointmentID);
                calendar1.Items.Remove(i);
            }

            Console.WriteLine("clicked");

                
            
           

        }
        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {


            //calendar1.ActivateEditMode(e.Item);


            
         



        }
        private void calendar1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
            CalendarItem i = calendar1.ItemAt(p);

            if (i == null)
            {
                toolTip1.Active = false;
                toolTip1.Hide(this);
            }
            else
            {
                toolTip1.Active = true;
                string toShow = i.StartDate.ToShortTimeString() + " - " + i.EndDate.ToShortTimeString() + "\n" +
                    i.Text;
                toolTip1.Show(toShow, this, p);
            }
        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show(e.Item.Text);
        }

        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixMinutes;
        }

        private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            if (Application.OpenForms["NewAppointment"] as NewAppointment == null && thisPatientID == 0)
            {
                NewAppointment newAppointment = new NewAppointment(true , selected, thisProviderID, calendar1, _items, this);
                newAppointment.Show();

            }




        }

        private void ScheduledClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            doAction.updateAppointmentStatus("Scheduled", selected.AppointmentID , "Blue");
            selected.BackgroundColor = Color.Blue;
           
        }

        private void CheckedInClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            doAction.updateAppointmentStatus("Checked In", selected.AppointmentID , "Yellow");
            selected.BackgroundColorLighter = Color.Yellow;


        }

        private void CompleteClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            doAction.updateAppointmentStatus("Complete", selected.AppointmentID, "Green");
            selected.BackgroundColor = Color.Green;


        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
      
        }

        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            selectedAppointmentID = e.Item.AppointmentID;

            if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
            {

                ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(e.Item.PatientID);
                foreach (getPatientByIDResult r in result)
                {
                    string name = r.FirstName + " " + r.LastName;
                    PatientHomePage patientHomePage = new PatientHomePage(name, r.PhoneNumber, r.Gender,
                        r.Age, r.DOB, e.Item.PatientID, this.providerMain, this);
                }

               
            }
        }

        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {

          

        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Vertical;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Empty;
                calendar1.Invalidate(item);
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void northToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.North;
                calendar1.Invalidate(item);
            }
        }

        private void eastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.East;
                calendar1.Invalidate(item);
            }
        }

        private void southToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.South;
                calendar1.Invalidate(item);
            }
        }

        private void westToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.West;
                calendar1.Invalidate(item);
            }
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.gif|*.gif|*.png|*.png|*.jpg|*.jpg";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Image img = Image.FromFile(dlg.FileName);

                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.Image = img;
                        calendar1.Invalidate(item);
                    }
                }
            }

            
        }

        private void ProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

           
                string selectedProviderID = (String)ProviderComboBox.SelectedValue;
                string selectedProividerName = (String)ProviderComboBox.SelectedText;
                if (!providerIDList.Contains(selectedProviderID))
                {
                    providerIDList.Add(selectedProviderID);


                    ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(selectedProviderID);

                    foreach (getAppointmentForCurrentProviderResult r in result)
                    {

                        DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                        DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                        string patientName = r.FirstName + " " + r.LastName;
                        int patientID = r.patientID;

                        string itemText = patientName  + "\n" + selectedProividerName + "\n" +  r.Details;
                        CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, itemText , patientName, r.appointmentID, r.patientID, r.ProviderID);

                        if (r.patientID == thisPatientID)
                        {
                            cal.ApplyColor(Color.AliceBlue);
                        }

                        _items.Add(cal);
                    }

                    PlaceItems(_items);


                }

                else
                {
                    providerIDList.Remove(selectedProviderID);
                }
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}