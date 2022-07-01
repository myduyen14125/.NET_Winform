using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi2
{
    public class SV
    {
        public int MSSV { get; set; }
        public string Name { get; set; }
        public virtual void Show() {
            Console.WriteLine("MSSV: {0}; Name: {1}", MSSV, Name);
        }
        public override string ToString() {
            return "MSSV: " + MSSV +  " Name: " + Name;
        }
    }
    

}