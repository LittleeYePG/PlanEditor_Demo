using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class mstItemDB
    {
        public List<DB.mstitem> GetMstitems()
        {
            using (DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstitems
                    .Where(w => w.DelFlag == 0)
                    .OrderBy(o => o.ItemCode)
                    .ToList();
                return result;
            }
        }
    }
}
