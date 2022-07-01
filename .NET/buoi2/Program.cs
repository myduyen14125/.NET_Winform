using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi2
{
    public class Program
    {
        static void Main(string[] args) {
            MyClass o = new MyClass();
            o.M(); 
            //o.A();//khong truy cap duoc
            IFile1 f1 = (IFile1)o; //upcast: myclass -> Ifile. 
            f1.A(); //van in ra cua lop con
            //f1.C1(); => loi khong ep duoc 
            IFile2 f2 = (IFile2)o; //upcast: myclass -> Ifile
            f2.A();
            //Cais list duoc c# cung cap - thay the cho QLNV,... 
            List<SV> li = new List<SV>();
            
        }
    }
}