using FluxorTest.Models;
namespace FluxorTest.Store.Timer
{
    public class TimerState
    {
        public Models.Timer Timer { get; private set; }
        public TimerState(Models.Timer timer)
        {
            Timer = timer;
        }
    }
}
