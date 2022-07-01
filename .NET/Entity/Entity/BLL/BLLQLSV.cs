using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;

namespace Entity.BLL
{
    public class BLLQLSV
    {
        private static BLLQLSV _Instance;
        quanlysinhvienEntities db;
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
            db = new quanlysinhvienEntities();
        }
        public List<CBBItem> GetCBB()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (LopSH i in db.LopSHes.ToList())
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
            if (checkAdd(sv.MSSV))
            {
                db.SVs.Add(sv);
            }
            else
            {
                var s = db.SVs.Where(p => p.MSSV == sv.MSSV).FirstOrDefault();
                s.NameSV = sv.NameSV;
                s.ID_Lop = sv.ID_Lop;
                s.DTB = sv.DTB;
            }
            db.SaveChanges();
        }

        private bool checkAdd(string mSSV)
        {
            foreach (SV i in db.SVs.ToList())
            {
                if (i.MSSV == mSSV)
                {
                    return false;
                }
            }
            return true;
        }
        public void DeleteSV(string mssv)
        {
            var s = db.SVs.Where(p => p.MSSV == mssv).FirstOrDefault();
            db.SVs.Remove(s);
            db.SaveChanges();
        }
        public string GetIDLopByTenLSH(string NameLop)
        {
            var s = db.LopSHes.Where(p => p.NameLop == NameLop).FirstOrDefault();
            return ((LopSH)s).ID_Lop;
        }

        public List<SV> GetSVByIDLop(string ID_lop, string txt)
        {
            List<SV> list = new List<SV>();
            if (ID_lop == "") //without ID Lop
            {
                var l = db.SVs.Where(p => p.NameSV.Contains(txt));
                //var l1 = from p in db.SVs
                //         where p.NameSV.Contains(txt)
                //         select p;
                list = l.ToList();
            }

            else
            {
                var l = db.SVs.Where(p => (p.ID_Lop == ID_lop) && p.NameSV.Contains(txt));
                //var l1 = from p in db.SVs
                //         where ((p.ID_Lop == ID_lop) && p.NameSV.Contains(txt))
                //         select p;
                list = l.ToList();
            }            
            return list;
        }
        public List<SVView> GetSVViewByIDLop(string ID_Lop, string txt)
        {
            List<SVView> list = new List<SVView>();
            foreach (SV i in GetSVByIDLop(ID_Lop, txt))
            {
                list.Add(new SVView
                {
                    MSSV = i.MSSV,
                    NameSV = i.NameSV,
                    NameLop = i.LopSH.NameLop
                });
            }
            return list;
        }
        public string GetNameLopByIDLop(string iD_Lop)
        {
            foreach (LopSH i in db.LopSHes.ToList())
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
            var s = db.SVs.Where(p => p.MSSV == MSSV).FirstOrDefault();
            return s;
        }
        public List<SVView> SortSV(string ID_Lop, string txt)
        {
            List<SVView> list = new List<SVView>();
            foreach (SV i in GetSort(ID_Lop, txt))
            {
                list.Add(new SVView
                {
                    MSSV = i.MSSV,
                    NameSV = i.NameSV,
                    NameLop = i.LopSH.NameLop
                });
            }
            return list;

        }
        public List<SV> GetSort(string ID_lop, string txt)
        {
            List<SV> list = new List<SV>();
            //var l1 = from p in db.SVs
            //         where (p.ID_Lop == ID_lop) && p.NameSV.Contains(txt)
            //         orderby p.NameSV
            //         select p;
            var l1 = db.SVs.Where(p => (p.ID_Lop == ID_lop) && p.NameSV.Contains(txt))
                    .OrderBy(p => p.NameSV);
            list = l1.ToList();
            return list;
        }
    }
}
