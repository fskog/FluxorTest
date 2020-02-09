using Blazor.Fluxor;
using FluxorTest.Store.Timer;
using System;

namespace FluxorTest.Store.Timer
{
    public class SetTimerCategoryAction
    {
        public Guid SystemId;
        public SetTimerCategoryAction(Guid systemId)
        {
            SystemId = systemId;
        }
    }

    namespace SetTimerCategory
    {
        public static class Reducers
        {
            [ReducerMethod]
            public static TimerState ReduceSetTimerCategoryAction(TimerState state, SetTimerCategoryAction action)
            {
                var timer = state.Timer;
                timer.CategorySystemId = action.SystemId;
                return new TimerState(timer);
            }
        }
    }

}
