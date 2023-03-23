using DevExpress.Schedule;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraSplashScreen;
using PlanEditor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEditor
{
    public partial class clsVPlan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Splash
        IOverlaySplashScreenHandle ShowProgressPanel()
        {
            return SplashScreenManager.ShowOverlayForm(this);
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle)
        {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }
        void ReloadData()
        {
            using (var handle = SplashScreenManager.ShowOverlayForm(this))
            {
                handle.QueueFocus(IntPtr.Zero);
            }
        }
        #endregion
        #region Properties
        private int aSize = 10;
        mstCalendarDB calendarDB = new Data.mstCalendarDB();
        private List<Data.cResource> resources = new List<Data.cResource>();
        Data.mstLineDB mstLineDB = new Data.mstLineDB();
        List<Data.EventData> events = new List<Data.EventData>();
        List<Data.cMRPCapacity> cMRPs = new List<Data.cMRPCapacity>();
        List<Data.cMRPCapacity> Capacities = new List<Data.cMRPCapacity>();

        List<Data.cMRPCapacity> calMRPs = new List<Data.cMRPCapacity>();
        List<Data.cMRPCapacity> calCapacities = new List<Data.cMRPCapacity>();
        Funcion.clsCPlan cls = new Funcion.clsCPlan();
        //Data.mmstOTDB GetOTDB = new Data.mmstOTDB();
        #endregion

        public clsVPlan()
        {
            InitializeComponent();
            gDetail.Width = 0;
            barServer.Caption = "Database : "+ Funcion.clsCFunction.getDataSource + " => " +Funcion.clsCFunction.getDataBaseName;
            barVersion.Caption = Funcion.clsCFunction.version;

            dtpDateFr.EditValue = System.DateTime.Today.AddDays(-2);
            dtpDateTo.EditValue = System.DateTime.Today.AddDays(7);
            //Funcion.TimeCellGenerateDB.GenerateWorkTime();

            #region setschedulerControl
            schedulerControl.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl.DayView.Enabled = false;
            schedulerControl.GanttView.ResourcesPerPage = 10;
            schedulerControl.GanttView.ShowResourceHeaders = false;
            schedulerControl.GanttView.NavigationButtonVisibility = NavigationButtonVisibility.Never;
            schedulerControl.Views.GanttView.Scales[4].Width = 200;
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            schedulerControl.LimitInterval.Start = dtpDateFr.DateTime;
            schedulerControl.LimitInterval.End = dtpDateTo.DateTime.AddDays(1);
            schedulerControl.GanttView.CellsAutoHeightOptions.Enabled = true;
            schedulerControl.GanttView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Never;
            schedulerControl.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.BarProgress;
            schedulerControl.CustomDrawTimeCell += SchedulerControl_CustomDrawTimeCell;
            schedulerControl.MouseDoubleClick += SchedulerControl_MouseDoubleClick;
            #endregion
            #region EVen Form
            this.Load += (sender, e) =>
            {
                schedulerControl.GanttView.AppointmentDisplayOptions.AppointmentHeight = aSize;
            };
            this.ResizeEnd += (sender, e) =>
            {
                schedulerControl.GanttView.AppointmentDisplayOptions.AppointmentHeight = aSize;
            };
            lblX.Click += (sender, e) =>
            {
                gDetail.Width = 0;
            };
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            #endregion
            #region EvenAppointment
            schedulerControl.MouseClick += SchedulerControl_MouseClick;
            schedulerControl.AppointmentFlyoutShowing += SchedulerControl_AppointmentFlyoutShowing;
            schedulerControl.SelectionChanged += SchedulerControl_SelectionChanged;
            schedulerControl.PopupMenuShowing += SchedulerControl_PopupMenuShowing;
            #endregion

            //Funcion.clsCFunction.GenerateHolidays(schedulerControl, dtpDateFr.DateTime.AddMonths(-6), dtpDateFr.DateTime.AddMonths(6),1);
            resources = mstLineDB.GetResource_Demo();
            addAppointment();

            cardView1.CustomDrawCardCaption += (sender, e) =>
            {
                CardView cardView = (CardView)sender;
                var txt = cardView.GetRowCellDisplayText(e.RowHandle, "ItemCode");
                int r = e.RowHandle + 1;
                e.CardCaption = "Row No "+ r;
            };

            schedulerControl.CustomDrawDayHeader += (sender, e) =>
            {
                // Check whether the current object is a Day Header.
                SchedulerHeader header = e.ObjectInfo as SchedulerHeader;
                if (header != null)
                {

                    // Check whether the current date is a known holiday.
                    //Holiday hol = FindHoliday(header.Interval.Start.Date);
                    //if (Funcion.clsCFunction.FindHoliday(header.Interval.Start.Date))
                    //{
                    //    // Add the holiday name to the day header's caption.
                    //    header.Caption = String.Format("{0} ({1})", "Holiday",
                    //        header.Caption);
                    //}
                }
            };
        }
        // This method finds a holiday for the specified date.
        

        private void SchedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            SchedulerMenuItem menuItem = new SchedulerMenuItem();
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.AppointmentDependencyCreation);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.DeleteAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.OpenAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.EditSeries);

                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = true;
                menuItem.Caption = "Show InFo";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[0];
                menuItem.Click += ClickInFo;
                e.Menu.Items.Add(menuItem);
            }
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu)
            {

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAppointment);

                // Hide the "New Recurring Event" menu item.
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent);

                // Enable the "Go To Today" menu item.
                e.Menu.EnableMenuItem(SchedulerMenuItemId.GotoToday);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.ChangeTimelineScaleWidthUI);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.CustomizeCurrentView);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.TimeScaleVisible);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.TimeScaleEnable);


                //// Find the "New Appointment" menu item and rename it.
                //SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                //if (item != null) item.Caption = "&New Job";


                //menuItem = new SchedulerMenuItem();
                //menuItem.BeginGroup = true;
                //menuItem.Caption = "Add OT";
                //menuItem.ImageOptions.SvgImage = svgImageCollection1[0];
                //menuItem.Click += ClickOT;
                //e.Menu.Items.Add(menuItem);

                //menuItem = new SchedulerMenuItem();
                //menuItem.BeginGroup = false;
                //menuItem.Caption = "Stop Time";
                //menuItem.ImageOptions.SvgImage = svgImageCollection1[1];
                //menuItem.Click += ClickStop;
                //e.Menu.Items.Add(menuItem);
            }

        }

        private void ClickInFo(object sender, EventArgs e)
        {
            ShowInfo();
        }


        #region EvenForm
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F12")
            {
                if (gDetail.Width == 0 && schedulerControl.SelectedAppointments.Count > 0)
                {
                    gDetail.Width = 415;
                }
                else
                {
                    gDetail.Width = 0;
                }
            }
        }
        #endregion
        #region Appointment
        private void addAppointment()
        {
            SchedulerDataStorage storage = (SchedulerDataStorage)schedulerControl.DataStorage;
            schedulerControl.BeginUpdate();
            try
            {
                storage.Appointments.ResourceSharing = true;
                storage.DateTimeSavingMode = DateTimeSavingMode.Storage;

                storage.Appointments.Labels.Clear();
                storage.Appointments.Labels.Add(SchedulerColorId.NoneLabel, "None", "None");
                //storage.Appointments.Labels.Add(SchedulerColorId.PersonalLabel, "Green Category", "Green Category");
                storage.Appointments.Labels.Add(ColorTranslator.FromHtml("#5880C8"), "Blue");
                storage.Appointments.Labels.Add(ColorTranslator.FromHtml("#F09252"), "Brow");
                storage.Appointments.Labels.Add(ColorTranslator.FromHtml("#2F528F"), "BackBlue");
                storage.Appointments.Labels.Add(ColorTranslator.FromHtml("#E96B15"), "BackBrow");

                storage.Appointments.CustomFieldMappings.Clear();

                PrepareResourceStorage(storage, true);
                PrepareAppointmentStorage(storage);
                schedulerControl.InitNewAppointment += (o, e) => { if (((SchedulerControl)o).GroupType == SchedulerGroupType.None) e.Appointment.ResourceId = 1; };

            }
            finally
            {
                schedulerControl.EndUpdate();
            }

        }
        private void PrepareResourceStorage(ISchedulerStorage storage, bool hideParentResource)
        {
            //ResourceMappingInfo mappings = storage.Resources.Mappings;
            //mappings.Id = "Id";
            //mappings.Caption = "Caption";
            //mappings.ParentId = "ParentId";
            ////mappings.Color = "Color";
            //storage.Resources.DataSource = this.resources;
            //if (hideParentResource)
            //{
            //    foreach (Resource resource in storage.Resources.Items)
            //    {
            //        if (resource.ParentId.Equals(resource.Id))
            //            continue;
            //        storage.Resources.GetResourceById(resource.ParentId).Visible = false;
            //    }
            //}
            foreach (var r in resources)
            {
                schedulerControl.DataStorage.Resources.Add(schedulerControl.DataStorage.CreateResource(r.Id));
                schedulerControl.DataStorage.Resources.GetResourceById(r.Id).Caption = r.Caption;
                schedulerControl.DataStorage.Resources.GetResourceById(r.Id).CustomFields["ID"] = r.Id;
            }
        }
        void PrepareAppointmentStorage(ISchedulerStorage storage)
        {
            AppointmentMappingInfo mappings = storage.Appointments.Mappings;
            mappings.AppointmentId = "Id";
            mappings.Start = "StartDate";
            mappings.End = "EndDate";
            mappings.AllDay = "AllDay";
            mappings.Subject = "Subject";
            mappings.Description = "Description";
            mappings.Location = "Location";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.Type = "EventType";
            mappings.ResourceId = "CalendarIds";
            mappings.Label = "LabelId";
            mappings.Status = "StatusId";
            mappings.PercentComplete = "PercentComplete";
            //schedulerDataStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("MyID", "MyID"));

            //storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Priority", "Priority"));
            //storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("IsPrivate", "IsPrivate"));
            storage.Appointments.DataSource = this.events;
        }
        void AddEvent(DateTime startDate, DateTime endDate, string subject, string description, bool allDay, string resourceIds, int eventType, string location, int labelId, int statusId, double PercentComplete, int ID)
        {
            Data.EventData result = new Data.EventData();
            result.StartDate = startDate;
            result.EndDate = endDate;
            result.Subject = PercentComplete.ToString("0.0") + " %";
            result.Description = "AAA";// description;
            result.AllDay = allDay;
            result.CalendarIds = resourceIds;
            result.EventType = eventType;
            result.Location = location;
            result.LabelId = labelId;
            result.StatusId = statusId;
            if (PercentComplete <= 100)
            {
                result.PercentComplete = 50;// PercentComplete;                
            }
            else
            {
                result.PercentComplete = 100;
                result.StatusId = 3;
                if (labelId == 1)
                    result.LabelId = 3;
                else
                    result.LabelId = 4;
            }
            result.Id = ID;
            events.Add(result);
        }
        private void addApp()
        {
            int id = 0;
            gDetail.Width = 0;
            schedulerControl.DataStorage.Appointments.Clear();
            foreach (var a in cMRPs)
            {
                id++;
                //AddEvent(a.MDate, a.MDate + TimeSpan.FromTicks(864000000000)
                //    , ""
                //    , "", true
                //    , "<ResourceIds>\r\n<ResourceId Type=\"System.Int32\" Value=\"" + a.ResourceID + "\" />\r\n<ResourceId Type=\"System.Int32\" Value=\"" + a.ResourceID + "\" />\r\n</ResourceIds>"// " < ResourceIds >\r\n < ResourceId Type =\"System.String\" Value=\" " + a.LineCode + "\" />\r\n</ResourceIds>"
                //    , 0, "", a.LabelID, 0, (double)a.MRPCapacity, id);

                Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
                aptnew.Start = a.MDate;
                aptnew.End = a.MDate + TimeSpan.FromTicks(864000000000);
                aptnew.ResourceId = a.ResourceID;
                aptnew.LabelId = 1;
                aptnew.Subject = a.MRPCapacity.ToString("0.0") + " %";
                aptnew.AllDay = true;
                aptnew.SetId(id);
                if (a.MRPCapacity <= 100)
                {
                    aptnew.PercentComplete = (int)a.MRPCapacity;// PercentComplete;                
                }
                else
                {
                    aptnew.PercentComplete = 100;
                    aptnew.StatusId = 3;
                    if (aptnew.LabelId == 1)
                        aptnew.LabelId = 3;
                    else
                        aptnew.LabelId = 4;
                }

                schedulerControl.DataStorage.Appointments.Add(aptnew);
            }
            foreach (var a in calMRPs)
            {
                id++;
                
                Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
                aptnew.Start = a.MDate;
                aptnew.End = a.MDate + TimeSpan.FromTicks(864000000000);
                aptnew.ResourceId = a.ResourceID;
                aptnew.LabelId = a.LabelID;
                aptnew.Subject = a.MRPCapacity.ToString("0.0") + " %";
                aptnew.AllDay = true;
                aptnew.SetId(id);
                if (a.MRPCapacity <= 100)
                {
                    aptnew.PercentComplete = (int)a.MRPCapacity;// PercentComplete;                
                }
                else
                {
                    aptnew.PercentComplete = 100;
                    aptnew.StatusId = 3;
                    if (aptnew.LabelId == 1)
                        aptnew.LabelId = 3;
                    else
                        aptnew.LabelId = 4;
                }

                schedulerControl.DataStorage.Appointments.Add(aptnew);
            }
        }
        #endregion
        #region EvenAppointment
        private void SchedulerControl_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e)
        {
            SelectableIntervalViewInfo cell = e.ObjectInfo as SelectableIntervalViewInfo;
            //SchedulerControl scheduler = sender as SchedulerControl;
            Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            using (var hatchBrush = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.LightYellow, Color.DodgerBlue))
                e.Cache.FillRectangle(hatchBrush, rec);
            //if (calendarDB.HolidayFlag(1, cell.Interval.Start) == 1)
            //{
            //    e.Cache.FillRectangle(Funcion.FColor.HoliDay, rec);
            //}
            //else
            //{                
            if (Funcion.clsCFunction.OTDB.GetOTTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])) > 0 &&
                Funcion.clsCFunction.OTDB.GetStopTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])))
            {
                e.Cache.FillRectangle(Funcion.FColor.StopTimeOT, rec);
            }
            else if (Funcion.clsCFunction.OTDB.GetOTTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])) > 0)
            {
                e.Cache.FillRectangle(Funcion.FColor.OTTime, rec);
            }
            else if (Funcion.clsCFunction.OTDB.GetStopTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])))
            {
                e.Cache.FillRectangle(Funcion.FColor.StopTime, rec);
            }
            else if (Funcion.clsCFunction.FindHoliday(cell.Interval.Start.Date))//(calendarDB.HolidayFlag(1, cell.Interval.Start) == 1)
            {
                e.Cache.FillRectangle(Funcion.FColor.HoliDay, rec);
            }
            else if (cell.Resource.Caption != "")
            {
                e.Cache.FillRectangle(Funcion.FColor.LineMRP, rec);
            }
            else
            {
                e.Cache.FillRectangle(Funcion.FColor.LineSimulator, rec);
            }
            //}

            e.Cache.DrawRectangle(e.Bounds, System.Drawing.Color.LightGray, 1);
            aSize = e.Bounds.Height - 4;
            e.Handled = true;
        }
        private void SchedulerControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Point pos = new Point(e.X, e.Y);
            //SchedulerViewInfoBase viewInfo = schedulerControl.ActiveView.ViewInfo;
            //SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);

            //if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent)
            //{
            //    #region Head

            //    #endregion
            //    var DataList = Capacities.Union(calCapacities).ToList();

            //    var app = ((DevExpress.XtraScheduler.Drawing.AppointmentViewInfo)hitInfo.ViewInfo).Appointment;
            //    var data = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId)).FirstOrDefault();


            //    lblLine.Text = resources.Where(w => w.Id == Convert.ToInt32(hitInfo.ViewInfo.Resource.Id)).Select(s => s.LineName).FirstOrDefault();
            //    lblPlanDate.Text = hitInfo.ViewInfo.Interval.Start.ToString("dd/MM/yyyy");

            //    var DaysTime = Funcion.clsCFunction.WorkHours;

            //    //var Capacity = data.MRPCapacity;
            //    var Capacity = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId) && w.MDate.Equals(hitInfo.ViewInfo.Interval.Start)).Sum(s => s.TotalWorkTime);
            //    lblWorktime.Text = Capacity.ToString("#,##0") + " / " + DaysTime.ToString("#,##0");
            //    lblWorktime1.Text = "( " + Funcion.clsCFunction.InfoWorkingTime((int)Capacity) + " / " + Funcion.clsCFunction.InfoWorkingTime((int)DaysTime) + " )";

            //    Capacity = (Capacity * 100) / (decimal)DaysTime;
            //    if (Capacity == 0)
            //    {
            //        lblCapacityV.Text = "(Nomal)";
            //        //lblCapacityV.Width = 100;
            //        lblGreen.Width = 0;
            //        lblRed.Width = 0;
            //    }
            //    else if (Capacity > 100)
            //    {
            //        lblCapacityV.Text = app.Subject + " (Over)";
            //        //lblCapacityV.Width = 100;
            //        lblGreen.Width = 100;
            //        if (Capacity < 200)
            //        {
            //            lblRed.Width = (int)((decimal)(2.6) * (Capacity - 100));
            //        }
            //        else
            //        {
            //            lblRed.Width = 260;
            //        }

            //    }
            //    else
            //    {
            //        lblCapacityV.Text = app.Subject + " (Normal)";
            //        //lblCapacityV.Width = 100;
            //        lblGreen.Width = (int)((decimal)(2.6) * Capacity);
            //        lblRed.Width = 0;
            //    }
            //    #region Gride
            //    gridControl1.DataSource = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId) && w.MDate.Equals(hitInfo.ViewInfo.Interval.Start)).ToList();
            //    #endregion
            //    gDetail.Width = 415;
            //}
        }
        private void SchedulerControl_MouseClick(object sender, MouseEventArgs e)
        {

            SchedulerControl scheduler = sender as SchedulerControl;
            if (scheduler == null) return;

            Point pos = new Point(e.X, e.Y);
            SchedulerViewInfoBase viewInfo = schedulerControl.ActiveView.ViewInfo;
            SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);

            if (hitInfo.HitTest == SchedulerHitTest.Cell)
            {

                cDate = hitInfo.ViewInfo.Interval.Start;
                cLineCode = Convert.ToInt32( hitInfo.ViewInfo.Resource.Id);

                //    var DataList = Capacities.Union(calCapacities).ToList();

                //var app = ((DevExpress.XtraScheduler.Drawing.AppointmentViewInfo)hitInfo.ViewInfo).Appointment;
                //var data = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId)).FirstOrDefault();


                //    lblLine.Text = resources.Where(w => w.Id == Convert.ToInt32(hitInfo.ViewInfo.Resource.Id)).Select(s => s.LineName).FirstOrDefault();
                //    lblPlanDate.Text = hitInfo.ViewInfo.Interval.Start.ToString("dd/MM/yyyy");

                //    var DaysTime = Funcion.clsCFunction.WorkHours;

                //    //var Capacity = data.MRPCapacity;
                //    var Capacity = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId) && w.MDate.Equals(hitInfo.ViewInfo.Interval.Start)).Sum(s => s.TotalWorkTime);
                //    lblWorktime.Text = Capacity.ToString("#,##0") + " / " + DaysTime.ToString("#,##0");
                //    lblWorktime1.Text = "( " + Funcion.clsCFunction.InfoWorkingTime((int)Capacity) + " / " + Funcion.clsCFunction.InfoWorkingTime((int)DaysTime) + " )";

                //    Capacity = (Capacity * 100) / (decimal)DaysTime;
                //    if (Capacity == 0)
                //    {
                //        lblCapacityV.Text = "(Nomal)";
                //        //lblCapacityV.Width = 100;
                //        lblGreen.Width = 0;
                //        lblRed.Width = 0;
                //    }
                //    else if (Capacity > 100)
                //    {
                //        lblCapacityV.Text = app.Subject + " (Over)";
                //        //lblCapacityV.Width = 100;
                //        lblGreen.Width = 100;
                //        if (Capacity < 200)
                //        {
                //            lblRed.Width = (int)((decimal)(2.6) * (Capacity - 100));
                //        }
                //        else
                //        {
                //            lblRed.Width = 260;
                //        }

                //    }
                //    else
                //    {
                //        lblCapacityV.Text = app.Subject + " (Normal)";
                //        //lblCapacityV.Width = 100;
                //        lblGreen.Width = (int)((decimal)(2.6) * Capacity);
                //        lblRed.Width = 0;
                //    }





                //    #region Gride
                //    gridControl1.DataSource = DataList.Where(w => w.ResourceID == Convert.ToInt32(app.ResourceId) && w.MDate.Equals(hitInfo.ViewInfo.Interval.Start)).ToList();
                //    #endregion
                //    //gDetail.Visible = true;
            }
        }
        private void SchedulerControl_AppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e)
        {
            e.Control = new clsUFlyoutPlan(e,resources, Capacities.Union(calCapacities).ToList());
        }
        private void SchedulerControl_SelectionChanged(object sender, EventArgs e)
        {
            SchedulerControl scheduler = sender as SchedulerControl;
            if (scheduler == null) return;

            if (schedulerControl.SelectedAppointments.Count <= 0) return;
            Appointment Apt = schedulerControl.SelectedAppointments[0];

            var DataList = Capacities.Union(calCapacities).ToList();

            lblLine.Text = resources.Where(w => w.Id == Convert.ToInt32(Apt.ResourceId)).Select(s => s.LineName).FirstOrDefault();
            lblPlanDate.Text = Apt.Start.ToString("dd/MM/yyyy");

            var Linecode = resources.Where(w => w.Id == Convert.ToInt32(Apt.ResourceId)).Select(s => s.LineCode).FirstOrDefault();
            var DaysTime = Funcion.clsCFunction.GetmstWorkTime_Minutes(Apt.Start.Date,Linecode);

            //var Capacity = data.MRPCapacity;
            var Capacity = DataList.Where(w => w.ResourceID == Convert.ToInt32(Apt.ResourceId) && w.MDate.Equals(Apt.Start)).Sum(s => s.TotalWorkTime);
            lblWorktime.Text = Capacity.ToString("#,##0") + " / " + DaysTime.ToString("#,##0");
            lblWorktime1.Text = "( " + Funcion.clsCFunction.InfoWorkingTime((int)Capacity) + " / " + Funcion.clsCFunction.InfoWorkingTime((int)DaysTime) + " )";

            Capacity = (Capacity * 100) / (decimal)DaysTime;
            if (Capacity == 0)
            {
                lblCapacityV.Text = "(Nomal)";
                //lblCapacityV.Width = 100;
                lblGreen.Width = 0;
                lblRed.Width = 0;
            }
            else if (Capacity > 100)
            {
                lblCapacityV.Text = Apt.Subject + " (Over)";
                //lblCapacityV.Width = 100;
                lblGreen.Width = 260;
                if (Capacity < 200)
                {
                    lblRed.Width = (int)((decimal)(2.6) * (Capacity - 100));
                }
                else
                {
                    lblRed.Width = 260;
                }

            }
            else
            {
                lblCapacityV.Text = Apt.Subject + " (Normal)";
                //lblCapacityV.Width = 100;
                lblGreen.Width = (int)((decimal)(2.6) * Capacity);
                lblRed.Width = 0;
            }

            #region Gride
            gridControl1.DataSource = DataList.Where(w => w.ResourceID == Convert.ToInt32(Apt.ResourceId) && w.MDate.Equals(Apt.Start)).ToList();
            #endregion

        }
        #endregion
        #region Detail
        private void lblX_Click(object sender, EventArgs e)
        {
            gDetail.Width = 0;
        }
        #endregion
        #region Toolbar
        private void btnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            IOverlaySplashScreenHandle handle = null;
            try
            {
                handle = ShowProgressPanel();
                ReloadData();

                calCapacities.Clear();
                calMRPs.Clear();
                Capacities = cls.GetCMRPCapacities(dtpDateFr.DateTime.Date, dtpDateTo.DateTime.Date, resources);
                cMRPs = cls.calCMRPPercen(Capacities);

                addApp();

                schedulerControl.LimitInterval.Start = dtpDateFr.DateTime;
                schedulerControl.LimitInterval.End = dtpDateTo.DateTime.AddDays(1);
               // addAppointment();
            }
            finally
            {
                CloseProgressPanel(handle);
            }
        }

        private void btnCalculate_ItemClick(object sender, ItemClickEventArgs e)
        {
            IOverlaySplashScreenHandle handle = null;
            try
            {
                handle = ShowProgressPanel();
                ReloadData();

                calCapacities = cls.calCMRP(Capacities, resources);
                if (calCapacities.Count > 0)
                {
                    calMRPs = cls.calCMRPPercen(calCapacities);
                    addApp();

                    // dtpDateFr.EditValue = calMRPs.Select(s => s.MDate).DefaultIfEmpty(dtpDateFr.DateTime).Min();
                    //dtpDateTo.EditValue = cMRPs.Select(s => s.MDate).DefaultIfEmpty(dtpDateTo.DateTime).Max();

                    DateTime sdate = calMRPs.OrderBy(o => o.MDate).Select(s => s.MDate).FirstOrDefault();
                    if (sdate < dtpDateFr.DateTime)
                    {
                        dtpDateFr.DateTime = sdate;
                        schedulerControl.LimitInterval.Start = dtpDateFr.DateTime;
                        schedulerControl.LimitInterval.End = dtpDateTo.DateTime.AddDays(1);
                        schedulerControl.Refresh();
                    }
                }
            }
            finally
            {
                CloseProgressPanel(handle);
            }
            
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DataList = calCapacities.ToList();
            //clsVPlanDetail detail = new clsVPlanDetail(dtpDateFr.DateTime, dtpDateTo.DateTime, calCapacities);
            clsVPlanEdit detail = new clsVPlanEdit(dtpDateFr.DateTime, dtpDateTo.DateTime, calCapacities);
            detail.WindowState = FormWindowState.Maximized;
            detail.StartPosition = FormStartPosition.CenterScreen;
            if (detail.ShowDialog() == DialogResult.OK)
            {
                IOverlaySplashScreenHandle handle = null;
                try
                {
                    handle = ShowProgressPanel();
                    ReloadData();
                    
                    calCapacities = detail.GetMRPCapacities;
                    calMRPs = cls.calCMRPPercen(calCapacities);
                    addApp();
                }
                finally
                {
                    CloseProgressPanel(handle);
                }
            }
            else
            {
                calCapacities = DataList;
            }
            detail.Dispose();
        }

        private void bntInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowInfo();
        }

        private void bntSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (clsVSetting frm = new clsVSetting())
            {
                Data.mmstOTDB OTDB = new Data.mmstOTDB();
                foreach (var r in Funcion.clsCFunction.OTDB.GetMstOTs)
                {
                    OTDB.GetMstOTs.Add(r);
                }
                frm.SetOTDB = OTDB.GetMstOTs;
                frm.LineID = cLineCode;
                frm.LineCode = mstLineDB.getLineCode(cLineCode, resources);
                frm.SetTempresources = resources;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Funcion.clsCFunction.OTDB.GetMstOTs = frm.GetOTDB;
                    schedulerControl.Refresh();
                }
            }
        }

        private void btnLineWorkTime_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FSetting.clsVLineWorkTime frm = new FSetting.clsVLineWorkTime())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    schedulerControl.Refresh();
                }
            }
        }
        private void btnReLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            reLoad();
        }
        private void ShowInfo()
        {
            if (schedulerControl.SelectedAppointments.Count > 0)
                gDetail.Width = 415;
        }
        #endregion
        #region SetOT
        private DateTime cDate = new DateTime();
        private int cLineCode =0;


        #endregion

        
        private void reLoad()
        {
            IOverlaySplashScreenHandle handle = null;
            try
            {
                handle = ShowProgressPanel();
                ReloadData();
                //Funcion.TimeCellGenerateDB.TimeCells = null;
                //Funcion.TimeCellGenerateDB.GenerateWorkTime();
                Funcion.clsCFunction.WorkTimes = null;
                calCapacities.Clear();
                calMRPs.Clear();

                schedulerControl.DataStorage.Appointments.Clear();
                schedulerControl.LimitInterval.Start = dtpDateFr.DateTime;
                schedulerControl.LimitInterval.End = dtpDateTo.DateTime;
                schedulerControl.Refresh();
            }
            finally
            {
                CloseProgressPanel(handle);
            }
        }
    }
}