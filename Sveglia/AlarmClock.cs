using System;
using System.Threading;

namespace Sveglia
{
    internal class AlarmClock : IAlarmClock
    {
        private Timer timer;
        
        public AlarmClock()
        {
            timer = new Timer(TimerClick, null, 0, 24 * 60 * 60 * 1000);
        }

        private void TimerClick(object state)
        {

        }

        public string Time { set => throw new NotImplementedException(); }
        public string AlarmTime { set => throw new NotImplementedException(); }

        public void PowerOff()
        {
            throw new NotImplementedException();
        }

        public void PowerOn()
        {
            throw new NotImplementedException();
        }
    }
}