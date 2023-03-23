using DevExpress.XtraBars;
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
    public partial class clsVSplit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Appointment _AptChanged;
        Appointment _AptChangedNew;
        public Appointment AptChanged
        {
            get
            {
                return _AptChanged;
            }
            set
            {
                _AptChanged = value;
            }
        }
        public Appointment AptChangedNew
        {
            get
            {
                return _AptChangedNew;
            }
            set
            {
                _AptChangedNew = value;
            }
        }
        
        double Qty;
        Data.mstLineDB mstLineDB = new Data.mstLineDB();
        private List<Data.cResource> Resources = new List<Data.cResource>();
        public clsVSplit(Appointment appointment, Appointment appointmentNew, int sQty1, int sQty2, List<Data.cResource> resource)
        {
            InitializeComponent();
            AptChanged = appointment;
            AptChangedNew = appointmentNew;
            Resources = resource;

            txtSupject.EditValue = AptChanged.Subject;
            txtItemCode.EditValue = AptChanged.CustomFields["ItemCode"];
            Qty = Convert.ToDouble( AptChanged.CustomFields["Qty"]);

            txtQty1.EditValue = sQty1;
            txtQty2.EditValue = sQty2;

            this.Load += (sender, e) =>
            {
                txtQty1.Focus();
            };
            this.Activated += (sender, e) =>
            {
                txtQty1.Focus();
            };
            btnSaveClose.ItemClick += (sender, e) =>
            {
                var l = Resources.Where(w => w.Id == Convert.ToInt32(AptChanged.ResourceId)).Select(s => s.LineCode).FirstOrDefault();
                decimal W = (decimal)mstLineDB.getWorkTime((string)AptChanged.CustomFields["ItemCode"], l);
                AptChanged.End = AptChanged.Start.AddMinutes((double)(W * Convert.ToDecimal(txtQty1.EditValue)));
                AptChanged.CustomFields["Qty"] = txtQty1.EditValue;

                AptChangedNew.ResourceId = AptChanged.ResourceId;
                AptChangedNew.Subject = AptChanged.Subject;
                AptChangedNew.Location = AptChanged.Location;
                AptChangedNew.Start = AptChanged.End;
                AptChangedNew.End = AptChangedNew.Start.AddMinutes((double)(W * Convert.ToDecimal(txtQty2.EditValue)));
                AptChangedNew.CustomFields["Qty"] = txtQty2.EditValue;
                AptChangedNew.CustomFields["ItemCode"] = AptChanged.CustomFields["ItemCode"];
                AptChangedNew.CustomFields["ItemName"] = AptChanged.CustomFields["ItemName"];
                AptChangedNew.CustomFields["TimeWork"] = W;
                Random rnd = new Random();
                AptChangedNew.LabelId = rnd.Next(100);

                this.DialogResult = DialogResult.OK;

            };
            txtQty1.EditValueChanged += (sender, e) =>
            {
                if (string.IsNullOrEmpty((string)txtQty1.EditValue)) { txtQty2.EditValue = Qty; return; }
                txtQty2.EditValue = Qty - Convert.ToDouble(txtQty1.EditValue);
            };
            txtQty1.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSaveClose.PerformClick();
                }
            };
        }
    }
}