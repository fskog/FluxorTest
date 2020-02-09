using Blazor.Fluxor;

namespace FluxorTest.Store.Timer
{
	public class TimerFeature : Feature<TimerState>
	{
		public override string GetName() => "Timer";
		protected override TimerState GetInitialState() => new TimerState(new Models.Timer());
	}
}
