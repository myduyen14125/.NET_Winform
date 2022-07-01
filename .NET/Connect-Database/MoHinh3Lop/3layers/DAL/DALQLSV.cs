using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using _3layers.DTO; 

namespace _3layers.DAL
{
    public class DALQLSV
    {
        private static DALQLSV _Instance;
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
        public DALQLSV()
        {
        }
        public List<SV> GetAllSV()
        {
            List<SV> list = new List<SV>(); 
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from SV").Rows)
            {
                list.Add(GetSVByDataRow(i)); 
            }
            return list;
        }

        private SV GetSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                DTB = Convert.ToDouble(i["DTB"].ToString())
            }; 
        }

        public void AddSV(SV sv)
        {
            string query = $"insert into SV (MSSV, NameSV, ID_Lop, DTB) values ('{sv.MSSV}','{sv.NameSV}','{sv.ID_Lop}',{sv.DTB})";
            DBHelper.Instance.ExecuteDB(query); 
        }
        public void UpdateSV(SV sv)
        {
            string query = $"update SV set NameSV = '{sv.NameSV}', ID_Lop = '{sv.ID_Lop}', DTB = {sv.DTB} where MSSV = '{sv.MSSV}'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DeleteSV(string mssv)
        {
            string query = "delete from SV where MSSV = '"+mssv+"'";
            DBHelper.Instance.ExecuteDB(query);
        }

        public List<LSH> GetAllLSH()
        {
            List<LSH> list = new List<LSH>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from LopSH").Rows)
            {
                list.Add(GetLSHByDataRow(i));
            }
            return list;
        }

        private LSH GetLSHByDataRow(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            }; 
        }
    }
}
