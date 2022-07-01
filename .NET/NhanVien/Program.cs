using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _NhanVien
{
    public class Program
    {
        static void Main(string[] args) {
            //Quan ly nhan vien cong ty
            QLNV db = new QLNV();
            NV nv1 = new NV { maNV = "NV1", Name = "Nguyen Van A", Age = 20 };
            NV nv2 = new NV { maNV = "NV2", Name = "Le Van B", Age = 25 };
            NV nv3 = new NV { maNV = "NV3", Name = "Ho Thi C", Age = 15 };
            db.Add(nv1);
            db.Add(nv2);
            db.Add(nv3);
            Console.WriteLine(db.length);
            db.Insert(4, nv1);
            Console.WriteLine(db.length);
            Console.WriteLine(db.ToString());
            Console.WriteLine("Vi tri cua nhan vien: " + db.IndexOf(nv2));

            //db.RemoveAt(2);
            //Console.WriteLine(db.length);
            //Console.WriteLine(db.ToString());
            //db.Remove(nv1);
            //Console.WriteLine(db.length);
            //Console.WriteLine(db.ToString());

            Console.WriteLine();
            //db.Update(nv2);
            //Console.WriteLine(db.ToString());

            db.Sort();
            Console.WriteLine(db.ToString());
        }
    }
}