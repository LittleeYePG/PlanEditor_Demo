using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class clsVLineWorkTime : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Data.mstLineDB mstLineDB = new Data.mstLineDB();
        private List<Data.mstLine_WorkTimeDB> MstLine_WorkTimes = new List<Data.mstLine_WorkTimeDB>();
        private bool NewRow = false;
        BindingSource bs = new BindingSource();

        public clsVLineWorkTime()
        {
            InitializeComponent();
            luLine.Properties.DataSource = mstLineDB.GetLineRefs;
            MstLine_WorkTimes = mstLineDB.GetMstLine_WorkTimes;
            luLine.EditValue = mstLineDB.GetLineRefs.Select(s => s.LineCode).DefaultIfEmpty("").First();
            GridDataSource();
        }

        private void luLine_EditValueChanged(object sender, EventArgs e)
        {
            //bs.DataSource = MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString()).ToList();
            //gridControl1.DataSource = MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString() && w.Status != "D").ToList();
            //gridView1.ActiveFilter.Clear();
            //gridView1.ActiveFilterString = "LineCode = '"+ luLine.EditValue.ToString() +"' ";
            GridDataSource();
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (luLine.EditValue == null)
            {
                return;
            }
            using (FSetting.clsVLineWorkTime_Edit frm=new clsVLineWorkTime_Edit())
            {
                frm.AddNew = true;
                frm.workTimeDB = new Data.mstLine_WorkTimeDB();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.workTimeDB.LineCode = (string)luLine.EditValue;                   
                    frm.workTimeDB.ID = (MstLine_WorkTimes.Max(m => (int?)m.ID) ?? 0) + 1;
                    frm.workTimeDB.Status = "I";
                    MstLine_WorkTimes.Add(frm.workTimeDB);
                    GridDataSource();
                }
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                return;
            }

            if (XtraMessageBox.Show("Do you want Delete?", "Question"
                       , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["ID"]);
                var result = MstLine_WorkTimes.Where(w => w.ID == Convert.ToInt32(id)).FirstOrDefault();
                if (result != null)
                {
                    result.Status = "D";
                }
                GridDataSource();
            }
        }

        private void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (luLine.EditValue == null)
            {
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                return;
            }

            // Initialize a new XtraInputBoxArgs instance
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            // Set required Input Box options
            args.Caption = "Copy To";
            args.Prompt = "Line ";
            args.DefaultButtonIndex = 0;

            args.Showing += Args_Showing;

            LookUpEdit lookUp = new LookUpEdit();
            lookUp.Properties.DataSource = mstLineDB.GetLineRefs
                .Where(w => w.LineCode != luLine.EditValue.ToString())
                .Select(s=>new { s.LineCode,s.LineName})
                .ToList();
            lookUp.Properties.DisplayMember = "LineName";
            lookUp.Properties.ValueMember = "LineCode";
            args.Editor = lookUp;

            // A default DateEdit value
            args.DefaultResponse = null;

            var result = XtraInputBox.Show(args);

            if (result != null)
            {
                //Delete old
                foreach (var d in MstLine_WorkTimes.Where(w=>w.LineCode == result.ToString()))
                {
                    d.Status = "D";
                }

                //Insert New
                foreach (var c in MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString() && w.Status != "D").ToList())
                {
                    Data.mstLine_WorkTimeDB i = new Data.mstLine_WorkTimeDB();
                    i.ID  = (MstLine_WorkTimes.Max(m => (int?)m.ID) ?? 0) + 1;
                    i.LineCode = result.ToString();
                    i.StartTime = c.StartTime;
                    i.EndTime = c.EndTime;
                    i.WorkTime = c.WorkTime;
                    i.Status = "I";
                    MstLine_WorkTimes.Add(i);
                }

                luLine.EditValue = result;
                GridDataSource();
            }

        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Icon = this.Icon;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mstLineDB.UpDateMstLine_WorkTimes(MstLine_WorkTimes, 1))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void GridDataSource()
        {
            gridControl1.DataSource = MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString() && w.Status != "D").ToList();
            ucScalTime1.ClsObject();
            foreach (var w in MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString() && w.Status != "D"))
            {
                AddObject(w);
            }

            var TotalTime = MstLine_WorkTimes.Where(w => w.LineCode == luLine.EditValue.ToString() && w.Status != "D").Select(s=>s.WorkTime).DefaultIfEmpty(0).Sum();
            lblTotalTime.Text ="Work Time " + Funcion.clsCFunction.InfoWorkingTime((int)TotalTime);
        }
        private bool AddObject(Data.mstLine_WorkTimeDB _WorkTimeDB)
        {
            try
            {
                ucScalTime1.AddObject(_WorkTimeDB.ID.ToString(), (TimeSpan)_WorkTimeDB.StartTime, (TimeSpan)_WorkTimeDB.EndTime);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}