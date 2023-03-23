using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
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
    public partial class clsVMerge : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Data.cMRPCapacity> CMRPs = new List<Data.cMRPCapacity>();
        private List<Data.cMRPCapacity> CM = new List<Data.cMRPCapacity>();
        private clsVPlanEdit FM;
        BindingSource bs = new BindingSource();
        string useItemCode = "";
        public clsVMerge(clsVPlanEdit fm)
        {
            InitializeComponent();
            FM = fm;

            CMRPs = FM.GetMRPCapacities;
            bs.DataSource = CM;
            gridControl1.DataSource = bs;

            gridControl1.AllowDrop = true;
            gridControl1.DragDrop += (sender, e) =>
            {
                GridControl gridControl = sender as GridControl;
                SchedulerDragData data = e.Data.GetData(typeof(SchedulerDragData)) as SchedulerDragData;
                DataTable dt = new DataTable();
                if (data != null)
                {
                    var aa = CMRPs.Where(w => w.ID == Convert.ToInt32(data.Appointments[0].Id)).FirstOrDefault();
                    if (useItemCode == "")
                    {
                        useItemCode = aa.ItemCode;
                        CM.Add(aa);
                    }
                    else if (useItemCode == aa.ItemCode)
                    {
                        CM.Add(aa);
                    }
                    else
                    {
                        XtraMessageBox.Show("Not Use ItemCode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                bs.DataSource = CM;
                gridControl1.DataSource = bs;
                cardView1.FocusedRowHandle = 0;
                cardView1.SelectRow(0);
                cardView1.RefreshData();
            };
            gridControl1.DragEnter += (sender, e) =>
            {
                e.Effect = System.Windows.Forms.DragDropEffects.All;
            };
            cardView1.CustomDrawCardCaption += (sender, e) =>
            {
                CardView cardView = (CardView)sender;
                var txt = cardView.GetRowCellDisplayText(e.RowHandle, "ItemCode");
                int r = e.RowHandle + 1;
                e.CardCaption = "Row No " + r;
            };
        }

        private void bntMerge_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CM.Count <= 1)
            {
                XtraMessageBox.Show("Please select more than 1 item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = 0;
            foreach (var m in CM)
            {
                if (id == 0)
                    id = m.ID;
                else
                    FM.MergeApt(id, m.ID);
            }
            this.Close();
        }

        private void bntCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do You Want Cancel", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cardView1.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Do You Want Delete", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cardView1.DeleteRow(cardView1.FocusedRowHandle);
            }
        }
    }
}