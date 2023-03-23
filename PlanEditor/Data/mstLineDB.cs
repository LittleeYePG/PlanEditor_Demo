using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class mstLineDB
    {
        public List<Data.cResource> GetResource_Demo(bool _dtail = false)
        {
            List<Data.cResource> resources = new List<Data.cResource>();
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstlines.Where(w => w.DelFlag == 0).ToList();
                int c = 0;
                foreach (var r in result)
                {
                    Data.cResource re = new Data.cResource();
                    c++;
                    if (!_dtail)
                    {
                        re.Id = c;
                        re.Code = r.LineCode + "MRP";
                        re.Caption = r.LineDesc;
                        re.Color = 1;
                        re.LineName = r.LineDesc;
                        re.LineCode = r.LineCode.ToString();
                        re.MRP = true;
                        resources.Add(re);

                        c++;
                        Data.cResource re1 = new Data.cResource();
                        re1.Id = c;
                        re1.Code = r.LineCode + "CRP";
                        re1.Caption = "";
                        re1.Color = 4;
                        re1.LineName = r.LineDesc;
                        re1.LineCode = r.LineCode.ToString();
                        re1.MRP = false;
                        resources.Add(re1);
                    }

                    if (_dtail)
                    {
                        c++;
                        Data.cResource re1 = new Data.cResource();
                        re1.Id = c;
                        re1.Code = r.LineCode + "CRP";
                        re1.Caption = r.LineDesc;
                        re1.Color = 4;
                        re1.LineName = r.LineDesc;
                        re1.LineCode = r.LineCode.ToString();
                        re1.MRP = false;
                        resources.Add(re1);
                    }
                }
            }
            return resources;
        }
        public List<Data.DB.mstitemcapacity> GetMstitemcapacities(string ItemCode,string TypeCode,string LineCode)
        {
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstitemcapacities
                    .Where(w => w.ItemCode == ItemCode && w.TypeCode == TypeCode && w.LineCode != LineCode)
                    .OrderBy(o=>o.LinePriority)
                    .ToList();
                return result;
            }
        }
        public string getLineName(int LineCode)
        {
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstline_Marunix
                    .Where(w => w.LineID == LineCode)
                    .FirstOrDefault();
                if (result != null)
                    return result.LineName;
                else
                    return "";
            }
        }
        public string getLineName(string LineCode)
        {
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = db.mstlines
                    .Where(w => w.LineCode == LineCode)
                    .FirstOrDefault();
                if (result != null)
                    return result.LineDesc;
                else
                    return "";
            }
        }
        public bool CheckLine(string ItemCode, int ResourceId, List<Data.cResource> resources)
        {
            var LineCode = resources.Where(w => w.Id == Convert.ToInt32(ResourceId)).Select(s => s.LineCode).FirstOrDefault();
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = (from t1 in db.mstitemcapacities
                              where t1.ItemCode == ItemCode
                              where t1.LineCode == LineCode
                              select new
                              {
                                  t1.LineCode,
                              }).ToList();
                if (result.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public double getWorkTime(string ItemCode, int ResourceId, List<Data.cResource> resources)
        {
            var LineCode = resources.Where(w => w.Id == Convert.ToInt32(ResourceId)).Select(s => s.LineCode).FirstOrDefault();
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = (from t1 in db.mstitemcapacities
                              where t1.ItemCode == ItemCode
                              where t1.LineCode == LineCode
                              select new
                              {
                                  t1.LineCode,
                                  t1.WorkingTime,
                              }).FirstOrDefault();
                if (result != null)
                {
                    return (double)result.WorkingTime;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double getWorkTime(string ItemCode, string LineCode)
        {
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                var result = (from t1 in db.mstitemcapacities
                              where t1.ItemCode == ItemCode
                              where t1.LineCode == LineCode
                              select new
                              {
                                  t1.LineCode,
                                  t1.WorkingTime,
                              }).FirstOrDefault();
                if (result != null)
                {
                    return (double)result.WorkingTime;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string getLineCode(int ResourceId, List<Data.cResource> resources)
        {
            
            var LineCode = resources.Where(w => w.Id == Convert.ToInt32(ResourceId)).Select(s => s.LineName).FirstOrDefault();
            return LineCode;
        }
        public string getLineName(int ResourceId, List<Data.cResource> resources)
        {
            var LineName = resources.Where(w => w.Id == Convert.ToInt32(ResourceId)).Select(s => s.LineName).FirstOrDefault();
            return LineName;
        }
        public List<LineRef> GetLineRefs
        {
            get
            {
                using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
                {
                    var result = (from q in db.mstlines
                                  where q.DelFlag == 0
                                  select new LineRef
                                  {
                                      LineCode = q.LineCode,
                                      LineName = q.LineDesc,
                                      LineDes = q.LineCode + " : "+q.LineDesc,
                                  }).ToList();
                    return result;
                }
            }
        }
        public List<mstLine_WorkTimeDB> GetMstLine_WorkTimes
        {
            get
            {
                using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
                {
                    var result = (from q in db.mstLine_WorkTime
                                  select new mstLine_WorkTimeDB
                                  {
                                      ID = q.ID,
                                      LineCode = q.LineCode,
                                      StartTime = q.StartTime,
                                      EndTime = q.EndTime,
                                      CreateDate = q.CreateDate,
                                      CreateUser = q.CreateUser,
                                      UpdateDate = q.UpdateDate,
                                      UpdateUser = q.UpdateUser,
                                      WorkTime = q.WorkTime,
                                      Status = "",
                                  }).ToList();
                    return result;
                }
            }
        }
        public bool UpDateMstLine_WorkTimes(List<mstLine_WorkTimeDB> _WorkTimeDBs,int StaffID)
        {
            using (Data.DB.PlanEditorEntities db = new DB.PlanEditorEntities())
            {
                using (DbContextTransaction transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        //Delete 
                        foreach (var d in _WorkTimeDBs.Where(w=>w.Status == "D"))
                        {
                            var dd = db.mstLine_WorkTime.Where(w => w.ID == d.ID).FirstOrDefault();
                            if (dd != null)
                            {
                                db.mstLine_WorkTime.Remove(dd);
                            }
                        }

                        //Insert
                        foreach (var i in _WorkTimeDBs.Where(w => w.Status == "I"))
                        {
                            var ii = db.mstLine_WorkTime.Where(w => w.ID == i.ID).FirstOrDefault();
                            if (ii == null)
                            {
                                ii = new DB.mstLine_WorkTime();
                                int _id = db.mstLine_WorkTime.Select(s => s.ID).DefaultIfEmpty(0).Max();
                                ii.ID = _id + 1;
                                ii.LineCode = i.LineCode;
                                ii.StartTime = i.StartTime;
                                ii.EndTime = i.EndTime;
                                ii.WorkTime = i.WorkTime;
                                ii.CreateDate = DateTime.Now;
                                ii.UpdateDate = ii.CreateDate;
                                ii.CreateUser = StaffID;
                                ii.UpdateUser = ii.CreateUser;
                                db.mstLine_WorkTime.Add(ii);
                            }
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        XtraMessageBox.Show(ex.Message,"Error");
                        return false;
                    }

                } 
            }
        }


    }
    public class LineRef
    {
        public string LineCode { get; set; }
        public string LineName { get; set; }
        public string LineDes { get; set; }
    }
    public class mstLine_WorkTimeDB
    {
        public int ID { get; set; }
        public string LineCode { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public int CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<decimal> WorkTime { get; set; }
        public string Status { get; set; } = "";
    }
}
