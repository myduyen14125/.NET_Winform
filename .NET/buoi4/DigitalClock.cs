using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi4
{
    public class DigitalClock
    {
        public void ShowDC(object o, TimeEventArgs e) {
            Console.WriteLine("DC: {0}:{1}:{2}:{3}", e.timer.Hour, e.timer.Minute, e.timer.Second, e.timer.Millisecond);
         }
    }
}