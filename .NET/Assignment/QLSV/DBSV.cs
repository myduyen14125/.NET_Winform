using System;
using System.Data;
using System.Windows.Forms;

namespace QLSV
{
    public class DBSV //nếu khai báo như ri thì cí thể khởi tạo được nhiều đối tượng DBSV -> không đồng bộ được dữ liệu -> DBSV là CSDL -> Nên chỉ 
        //được khởi tạo duy nhất 1 CSDL -> sử dụng Design pattern singleton -> Instanse
    {
        private static DBSV _Instance; //đối tượng duy nhất singleton ở đaay
        public static DBSV Instance
        {
            get
            {
                if (_Instance == null) //Khoi tao duy nhat 1 doi tuong Instance - la CSDL cho bai 
                {
                    _Instance = new DBSV();
                }
                return _Instance;
            }
            private set { } //set gia tri de private 
        }
        public DataTable DTSV { get; set; }
        private DBSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[] //khởi tạo column -> row
            {
                new DataColumn {ColumnName = "MSSV", DataType = typeof(string)},
                new DataColumn {ColumnName = "Name", DataType = typeof (string)},
                new DataColumn {ColumnName = "Class", DataType = typeof(string)},
                new DataColumn {ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Date of birth", DataType= typeof(DateTime)},
                new DataColumn {ColumnName = "Avg score", DataType = typeof(double)},
                new DataColumn {ColumnName = "Photo", DataType = typeof(bool)},
                new DataColumn {ColumnName = "School profile", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Citizen ID", DataType = typeof(bool)},
            });
            DTSV.Rows.Add("102200001", "Nguyen An", "20T", true, DateTime.Now, 9.1, true, false, true);
            DTSV.Rows.Add("102200003", "Nguyen Binh", "21T", true, DateTime.Now, 9.2, true, false, true);
            DTSV.Rows.Add("102200002", "Nguyen Binh", "20T", false, DateTime.Now, 9.2, true, false, true);
            DTSV.Rows.Add("102200004", "Le Ca", "19T", false, DateTime.Now, 9.5, true, true, true);
            DTSV.Rows.Add("102200007", "Phan Lien", "19T", true, DateTime.Now, 8.0, false, true, true);
        }
        public void AddRow(SV s)
        {
            DTSV.Rows.Add(s.MSSV, s.Name, s.Class, s.Gender, s.DateOfBirth, s.AvgScore, s.Photo, s.SchoolProfile, s.CitizenID);
        }
        public void UpdateRow(SV s)
        {
            foreach (DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == s.MSSV)
                {
                    i["Name"] = s.Name;
                    i["Class"] = s.Class;
                    i["Gender"] = s.Gender;
                    i["Date of birth"] = s.DateOfBirth;
                    i["Avg score"] = s.AvgScore;
                    i["Photo"] = s.Photo;
                    i["School profile"] = s.SchoolProfile;
                    i["Citizen ID"] = s.CitizenID;
                    break;
                }
            }
        }
        public void DelRow(string MSSV)
        {
            foreach (DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == MSSV)
                {
                    i.Delete();
                    break;
                }
            }
        }

    }
}
