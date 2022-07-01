using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi4
{
    public class TimeEventArgs : EventArgs
    {
        public DateTime timer { get; set; }
        public TimeEventArgs(DateTime d) {
            timer = d;
        }
    }
}