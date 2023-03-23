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
    public partial class clsUFlyout : DevExpress.XtraEditors.XtraUserControl
    {
        public clsUFlyout()
        {
            InitializeComponent();
        }
        public clsUFlyout(AppointmentFlyoutShowingEventArgs eventArgs)
        {
            InitializeComponent();
            this.lblSubject.Text = eventArgs.FlyoutData.Subject;
            lblSubject.BackColor = eventArgs.FlyoutData.SubjectAppearance.BackColor;
            lblSubject.ForeColor = eventArgs.FlyoutData.SubjectAppearance.ForeColor;

            this.lblStart.Text = eventArgs.FlyoutData.Start.ToString("dd/MM/yyyy HH:mm");
            this.lblEnd.Text = eventArgs.FlyoutData.End.ToString("dd/MM/yyyy HH:mm");
            this.lblItemcode.Text = (string)eventArgs.FlyoutData.Appointment.CustomFields["ItemCode"];
            this.lblQty.Text = Convert.ToDecimal( eventArgs.FlyoutData.Appointment.CustomFields["Qty"]).ToString("#,##0.00");
            this.lblItemName.Text = (string)eventArgs.FlyoutData.Appointment.CustomFields["ItemName"];
            this.lblRemark.Text = (string)eventArgs.FlyoutData.Appointment.CustomFields["Remark"];
        }
    }
}
