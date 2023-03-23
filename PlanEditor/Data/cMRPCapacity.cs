using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class cMRPCapacity
    {
        public int ID { get; set; } = 0;
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string TypeCode { get; set; }
        public string LineCode { get; set; }
        public DateTime MDate { get; set; }
        public decimal MRPWorkTime { get; set; }
        public decimal LineCapacity { get; set; }
        public decimal LineCalendarCapacity { get; set; }
        public decimal MRPCapacity { get; set; }
        public int ResourceID { get; set; } = 0;
        public int LabelID { get; set; } = 0;
        public decimal TotalWorkTime { get; set; }
        public string OrderProdNo { get; set; }
        public System.DateTime StartPlanDate { get; set; }
        public System.DateTime EndPlanDate { get; set; }
        public double TimeWork { get; set; } = 0;
        public decimal PlanQty { get; set; } = 0;
        public DateTime MDate_Ref { get; set; }
        public decimal RemainCalQty { get; set; } = 0;
        public string Remark { get; set; }

    }
}
