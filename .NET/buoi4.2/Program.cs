using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi4_2
{
    public class Program
    {   
        public delegate bool Compare(object o1, object o2);
        public static void Sort(object[] arr, Compare cmp) {
        for (int i = 0; i < arr.Length; i++) {
            for (int j = i + 1; j < arr.Length; j++) {
                //if(arr[i].MSSV > arr[j].MSSV) 
                //if(SV.compareMSSV(arr[i], arr[j]))
                if(cmp(arr[i], arr[j]))
                {
                    object temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
        static void Main(string[] args) {
            SV[] arr = 
            {
                new SV {MSSV = 2, Name = "B"},
                new SV {MSSV = 1, Name = "A"},
                new SV {MSSV = 3, Name = "C"}
            };
            Sort(arr, SV.CompareName);
            foreach(SV i in arr) {
                Console.WriteLine(i.ToString());
            }

        }
    }
}