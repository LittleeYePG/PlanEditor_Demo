using DevExpress.XtraScheduler;
using PlanEditor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEditor
{
    public class MyCustomScale : TimeScaleHour
    {
        //private  mstCalendarDB calendarDB = new Data.mstCalendarDB();
        public MyCustomScale() { }

        public override string DisplayName { get => "Custom Work Hours"; set => base.DisplayName = value; }
        public override string MenuCaption { get => "Custom Work Hours"; set => base.MenuCaption = value; }

        public override string FormatCaption(DateTime start, DateTime end)
        {
            if (start.Hour <= 12) return start.Hour.ToString() + " AM";
            else return (start.Hour - 12).ToString() + " PM";
        }
        public override bool IsDateVisible(DateTime date)
        {
            TimeSpan Start = Funcion.clsCFunction.OTDB.GetMinTime(date); //Funcion.clsCFunction.StartTime;

            TimeSpan End = Funcion.clsCFunction.OTDB.GetMaxTime(date);


            if (!Funcion.clsCFunction.ShowHoliday)
            {
                if (Funcion.clsCFunction.FindHoliday(date.Date) && !Funcion.clsCFunction.CheckOTDay(date.Date))
                {
                    return false;
                }
                else if (Funcion.clsCFunction.FindHoliday(date.Date) && Funcion.clsCFunction.CheckOTDay(date.Date))
                {
                    Start = Funcion.clsCFunction.OTDB.GetMinTimeOT(date);
                    End = Funcion.clsCFunction.OTDB.GetMaxTimeOT(date);
                }
            }

            if (date.Hour >= Start.Hours && date.Hour <= End.Hours)
                return true;
            else return false;
        }
    }
}
