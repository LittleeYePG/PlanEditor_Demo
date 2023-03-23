using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
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
    public partial class clsVSetting : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Data.mstLineDB mstLineDB = new Data.mstLineDB();
        private List<Data.cResource> cResources = new List<Data.cResource>();
        private List<Data.cResource> Tempresources = new List<Data.cResource>();
        public List<Data.cResource> SetTempresources
        {
            set
            {
                Tempresources = value;
            }
        }

        private Data.mmstOTDB oTDB = new Data.mmstOTDB();
        public List<Data.mstOT> GetOTDB
        {
            get
            {
                return oTDB.GetMstOTs;
            }
        }
        public List<Data.mstOT> SetOTDB
        {
            set
            {
                oTDB.GetMstOTs = value;
            }
        }

        private int _lineID = 0;
        public int LineID
        {
            get
            {
                return _lineID;
            }
            set
            {
                _lineID = value;
            }
        }
        private string _lineCode = "";
        public string LineCode
        {
            get
            {
                return _lineCode;
            }
            set
            {
                _lineCode = value;
            }
        }
        private bool _Load = false;

        public clsVSetting()
        {
            InitializeComponent();
            schedulerControl.ActiveViewType = SchedulerViewType.FullWeek;
            _Load = true;
            schedulerControl.GanttView.WorkTime.Start = Funcion.clsCFunction.StartTime;
            schedulerControl.GanttView.WorkTime.End = Funcion.clsCFunction.EndTime;

            schedulerControl.FullWeekView.TimeScale = new TimeSpan(00,15,00);
            schedulerControl.FullWeekView.ShowAllDayArea = false;

            //MyCustomScale myScale = new MyCustomScale();
            //schedulerControl.WeekView.Scales.Add(myScale);
            //schedulerControl.WeekView.Scales.Last().Width = 100;
            //schedulerControl.WeekView.Scales.Last().Enabled = true;
            //TimeScaleCollection scales = schedulerControl.WeekView.Scales;

            //foreach (var s in scales.ToList())
            //{
            //    if (s.DisplayName == "Year"
            //        || s.DisplayName == "Quarter"
            //        || s.DisplayName == "Hour")
            //    {
            //        schedulerControl.GanttView.Scales.Remove(s);
            //    }
            //    else if (s.DisplayName == "Week")
            //    {
            //        var sv = schedulerControl.Views.GanttView.Scales.Where(w => w.DisplayName == s.DisplayName).FirstOrDefault();
            //        sv.Enabled = false;
            //    }
            //}


            Resources();
            addAppointment();
            _Load = false;
            schedulerControl.CustomDrawTimeCell += SchedulerControl_CustomDrawTimeCell;
            schedulerControl.EditAppointmentFormShowing += SchedulerControl_EditAppointmentFormShowing;
            schedulerControl.DataStorage.AppointmentChanging += DataStorage_AppointmentChanging;
            schedulerControl.DataStorage.AppointmentDeleting += DataStorage_AppointmentDeleting;
            schedulerControl.DataStorage.AppointmentsDeleted += DataStorage_AppointmentsDeleted;
            schedulerControl.DataStorage.AppointmentsInserted += DataStorage_AppointmentsInserted;
            schedulerControl.PopupMenuShowing += SchedulerControl_PopupMenuShowing;

            Tempresources = mstLineDB.GetResource_Demo(true);
            luLine.Properties.DataSource = Tempresources;
            luLine.Properties.DisplayMember = "LineName";
            luLine.Properties.ValueMember = "Id";
            LineID = (int?)Tempresources.Select(s => s.Id).First() ?? 0;
            LineCode = mstLineDB.getLineCode(LineID, Tempresources);
            luLine.EditValue = Tempresources.Select(s => s.Id).First();

            this.Load += (sender, e) =>
            {
                

                _Load = true;                
                addAppointment();
                addApp();
                _Load = false;
                
            };

            luLine.EditValueChanged += (sender, e) =>
            {
                LineID = (int?)luLine.EditValue ?? 0;
                LineCode = mstLineDB.getLineCode(LineID, Tempresources);
                addApp();
            };
        }

        

        private void SchedulerControl_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e)
        {
            SelectableIntervalViewInfo cell = e.ObjectInfo as SelectableIntervalViewInfo;
            TimeSpan startWorkHours = schedulerControl.GanttView.WorkTime.Start;
            TimeSpan endWorkHours = schedulerControl.GanttView.WorkTime.End;
            TimeSpan endWorkHoursOT = schedulerControl.GanttView.WorkTime.End;

            //if (cell.Interval.End.Date.Equals(DateTime.Today))
            //    endWorkHoursOT += TimeSpan.FromMinutes((double)Funcion.clsCFunction.GetOT);

            Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            using (var hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Funcion.FColor.StopTimeOT, Color.White))
            {
                if (!Funcion.clsCFunction.checkWorkTime(cell.Interval.Start, LineCode))
                {
                    e.Cache.FillRectangle(hatchBrush, rec);
                }
                else if((cell.Interval.Start.TimeOfDay < startWorkHours || cell.Interval.End.TimeOfDay > endWorkHoursOT) || cell.Interval.End.TimeOfDay.Hours == 0)
                {
                    e.Cache.FillRectangle(hatchBrush, rec);
                }
                else if (cell.Interval.End.TimeOfDay > endWorkHours)
                {
                  //  e.Cache.FillRectangle(ColorTranslator.FromHtml("#FF0000"), rec);
                }
                else
                {
                    e.Cache.FillRectangle(ColorTranslator.FromHtml("#FFFFFF"), rec);
                }

                if (cell.Selected)
                {
                    Brush myBrush = (cell.Selected) ? SystemBrushes.Highlight : SystemBrushes.Window;
                    e.Cache.FillRectangle(myBrush, cell.Bounds);
                }
                
            }
            e.Cache.DrawRectangle(e.Bounds, System.Drawing.Color.LightGray, 1);
            e.Handled = true;
        }
        private void SchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            FSetting.clsVEditOT form = new FSetting.clsVEditOT(scheduler, e.Appointment, e.OpenRecurrenceForm, cResources);
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

            
            


            var app = GetOTDB.Where(w => w.ID == Convert.ToInt32(apt.Id)).FirstOrDefault();
            if (app != null)
            {
                app.Date = apt.Start.Date;
                app.stTime = apt.Start.TimeOfDay;
                app.etTime = apt.End.TimeOfDay;
                app.Type = Convert.ToInt32(apt.CustomFields["Type"]);
                app.Remark = apt.CustomFields["Remark"] == null ? "" : apt.CustomFields["Remark"].ToString();
                app.LineID = LineID;
                app.LineCode = LineCode;
                if (app.Type == 1)
                {
                    app.OTTime = (app.etTime - app.stTime).TotalMinutes;
                }
                else
                {
                    app.OTTime = (app.etTime - app.stTime).TotalMinutes;
                }
                //app.OTTime = (app.etTime - app.stTime).TotalMinutes;
               // oTDB.GetMstOTs.Add(app);
               // apt.LabelId = app.Type;
                apt.Description = app.Remark;
            }
        }
        private void DataStorage_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            if (_Load) return;
            Appointment aptnew = (Appointment)e.Objects[0];
            var app = GetOTDB.Where(w => w.ID == Convert.ToInt32(aptnew.Id)).FirstOrDefault();
            if (app != null)
            {
                
            }
            else
            {
                app = new Data.mstOT();
                aptnew.SetId((GetOTDB.Max(m => (int?)m.ID) ?? 0) + 1);

                app.ID = Convert.ToInt32(aptnew.Id);
                app.Date = aptnew.Start.Date;
                app.stTime = aptnew.Start.TimeOfDay;
                app.etTime = aptnew.End.TimeOfDay;
                app.Type = (int)aptnew.CustomFields["Type"];
                app.Remark = aptnew.CustomFields["Remark"] == null ? "" : aptnew.CustomFields["Remark"].ToString();
                app.LineID = LineID;
                app.LineCode = LineCode;
                oTDB.GetMstOTs.Add(app);

                if (app.Type == 1)
                {
                    aptnew.Subject = "Stop";
                    app.OTTime = 0;
                }
                else
                {
                    aptnew.Subject = "OT";
                    app.OTTime = (app.etTime - app.stTime).TotalMinutes;
                }
                
                aptnew.Description = app.Remark;
                //aptnew.LabelId = app.Type;
                //aptnew.ResourceId = aptnew.LabelId;
            }
        }
        private void DataStorage_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            Appointment apt = (Appointment)e.Objects[0];
            var app = GetOTDB.Where(w => w.ID == Convert.ToInt32(apt.Id)).FirstOrDefault();
            if (app != null)
            {
                GetOTDB.Remove(app);
            }
        }
        private void DataStorage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.AppointmentDependencyCreation);
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


                //// Find the "New Appointment" menu item and rename it.
                //SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                //if (item != null) item.Caption = "&New Job";


                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = true;
                menuItem.Caption = "Add OT";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[0];
                menuItem.Click += ClickOT;
                e.Menu.Items.Add(menuItem);

                menuItem = new SchedulerMenuItem();
                menuItem.BeginGroup = false;
                menuItem.Caption = "Stop Time";
                menuItem.ImageOptions.SvgImage = svgImageCollection1[1];
                menuItem.Click += ClickStop;
                e.Menu.Items.Add(menuItem);

               
            }

        }

        private void ClickOT(object sender, EventArgs e)
        {
            MyClickOT();
        }

        private void ClickStop(object sender, EventArgs e)
        {
            MyClickStop();
        }

        private void Resources()
        {
            Data.cResource r = new Data.cResource();
            
            r = new Data.cResource();
            r.Id = 1;
            r.Caption = "Stop";
            cResources.Add(r);

            r = new Data.cResource();
            r.Id = 2;
            r.Caption = "OT";
            cResources.Add(r);
        }
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
               // storage.Appointments.Labels.Add(SchedulerColorId.NoneLabel, "None", "None");
                storage.Appointments.Labels.Add(Funcion.FColor.StopTime, "Stop");
                storage.Appointments.Labels.Add(Funcion.FColor.OTTime, "OT");

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
            ResourceMappingInfo mappings = storage.Resources.Mappings;
            mappings.Id = "Id";
            mappings.Caption = "Caption";
            mappings.ParentId = "ParentId";
            //mappings.Color = "Color";
            storage.Resources.DataSource = this.cResources;
            if (hideParentResource)
            {
                foreach (Resource resource in storage.Resources.Items)
                {
                    if (resource.ParentId.Equals(resource.Id))
                        continue;
                    storage.Resources.GetResourceById(resource.ParentId).Visible = false;
                }
            }
            //foreach (var r in resources)
            //{
            //    schedulerControl.DataStorage.Resources.Add(schedulerControl.DataStorage.CreateResource(r.Id));
            //    schedulerControl.DataStorage.Resources.GetResourceById(r.Id).Caption = r.Caption;
            //}
        }
        private void addApp()
        {
            int id = 0;
            schedulerControl.DataStorage.Appointments.Clear();
            LineID = (int?)luLine.EditValue ?? 0;
            LineCode = mstLineDB.getLineCode(LineID, Tempresources);
            foreach (var a in GetOTDB.Where(w=>w.LineID.Equals(LineID)))
            {
                id++;
                
                Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
                aptnew.Start = a.Date + a.stTime;
                aptnew.End = a.Date + a.etTime;
                aptnew.ResourceId = a.Type;
                aptnew.LabelId = a.Type-1;
                if (a.Type == 1)
                {
                    aptnew.Subject = "Stop";

                }
                else if (a.Type == 2)
                {
                    aptnew.Subject = "OT";
                }                
                aptnew.AllDay = false;
                aptnew.Description = a.Remark;
                aptnew.CustomFields["Type"] = a.Type;
                aptnew.SetId(id);
                
                schedulerControl.DataStorage.Appointments.Add(aptnew);
            }
            
        }

        private void barSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void barOT_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyClickOT();
        }

        private void barStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyClickStop();
        }

        private void MyClickOT()
        {
            LineID = (int?)luLine.EditValue ?? 0;
            LineCode = mstLineDB.getLineCode(LineID, Tempresources);

            if (schedulerControl.SelectedInterval.Start == null)
                return;

            if (Funcion.clsCFunction.checkWorkTime(schedulerControl.SelectedInterval.Start.AddSeconds(1), LineCode) ||
                Funcion.clsCFunction.checkWorkTime(schedulerControl.SelectedInterval.End.AddSeconds(-1), LineCode))
            {
                XtraMessageBox.Show("ไม่สามารถ สร้าง OT ในช่วงเวลาทำงานได้", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
            aptnew.Start = schedulerControl.SelectedInterval.Start;
            aptnew.End = schedulerControl.SelectedInterval.End;
            aptnew.ResourceId = schedulerControl.DataStorage.Resources[1].Id;
            aptnew.LabelId = 1;
            aptnew.Subject = "OT";
            aptnew.AllDay = false;
            aptnew.Description = "";
            aptnew.CustomFields["Type"] = 2;
            aptnew.Description = InputRemark();
            aptnew.CustomFields["Remark"] = aptnew.Description;
            schedulerControl.DataStorage.Appointments.Add(aptnew);
        }
        private void MyClickStop()
        {
            LineID = (int?)luLine.EditValue ?? 0;
            LineCode = mstLineDB.getLineCode(LineID, Tempresources);

            if (schedulerControl.SelectedInterval.Start == null)
                return;


            Appointment aptnew = schedulerControl.DataStorage.CreateAppointment(AppointmentType.Normal);
            aptnew.Start = schedulerControl.SelectedInterval.Start;
            aptnew.End = schedulerControl.SelectedInterval.End;
            aptnew.ResourceId = schedulerControl.DataStorage.Resources[0].Id;
            aptnew.LabelId = 0;
            aptnew.Subject = "Stop";
            aptnew.AllDay = false;
            aptnew.Description = "";
            aptnew.CustomFields["Type"] = 1;
            aptnew.Description = InputRemark();
            aptnew.CustomFields["Remark"] = aptnew.Description;
            schedulerControl.DataStorage.Appointments.Add(aptnew);
        }
        private string InputRemark()
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Input";
            args.Prompt = "Remark";
            args.DefaultButtonIndex = 0;
            args.Showing += Args_Showing;

            TextEdit editor = new TextEdit();
            editor.Text = "";
            editor.Properties.NullText = "";
            args.Editor = editor;
            var result = XtraInputBox.Show(args);
            if (result == null)
                return "";
            else
            return result.ToString();
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Icon = this.Icon;
        }
    }
}