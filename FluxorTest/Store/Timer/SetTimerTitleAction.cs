using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.Timer
{
    public class SetTimerTitleAction
    {
        public string Title;
        public SetTimerTitleAction(string title)
        {
            Title = title;
        }
    }

    namespace SetTimerTitle
    {
        public static class Reducers
        {
            [ReducerMethod]
            public static TimerState ReduceSetTimerTitleAction(TimerState state, SetTimerTitleAction action)
            {
                var timer = state.Timer;
                timer.Title = action.Title;
                return new TimerState(timer);
            }
        }
    }

}
