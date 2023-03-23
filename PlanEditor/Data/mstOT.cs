using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Data
{
    public class mstOT
    {
        public int ID { get; set; } 
        public DateTime Date { get; set; } 
        public int LineID { get; set; }
        public TimeSpan stTime { get; set; }
        public TimeSpan etTime { get; set; }
        public double OTTime { get; set; } = 0;
        public int Type { get; set; } = 1;
        public string Remark { get; set; }
        public string LineCode { get; set; }
    }
    public class mmstOTDB
    {
        private List<mstOT> mstOTs = new List<mstOT>();
        public List<mstOT> GetMstOTs
        {
            get
            {
                return mstOTs;
            }
            set
            {
                mstOTs = value;
            }
        }
        public bool InsertUpdateData(DateTime date,int LineId,TimeSpan sTime,TimeSpan eTime)
        {
            try
            {
                mstOT oT = GetMstOTs.Where(w => w.Date.Equals(date) && w.LineID.Equals(LineId)).FirstOrDefault();
                if (oT != null)
                {
                    
                    oT.stTime = sTime;
                    oT.etTime = eTime;
                    oT.OTTime = (oT.etTime - oT.stTime).TotalMinutes;
                }else
                {
                    oT = new mstOT();
                    oT.Date = date;
                    oT.LineID = LineId;
                    oT.stTime = sTime;
                    oT.etTime = eTime;
                    oT.OTTime = (oT.etTime - oT.stTime).TotalMinutes;
                    mstOTs.Add(oT);
                }
                
                return true;
            }catch
            {
                return false;
            }
        }
        public bool InsertUpdateData(mstOT mstOT)
        {
            try
            {
                mstOT oT = GetMstOTs.Where(w => w.Date.Equals(mstOT.Date) && w.LineID.Equals(mstOT.LineID)).FirstOrDefault();
                if (oT != null)
                {

                    oT.stTime = mstOT.stTime;
                    oT.etTime = mstOT.etTime;
                    oT.OTTime = (oT.etTime - oT.stTime).TotalMinutes;
                    oT.Remark = mstOT.Remark;
                }
                else
                {
                    oT = new mstOT();
                    oT = mstOT;
                    oT.OTTime = (oT.etTime - oT.stTime).TotalMinutes;
                    mstOTs.Add(oT);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public double GetOTTime(DateTime date,int LineID)
        {
            var result = GetMstOTs.Where(w => w.Date.Equals(date) && w.LineID.Equals(LineID) && w.Type.Equals(2)).Select(s => s.OTTime).FirstOrDefault();
            if (result == null)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }
        public bool GetStopTime(DateTime date, int LineID)
        {
            var result = GetMstOTs.Where(w => w.Date.Equals(date) && w.LineID.Equals(LineID) && w.Type.Equals(1)).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public TimeSpan GetMaxTime()
        {
            try
            {
                var result = GetMstOTs.OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                {
                    if (result.etTime < Funcion.clsCFunction.EndTime)
                        return Funcion.clsCFunction.EndTime;
                    else
                        return result.etTime;
                }
                else
                    return Funcion.clsCFunction.EndTime;
            }
            catch
            {
                return Funcion.clsCFunction.EndTime;
            }
        }
        public TimeSpan GetMinTime()
        {
            try
            {
                var result = GetMstOTs.OrderBy(o => o.stTime).FirstOrDefault();
                if (result != null)
                { 
                    if (Funcion.clsCFunction.StartTime < result.stTime)
                    { return Funcion.clsCFunction.StartTime; }
                    else
                    { return result.stTime; }
                }
                    
                else
                    return Funcion.clsCFunction.StartTime;
            }
            catch
            {
                return Funcion.clsCFunction.StartTime;
            }
        }
        public TimeSpan GetMaxTime(DateTime date)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date) )
                    .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                    if (result.etTime < Funcion.clsCFunction.EndTime)
                        return Funcion.clsCFunction.EndTime;
                    else
                        return result.etTime;
                else
                    return Funcion.clsCFunction.EndTime;
            }
            catch
            {
                return Funcion.clsCFunction.EndTime;
            }
        }
        public TimeSpan GetMinTime(DateTime date)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date) )
                    .OrderBy(o => o.stTime).FirstOrDefault();
                if (result != null)
                    if (Funcion.clsCFunction.StartTime < result.stTime)
                        return Funcion.clsCFunction.StartTime;
                    else
                        return result.stTime;
                else
                    return Funcion.clsCFunction.StartTime;
            }
            catch
            {
                return Funcion.clsCFunction.StartTime;
            }
        }
        public TimeSpan GetMaxTime(DateTime date, int LineID)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w=>w.Date.Date.Equals(date.Date) && w.LineID.Equals(LineID))
                    .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                    if (result.etTime < Funcion.clsCFunction.EndTime)
                        return Funcion.clsCFunction.EndTime;
                    else
                        return result.etTime;
                else
                    return Funcion.clsCFunction.EndTime;
            }
            catch
            {
                return Funcion.clsCFunction.EndTime;
            }
        }
        public TimeSpan GetMinTime(DateTime date, int LineID)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date) && w.LineID.Equals(LineID))
                    .OrderBy(o => o.stTime).FirstOrDefault();
                if (result != null)
                    if (Funcion.clsCFunction.StartTime < result.stTime)
                        return Funcion.clsCFunction.StartTime;
                    else
                        return result.stTime;                
                else
                    return Funcion.clsCFunction.StartTime;
            }
            catch
            {
                return Funcion.clsCFunction.StartTime;
            }
        }
        public TimeSpan GetMaxTime(DateTime date, string LineCode)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date) && w.LineCode.Equals(LineCode))
                    .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                    if (result.etTime < Funcion.clsCFunction.EndTime)
                        return Funcion.clsCFunction.EndTime;
                    else
                        return result.etTime;
                else
                    return Funcion.clsCFunction.EndTime;
            }
            catch
            {
                return Funcion.clsCFunction.EndTime;
            }
        }
        public TimeSpan GetMinTime(DateTime date, string LineCode)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date) && w.LineCode.Equals(LineCode))
                    .OrderBy(o => o.stTime).FirstOrDefault();
                if (result != null)
                    if (Funcion.clsCFunction.StartTime < result.stTime)
                        return Funcion.clsCFunction.StartTime;
                    else
                        return result.stTime;
                else
                    return Funcion.clsCFunction.StartTime;
            }
            catch
            {
                return Funcion.clsCFunction.StartTime;
            }
        }
        public bool checkTimeOT(DateTime date,int LineID)
        {
            try
            {
                var result = GetMstOTs
                   .Where(w => w.Date.Equals(date.Date) && w.LineID.Equals(LineID) && w.Type.Equals(2) 
                   && w.stTime <= date.TimeOfDay && w.etTime > date.TimeOfDay)
                   .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkStopTime(DateTime date, int LineID)
        {
            try
            {
                var result = GetMstOTs
                   .Where(w => w.Date.Equals(date.Date) && w.LineID.Equals(LineID) && w.Type.Equals(1)
                   && w.stTime <= date.TimeOfDay && w.etTime > date.TimeOfDay)
                   .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public TimeSpan GetMaxTimeOT(DateTime date)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date))
                    .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                    return result.etTime;
                else
                    return Funcion.clsCFunction.EndTime;
            }
            catch
            {
                return Funcion.clsCFunction.EndTime;
            }
        }
        public TimeSpan GetMinTimeOT(DateTime date)
        {
            try
            {
                var result = GetMstOTs
                    .Where(w => w.Date.Date.Equals(date.Date))
                    .OrderBy(o => o.stTime).FirstOrDefault();
                if (result != null)
                    return result.stTime;
                else
                    return Funcion.clsCFunction.StartTime;
            }
            catch
            {
                return Funcion.clsCFunction.StartTime;
            }
        }

        /// <summary>
        /// เช็ค ว่า เป็นเวลาทำงานใช่หรือไม่
        /// </summary>
        /// <param name="date"></param>
        /// <param name="LineCode"></param>
        /// <returns></returns>
        public bool checkTimeOT(DateTime date, string LineCode)
        {
            try
            {
                var result = GetMstOTs
                   .Where(w => w.Date.Equals(date.Date) && w.LineCode.Equals(LineCode) && w.Type.Equals(2)
                   && w.stTime <= date.TimeOfDay && w.etTime > date.TimeOfDay)
                   .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkStopTime(DateTime date, string LineCode)
        {
            try
            {
                var result = GetMstOTs
                   .Where(w => w.Date.Equals(date.Date) && w.LineCode.Equals(LineCode) && w.Type.Equals(1)
                   && w.stTime <= date.TimeOfDay && w.etTime > date.TimeOfDay)
                   .OrderByDescending(o => o.etTime).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// หาเวลาทำงาน OT
        /// </summary>
        /// <param name="date"></param>
        /// <param name="LineCode"></param>
        /// <returns></returns>
        public double GetOTTime(DateTime date, string LineCode)
        {
            try
            {
                if (GetMstOTs == null) return 0;

                var result = GetMstOTs
                .Where(w => w.Date.Equals(date) && w.LineCode.Equals(LineCode) && w.Type.Equals(2))
                .Select(s => s.OTTime).DefaultIfEmpty(0)
                .Sum();

                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// หาเวลา Stop Time
        /// </summary>
        /// <param name="date"></param>
        /// <param name="LineCode"></param>
        /// <returns></returns>
        public double GetStopTime(DateTime date, string LineCode)
        {
            try
            {
                if (GetMstOTs == null) return 0;

                var result = GetMstOTs
                .Where(w => w.Date.Equals(date) && w.LineCode.Equals(LineCode) && w.Type.Equals(1))
                .Select(s => s.OTTime).DefaultIfEmpty(0)
                .Sum();

                return result;
            }
            catch
            {
                return 0;
            }
        }

        public bool GetOTTimeDay(DateTime date)
        {
            try
            {
                if (GetMstOTs == null) return false;

                var result = GetMstOTs
                .Where(w => w.Date.Equals(date)  && w.Type.Equals(2))
                .ToList();
                if (result.Count > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
