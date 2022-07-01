using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceNewspaper
{
    public class Database
    {
        private static Database _Instance; 
        public static Database Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Database();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DT { get; set; }
        private Database()
        {
            DT = new DataTable();
            DT.Columns.AddRange(new DataColumn[] {
                new DataColumn {ColumnName = "ID", DataType = typeof(string)},
                new DataColumn {ColumnName = "NameDA", DataType = typeof(string)},
                new DataColumn {ColumnName = "SV", DataType = typeof(string)},
                new DataColumn {ColumnName = "HuongNC", DataType = typeof(string)},
                new DataColumn {ColumnName = "GVHD", DataType = typeof(string)},
                new DataColumn {ColumnName = "Status", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Year", DataType = typeof(int)},
            });
            DT.Rows.Add("101", "Robotic and AI", "Nguyen An", "AI", "Dang Hoai Phuong", true, 2020);
            DT.Rows.Add("104", "Web Đăng ký tín chỉ", "Nguyen Binh", "Web", "Le Thi My Hanh", false, 2021);
            DT.Rows.Add("102", "Iphone 100+", "Le Ce", "Mobile", "Nguyen Van Nguyen", true, 2021);
            DT.Rows.Add("103", "Automatic", "Phan Dat", "AI", "Nguyen Van Hieu", true, 2022);
            DT.Rows.Add("105", "OOP and future", "Phan Thanh", "OOP", "Dang Hoai Phuong", false, 2020);
            DT.Rows.Add("106", "Emotional Robot", "Tran Nga", "AI", "Pham Minh Tuan", false, 2020);
        }
        public void AddRow(Doan doan) 
        {
            DT.Rows.Add(doan.ID, doan.NameDA, doan.SV, doan.HuongNC, doan.GVHD, doan.Status, doan.Year);
        }
        public void EditRow(Doan p)
        {
            foreach (DataRow i in DT.Rows)
            {
                if (i["ID"].ToString() == p.ID)
                {
                    i["NameDA"] = p.NameDA;
                    i["SV"] = p.SV;
                    i["HuongNC"] = p.HuongNC;
                    i["GVHD"] = p.GVHD;
                    i["Status"] = p.Status;
                    i["Year"] = p.Year;
                    break;
                }
            } 
        }
        public void DelRow(string id)
        {
            foreach (DataRow i in DT.Rows)
            {
                if (i["ID"].ToString() == id)
                {
                    i.Delete();
                    break;
                }
            }
        }
    }
}
