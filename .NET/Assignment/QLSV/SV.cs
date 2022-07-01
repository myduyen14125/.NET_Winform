using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class SV
    {
        private string _MSSV;
        private string _NameSV;
        private string _LopSH;
        private bool _Gender;
        private DateTime _Ngaysinh;
        private double _DTB;
        private bool _Anh;
        private bool _Hocba;
        private bool _CMND;

        public string MSSV { get; set; }
        public string Name { get; set; } 
        public string Class { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double AvgScore { get; set; } 
        public bool Photo { get; set; }
        public bool SchoolProfile { get; set; }
        public bool CitizenID { get; set; }
              
    }
}
