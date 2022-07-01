using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_DB
{
    public class DataProvider
    {
        private static DataProvider _Instance;
        private string connectionString;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataProvider();
                }
                return _Instance;
            }
            private set { }
        }
        public DataProvider()//goi ham dung -> goi toi CSDL
        {
            connectionString = @"Data Source=.\;Initial Catalog=QLSV;Integrated Security=True";
        }
        //hàm ni để thực hiện câu lênh: insert, update, delete
        //Chiều thứ 2 để thay đổi CSDL 
        public string AddItem(string data)
        {
            string query = "insert into SV values(" + data + ")";
            return query;
        }
        public string EditItem(string data, string condition)
        {
            string query = " update SV set " + data + "where" + condition;
            return query;
        }

        public bool ExecuteDB(string query) //thường dùng trả về bool để kiểm tra xem có khởi tạo được DB hay không 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery(); //de goi insert, edit, del
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //hàm để thực hiện câu lệnh select/ select where 
        //Chiều lấy dữ liệu ra từ DB -> lấy qua DataTable nhe
        public DataTable GetRecords(string query)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    connection.Close();
                    return table;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
