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

namespace PlanEditor.FSetting
{
    public partial class clsVLineWorkTime_Edit : DevExpress.XtraEditors.XtraForm
    {
        private bool _AddNew = false;
        public bool AddNew { get { return _AddNew; } set { _AddNew = value; } }

        private Data.mstLine_WorkTimeDB _WorkTimeDB ;
        public Data.mstLine_WorkTimeDB workTimeDB { get { return _WorkTimeDB; } set { _WorkTimeDB = value; } }
        private bool _Load = false;
        public clsVLineWorkTime_Edit()
        {
            InitializeComponent();

            
            this.Load += (sender, e) =>
            {
                _Load = true;
                if (AddNew)
                {
                    this.edtStartTime.EditValue = "00:00";
                    this.edtEndTime.EditValue = "00:00";
                    this.txtWorkTime.EditValue = 0;
                }
                else
                { 
                    this.edtStartTime.EditValue = workTimeDB.StartTime;
                    this.edtEndTime.EditValue = workTimeDB.EndTime;
                    this.txtWorkTime.EditValue = workTimeDB.WorkTime;
                }
                _Load = false;
                edtStartTime.Focus();
            };

            this.btnSave.Click += (sender, e) =>
            {
                workTimeDB.StartTime = Convert.ToDateTime(this.edtStartTime.EditValue).TimeOfDay;
                workTimeDB.EndTime = Convert.ToDateTime(this.edtEndTime.EditValue).TimeOfDay;
                workTimeDB.WorkTime = (decimal?)this.txtWorkTime.EditValue;
                this.DialogResult = DialogResult.OK;
            };

            this.edtStartTime.EditValueChanged += EdtStartTime_EditValueChanged;
            this.edtEndTime.EditValueChanged += EdtEndTime_EditValueChanged;
        }

        private void EdtEndTime_EditValueChanged(object sender, EventArgs e)
        {
            if (_Load) return;
            this.txtWorkTime.EditValue = (Convert.ToDateTime(edtEndTime.EditValue) - Convert.ToDateTime(edtStartTime.EditValue)).TotalMinutes;
        }

        private void EdtStartTime_EditValueChanged(object sender, EventArgs e)
        {
            if (_Load) return;
            if (Convert.ToDateTime(edtEndTime.EditValue) < Convert.ToDateTime(edtStartTime.EditValue))
            {
                edtEndTime.EditValue = edtStartTime.EditValue;
            }
        }
    }
}