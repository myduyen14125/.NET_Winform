using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceNewspaper
{
    public class ListManage
    {
        public List<Doan> GetAllDoan()
        {
            List<Doan> data = new List<Doan>();
            foreach (DataRow i in Database.Instance.DT.Rows)
            {
                data.Add(GetDoanByDataRow(i));
            }
            return data;
        }
        public Doan GetDoanByDataRow(DataRow i)
        {
            Doan p = new Doan();

            p.ID = i["ID"].ToString();
            p.NameDA = i["NameDA"].ToString();
            p.SV = i["SV"].ToString();
            p.HuongNC = i["HuongNC"].ToString();
            p.GVHD = i["GVHD"].ToString();
            p.Status = Convert.ToBoolean(i["Status"].ToString());
            p.Year = Convert.ToInt32(i["Year"].ToString());
            return p;
        }
        public List<Doan> GetDoanByFilter(string huongNC, string status, string GVHD, string txt)
        {
            List<Doan> data = new List<Doan>();
            bool checkStatus = true;
            if (status != "All")
            {
                if (status == "True") checkStatus = true;
                else checkStatus = false;
            }
            ///111 => All
            if (huongNC == "All" && status == "All" && GVHD == "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //101 => tim theo status
            if (huongNC == "All" && status != "All" && GVHD == "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.Status == checkStatus && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //110 => tim theo GVHD
            if (huongNC == "All" && status == "All" && GVHD != "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.GVHD == GVHD && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //100 tim theo gvhd va tinh trang
            if (huongNC == "All" && status != "All" && GVHD != "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.Status == checkStatus && i.GVHD == GVHD && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //011 -> tim theo huong nc
            if (huongNC != "All" && status == "All" && GVHD == "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.HuongNC == huongNC && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //001 => tim theo huong nc va tinh trang
            if (huongNC != "All" && status != "All" && GVHD == "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.HuongNC == huongNC && i.Status == checkStatus && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //010 => tim theo huong nc va gvhd
            if (huongNC != "All" && status == "All" && GVHD != "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.HuongNC == huongNC && i.GVHD == GVHD && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            //000 tim theo ca 3
            if (huongNC != "All" && status != "All" && GVHD != "All")
            {
                foreach (Doan i in GetAllDoan())
                {
                    if (i.HuongNC == huongNC && i.Status == checkStatus && i.GVHD == GVHD && i.NameDA.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }

            return data;
        }
        public List<string> GetAllHuongNC()
        {
            List<string> data = new List<string>();
            foreach (Doan i in GetAllDoan())
            {
                data.Add(i.HuongNC);
            }
            return data;
        }
        public List<string> GetAllGVHD()
        {
            List<string> data = new List<string>();
            foreach (Doan i in GetAllDoan())
            {
                data.Add(i.GVHD);
            }
            return data;
        }
        public List<string> GetGVHDByHuongNC(string huongNC)
        {
            List<string> data = new List<string>();
            foreach (Doan i in GetAllDoan())
            {
                if (i.HuongNC == huongNC)
                {
                    data.Add(i.GVHD);
                }
            }
            return data;
        }
        public List<int> GetAllYear()
        {
            List<int> data = new List<int>();
            foreach (Doan i in GetAllDoan())
            {
                data.Add(i.Year);
            }
            return data;
        }
        public List<bool> GetAllStatus()
        {
            List<bool> data = new List<bool>();
            foreach (Doan i in GetAllDoan())
            {
                data.Add(i.Status);
            }
            return data;
        }

        public Doan GetDoanByID(string ID)
        {
            Doan p = new Doan();
            foreach (Doan i in GetAllDoan())
            {
                if (i.ID == ID)
                {
                    p = i;
                    break;
                }
            }
            return p;
        }
        public bool AddOrEdit(string ID) //kiem tra xem la add hay edit -> neu la add thi them sv vo bang, edit thi sua sv no thou 
        {
            bool checkAdd = true;
            foreach (Doan i in GetAllDoan())
            {
                if (i.ID == ID)
                {
                    checkAdd = false;
                }
            }
            return checkAdd;
        }
        public void ExecuteDB(Doan p)
        {
            if (AddOrEdit(p.ID)) //neu checkAdd = true 
                Database.Instance.AddRow(p);
            else
                Database.Instance.EditRow(p);
        }
        public void DelDoan(List<string> del)
        {
            foreach (string i in del)
            {
                Database.Instance.DelRow(i);
            }
        }
    }
}
