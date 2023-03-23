using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.UI;
using PlanEditor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEditor.FSetting
{
    public partial class clsVEditOT : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Fields
        bool openRecurrenceForm;
        private bool _ReadOnly;
        readonly ISchedulerStorage storage;
        readonly SchedulerControl control;
        readonly AppointmentFormController controller;
        IDXMenuManager menuManager;
        bool supressCancelCore;
        private mstItemDB mstItemDB = new Data.mstItemDB();
        private Data.mstLineDB mstLineDB = new Data.mstLineDB();
        #endregion
        #region Properties
        [Browsable(false)]
        public IDXMenuManager MenuManager { get { return this.menuManager; } private set { this.menuManager = value; } }
        protected internal AppointmentFormController Controller { get { return this.controller; } }
        protected internal SchedulerControl Control { get { return this.control; } }
        protected internal ISchedulerStorage Storage { get { return this.storage; } }
        protected internal bool IsNewAppointment { get { return this.controller != null ? this.controller.IsNewAppointment : true; } }

        protected internal bool OpenRecurrenceForm { get { return this.openRecurrenceForm; } }
        [DXDescription("DevExpress.XtraScheduler.UI.AppointmentRibbonForm,ReadOnly")]
        [DXCategory(CategoryName.Behavior)]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return Controller.ReadOnly; }
            set
            {
                if (Controller.ReadOnly == value)
                    return;
                Controller.ReadOnly = value;
            }
        }
        protected override FormShowMode ShowMode { get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; } }
        internal Point FormLocation { get; private set; }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public clsVEditOT()
        {
            InitializeComponent();
        }
        public clsVEditOT(DevExpress.XtraScheduler.SchedulerControl control, Appointment apt, bool openRecurrenceForm, List<Data.cResource> cResources)
        {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage");
            Guard.ArgumentNotNull(apt, "apt");
            this.openRecurrenceForm = openRecurrenceForm;
            this.controller = CreateController(control, apt);
            InitializeComponent();

            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            //this.FormShadow.Opacity = 120;

            this.control = control;
            this.storage = control.DataStorage;
            this.edtLabel.Storage = this.storage;

            edtResources.Properties.DataSource = cResources;
            edtResources.Properties.DisplayMember = "Caption";
            edtResources.Properties.ValueMember = "Id";

            SubscribeControlsEvents();
            BindControllerToControls();
        }
        protected virtual AppointmentFormController CreateController(SchedulerControl control, Appointment apt)
        {
            return new AppointmentFormController(control, apt);
        }
        private void BindControllerToControls()
        {
            BindProperties(this.edtStartDate, "EditValue", "DisplayStartDate");
            BindProperties(this.edtStartDate, "Enabled", "IsDateTimeEditable");
            BindProperties(this.edtStartTime, "EditValue", "DisplayStartTime");
            BindProperties(this.edtStartTime, "Enabled", "IsTimeEnabled");
            BindProperties(this.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Enabled", "IsTimeEnabled", DataSourceUpdateMode.Never);

            BindProperties(this.txtRemark, "Enabled", "Description");
            //BindProperties(this.tbItemCode, "EditValue", "ItemCode");
            //BindProperties(this.tbQty, "EditValue", "Qty");

            BindProperties(this.edtLabel, "Label", "Label");
            LoadFormData(Controller.EditedAppointmentCopy);

            btnSaveAndClose.Enabled = !_ReadOnly;

        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty)
        {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode)
        {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
            BindToIsReadOnly(target, updateMode);
        }
        protected virtual void BindToIsReadOnly(Control control)
        {
            BindToIsReadOnly(control, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindToIsReadOnly(Control control, DataSourceUpdateMode updateMode)
        {
            if ((!(control is BaseEdit)) || control.DataBindings["ReadOnly"] != null)
                return;
            control.DataBindings.Add("ReadOnly", Controller, "ReadOnly", true, updateMode);
        }

        protected internal virtual void SubscribeControlsEvents()
        {
            this.edtEndDate.Validating += new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating += new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.edtStartDate.Validating += new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating += new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }
        protected internal virtual void OnEdtStartTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtStartDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtEndDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndDate.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtEndTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndTime.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual bool IsValidInterval()
        {
            return AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay) &&
                Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }

        #region #CustomFieldData
        string _ItemCode;

        public virtual void LoadFormData(Appointment appointment)
        {
            edtResources.EditValue = appointment.ResourceId;
            edtLabel.EditValue = appointment.LabelId;
            txtRemark.EditValue = appointment.CustomFields["Remark"];

        }
        public virtual bool SaveFormData(Appointment appointment)
        {
            
            appointment.ResourceId = edtResources.EditValue;
            //appointment.LabelId = storage.GetLabelColor(Convert.ToInt32(edtResources.EditValue));
            appointment.CustomFields["Type"] = edtResources.EditValue;
            appointment.CustomFields["Remark"] = txtRemark.EditValue;
            return true;

        }
        public virtual bool IsAppointmentChanged(Appointment appointment)
        {
            //if (_ItemCode == appointment.CustomFields["ItemCode"].ToString())
            //    return false;
            //else
                return true;
        }
        #endregion #CustomFieldData

        #region Even
        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnOkButton();
        }
        protected internal virtual void OnOkButton()
        {
            Save(true);
        }
        void Save(bool closeAfterSave)
        {
            if (!ValidateDateAndTime())
                return;
            if (!SaveFormData(Controller.EditedAppointmentCopy))
                return;
            if (!Controller.IsConflictResolved())
            {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Controller.IsTimeValid())
            {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidAppointmentTime), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_InvalidAppointmentTime), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsAppointmentChanged(Controller.EditedAppointmentCopy) || Controller.IsAppointmentChanged() || Controller.IsNewAppointment)
                Controller.ApplyChanges();
            if (closeAfterSave)
            {
                this.supressCancelCore = true;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }
        private bool ValidateDateAndTime()
        {
            this.edtEndDate.DoValidate();
            this.edtEndTime.DoValidate();
            this.edtStartDate.DoValidate();
            this.edtStartTime.DoValidate();

            return String.IsNullOrEmpty(this.edtEndTime.ErrorText) && String.IsNullOrEmpty(this.edtEndDate.ErrorText) && String.IsNullOrEmpty(this.edtStartDate.ErrorText) && String.IsNullOrEmpty(this.edtStartTime.ErrorText);
        }
        protected internal virtual DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(this, text, caption, buttons, icon);
        }
        private void btnNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNextButton();
        }

        private void btnPrevious_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnPreviousButton();
        }
        protected internal virtual void OnNextButton()
        {
            if (CancelCore())
            {
                this.supressCancelCore = true;
                OpenNextAppointmentCommand command = new OpenNextAppointmentCommand(Control);
                command.Execute();
                Close();
            }
        }

        protected internal virtual void OnPreviousButton()
        {
            if (CancelCore())
            {
                this.supressCancelCore = true;
                OpenPrevAppointmentCommand command = new OpenPrevAppointmentCommand(Control);
                command.Execute();
                Close();
            }
        }
        private bool CancelCore()
        {
            bool result = true;

            if (DialogResult != System.Windows.Forms.DialogResult.Abort && Controller != null && Controller.IsAppointmentChanged() && !this.supressCancelCore)
            {
                DialogResult dialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                    result = false;
                else if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    Save(true);
            }

            return result;
        }
        #endregion

        private void edtResources_EditValueChanged(object sender, EventArgs e)
        {
            edtLabel.SelectedIndex = Convert.ToInt32(edtResources.EditValue)-1;
        }
    }
}