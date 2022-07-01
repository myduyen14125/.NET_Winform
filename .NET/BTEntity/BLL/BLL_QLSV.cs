using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTEntity.DTO;

namespace BTEntity.BLL
{
    
    public class BLL_QLSV
    {
        private static BLL_QLSV _instance;

        demoQLSV db = new demoQLSV();

        public static BLL_QLSV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLSV();
                }
                return _instance;
            }
            private set { }
        }

        

        public List<SV> GetAllSV()
            {
            var list = db.SVs.Select(s => s);
            return list.ToList();
            }
        public List<SV> SearchSV(int ID_Lop,string txt)
        {
            
            if (ID_Lop == 0)
            {   var list1 = db.SVs.Where(s => s.NameSV.Contains(txt));
                return list1.ToList();
            }
            var list = db.SVs.Where(s => s.ID_Lop == ID_Lop && s.NameSV.Contains(txt));
            return list.ToList();
        }
        public List<LOP> GetAllLSH()
        {
           return db.LOPs.Select(p => p).ToList();
            
        }
        public List<SV_View> GetView(List<SV> data)
        {   
            List<SV_View> res = new List<SV_View> ();
           foreach ( SV i in data)
            {
                res.Add(new SV_View
                {
                    MSSV = i.MSSV,
                    NameSV = i.NameSV,
                    NameLop = i.LOP.NameLop,
                    DTB  = (double)i.DTB,
                });
            }
           return res;
        }
        public SV GetSVByMSSV(string MSSV)
        {
            SV sv = null;
            sv = db.SVs.Find(MSSV);
            return sv;
        }
        public void DeleteSV(List<string> del)
        {
            foreach (string i in del)
            {
                SV s = db.SVs.Find(i);
                db.SVs.Remove(s);
                db.SaveChanges();
            }
        }
        public LOP GetLopByID(int ID_Lop)
        {
            return db.LOPs.Find(ID_Lop);

        }
        public void AddUpdate(SV s)
        {
            if (db.SVs.Find(s.MSSV) != null)

            {
                UpdateSV(s);

            }
            else AddSV(s);
        }
        public List<SV> SortSV(List<string> listnow, string SortType)
        {
            List<SV> sv = new List<SV>();
            foreach (string i in listnow)
            {
                sv.Add(db.SVs.Find(i));
            }
            switch (SortType)
            {
                case "Tên":
                    {
                        return sv.OrderBy(s => s.NameSV).ToList();
                    }
                case "Lớp":
                    {
                        return sv.OrderBy(s => s.LOP.NameLop).ToList();
                    }
                case "MSSV":
                    {
                        return sv.OrderBy(s => s.MSSV).ToList();

                    }
                case "Điểm trung bình":
                    {
                        return sv.OrderBy(s => s.DTB).ToList();
                    }
                default:
                    return sv;

            }
        }
        public void AddSV(SV s)
        {
            db.SVs.Add(s);
            db.SaveChanges();
        }
        public void UpdateSV(SV s)
        {
            var curr = db.SVs.Find(s.MSSV);
            curr.NameSV = s.NameSV;
            curr.CCNN = s.CCNN;
            curr.DTB = s.DTB;
            curr.LOP = s.LOP;
            curr.ID_Lop = s.ID_Lop;
            curr.Anh = s.Anh;
            curr.Gender = s.Gender;
            curr.NgaySinh = s.NgaySinh;
            curr.LOP = s.LOP;
            db.SaveChanges();
        }

    }

}
