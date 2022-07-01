using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi2
{
    public class SVCNTT : SV
    {
        public bool LT { get; set; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("LT" + LT);
            
        }
    }
}