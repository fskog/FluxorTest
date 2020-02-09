using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.TimeLog
{
	public class RemoveTimeLogItemAction
	{
		public Guid systemId;
		public RemoveTimeLogItemAction(Guid systemId)
		{
			this.systemId = systemId;
		}
	}

	namespace RemoveTimeLogItem
	{
		public static class Reducers
		{
			[ReducerMethod]
			public static TimeLogState ReduceRemoveTimeLogItemAction(TimeLogState state, RemoveTimeLogItemAction action)
			{
				var timeLog = state.TimeLog;
				timeLog.Remove(timeLog.Find(x => x.SystemId == action.systemId));
				return new TimeLogState(timeLog);
			}
		}
	}

}
