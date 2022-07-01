using _3layers.DTO;
using _3layers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3layers.BLL
{
    public class BLLQLSV
    {
        private static BLLQLSV _Instance;
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
        public BLLQLSV()
        {
        }
        public List<CBBItem> GetCBB ()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (LSH i in DALQLSV.Instance.GetAllLSH())
            {
                list.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                }); 
            }
            return list; 
        }
        
        public void AddorUpdateSV(SV sv)
        {
            //true - add, false - update
            if (checkAdd(sv.MSSV))
            {
                DALQLSV.Instance.AddSV(sv); 
            }
            else
            {
                DALQLSV.Instance.UpdateSV(sv);
            }
        }

        private bool checkAdd(string mSSV)
        {
            foreach (SV i in DALQLSV.Instance.GetAllSV())
            {
                if (i.MSSV == mSSV)
                {
                    return false;
                }
            }
            return true; 
        }

        internal int GetIDLopByTenLSH(string NameLop)
        {
            foreach (LSH i in DALQLSV.Instance.GetAllLSH())
            {
                if (i.NameLop == NameLop)
                {
                    return i.ID_Lop;
                }
            }
            return -1;
        }

        public void DeleteSV(string mssv)
        {
            DALQLSV.Instance.DeleteSV(mssv); 
        }

        public List<SV> GetSVByIDLop(int ID_lop,string txt)
        {
            List<SV> list = new List<SV>(); 
            if (ID_lop==0)
            {
                if (txt=="")
                {
                    list = DALQLSV.Instance.GetAllSV();
                }
                else
                {
                    foreach (SV i in DALQLSV.Instance.GetAllSV())
                    {
                        if (i.NameSV.Contains(txt))
                        {
                            list.Add(i);
                        }
                    }
                }
            }
            else
            {
                foreach (SV i in DALQLSV.Instance.GetAllSV())
                {
                    if (i.ID_Lop==ID_lop&&i.NameSV.Contains(txt))
                    {
                        list.Add(i); 
                    }
                }
            }
            return list; 
        }
        public List<SVView> GetSVViewByIDLop(int ID_Lop, string txt)
        {
            List<SVView> list = new List<SVView>(); 
            foreach (SV i in GetSVByIDLop(ID_Lop,txt))
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

        public string GetNameLopByIDLop(int iD_Lop)
        {
            foreach (LSH i in DALQLSV.Instance.GetAllLSH())
            {
                if (i.ID_Lop==iD_Lop)
                {
                    return i.NameLop; 
                }
            }
            return "no"; 
        }

        public SV GetSVByMSSV(string MSSV)
        {
            foreach (SV i in DALQLSV.Instance.GetAllSV())
            {
                if (i.MSSV == MSSV)
                {
                    return i; 
                }
            }
            return null;
        }
    }
}
