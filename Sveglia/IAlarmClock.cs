using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia
{
    public interface IAlarmClock
    {
        string Time { set; }
        string AlarmTime { set; }

        void PowerOn();

        void PowerOff();
    }
}
