using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class cResource
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Caption { get; set; }
        public int Color { get; set; }
        public int ParentId { get; set; }
        public string LineCode { get; set; }
        public string LineName { get; set; }
        public bool MRP { get; set; } = true;
    }
}
