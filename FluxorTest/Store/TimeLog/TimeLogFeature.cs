using Blazor.Fluxor;
using System;
using System.Collections.Generic;

namespace FluxorTest.Store.TimeLog
{
    public class TimeLogFeature : Feature<TimeLogState>
    {
        public override string GetName() => "TimeLog";
        protected override TimeLogState GetInitialState()
        {

            var timeLog = new List<Models.Timer>();

            for (int i = 0; i < 12; i++)
            {
                var t = (int)i % 5;
                var date = DateTime.Now;
                var time = new Models.Timer()
                {
                    StartTime = date.AddDays(-t),
                    EndTime = date.AddDays(-t).AddHours(i),
                    Title = $"Task {i}",
                    SystemId = Guid.NewGuid()
                };
                timeLog.Add(time);
            }

            return new TimeLogState(timeLog);
        }
    }
}
