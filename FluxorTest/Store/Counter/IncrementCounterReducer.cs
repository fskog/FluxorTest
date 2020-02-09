using Blazor.Fluxor;

namespace FluxorTest.Store.Counter
{
	public class IncrementCounterReducer : Reducer<CounterState, IncrementCounterAction>
	{
		public override CounterState Reduce(CounterState state, IncrementCounterAction action) =>
			new CounterState(state.ClickCount + 1);
	}
}
