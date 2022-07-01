using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi2
{
    public class MyClass : IFile1, IFile2 //lop thua ke tu interface Ifile1, inplement interface
    {
        void IFile1.A()
        {
            Console.WriteLine("A");
        }

        void IFile2.A()
        {
            Console.WriteLine("AA");
        }

        void IFile1.A1()
        {
            Console.WriteLine("A1");
        }

        void IFile2.A2()
        {
            Console.WriteLine("A2");
        }

        void IFile1.B1()
        {
            Console.WriteLine("B1");
        }

        void IFile2.B2()
        {
            Console.WriteLine("B2");
        }
        public void M() { Console.WriteLine("M"); }
    }
}