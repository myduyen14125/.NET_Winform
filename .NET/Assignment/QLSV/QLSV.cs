using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class QLSV
    {
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow i in DBSV.Instance.DTSV.Rows) //DBSV.Instance: tao mot instance duy nhat la DBSV - chinh la CSDL
            {
                data.Add(GetSVByDataRow(i)); 
                //lấy ra 1 sinh viên từ 1 dòng bằng hàm GetSVBYDataRow -> sau đó thêm sv vô list <SV> Data
            }
            return data;
        }
        public SV GetSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(), //lay o trong hang -> gan gia tri vo cho 1 doi tuong SV 
                Name = i["Name"].ToString(),
                Class = i["Class"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                DateOfBirth = Convert.ToDateTime(i["Date of birth"].ToString()),
                AvgScore = Convert.ToDouble(i["Avg score"].ToString()),
                Photo = Convert.ToBoolean(i["Photo"].ToString()),
                SchoolProfile = Convert.ToBoolean(i["School profile"].ToString()),
                CitizenID = Convert.ToBoolean(i["Citizen ID"].ToString()),
                //or we can get cell i by index: like i[0], i[1]....
            };
        }
        public List<SV> GetSVByClass(string LopSH, string txt = "") //thêm string txt để phục vụ cho hàm search 
        {
            List<SV> data = new List<SV>(); //sử dụng tầng trung gian -> dễ scale, lớp trung gian thông qua class SV và QLSV để nối với SV 
            if (LopSH == "All")
            {
                foreach(SV i in GetAllSV())
                {
                    if(i.Name.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            else
            {
                foreach(SV i in GetAllSV()) //cho sv i trong Lay tat ca sv
                {
                    if (i.Class == LopSH)
                    {
                        data.Add(i); //neu thuoc tinh lop = lop sh truyen vao => them vao list data => chi hoat
                        //dong, lay du lieu tu list thoi
                    }
                }
            }
            return data;
        }
        public List<string> GetAllClass()
        {
            List<string> data = new List<string>();
            foreach(SV i in GetAllSV())
            {
                data.Add(i.Class);
            }
            return data;
        }
        public SV GetSVByMSSV(string MSSV)//tim sv bang MSSV
        {
            SV s = new SV();
            foreach(SV i in GetAllSV())
            {
                if (i.MSSV == MSSV)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }

        public bool AddOrUpdate(string MSSV) //kiem tra xem la add hay edit -> neu la add thi them sv vo bang, edit thi sua sv no thou 
        {
            bool checkAdd = true;
            foreach(SV i in GetAllSV())
            {
                if(i.MSSV == MSSV)
                {
                    checkAdd = false; 
                }
            }
            return checkAdd;
        }
        public void ExecuteDB(SV s)
        {
            if (AddOrUpdate(s.MSSV)) //neu checkAdd = true
            {
                DBSV.Instance.AddRow(s);
            }
            else
            {
                DBSV.Instance.UpdateRow(s);
            }
        }
        public void DelSV(List<string> del)
        {
            foreach(string i in del)
            {
                DBSV.Instance.DelRow(i);
            }
        }
        public List<SV> ListSVNow(List<string> now) //lay list chua mssv theo lop dang xem o vi tri hien tai 
        {
            List<SV> data = new List<SV> ();
            foreach (string i in now)
            {
                foreach (SV j in GetAllSV())
                {
                    if (i == j.MSSV) //neu 2 cai mssv bang nhau 
                    {
                        data.Add(j);
                    }
                }
            }
            return data;
        }
        //viet ham sort su dung Delegate doi voi ListSVNow
    }
}
