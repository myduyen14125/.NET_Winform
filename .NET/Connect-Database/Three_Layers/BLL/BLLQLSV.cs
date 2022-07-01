using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layers.DTO;
using Three_Layers.DAL;

namespace Three_Layers.BLL
{
    class BLLQLSV
    {
        private static BLLQLSV _Instance;
        private string connectionString;
        public static BLLQLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLQLSV();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLQLSV()
        {

        }
        public List<CbbItem> GetCBB()
        {
            List<CbbItem> data = new List<CbbItem>();
            foreach(LSH i in DALQLSV.Instance.GetAllLSH())
            {
                data.Add(new CbbItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });
            }
            return data;
        }
        public List<SV> GetSVByIDLop(int ID_Lop)
        {
            List<SV> data = new List<SV>();
            if (ID_Lop == 0)
            {
                data = DALQLSV.Instance.GetAllSV();
            }
            else
            {
                foreach (SV i in DALQLSV.Instance.GetAllSV())
                {
                    if (i.ID_Lop == ID_Lop)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        public List<SVView> GetSVViewByIDLop(int ID_Lop)
        {
            List<SVView> list = new List<SVView>();
            foreach (SV i in GetSVByIDLop(ID_Lop))
            {
                list.Add(new SVView
                {
                    MSSV = i.MSSV,
                    NameSV = i.NameSV,
                    NameLop = GetNameLopByIDLop(i.ID_Lop)
                });
            }
            return list;
        }

        private string GetNameLopByIDLop(int iD_Lop)
        {
            foreach (LSH i in DALQLSV.Instance.GetAllLSH())
            {
                if (i.ID_Lop == iD_Lop)
                {
                    return i.NameLop;
                }
            }
            return "no";
        }
        public SV GetSVByMSSV(string MSSV)
        {
            SV s = null;
            foreach (SV i in DALQLSV.Instance.GetAllSV())
            {
                if (i.MSSV == MSSV) s = i;
            }
            return s;
        }
    }
}
