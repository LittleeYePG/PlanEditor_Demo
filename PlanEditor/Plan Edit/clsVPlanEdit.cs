using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
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
    public partial class clsVPlanEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Data.mstLineDB mstLineDB = new Data.mstLineDB();
        private DateTime _dtpDateFr;
        private DateTime _dtpDateTo;
        private List<Data.cMRPCapacity> CMRPs = new List<Data.cMRPCapacity>();
        private List<Data.cResource> resources = new List<Data.cResource>();
        private List<Data.cResource> resourcesAll = new List<Data.cResource>();
        private int rndCount = 0;
        mstCalendarDB calendarDB = new Data.mstCalendarDB();
        clsVShowInfomation fm;
        private bool _Load = false;
        bool _Merge = false;
        public List<Data.cMRPCapacity> GetMRPCapacities
        {
            get
            {
                return CMRPs;
            }
        }
        public List<Data.cMRPCapacity> SetMRPCapacities
        {
            set
            {
                CMRPs = value;
            }
        }
        public Data.cMRPCapacity AddMRPCapacities
        {
            set
            {
                CMRPs.Add(value);
            }
        }
        public bool UpdateCMRPs(int ID,decimal Qty,double TimeWork)
        {
            try
            {
                var app = CMRPs.Where(w => w.ID == ID).FirstOrDefault();
                if (app != null)
                {                    
                    app.PlanQty += Qty;
                    app.EndPlanDate = app.EndPlanDate.AddMinutes(TimeWork);
                    app.TotalWorkTime += Convert.ToDecimal(TimeWork);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public clsVPlanEdit(DateTime dtpDateFr, DateTime dtpDateTo, List<Data.cMRPCapacity> cMRPCapacities)
        {
            InitializeComponent();
            _Load = true;
            gDetail.Width = 0;
            lblToolTip.Visible = false;

            _dtpDateFr = dtpDateFr;
            _dtpDateTo = dtpDateTo;

            CMRPs = cMRPCapacities;
            rndCount = CMRPs.Count*2;

            

            #region setschedulerControl
            schedulerControl.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl.GroupType = SchedulerGroupType.Resource;
            schedulerControl.DayView.Enabled = false;

            schedulerControl.LimitInterval.Start = dtpDateFr;
            schedulerControl.LimitInterval.End = dtpDateTo;
            schedulerControl.GanttView.WorkTime.Start = Funcion.clsCFunction.GetStartTime;
            schedulerControl.GanttView.WorkTime.End = Funcion.clsCFunction.GetEndTime;

            schedulerControl.OptionsCustomization.AllowAppointmentMultiSelect = false;
            schedulerControl.GanttView.ShowResourceHeaders = false;
            schedulerControl.GanttView.NavigationButtonVisibility = NavigationButtonVisibility.Never;
            schedulerControl.Views.GanttView.Scales[4].Enabled = true;
            schedulerControl.Views.GanttView.Scales[4].Width = 200;
            schedulerControl.Views.GanttView.Scales[5].Enabled = true;
            schedulerControl.Views.GanttView.Scales[5].DisplayFormat = "HH";
            schedulerControl.Views.GanttView.Scales[5].Width = 50;
            schedulerControl.Views.GanttView.Scales[6].Enabled = true;
            schedulerControl.Views.GanttView.Scales[6].DisplayFormat = "mm";
            schedulerControl.Views.GanttView.Scales[6].Width = 30;
            schedulerControl.GanttView.ResourcesPerPage = 8;
            schedulerControl.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.BarProgress;
            schedulerControl.GanttView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Never;
            schedulerControl.GanttView.AppointmentDisplayOptions.AppointmentHeight = 30;

            schedulerControl.GanttView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Always;
            schedulerControl.GanttView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Always;
            schedulerControl.GanttView.AppointmentDisplayOptions.TimeDisplayType = AppointmentTimeDisplayType.Text;

            schedulerControl.OptionsView.ResourceHeaders.RotateCaption = false;
            schedulerControl.OptionsCustomization.AllowAppointmentMultiSelect = false;
            schedulerControl.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.Custom;
            
            #endregion

            #region EvenschedulerControl
            MyCustomScale myScale = new MyCustomScale();
            schedulerControl.GanttView.Scales.Add(myScale);
            schedulerControl.GanttView.Scales.Last().Width = 100;
            schedulerControl.GanttView.Scales.Last().Enabled = true;
            TimeScaleCollection scales = schedulerControl.GanttView.Scales;

            foreach (var s in scales.ToList())
            {
                if (s.DisplayName == "Year"
                    || s.DisplayName == "Quarter"
                    || s.DisplayName == "Hour")
                {
                    schedulerControl.GanttView.Scales.Remove(s);
                }
                else if (s.DisplayName == "Week")
                {
                    var sv = schedulerControl.Views.GanttView.Scales.Where(w => w.DisplayName == s.DisplayName).FirstOrDefault();
                    sv.Enabled = false;
                }
            }

            

            schedulerControl.AppointmentDrop += SchedulerControl_AppointmentDrop;
            schedulerControl.AppointmentFlyoutShowing += SchedulerControl_AppointmentFlyoutShowing;
            schedulerControl.EditAppointmentFormShowing += SchedulerControl_EditAppointmentFormShowing;
            schedulerControl.DataStorage.AppointmentChanging += DataStorage_AppointmentChanging;
            schedulerControl.DataStorage.AppointmentDeleting += DataStorage_AppointmentDeleting;
            schedulerControl.DataStorage.AppointmentsDeleted += DataStorage_AppointmentsDeleted;
            schedulerControl.DataStorage.AppointmentsInserted += DataStorage_AppointmentsInserted;
            schedulerControl.MouseClick += SchedulerControl_MouseClick;
            schedulerControl.SelectionChanged += SchedulerControl_SelectionChanged;
            schedulerControl.MouseMove += SchedulerControl_MouseMove;
            schedulerControl.PopupMenuShowing += SchedulerControl_PopupMenuShowing;
            resourcesTree1.MouseWheel += ResourcesTree1_MouseWheel;
            #endregion

            resources = mstLineDB.GetResource_Demo(true);
            addAppointment();

            schedulerControl.CustomDrawTimeCell += (sender, e) =>
            {
                SelectableIntervalViewInfo cell = e.ObjectInfo as SelectableIntervalViewInfo;
                TimeSpan startWorkHours = Funcion.clsCFunction.OTDB.GetMinTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])); //schedulerControl.GanttView.WorkTime.Start;
                TimeSpan endWorkHours = Funcion.clsCFunction.OTDB.GetMaxTime(cell.Interval.Start.Date, Convert.ToInt32(cell.Resource.CustomFields["ID"])); ;
                //TimeSpan endWorkHoursOT = schedulerControl.GanttView.WorkTime.End;

                //if (cell.Interval.End.Date.Equals(DateTime.Today))
                //endWorkHoursOT += TimeSpan.FromMinutes((double)Funcion.clsCFunction.GetOT);

                //if (cell.Interval.Start.TimeOfDay.Hours == 18)
                //{
                //    startWorkHours = startWorkHours;
                //}
                Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

                var LineCode = mstLineDB.getLineCode(Convert.ToInt32(cell.Resource.CustomFields["ID"]), resources);
                if (LineCode == null)
                {
                    if (cell.Interval.Start.Day % 2 == 0)
                    {
                        e.Cache.FillRectangle(Funcion.FColor.LineMRP, rec);
                    }
                    else
                    {
                        e.Cache.FillRectangle(Funcion.FColor.LineSimulator, rec);
                    }
                }
                else
                {                    
                    using (var hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Funcion.FColor.StopTimeOT, Color.White))
                    {

                        if ((cell.Interval.Start.TimeOfDay < startWorkHours || cell.Interval.End.TimeOfDay > endWorkHours)) //|| cell.Interval.End.TimeOfDay.Hours == 0
                        {
                            e.Cache.FillRectangle(hatchBrush, rec);
                        }
                        else if (!Funcion.clsCFunction.checkWorkTime(cell.Interval.Start, LineCode))
                        {
                            if (Funcion.clsCFunction.FindHoliday(cell.Interval.Start.Date))
                            {
                                // e.Cache.FillRectangle(Funcion.FColor.HoliDay, rec);
                                using (var hatchBrush1 = new HatchBrush(HatchStyle.DiagonalCross, Funcion.FColor.HoliDay, Color.White))
                                {
                                    e.Cache.FillRectangle(hatchBrush1, rec);
                                }
                            }
                            else
                                e.Cache.FillRectangle(hatchBrush, rec);
                        }
                        else if (Funcion.clsCFunction.OTDB.checkTimeOT(cell.Interval.Start, Convert.ToInt32(cell.Resource.CustomFields["ID"])))
                        {
                            e.Cache.FillRectangle(Funcion.FColor.OTTime, rec);
                        }
                        else if (Funcion.clsCFunction.OTDB.checkStopTime(cell.Interval.Start, Convert.ToInt32(cell.Resource.CustomFields["ID"])))
                        {
                            //using (var hatchBrush1 = new HatchBrush(HatchStyle.DiagonalCross, Color.White, Funcion.FColor.StopTime))
                            //{
                            //    //      e.Cache.FillRectangle(hatchBrush1, rec);
                            //}
                            e.Cache.FillRectangle(ColorTranslator.FromHtml("#FADBD8"), rec);
                        }
                        else
                        {
                            //e.Cache.FillRectangle(ColorTranslator.FromHtml("#FFFFFF"), rec);
                            e.DrawDefault();
                        }
                    }
                }
                //if (startWorkHours.Hours == cell.Interval.Start.Hour && cell.Interval.Start.Minute == 0)
                //{
                //    e.Cache.DrawRectangle(e.Bounds, System.Drawing.Color.Red, 1);
                //}
                //else
                //{
                    e.Cache.DrawRectangle(e.Bounds, System.Drawing.Color.LightGray, 1);
                //}
                
                
                e.Handled = true;
            };
            schedulerControl.CustomDrawDayHeader += (sender, e) =>
            {
                //DayHeader header = e.ObjectInfo as DayHeader;
                //// Draws the outer rectangle.
                //using (var backBrush = new LinearGradientBrush(e.Bounds,
                //        Color.LightBlue, Color.Blue, LinearGradientMode.Vertical))
                //    e.Cache.FillRectangle(backBrush, e.Bounds);
                //Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
                //// Draws the inner rectangle.
                //using (var backBrush = new LinearGradientBrush(e.Bounds,
                //        Color.Blue, Color.LightSkyBlue, LinearGradientMode.Vertical))
                //    e.Cache.FillRectangle(backBrush, innerRect);
                //// Draws the header's caption.
                //e.Cache.DrawString(header.Caption, header.Appearance.HeaderCaption.Font,
                //    Brushes.White, innerRect,
                //    header.Appearance.HeaderCaption.GetStringFormat());
                //e.Handled = true;
            };
            bntSave.ItemClick += BntSave_ItemClick;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            lblX.Click += (sender, e) =>
            {
                gDetail.Width = 0;
            };

            this.Load += (sender, e) =>
            {               
                _Load = false;
            };
            
        }

        #region FormEven
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F12")
            {
                
            }
            //else if (e.Modifiers == Keys.Shift)
            //{
                
            //}
            else if (e.KeyCode == Keys.Escape)
            {
                cSplin();
            }
            //else if (e.KeyCode.ToString() == "F11")
            //{
                
            //}
        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void bntInfo_ItemClick(object sender, ItemClickEventArgs e)
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
        #endregion
        #region BarEven
        private void BntSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void bntInfoScreen_ItemClick(object sender, ItemClickEventArgs e)
        {
            setInfoScreen();
        }
        private void setInfoScreen()
        {
            if (schedulerControl.SelectedAppointments.Count <= 0) return;
            if (fm == null || fm.Text == "")
            {
                fm = new clsVShowInfomation();
                fm.Show();
            }

            setInfo();
        }
        private void setInfo()
        {
            if (schedulerControl.SelectedAppointments.Count <= 0) return;

            Appointment Apt = schedulerControl.SelectedAppointments[0];

            lblSDate.Text = Apt.Start.ToString("dd/MM/yyyy HH:mm");
            lblEndDate.Text = Apt.End.ToString("dd/MM/yyyy HH:mm");
            lblSub.Text = Apt.Subject;
            int ID = (int)Apt.ResourceId;
            lblLine.Text = resources.Where(w => w.Id == ID).Select(s => s.Caption).FirstOrDefault();
            lblItemCode.Text = (string)Apt.CustomFields["ItemCode"];
            lblName.Text = (string)Apt.CustomFields["ItemName"];
            lblQty.Text = Convert.ToDouble(Apt.CustomFields["Qty"]).ToString("#,##0.00");
            lblRemark.Text = (string)Apt.CustomFields["Remark"];

            if (fm != null && fm.Text != "")
            {
                if (CheckOpened(fm.Text))
                {
                    fm.WindowState = FormWindowState.Normal;
                    fm.LineName = lblLine.Text;
                    fm.Start = lblSDate.Text;
                    fm.End = lblEndDate.Text;
                    fm.ItemCode = lblItemCode.Text;
                    fm.ItemName = lblName.Text;
                    fm.Qty = lblQty.Text;
                    fm.Remark = lblRemark.Text;
                    fm.Show();
                    fm.Focus();
                    fm.BringToFront();

                }
            }

        }
        private void bntMerge_ItemClick(object sender, ItemClickEventArgs e)
        {
            Merge();
        }
        private void Merge()
        {
            if (fmMerge == null || fmMerge.Text == "")
            {
                fmMerge = new clsVMerge(this);
                fmMerge.Show();
            }
            else if (fmMerge != null && fmMerge.Text != "")
            {
                if (CheckOpened(fmMerge.Text))
                {
                    fmMerge.WindowState = FormWindowState.Normal;
                    fmMerge.Show();
                    fmMerge.Focus();
                    fmMerge.BringToFront();

                }
            }
        }
        private void bntSeparate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Separate();
        }
        private void Separate()
        {
            schedulerControl.Cursor = new Cursor(Properties.Resources.open_door_128.Handle);
            _KeyDouw = true;
            schedulerControl.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
        }
        #endregion


        #region EvenschedulerControl
        private void updateMRP(Appointment apt)
        {
            var app = CMRPs.Where(w => w.ID == Convert.ToInt32(apt.Id)).FirstOrDefault();
            if (app != null)
            {
                app.StartPlanDate = apt.Start;
                app.EndPlanDate = apt.End;
                app.ResourceID = (int)apt.ResourceId;
                app.MDate = apt.Start.Date;
                app.PlanQty = Convert.ToDecimal(apt.CustomFields["Qty"]);
                app.TotalWorkTime = (decimal)(apt.End - apt.Start).TotalMinutes;
                app.LineCode = resources.Where(w => w.Id == (int)apt.ResourceId).Select(s => s.LineCode).FirstOrDefault();
            }
        }
        private void SchedulerControl_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            if (e.EditedAppointment.ResourceId == e.SourceAppointment.ResourceId)
            {
                e.Allow = true;
                updateMRP(e.EditedAppointment);
            }
            else if (!mstLineDB.CheckLine((string)e.SourceAppointment.CustomFields["ItemCode"], (int)e.EditedAppointment.ResourceId,resources))
            {
                MessageBox.Show("Not Move Line");
                e.Allow = false;
            }
            else
            {
                e.EditedAppointment.End = e.EditedAppointment.Start.AddMinutes(
                    mstLineDB.getWorkTime((string)e.SourceAppointment.CustomFields["ItemCode"], (int)e.EditedAppointment.ResourceId, resources) * Convert.ToDouble(e.EditedAppointment.CustomFields["Qty"])
                    ); ;
                e.Allow = true;
                updateMRP(e.EditedAppointment);
            }
            this.BeginInvoke(new MethodInvoker(Relocate));
        }
        public void Relocate()
        {
            Appointment AptChanged = schedulerControl.SelectedAppointments[0];

            List<Appointment> lstChangedApts = new List<Appointment>(); //List of changed appointmens
            lstChangedApts.Add(AptChanged);

            while (lstChangedApts.Count > 0) //Exists at least one appointment moved
            {
                AptChanged = lstChangedApts[0];
                schedulerControl.DataStorage.BeginUpdate();

                foreach (Appointment apt in schedulerControl.DataStorage.Appointments.Items) //Cicles to find overlapped appointments
                {
                    if (Convert.ToDouble(apt.ResourceId) == Convert.ToDouble(AptChanged.ResourceId) && apt.Subject != AptChanged.Subject) //Is the same resource and other apointment?
                    {
                        if ((new TimeInterval(apt.Start, apt.End)).IntersectsWith(new TimeInterval(AptChanged.Start, AptChanged.End)) && !(apt.Start == AptChanged.End || apt.End == AptChanged.Start)) //Overlapping?
                        {
                            if (AptChanged.Start.Ticks < apt.Start.AddTicks(Convert.ToInt64((new TimeInterval(apt.Start, apt.End)).Duration.Ticks / 2.0)).Ticks) //Moves After or before?
                            {
                                apt.Start = AptChanged.End; //Moves the found overlapped before
                                lstChangedApts.Add(apt); //Adds the last moved to the changed list
                            }
                            else
                            {
                                AptChanged.Start = apt.End; //Moves the changed Appointent
                                lstChangedApts.Add(AptChanged); //Adds the last moved to the changed list
                            }
                        }
                    }
                }
                lstChangedApts.Remove(AptChanged); //After relocate the appointment, removes from the changed list
                schedulerControl.DataStorage.EndUpdate();
            }
            lstChangedApts.Clear();
        }
        private void SchedulerControl_AppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e)
        {
            e.Control = new clsUFlyout(e);
        }
        private void SchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            clsVEdit form = new clsVEdit(scheduler, e.Appointment, e.OpenRecurrenceForm, resources, false);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }
        private void DataStorage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = (Appointment)e.Object;
            var app = CMRPs.Where(w => w.ID == Convert.ToInt32(apt.Id)).FirstOrDefault();
            if (app != null)
            {
                app.StartPlanDate = apt.Start;
                app.EndPlanDate = apt.End;
                //app.ResourceID = (int)apt.ResourceId;
                app.MDate = apt.Start.Date;
                app.PlanQty = Convert.ToDecimal( apt.CustomFields["Qty"]);
                app.TotalWorkTime = (decimal)(apt.End - apt.Start).TotalMinutes;
            }
        }
        private void DataStorage_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            if (_Load) return;
           Appointment aptnew = (Appointment)e.Objects[0];
            var app = CMRPs.Where(w => w.ID == Convert.ToInt32(aptnew.Id)).FirstOrDefault();
            if (app != null)
            {
                app.StartPlanDate = aptnew.Start;
                app.EndPlanDate = aptnew.End;
                //app.ResourceID = (int)apt.ResourceId;
                app.MDate = aptnew.Start.Date;
                app.PlanQty = Convert.ToDecimal(aptnew.CustomFields["Qty"]);
                app.TimeWork = (aptnew.End - aptnew.Start).TotalMinutes;
            }
            else
            {
                app = new Data.cMRPCapacity();
                aptnew.SetId(CMRPs.Max(m => m.ID) + 1);

                app.ID = Convert.ToInt32(aptnew.Id);
                app.LineCode = resources.Where(w => w.Id == (int)aptnew.ResourceId).Select(s => s.LineCode).FirstOrDefault(); 
                app.TimeWork = Convert.ToDouble(aptnew.CustomFields["TimeWork"]);
                app.MDate = aptnew.Start.Date;
                app.ItemCode = (string)aptnew.CustomFields["ItemCode"];
                app.ItemName = (string)aptnew.CustomFields["ItemName"];
               // app.TypeCode = old.TypeCode;
                app.OrderProdNo = app.ItemName;
                app.PlanQty = Convert.ToDecimal(aptnew.CustomFields["Qty"]);
                app.LabelID = 2;
                app.MDate_Ref = aptnew.Start.Date;
                app.RemainCalQty = app.PlanQty;
                app.ResourceID = (int)aptnew.ResourceId;
                app.TotalWorkTime = Convert.ToDecimal((aptnew.End - aptnew.Start).TotalMinutes);
                app.StartPlanDate = aptnew.Start;
                app.EndPlanDate = aptnew.End;
                

                aptnew.CustomFields["Remark"] = string.Format(@"New Itemcode {0} Date {1} ", app.ItemCode, app.MDate);
                app.Remark = (string)aptnew.CustomFields["Remark"];
                CMRPs.Add(app);
            }
        }
        private void SchedulerControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (schedulerControl.SelectedAppointments.Count <= 0) return;

            Appointment Apt = schedulerControl.SelectedAppointments[0];
            bool control = Control.ModifierKeys == Keys.Shift;
            if (_KeyDouw)
            {
                Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
                fmSplit = new clsVSplit(Apt, aptnew, sQty1, sQty2,resources);
                try
                {
                    if (fmSplit.ShowDialog() == DialogResult.OK)
                    {
                        //Apt = fmSplit.AptChanged;
                        //
                        //aptnew = fmSplit.AptChangedNew;

                        aptnew.SetId(CMRPs.Max(m => m.ID)+1);
                        aptnew.LabelId = Convert.ToInt32(aptnew.Id);
                        var old = CMRPs.Where(w => w.ID == Convert.ToInt32 (Apt.Id)).FirstOrDefault();

                        Data.cMRPCapacity capacity = new Data.cMRPCapacity();
                        capacity.ID = Convert.ToInt32(aptnew.Id);
                        capacity.LineCode = old.LineCode;
                        capacity.TimeWork = Convert.ToDouble( aptnew.CustomFields["TimeWork"]);
                        capacity.MDate = old.MDate;
                        capacity.ItemCode = old.ItemCode;
                        capacity.ItemName = old.ItemName;
                        capacity.TypeCode = old.TypeCode;
                        capacity.OrderProdNo = old.OrderProdNo;
                        capacity.PlanQty = Convert.ToDecimal(aptnew.CustomFields["Qty"]);
                        capacity.LineCode = old.LineCode;
                        capacity.LabelID = 2;
                        capacity.MDate_Ref = old.MDate;
                        capacity.RemainCalQty = capacity.PlanQty;
                        capacity.ResourceID = old.ResourceID;
                        capacity.TotalWorkTime = Convert.ToDecimal( (aptnew.End - aptnew.Start).TotalMinutes);
                        old.TotalWorkTime = Convert.ToDecimal((Apt.End - Apt.Start).TotalMinutes);
                        old.TimeWork = capacity.TimeWork;
                        capacity.StartPlanDate = aptnew.Start;
                        capacity.EndPlanDate = aptnew.End;

                        aptnew.CustomFields["Remark"] = string.Format(@"Splin Itemcode {0} Date {1} ",capacity.ItemCode,capacity.MDate);
                        capacity.Remark = (string)aptnew.CustomFields["Remark"];
                        CMRPs.Add(capacity);

                        schedulerControl.DataStorage.Appointments.Add(aptnew);
                        schedulerControl.ActiveView.SelectAppointment(aptnew);
                        //schedulerControl.DataStorage.Appointments.Add(Apt);

                    }

                    cSplin();
                }
                finally
                {
                    fmSplit.Dispose();
                }
            }
        }
        private void SchedulerControl_SelectionChanged(object sender, EventArgs e)
        {
            SchedulerControl scheduler = sender as SchedulerControl;
            if (scheduler == null) return;

            if (schedulerControl.SelectedAppointments.Count <= 0) return;

            setInfo();
        }
        private void SchedulerControl_MouseMove(object sender, MouseEventArgs e)
        {
            SchedulerControl scheduler = sender as SchedulerControl;
            if (scheduler == null) return;
            if (_KeyDouw == false)
            {
                lblToolTip.Visible = false;
                sQty1 = 0;
                sQty2 = 0;
                return;
            }

            Point pos = new Point(e.X, e.Y);
            SchedulerViewInfoBase viewInfo = schedulerControl.ActiveView.ViewInfo;
            SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);
            if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent)
            {
                Appointment apt = ((AppointmentViewInfo)hitInfo.ViewInfo).Appointment;
                int diff = pos.X - hitInfo.ViewInfo.Bounds.X;



                long ticksPerPixel = hitInfo.ViewInfo.Interval.Duration.Ticks /
              hitInfo.ViewInfo.Bounds.Width;
                long ticksCount = ticksPerPixel * diff;
                DateTime actualTime = hitInfo.ViewInfo.Interval.Start.AddTicks(ticksCount);

                var iMW = actualTime - apt.Start;
                int iH = iMW.Hours * 60;
                int iM = iH + iMW.Minutes;
                int iDiff = (int)((iM / Convert.ToDouble(apt.CustomFields["TimeWork"])) + 0.5);
                int iDiff1 = (int)(Convert.ToDouble(apt.CustomFields["Qty"]) - iDiff);

                sQty1 = iDiff;
                sQty2 = iDiff1;

                pos.X = Cursor.Position.X - 30;
                pos.Y = Cursor.Position.Y - 20;
                lblToolTip.Location = pos;

                lblToolTip.Text = apt.Subject + " " + iDiff + " / " + iDiff1;
                lblToolTip.Visible = true;
            }
            else
            {
                lblToolTip.Visible = false;
                sQty1 = 0;
                sQty2 = 0;
            }
        }
        private void ResourcesTree1_MouseWheel(object sender, MouseEventArgs e)
        {
            var index = resourcesTree1.TopVisibleNodeIndex;
            bool control = Control.ModifierKeys == Keys.Control;
            if (e.Delta > 0 && control)
            {
                schedulerControl.GanttView.ResourcesPerPage += 1;
            }
            else if (e.Delta < 0 && control)
            {
                if (schedulerControl.GanttView.ResourcesPerPage - 1 > 0)
                {
                    schedulerControl.GanttView.ResourcesPerPage -= 1;
                }
            }
            if (control)
                BeginInvoke(new Action(() => {
                    resourcesTree1.TopVisibleNodeIndex = index;
                }));
        }
        private void DataStorage_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            Appointment apt = (Appointment)e.Objects[0];
            var app = CMRPs.Where(w => w.ID == Convert.ToInt32(apt.Id)).FirstOrDefault();
            if (app != null)
            {
                CMRPs.Remove(app);
            }
        }
        private void DataStorage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            if (_Merge) return;
            if (XtraMessageBox.Show("Do you want Delete?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void SchedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            SchedulerMenuItem menuItem = new SchedulerMenuItem();
            cSplin();
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.AppointmentDependencyCreation);

                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = true;
                menuItem.Caption = "Show Infomation";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[2];
                menuItem.Click += MyClickInfo;
                e.Menu.Items.Add(menuItem);

                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = false;
                menuItem.Caption = "Show Screen Infomation";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[3];
                menuItem.Click += MyClickInfoScreen;
                e.Menu.Items.Add(menuItem);
            }
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu)
            {
                // Hide the "Change View To" menu item.
                //SchedulerPopupMenu itemChangeViewTo = e.Menu.GetPopupMenuById(SchedulerMenuItemId.SwitchViewMenu);
                //itemChangeViewTo.Visible = false;

                // Disable the "New Recurring Appointment" menu item.
                //e.Menu.DisableMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);

                // Hide the "New Recurring Event" menu item.
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent);

                // Enable the "Go To Today" menu item.
                e.Menu.EnableMenuItem(SchedulerMenuItemId.GotoToday);

                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.ChangeTimelineScaleWidthUI);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.CustomizeCurrentView);


                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                if (item != null) item.Caption = "&New Job";

                
                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = true;
                menuItem.Caption = "Separate";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[0];                
                menuItem.Click += MyClickSeparate;
                e.Menu.Items.Add(menuItem);

                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = false;
                menuItem.Caption = "Merge";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[1];
                menuItem.Click += MyClickMerge;
                e.Menu.Items.Add(menuItem);

                //e.Menu.Items.Add(new SchedulerMenuItem("Separate", MyClickSeparate));
                //e.Menu.Items.Add(new SchedulerMenuItem("Merge", MyClickMerge ));
            }

        }

        private void MyClickInfoScreen(object sender, EventArgs e)
        {
            setInfoScreen();
        }

        private void MyClickInfo(object sender, EventArgs e)
        {
            if (gDetail.Width == 0 && schedulerControl.SelectedAppointments.Count > 0)
            {
                gDetail.Width = 415;
            }
            else
            {
                gDetail.Width = 0;
            }
            setInfo();
        }

        private void MyClickMerge(object sender, EventArgs e)
        {
            Merge();
        }

        public void MyClickSeparate(object sender, EventArgs e)
        {
            Separate();
        }
        #endregion

        #region Appointment
        private void addAppointment()
        {
            SchedulerDataStorage storage = (SchedulerDataStorage)schedulerControl.DataStorage;
            schedulerControl.BeginUpdate();
            try
            {
               // schedulerControl.BeginInit();
                storage.Appointments.ResourceSharing = true;
                storage.DateTimeSavingMode = DateTimeSavingMode.Storage;

                storage.Appointments.Labels.Clear();
                storage.Appointments.Labels.Add(SchedulerColorId.NoneLabel, "None", "None");

                Random rnd = new Random();
                for (int i = 0; i < rndCount; i++)
                {
                    storage.Appointments.Labels.Add(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), "C" + i);
                }
                storage.Appointments.CustomFieldMappings.Clear();

                PrepareResourceStorage(storage, true);
                addApp();
                schedulerControl.InitNewAppointment += (o, e) => { if (((SchedulerControl)o).GroupType == SchedulerGroupType.None) e.Appointment.ResourceId = 1; };
               // schedulerControl.EndInit();
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
        private void addApp()
        {
            int id = 0;
            gDetail.Width = 0;
            schedulerControl.DataStorage.Appointments.Clear();
            foreach (var a in CMRPs)
            {
                id++;
                Random rnd = new Random();
                Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
                aptnew.Start = a.StartPlanDate;
                aptnew.End = a.EndPlanDate;
                aptnew.ResourceId = a.ResourceID;
                aptnew.LabelId = id;
                aptnew.Subject = a.ItemCode;
                aptnew.Description = a.OrderProdNo;
                aptnew.AllDay = false;

                aptnew.CustomFields["ItemCode"] = a.ItemCode;
                aptnew.CustomFields["ItemName"] = a.ItemName;
                aptnew.CustomFields["Qty"] = a.PlanQty;
                aptnew.CustomFields["TimeWork"] = a.TimeWork;
                aptnew.CustomFields["Remark"] = a.Remark;
                aptnew.SetId(id);
                a.ID = id;

                schedulerControl.DataStorage.Appointments.Add(aptnew);
            }

        }
        #endregion

        #region Splin
        clsVSplit fmSplit = null;
        private bool _readOnly = false;
        private bool _KeyDouw = false;
        private int sQty1 = 0;
        private int sQty2 = 0;
        private void cSplin()
        {
            lblToolTip.Visible = false;
            sQty1 = 0;
            sQty2 = 0;
            _KeyDouw = false;
            schedulerControl.Cursor = Cursors.Default;
            schedulerControl.OptionsCustomization.AllowDisplayAppointmentFlyout = true;
        }

        #endregion

        #region Merge
        clsVMerge fmMerge = null;
        private Appointment GetAppointment(int ID)
        {
            foreach (Appointment apt in schedulerControl.DataStorage.Appointments.Items)
            {
                if (Convert.ToInt32(apt.Id) == ID)
                {
                    return apt;
                }
            }

            return null;
        }
        public bool MergeApt(int IDMain,int IDMerge)
        {
            try
            {
                Appointment MainApt = GetAppointment(IDMain);
                Appointment MergeApt = GetAppointment(IDMerge);

                if (MainApt != null && MergeApt != null)
                {
                    var app = CMRPs.Where(w => w.ID == Convert.ToInt32(MainApt.Id)).FirstOrDefault();
                    if (app != null)
                    {
                        MainApt.CustomFields["Qty"] = Convert.ToDecimal(MainApt.CustomFields["Qty"]) + Convert.ToDecimal(MergeApt.CustomFields["Qty"]);
                        MainApt.End = MainApt.End.AddMinutes((MergeApt.End - MergeApt.Start).TotalMinutes);
                        MainApt.CustomFields["TimeWork"] = ((MainApt.End - MainApt.Start).TotalMinutes / Convert.ToDouble(MainApt.CustomFields["Qty"]));
                        app.PlanQty = Convert.ToDecimal(MainApt.CustomFields["Qty"]);
                        app.EndPlanDate = app.EndPlanDate.AddMinutes((MergeApt.End - MergeApt.Start).TotalMinutes);
                        app.TimeWork = ((app.EndPlanDate - app.StartPlanDate).TotalMinutes) / Convert.ToDouble(app.PlanQty);
                        app.TotalWorkTime = (decimal)(app.EndPlanDate - app.StartPlanDate).TotalMinutes;
                        //MainApt.End = app.EndPlanDate;
                        //MainApt.CustomFields["Qty"] = app.PlanQty;
                        _Merge = true;
                        schedulerControl.DeleteAppointment(MergeApt);
                        _Merge = false;
                    }
                }
                else
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        private void bntShowHoliday_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Funcion.clsCFunction.ShowHoliday = bntShowHoliday.Checked;
            schedulerControl.Refresh();
        }
    }
}