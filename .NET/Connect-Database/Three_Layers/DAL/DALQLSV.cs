using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layers.DTO;

namespace Three_Layers.DAL
{
    public class DALQLSV
    {
        private static DALQLSV _Instance;
        private string connectionString;
        public static DALQLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALQLSV();
                }
                return _Instance;
            }
            private set { }
        }
        private DALQLSV() { 
        }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach(DataRow i in DBHelper.Instance.GetRecords("select * from SV").Rows)
            {
                data.Add(GetSVByDataRow(i));
            }
            return data;
        }
        public SV GetSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                DTB = Convert.ToInt32(i["DTB"].ToString())
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> data = new List<LSH>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from LSH").Rows)
            {
                data.Add(GetLSHByDataRow(i));
            }
            return data;
        }
        public LSH GetLSHByDataRow(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            };
        }
    }
}
