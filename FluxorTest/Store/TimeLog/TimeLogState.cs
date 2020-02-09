using FluxorTest.Models;
using System.Collections.Generic;

namespace FluxorTest.Store.TimeLog
{
    public class TimeLogState
    {
        public List<Models.Timer> TimeLog { get; private set; }
        public TimeLogState(List<Models.Timer> timeLog)
        {
            TimeLog = timeLog;
        }
    }
}
