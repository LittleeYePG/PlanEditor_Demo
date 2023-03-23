using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor.Funcion
{
    public static class TimeCellGenerateDB
    {
        private static List<TimeCellGenerate> _timeCells = null;
        public static List<TimeCellGenerate> TimeCells
        {
            get { return _timeCells; }
            set { _timeCells = value; }
        }
        /// <summary>
        /// สร้างเฉพราะ เวลาทำงาน ถ้าไม่มี ถือ ว่า หยุด 
        /// </summary>
        /// <returns></returns>
        public static bool GenerateWorkTime()
        {
            if (_timeCells != null)
                return true;

            DateTime st = DateTime.Today.AddMonths(-1);
            DateTime ed = DateTime.Today.AddMonths(4);
            _timeCells = new List<TimeCellGenerate>();
            try
            {
                using (Data.DB.PlanEditorEntities db = new Data.DB.PlanEditorEntities())
                {
                    var line = db.mstlines.Where(w=>w.DelFlag == 0).ToList();
                    var cal = db.mstcalendardetails
                        .Where(w => w.CalDate >= st && w.CalDate <= ed && w.DelFlag == 0).ToList();

                    foreach (var l in line)
                    {

                        foreach (var c in cal)
                        {
                            DateTime startWorkHours = c.CalDate.Date.Add( Funcion.clsCFunction.OTDB.GetMinTime(c.CalDate.Date, l.LineCode)); //schedulerControl.GanttView.WorkTime.Start;
                            DateTime endWorkHours = c.CalDate.Date.Add(Funcion.clsCFunction.OTDB.GetMaxTime(c.CalDate.Date, l.LineCode)); 

                            
                            while (startWorkHours < endWorkHours)
                            {
                                TimeCellGenerate timeCell = new TimeCellGenerate();
                                timeCell.DateTime = startWorkHours;
                                timeCell.LineCode = l.LineCode;
                                timeCell.LineName = l.LineDesc;

                                if (Funcion.clsCFunction.checkWorkTime(timeCell.DateTime, timeCell.LineCode))
                                {
                                    timeCell.Status = TimeCellStatus.Work;
                                    timeCell.Color = FColor.WorkTime;
                                }
                                else if (Funcion.clsCFunction.OTDB.checkTimeOT(timeCell.DateTime, timeCell.LineCode))
                                {
                                    timeCell.Status = TimeCellStatus.OT;
                                    timeCell.Color = FColor.OTTime;
                                }
                                else if (Funcion.clsCFunction.OTDB.checkStopTime(timeCell.DateTime, timeCell.LineCode))
                                {
                                    timeCell.Status = TimeCellStatus.Stop;
                                    timeCell.Color = FColor.StopTime;
                                }
                                else if (Funcion.clsCFunction.FindHoliday(timeCell.DateTime.Date))
                                {
                                    timeCell.Status = TimeCellStatus.Holiday;
                                    timeCell.Color = FColor.HoliDay;
                                }
                                else 
                                {
                                    startWorkHours = startWorkHours.AddMinutes(15);
                                    continue;
                                }

                                _timeCells.Add(timeCell);
                                startWorkHours = startWorkHours.AddMinutes(15);
                            }
                        }
                    }

                    
                }
                return true;
            }
            catch (Exception ex){
                XtraMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public static TimeCellGenerate GetDate(DateTime date ,string LineCode)
        {
            try
            {
                var result = TimeCells.Where(w => w.DateTime == date && w.LineCode == LineCode).First();
                return result;
            }
            catch
            {
                return null;
            }
        }
    }

    public class TimeCellGenerate
    {
        public  DateTime DateTime { get; set; }
        public  string LineCode { get; set; }
        public  string LineName { get; set; }
        public  TimeCellStatus Status { get; set; }
        public Color Color { get; set; }
    }
    public enum TimeCellStatus
    {
        Work = 0, Holiday = 1, OT = 2,Stop = 3
    }
}
