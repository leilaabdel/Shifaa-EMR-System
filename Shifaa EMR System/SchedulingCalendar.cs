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
        private static readonly IDbConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.EMRDatabaseConnectionString);
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(con);
        readonly string thisProviderID = null;
        readonly int thisPatientID = 0;
        int selectedAppointmentID = 0;
        readonly ProviderMain providerMain;
        private List<String> providerIDList = new List<String>();
        private string _type;
        private List<CalendarItem> providerCalendarItems = new List<CalendarItem>();


        SchedulerMain schedulerMain;
        public SchedulingCalendar(string providerID, ProviderMain providerMain)
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

            this.providerMain = providerMain ?? new ProviderMain(thisProviderID, thisProviderID);

            ProviderComboBox.Hide();
            SelectProviderLabel.Hide();

            panel1.Hide();

            calendar1.Location = new Point(213, 0);
            calendar1.Dock = DockStyle.Top;


            calendar1.SetViewRange(DateTime.Today, DateTime.Today.Add(new TimeSpan(7, 0, 0, 0)));

            this.MdiParent = providerMain;
            this.WindowState = FormWindowState.Maximized;
            Type = "Provider";

            CancelButton2.Hide();

        }


        public SchedulingCalendar(string schedulerID, SchedulerMain schedulerMain)
        {
            InitializeComponent();
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
            panel2.Hide();
            CancelButton1.Hide();
            calendar1.Location = new Point(213, 75);
            calendar1.Dock = DockStyle.Bottom;
            panel1.Dock = DockStyle.Top;
          

            calendar1.SetViewRange(DateTime.Today, DateTime.Today.Add(new TimeSpan(7, 0, 0, 0)));

            this.MdiParent = schedulerMain;
            this.WindowState = FormWindowState.Maximized;
            Type = "Scheduler";
        }

        public SchedulingCalendar(int patientID)
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            thisPatientID = patientID;
            this.WindowState = FormWindowState.Maximized;
            Type = "Provider";


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            _items.Clear();
           

            this.WindowState = FormWindowState.Maximized;

            ProviderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            calendar1.Items.Clear();

            if (thisPatientID == 0)
            {


                foreach (string provider in providerIDList)
                {

                    ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(provider);

                    foreach (getAppointmentForCurrentProviderResult r in result)
                    {

                        DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                        DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                        string patientName = r.FirstName + " " + r.LastName;
                        int patientID = r.patientID;



                        string itemText = patientName + "\n" + GetProviderName(provider) + "\n" + r.Details;
                        CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, itemText, r.FirstName, r.LastName, r.appointmentID,
                            r.patientID, r.ProviderID, r.Status);

                        Color c = Color.FromName(r.Color);
                        cal.BackgroundColor = c;
                        if (r.Pattern != "None" && r.PatternColor != "Color [Empty]")
                        {
                            cal.Pattern = (System.Drawing.Drawing2D.HatchStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.HatchStyle), r.Pattern);
                            cal.PatternColor = Color.Red;

                        }
                      

                        _items.Add(cal);
                    }

                    PlaceItems(_items);
                }
            }
            else
            {
                ISingleResult<getAppointmentsForCurrentPatientResult> result = doAction.getAppointmentsForCurrentPatient(thisPatientID);

                foreach (getAppointmentsForCurrentPatientResult r in result)
                {

                    DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                    DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                    string patientName = r.FirstName + " " + r.LastName;
                    int patientID = r.patientID;



                    string itemText = patientName + "\n" + GetProviderName(r.ProviderID) + "\n" + r.Details;
                    CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, itemText, r.FirstName, r.LastName, r.appointmentID,
                        r.patientID, r.ProviderID, r.Status);

                    Color c = Color.FromName(r.Color);
                    cal.BackgroundColor = c;
                    cal.Pattern = (System.Drawing.Drawing2D.HatchStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.HatchStyle), r.Pattern);
                    cal.PatternColor = Color.Red;

                    _items.Add(cal);
                }

                PlaceItems(_items);
            }
        }

        private void GainedFocus(object sender, EventArgs e)
        {

          

        }


        private string GetProviderName(string providerID)
        {
            string name = "";
            ISingleResult<getProviderInfoResult> result = doAction.getProviderInfo(providerID);
            foreach (getProviderInfoResult r in result)
            {
                name = r.FirstName + " " + r.LastName + " " + r.Title;
            }

            return name;
        }


        public List<CalendarItem> GetCalendarItems()
        {
            return _items;
        }


        public int GetAppointmentID()
        {
            return selectedAppointmentID;
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
            if (calendar1.State == Calendar.CalendarState.DraggingTimeSelection)
            {

            }

            //TODO: Configure for adding an appointment on selection.
        }

        private void calendar1_DateChanged(object sender, CalendarItemEventArgs e)
        {
            string[] Text = e.Item.Text.Split('\n');
            doAction.editAppointment(e.Item.AppointmentID, e.Item.PatientFirstName, e.Item.PatientLastName, Text[2], e.Item.StartDate,
                e.Item.EndDate, e.Item.PatientID, e.Item.ProviderID);
        }



        private void calendar1_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null && thisPatientID == 0)
            {
                NewAppointment newAppointment = new NewAppointment(e.Item, thisProviderID, calendar1, this);
                newAppointment.Show();




            }

            if (Application.OpenForms["NewAppointmentFromPatientView"] as NewAppointmentFromPatientView == null && thisPatientID != 0)
            {
                NewAppointmentFromPatientView newAppointment = new NewAppointmentFromPatientView(thisPatientID, thisProviderID, e.Item, calendar1, _items, this);
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
     
        private void calendar1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Calendar.CalendarItem i = calendar1.ItemAt(calendar1.PointToClient(Cursor.Position));
            
            if (i == null)
            {
                toolTip1.Active = false;
                toolTip1.Hide(this);
            }
            else if (toolTip1.Active == false && calendar1.State != Calendar.CalendarState.DraggingItem && 
                calendar1.State != Calendar.CalendarState.ResizingItem)
            {
                toolTip1.Active = true;
                Point tooltipPosition = PointToClient(Cursor.Position);
                toolTip1.Show(i.Text, this, tooltipPosition);
            }
            
        }


        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                toolTip1.Hide(this);
            }
        }

        private void appointmentBox_LostFocus(object sender, EventArgs e)
        {
            //appointmentBox.Hide();
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
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, "Red", item.Pattern.ToString() , item.PatternColor.ToString());

            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Yellow);
                calendar1.Invalidate(item);
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, "Yellow", item.Pattern.ToString(), item.PatternColor.ToString());

            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, "Green" , item.Pattern.ToString(), item.PatternColor.ToString());

            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Blue);
                calendar1.Invalidate(item);
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, "Blue" ,  item.Pattern.ToString(), item.PatternColor.ToString());
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            if (Application.OpenForms["NewAppointment"] as NewAppointment == null && thisPatientID == 0)
            {
                NewAppointment newAppointment = new NewAppointment(true, selected, thisProviderID, calendar1, this);
                newAppointment.Show();

            }




        }

        private void ScheduledClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            doAction.updateAppointmentStatus("Scheduled", selected.AppointmentID, "Blue" , selected.Pattern.ToString(), selected.PatternColor.ToString());
            selected.BackgroundColor = Color.Blue;
            calendar1.Invalidate(selected);

        }

        private void CheckedInClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];

            doAction.updateAppointmentStatus("Checked In", selected.AppointmentID, "Yellow" , selected.Pattern.ToString(), selected.PatternColor.ToString());
            selected.BackgroundColor = Color.Yellow;
            calendar1.Invalidate(selected);


        }

        private void CompleteClick(object sender, EventArgs e)
        {
            List<CalendarItem> selectedItems = (List<CalendarItem>)calendar1.GetSelectedItems();
            CalendarItem selected = selectedItems[0];
            string checkedOut = "Complete at: " + DateTime.Now.ToString("HH:mm");
            doAction.updateAppointmentStatus(checkedOut, selected.AppointmentID, "Green" , selected.Pattern.ToString(), selected.PatternColor.ToString());
            selected.BackgroundColor = Color.Green;
            calendar1.Invalidate(selected);


        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            selectedAppointmentID = e.Item.AppointmentID;
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "ProviderMain" && Application.OpenForms[i].Name != "WelcomeHomePage")
                {
                    Application.OpenForms[i].Close();
                }
            }

            if (Application.OpenForms["PatientHomePage"] as PatientHomePage == null)
            {

                ISingleResult<getPatientByIDResult> result = doAction.getPatientByID(e.Item.PatientID);
                foreach (getPatientByIDResult r in result)
                {
                    string name = r.FirstName + " " + r.LastName;
                    PatientHomePage patientHomePage = new PatientHomePage(name, r.PhoneNumber, r.Gender,
                         r.MaritalStatus, r.Age, r.DOB, e.Item.PatientID, this.providerMain, this, e.Item)
                    {
                        MdiParent = providerMain
                    };
                    patientHomePage.Show();
                }




            }
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

                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, item.BackgroundColor.Name.ToString(), item.Pattern.ToString(), item.PatternColor.ToString());
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
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, item.BackgroundColor.Name.ToString(), item.Pattern.ToString(), item.PatternColor.ToString());

            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
                Console.WriteLine("Click");
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, item.BackgroundColor.Name.ToString(), item.Pattern.ToString(), item.PatternColor.ToString());
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, item.BackgroundColor.Name.ToString(), item.Pattern.ToString(), item.PatternColor.ToString());



            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Empty;
                calendar1.Invalidate(item);
                doAction.updateAppointmentStatus(item.Status, item.AppointmentID, item.BackgroundColor.Name.ToString(), item.Pattern.ToString(), item.PatternColor.ToString());

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



        private void ProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedProviderID = (String)ProviderComboBox.SelectedValue;
            _ = (String)ProviderComboBox.Text;
            if (!providerIDList.Contains(selectedProviderID))
            {
                providerIDList.Add(selectedProviderID);

                providerCalendarItems.Clear();

                ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(selectedProviderID);

                foreach (getAppointmentForCurrentProviderResult r in result)
                {

                    DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                    DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                    string patientName = r.FirstName + " " + r.LastName;
                    int patientID = r.patientID;



                    string itemText = patientName + "\n" + GetProviderName(selectedProviderID) + "\n" + r.Details;
                    CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, itemText, r.FirstName, r.LastName, r.appointmentID,
                        r.patientID, r.ProviderID, r.Status);

                    Color c = Color.FromName(r.Color);
                    cal.BackgroundColor = c;
                    if (r.Pattern != "None")
                    {
                        cal.Pattern = (System.Drawing.Drawing2D.HatchStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.HatchStyle), r.Pattern);
                        cal.PatternColor = Color.Red;

                    }
                    else
                    {
                        cal.PatternColor = Color.Empty;
                    }

                    providerCalendarItems.Add(cal);
                }

                PlaceItems(providerCalendarItems);
                _items = calendar1.Items;
                _items = calendar1.Items;
            }


            else
            {
                providerIDList.Remove(selectedProviderID);

                ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(selectedProviderID);

                List<CalendarItem> items = calendar1.Items;

                foreach (getAppointmentForCurrentProviderResult r in result)
                {
                    foreach (CalendarItem cal in items)
                    {
                        {
                            if (cal.AppointmentID == r.appointmentID)
                            {
                                calendar1.Items.Remove(cal);
                             
                            }
                        }
                    }



                }
                _items = calendar1.Items;


            }
            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        public virtual string Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {

        }

        private void calendar1_LoadItems_1(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems(_items);
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}