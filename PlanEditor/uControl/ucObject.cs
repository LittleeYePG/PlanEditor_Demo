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

namespace PlanEditor.uControl
{
    public partial class ucObject : DevExpress.XtraEditors.XtraUserControl
    {
        public string TextStart
        {
            get
            {
                return lblStart.Text;
            }
            set
            {
                lblStart.Text = value;
            }
        }
        public string TextEnd
        {
            get
            {
                return lblEnd.Text;
            }
            set
            {
                lblEnd.Text = value;
            }
        }
        public string TextDetail
        {
            get
            {
                return lblDetail.Text;
            }
            set
            {
                lblDetail.Text = value;
            }
        }
        public ucObject()
        {
            InitializeComponent();
            pDetail.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, this.pDetail.ClientRectangle, Color.Pink, ButtonBorderStyle.Solid);
            };
            lblDetail.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, this.lblDetail.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            };
        }
    }
}
