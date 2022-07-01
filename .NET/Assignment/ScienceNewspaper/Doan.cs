using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceNewspaper
{
    public class Doan
    {
        private string _ID;
        private string _NameDA;
        private string _SV;
        private string _HuongNC;
        private string _GVHD;
        private int _Status;
        private string _Year;

        public string ID { get; set; }
        public string NameDA { get; set; }
        public string SV { get; set; }
        public string HuongNC { get; set; }  
        public string GVHD { get; set; }
        public bool Status { get; set; }
        public int Year { get; set; }  
        
    }
}
