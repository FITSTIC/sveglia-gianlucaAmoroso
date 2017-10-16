using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlarmClock sveglia = new AlarmClock();
            string dateFormat = "dd/MM/yyyy HH:mm:ss";
            sveglia.PowerOn();
            sveglia.Time = DateTime.Now.ToString(dateFormat);
            sveglia.AlarmTime = new DateTime(2017, 10, 9, 8, 0, 0).ToString(dateFormat);

            
            Console.WriteLine("Premi un tasto per terminare...");
            Console.ReadLine();

            sveglia.PowerOff();
        }
    }
}
