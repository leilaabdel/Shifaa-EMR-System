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
        List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;
        private readonly SiteFunctionsDataContext doAction = new SiteFunctionsDataContext(@"Data Source=shifaaserver.database.windows.net;Initial Catalog=EMRDatabase;Persist Security Info=True;User ID=shifaaAdmin;Password=qalbeefeemasr194!");
        string thisProviderID = null;
        int thisPatientID = 0;
        int selectedAppointmentID = 0;
        ProviderMain providerMain;

        SchedulerMain schedulerMain;
        public SchedulingCalendar(string providerID , ProviderMain providerMain)
        {
            InitializeComponent();
            this.thisProviderID = providerID;


            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            //Initialize only double clicking for physicians
            this.calendar1.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);

            this.providerMain = providerMain ?? new ProviderMain(thisProviderID , thisProviderID);

            calendar1.SetViewRange(this.providerMain.GetDateSelection()[0], providerMain.GetDateSelection()[providerMain.GetDateSelection().Count - 1]); ;

        }

        public SchedulingCalendar(string providerID , SchedulerMain schedulerMain)
        {
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            this.schedulerMain = schedulerMain ?? new SchedulerMain();

            calendar1.SetViewRange(this.schedulerMain.GetDateSelection()[0], schedulerMain.GetDateSelection()[schedulerMain.GetDateSelection().Count - 1]); ;
        }

        public SchedulingCalendar(int patientID)
        {
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            thisPatientID = patientID;
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {

            if (thisPatientID == 0)
            {

                ISingleResult<getAppointmentForCurrentProviderResult> result = doAction.getAppointmentForCurrentProvider(thisProviderID);

                foreach (getAppointmentForCurrentProviderResult r in result)
                {

                    DateTime startDateTime = r.StartDateTime ?? DateTime.Now;
                    DateTime endDateTime = r.EndDateTime ?? DateTime.Now;

                    string patientName = r.FirstName + " " + r.LastName;
                    int patientID = r.patientID;
                    CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, r.Details, patientName, r.appointmentID, r.patientID, r.ProviderID);


                    _items.Add(cal);
                }

                PlaceItems();
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
                    CalendarItem cal = new CalendarItem(calendar1, startDateTime, endDateTime, r.Details, patientName, r.appointmentID, r.patientID, r.ProviderID);


                    _items.Add(cal);
                }

                PlaceItems();

            }
            
        }

        public int GetAppointmentID()
        {
            return selectedAppointmentID;
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            if (Application.OpenForms["NewAppointment"] as NewAppointment == null && thisPatientID == 0)
            {
                NewAppointment newAppointment = new NewAppointment(e.Item, thisProviderID);
                e.Item.Text = newAppointment.GetFirstName() + " " + newAppointment.GetLastName() + "\n" +
                    newAppointment.GetProviderName() + ":\n" +  newAppointment.GetAppointmentDetails();

                ISingleResult<getJustCreatedAppointmentIDResult> result = doAction.getJustCreatedAppointmentID();
                
                foreach (getJustCreatedAppointmentIDResult r in result)
                {
                    e.Item.AppointmentID = r.appointmentID;
                }

                _items.Add(e.Item);
            }

            if (Application.OpenForms["NewAppointmentFromPatientView"] as NewAppointmentFromPatientView == null && thisPatientID != 0)
            {
                NewAppointment newAppointment = new NewAppointment(e.Item, thisProviderID);
                e.Item.Text = newAppointment.GetFirstName() + " " + newAppointment.GetLastName() + "\n" +
                    newAppointment.GetProviderName() + ":\n" + newAppointment.GetAppointmentDetails();

                ISingleResult<getJustCreatedAppointmentIDResult> result = doAction.getJustCreatedAppointmentID();

                foreach (getJustCreatedAppointmentIDResult r in result)
                {
                    e.Item.AppointmentID = r.appointmentID;
                }

                _items.Add(e.Item);
            }






        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
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
            calendar1.ActivateEditMode();
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

            doAction.deleteAppointment(e.Item.AppointmentID);
            _items.Remove(e.Item);

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
    }
}