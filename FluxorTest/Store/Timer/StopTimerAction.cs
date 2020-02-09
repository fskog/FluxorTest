using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;
using FluxorTest.Store.TimeLog;
using System.Threading.Tasks;

namespace FluxorTest.Store.Timer
{
    public class StopTimerAction
    {
        public Models.Timer Timer;

        public StopTimerAction(Models.Timer timer)
        {
            Timer = timer;
        }
    }

    namespace StopTimer
    {
        public class Effects
        {
            [EffectMethod]
            protected async Task HandleStopTimerAction(StopTimerAction action, IDispatcher dispatcher)
            {
                dispatcher.Dispatch(new AddTimeLogItemAction(action.Timer));
            }
        }


        public static class Reducers
        {
            [ReducerMethod]
            public static TimerState ReduceStopTimerAction(TimerState state, StopTimerAction action)
            {
                var timer = state.Timer;
                timer.EndTime = DateTime.Now;
                return new TimerState(new Models.Timer());
            }
        }
    }
}
