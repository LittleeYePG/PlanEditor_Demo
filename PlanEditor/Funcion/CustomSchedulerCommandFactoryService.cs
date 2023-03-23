using DevExpress.Utils;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Operations;
using DevExpress.XtraScheduler.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor
{
    public class CustomSchedulerCommandFactoryService : ISchedulerCommandFactoryService
    {
        readonly ISchedulerCommandFactoryService service;
        readonly SchedulerControl control;

        public CustomSchedulerCommandFactoryService(SchedulerControl control,
            ISchedulerCommandFactoryService service)
        {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }

        #region ISchedulerCommandFactoryService Members
        public SchedulerCommand CreateCommand(SchedulerCommandId id)
        {
            if (id == SchedulerCommandId.SplitAppointment)
            {
                CustomSplitAppointmentOperationCommand cmd = new CustomSplitAppointmentOperationCommand(control);
                cmd.SplitAppointmentCommandStep = TimeSpan.FromMilliseconds(10);
                return cmd;
            }
            return service.CreateCommand(id);
        }
        
        #endregion
    }

    public class CustomSplitAppointmentOperationCommand : SplitAppointmentOperationCommand
    {
        public CustomSplitAppointmentOperationCommand(ISchedulerCommandTarget target) : base(target) { }
        public CustomSplitAppointmentOperationCommand(SchedulerControl control) : base(control) { }

        private TimeSpan splitInterval = TimeSpan.FromMinutes(10);
        public TimeSpan SplitAppointmentCommandStep
        {
            get
            {
                return splitInterval;
            }
            set
            {
                splitInterval = value;
            }
        }
        protected override IOperation CreateOperation()
        {
            //TimeScaleCollection timeScales = CreateTimeScaleCollection();
            TimeScaleCollection timeScales = new TimeScaleCollection();
            timeScales.Add(new TimeScaleFixedInterval(SplitAppointmentCommandStep));
            return new SplitAppointmentOperation(SchedulerControl, timeScales, SchedulerControl.SelectedAppointments[0]);
        }
        public override void Execute()
        {
            
            base.Execute();
        }
    }

    //public class CustomSplitAppointmentOperation: SplitAppointmentOperation
    //{
    //    readonly SchedulerControl control;
    //    private Appointment apt;
    //    public Appointment Appointment
    //    {
    //        get
    //        {
    //            return apt;
    //        }
    //        set
    //        {
    //            apt = value;
    //        }
    //    }
    //   // public CustomSplitAppointmentOperation(DevExpress.XtraScheduler.SchedulerControl control) : base(control) { }
    //}
}
