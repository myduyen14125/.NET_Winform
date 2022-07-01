using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi4
{
    public class AnalogClock
    {
        public void ShowAC(object o, TimeEventArgs e) {
            Console.WriteLine("AC: {0}:{1}:{2}:{3}", e.timer.Hour, e.timer.Minute, e.timer.Second, e.timer.Millisecond);
         }
    }
}