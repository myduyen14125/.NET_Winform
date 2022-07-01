using System;

class Program {
    static void Main(string[] args) {
        // Console.WriteLine("ITF");
        // Console.Write("DUT");
        // int x = 1, y = 2;
        // Console.WriteLine("x = " + x);
        // Console.WriteLine("x = {0}", x);
        // Console.WriteLine("x = {0}, y = {1}", x, y);
        //Read(); ReadLine(); ReadKey(); 
        // int x; 
        // Console.Write("x = ");
        // x = Console.Read(); //tra ve gia tri cua input nhap vao trong ascii
        // Console.WriteLine("x = {0}", x);
        // string y;  
        // Console.Write("y = ");
        // y = Console.ReadLine();
        // Console.WriteLine("y = {0}", y);
        //=======================
        // int x = 100;
        // object obj = new object();
        // obj = x; //boxing: biến giá trị x được gán vô cho obj là kiểu tham chiếu 
        // Console.WriteLine("x = {0}, obj = {1}", x, obj);
        // object obj; //reference type
        // int x = 100;
        // obj = x; //boxing
        // int y = (int)obj; //unboxing
        // Console.WriteLine("x = {0}, obj = {1}, y = {2}", x, obj, y);
        //---------------------- 
        // int m = 1, n = 2;
        // int t; //biến t k có giá trị 
        // swap(ref m, ref n);
        // add(out t);
        // Console.WriteLine("m = {0}, n = {1}, t = {2}", m, n, t);
        //======== ==
        // int x; 
        // Console.Write("input x = ");
        // x = int.Parse(Console.ReadLine());
        // Console.WriteLine("x + 1 = {0}", x + 1);
        // int y; 
        // Console.Write("input y = ");
        // //bool -> true/false
        // int.TryParse(Console.ReadLine(), out y);
        // Console.WriteLine("y + 1 = {0}", y + 1);
        //----------- 
        int x; string y = "123";
        x = Convert.ToInt32(y);
        Console.WriteLine(x + 1);
    }
}