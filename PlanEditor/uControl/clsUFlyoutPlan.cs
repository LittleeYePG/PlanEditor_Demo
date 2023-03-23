using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEditor
{
    public partial class clsUFlyoutPlan : DevExpress.XtraEditors.XtraUserControl
    {
        public clsUFlyoutPlan()
        {
            InitializeComponent();
        }
        public clsUFlyoutPlan(AppointmentFlyoutShowingEventArgs eventArgs, List<Data.cResource> resources, List<Data.cMRPCapacity> DataList)
        {
            InitializeComponent();

            lblLine.Text = resources.Where(w => w.Id == Convert.ToInt32(eventArgs.FlyoutData.Appointment.ResourceId)).Select(s => s.LineName).FirstOrDefault();
            lblPlanDate.Text = eventArgs.FlyoutData.Start.ToString("dd/MM/yyyy");

            //var DaysTime = Funcion.clsCFunction.GetWorkHours(eventArgs.FlyoutData.Start.Date);

            var DaysTime = Funcion.clsCFunction.GetmstWorkTime_Minutes(
                eventArgs.FlyoutData.Start.Date,
                resources.Where(w => w.Id == Convert.ToInt32(eventArgs.FlyoutData.Appointment.ResourceId)).Select(s => s.LineCode).FirstOrDefault()
                );

            var Capacity = DataList.Where(w => w.ResourceID == Convert.ToInt32(eventArgs.FlyoutData.Appointment.ResourceId) && w.MDate.Equals(eventArgs.FlyoutData.Start)).Sum(s => s.TotalWorkTime);
            lblWorktime.Text = Capacity.ToString("#,##0") + " / " + DaysTime.ToString("#,##0");
            lblWorktime1.Text = "( " + Funcion.clsCFunction.InfoWorkingTime((int)Capacity) + " / " + Funcion.clsCFunction.InfoWorkingTime((int)DaysTime) + " )";

            
            

        }
    }
}
