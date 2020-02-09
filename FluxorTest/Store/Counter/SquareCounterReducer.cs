using Blazor.Fluxor;

namespace FluxorTest.Store.Counter
{
    public class SquareCounterReducer : Reducer<CounterState, SquareCounterAction>
    {
        public override CounterState Reduce(CounterState state, SquareCounterAction action) =>
            new CounterState(state.ClickCount * state.ClickCount);
    }
}
