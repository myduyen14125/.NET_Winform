using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ShowLV();
            ShowDGV();
        }
        //Tao listview
        private void ShowLV()
        {
            listView1.Columns.AddRange(new ColumnHeader[] {
                new ColumnHeader { Name = "MSSV", Text = "MSSV"},
                new ColumnHeader { Name = "Name", Text = "Name"},
                new ColumnHeader{ Name = "Gender", Text = "Gender"},
                new ColumnHeader { Name = "Class", Text = "Class" }
            });
            ListViewItem i1 = new ListViewItem { Text = "102" };
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem {Text = "NVA"},
                new ListViewItem.ListViewSubItem{Text = true.ToString()},
                new ListViewItem.ListViewSubItem { Text = "21T"}
            });
            ListViewItem i2 = new ListViewItem { Text = "103" };
            i2.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem {Text = "NVB"},
                new ListViewItem.ListViewSubItem{Text = true.ToString()},
                new ListViewItem.ListViewSubItem { Text = "20T"}
            });
            ListViewItem i3 = new ListViewItem { Text = "104" };
            i3.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem {Text = "NVC"},
                new ListViewItem.ListViewSubItem{Text = true.ToString()},
                new ListViewItem.ListViewSubItem { Text = "19T"}
            });
            listView1.Items.AddRange(new ListViewItem[] { i1, i2, i3 });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string s = "";
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    string MSSV = i.Text;
                    string Name = i.SubItems[1].Text;
                    bool Gender = Convert.ToBoolean(i.SubItems[2].Text);
                    string Class = i.SubItems[3].Text;
                    s += MSSV + "," + Name + "," + Gender.ToString() + "," + Class + "\n";
                }
                MessageBox.Show(s);
            }
        }
        //tao data grid view: co data source, là mảng đối tượng, cho phép hiển thị dữ liệu dưới dạng hàng và cột
        //-> tự tạo ra các hàng và cột, tối ưu hơn
        //-> Đặc trưng: tùy thuộc vào kiểu dữ liệu thuộc tính mà lựa chọn kiểu dữ liệu component cho phù hợp 
        private void ShowDGV()
        {
            //Tao mang cac sinh vien - C1 tao mang de them vao DataGridView
            /*SV[] data1 = new SV[]
            {
                new SV {MSSV = "12", Name = "NVA", Gender = true, Class = "21T"},
                new SV {MSSV = "13", Name = "NVB", Gender = true, Class = "20T"},
                new SV {MSSV = "14", Name = "NVC", Gender = true, Class = "19T"}
            };*/
            //C2: tao List cac sinh vien de them vao DataGridView
            List<SV> data = new List<SV>();
            data.AddRange(new SV[]
            {
                new SV {MSSV = "102", Name = "NVA", Gender = true, Class = "21T"},
                new SV {MSSV = "103", Name = "NVB", Gender = true, Class = "20T"},
                new SV {MSSV = "104", Name = "NVC", Gender = true, Class = "19T"}
            });
            //C3: Use Datatable -> more effectively 
            DataTable dt = new DataTable(); //khoi tao bang datatable
            dt.Columns.AddRange(new DataColumn[] { //Dt them cot -> them dong
                new DataColumn {ColumnName = "MSSV", DataType = typeof(string)}, //them ten cot
                new DataColumn {ColumnName = "Name", DataType = typeof(string)},
                new DataColumn {ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Class", DataType= typeof(string)},
            }) ;
            dt.Rows.Add("105", "NVF", true, "20T1");
            foreach (SV i in data)
            {
                dt.Rows.Add(i.MSSV, i.Name, i.Gender, i.Class);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string s = "";
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MSSV = i.Cells[0].Value.ToString();
                    string Name = i.Cells["Name"].Value.ToString();
                    bool Gender = Convert.ToBoolean(i.Cells["Gender"].Value.ToString());
                    string Class = i.Cells["Class"].Value.ToString();
                    s += MSSV + "," + Name + "," + Gender.ToString() + "," + Class + "\n";
                }
                MessageBox.Show(s); 
            }
            
        }
    }
}
