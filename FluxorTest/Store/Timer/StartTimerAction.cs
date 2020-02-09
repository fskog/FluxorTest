using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.Timer
{
    public class StartTimerAction
    {
    }

	namespace StartTimer {
		public static class Reducers
		{
			[ReducerMethod]
			public static TimerState ReduceStartTimerAction(TimerState state, StartTimerAction action)
			{
				var timer = state.Timer;
				timer.StartTime = DateTime.Now;
				return new TimerState(timer);
			}
		}
	}
	
}
