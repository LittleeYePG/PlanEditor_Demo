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
    public partial class clsVShowInfomation : DevExpress.XtraEditors.XtraForm
    {
        private string _LineName = "";
        private string _Start = "";
        private string _End = "";
        private string _ItemCode = "";
        private string _ItemName = "";
        private string _Qty = "";
        private string _Remark = "";

        public string LineName
        {
            set { lblLine.Text = value; }
        }
        public string Start
        {
            set { lblSDate.Text = value; }
        }
        public string End
        {
            set { lblEndDate.Text = value; }
        }
        public string ItemCode
        {
            set { lblItemCode.Text = value; }
        }
        public string ItemName
        {
            set { lblName.Text = value; }
        }
        public string Qty
        {
            set { lblQty.Text = value; }
        }
        public string Remark
        {
            set { lblRemark.Text = value; }
        }

        public clsVShowInfomation()
        {
            InitializeComponent();
            ReLoad();

        }
        public void ReLoad()
        {
            
        }
    }
}