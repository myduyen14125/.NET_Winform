using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCbb();
        }
        public void SetCbb() {
            string query = "select * from LopSH";
            DataTable dt = QLSV.DataProvider.Instance.GetRecords(query);
            if (comboBox1.Items != null)
            {
                comboBox1.Items.Clear();
            }
            comboBox1.Items.Add(new CbbItem { Value = 0, Text = "All" });
            foreach(DataRow i in dt.Rows)
            {
                comboBox1.Items.Add(new CbbItem { 
                    Value = Convert.ToInt32(i["ID_Lop"]),
                    Text = i["NameLop"].ToString(),
                });
            }
            comboBox1.SelectedIndex = 0;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = "select * from SV";
            DataTable dt2 = QLSV.DataProvider.Instance.GetRecords(query);
            dataGridView1.DataSource = dt2;
            //InitDB(query1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                //ep kieu moi SelectedItem thanh CbbItem
                string s = ((CbbItem)comboBox1.SelectedItem).Value.ToString() + " " + ((CbbItem)comboBox1.SelectedItem).Text.ToString();
                MessageBox.Show(s);
            }
        }
        //không nên viết thẳng 2 thằng ni ở GUI ở đây -> đưa qua lớp Hỗ trợ CSDl - DataProvider 
        //public void InitDB(string query)
        //{
        //    string connectionString = @"Data Source=.\;Initial Catalog=demo;Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //}
        //public DataTable GetData(string query)
        //{
        //    string connectionString = @"Data Source=.\;Initial Catalog=demo;Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    connection.Open();

        //    SqlCommand command = new SqlCommand(query, connection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;
        //    connection.Close();

        //    return table;
        //}
    }
}
