using System;

namespace FluxorTest.Models
{
    public class Timer
    {
        public Guid SystemId = Guid.NewGuid();
        public string Title = "";
        public DateTime StartTime;
        public DateTime EndTime;
        public Guid CategorySystemId;



        public bool IsRunning => StartTime > DateTime.MinValue && EndTime == DateTime.MinValue;
        public TimeSpan Elapsed => IsRunning ? DateTime.Now - StartTime : EndTime - StartTime;
        public string ElapsedFormatted => Elapsed.ToString((Elapsed.TotalHours >= 1 ? "hh' h '" : "") + (Elapsed.Minutes > 0 ? "m' min '" : "") + "s' sec '");
    
        public object Copy()
        {
            return this.MemberwiseClone();
        }
    }
}
