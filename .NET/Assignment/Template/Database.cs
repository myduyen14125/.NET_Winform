using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Database
    {

        //Singleton Pattern là một design pattern mà

        //Đảm bảo rằng một class chỉ có duy nhất một instance
        //Và cung cấp một cáchs toàn cầu để truy cấp tới instance đó.
        private static Database _Instance; 
        //Private constructor của class đó để đảm bảo rằng class lớp khác không thể truy cập vào constructor và tạo ra instance mới
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
                new DataColumn {ColumnName = "Name", DataType = typeof(string)},
            });
            DT.Rows.Add("102200017", "Nguyen Hehe");
        }
        public void AddRow() //add some reference here
        {

        }
        public void EditRow()
        {
            foreach (DataRow i in DT.Rows)
            {

            } 
        }
        public void DelRow()
        {
            foreach (DataRow i in DT.Rows)
            {

            }
        }
    }
}
