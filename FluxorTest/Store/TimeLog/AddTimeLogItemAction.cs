using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.TimeLog
{
	public class AddTimeLogItemAction
	{
		public Models.Timer NewTimer;
		public AddTimeLogItemAction(Models.Timer timer)
		{
			NewTimer = timer;
		}
	}

	namespace AddTimeLog
	{
		public static class Reducers
		{
			[ReducerMethod]
			public static TimeLogState ReduceAddTimeLogItemAction(TimeLogState state, AddTimeLogItemAction action)
			{
				var timeLog = state.TimeLog;
				timeLog.Add(action.NewTimer.Copy() as Models.Timer);
				return new TimeLogState(timeLog);
			}
		}
	}

}
