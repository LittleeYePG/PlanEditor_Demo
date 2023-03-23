using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class mstCalendarDB
    {

        private List<DB.mstcalendardetail> mstcalendardetails = new List<DB.mstcalendardetail>();
        public List<DB.mstcalendardetail> GetMstcalendardetails(decimal CalNo)
        {
            using (DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstcalendardetails.Where(w => w.CalNo == CalNo).ToList();
                return result;
            }
        }
        public decimal HolidayFlag(decimal CalNo, DateTime date)
        {
            using (DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstcalendardetails.Where(w => w.CalDate == date.Date).FirstOrDefault();
                if (result == null)
                    return 0;

                if (result.HolidayFlag == null)
                {
                    return 0;
                }
                else
                {
                    return (decimal)result.HolidayFlag;
                }
            }
        }

        public List<DB.mstcalendardetail> GetMstcalendardetails(decimal CalNo, DateTime date)
        {
            using (DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstcalendardetails
                    .Where(w => w.CalDate.Year == date.Date.Year || w.CalDate.Year == date.AddYears(-1).Year)
                    .ToList();
                return result;
            }
        }
    }
}
