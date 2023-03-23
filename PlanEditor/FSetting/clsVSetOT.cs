using DevExpress.XtraEditors;
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
    public partial class clsVSetOT : DevExpress.XtraEditors.XtraForm
    {
        public clsVSetOT()
        {
            InitializeComponent();
            edtStartTime.EditValue = Funcion.clsCFunction.EndTime;
            edtEndTime.EditValue = edtStartTime.Time.AddMinutes(60).TimeOfDay;

            bntOK.Click += (sender, e) =>
              {
                  this.DialogResult = DialogResult.OK;
              };
        }
        public TimeSpan GetStartTiem { get { return (TimeSpan)edtStartTime.EditValue; } }
        public TimeSpan GetEndTime { get { return (TimeSpan)edtEndTime.EditValue; } }
        public string SetText { set { this.Text = value; } }
    }
}