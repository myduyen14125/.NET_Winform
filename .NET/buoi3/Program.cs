using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi3
{
    public class Program
    {
        static void Main(string[] args) {
            try {
                f2();
            }
            catch (DivideByZeroException dex) {//specific exceptions
                Console.WriteLine("Divide by zero exception: " + dex.StackTrace);
            }
            catch (Exception ex) {//general exceptions
                Console.WriteLine("General Exception: " + ex.Message);
            }
        }
        static void f2() {
            f1();
        }
        static void f1() {
            int a = 5;
            int b = 0;
            Console.WriteLine(a/b);
        }

    }
}