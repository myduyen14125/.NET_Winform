using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _NhanVien
{
    public class NV
    {
        public string maNV { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public NV() {
            maNV = "";
            Name = "";
            Age = 0;
        }
        public NV(string maNV, string Name, int Age) {
            this.maNV = maNV;
            this.Name = Name;
            this.Age = Age;
        }
        public bool compare(NV o) {
            if (maNV == o.maNV && Name == o.Name && Age == o.Age) 
                return true;
            else return false;
        }
    }
}