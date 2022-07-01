using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class MainForm : Form
    {
        private QLSV qlsv = new QLSV();
        public MainForm()
        {
            InitializeComponent();
            cbClass.Items.Add("All"); //them truong "All" vao item cua combobox Class
            foreach(string i in qlsv.GetAllClass().Distinct())
            {
                cbClass.Items.Add(i); //them item vo cbClass bang cac lop cua sv
            }
            cbSort.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid class!");
            }
            else
            {
                dataGridView1.DataSource = qlsv.GetSVByClass(cbClass.SelectedItem.ToString());
            }       
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details f = new Details("");//create an instance of details form: truyen vao string rong => tuc edit = false
            //create an instance of the delegate
            f.myDel = new Details.MyDel(ShowDGV);
            f.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString(); //lay hang dau tien -> cot MSSV
                Details f = new Details(MSSV);
                f.myDel = new Details.MyDel(ShowDGV);
                f.Show();
            }
            else
            {
                MessageBox.Show("Choose a row!");
            }

        }
        public void ShowDGV(string LopSH, string txt = "") //ham show co the duoc su dung thay cho ham show o tren nhe!
        {
            dataGridView1.DataSource = qlsv.GetSVByClass(LopSH, txt); //khi show -> search lấy theo Lớp và text search truyền vô 
        }
        
        //Khi click vô 1 row thì chỉ cần lấy cái MSSV ra -> sau đó qua form kia thì lấy cái mã số sv để trả về dữ liệu của hắn
        //làm sao để phân biệt hàm add và edit: truyền vô 1 string mssv vô, nếu adđ thì mssv = rỗng


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> del = new List<string>();
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    del.Add(i.Cells["MSSV"].Value.ToString()); //them list MSSV : khoa chinh -> la nhung string vao list del can xoa
                }
                qlsv.DelSV(del);
                cbClass.SelectedIndex = 0;
                ShowDGV(cbClass.SelectedItem.ToString()); //sau khi xoa xong thi SHowDGV lai nhe
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            List<string> now = new List<string>();
            foreach(DataGridViewRow i in dataGridView1.Rows)
            {
                now.Add(i.Cells["MSSV"].Value.ToString()); //tuong tu nhu tren, them mssv vao list string do ne
                //List đang chứa những mssv là sv đang được show ra ở datagridview
            }
            if (cbSort.SelectedIndex < 0)
            {
                MessageBox.Show("Choose field to sort!");
            }
            else
            {
                //syntax sort: OrderBy<TSource,TKey>: Tsour: type of the element of source, Tkey: type of key return by key selector
                if (cbSort.SelectedItem.ToString() == "MSSV")
                {
                    this.dataGridView1.DataSource = qlsv.GetSVByClass(cbClass.SelectedItem.ToString()).OrderBy(x => x.MSSV).ToList();
                }
                if (cbSort.SelectedItem.ToString() == "Name")
                {
                    this.dataGridView1.DataSource = qlsv.GetSVByClass(cbClass.SelectedItem.ToString()).OrderBy(x => x.Name).ToList();
                }
                if (cbSort.SelectedItem.ToString() == "Avg score")
                {
                    this.dataGridView1.DataSource = qlsv.GetSVByClass(cbClass.SelectedItem.ToString()).OrderBy(x => x.AvgScore).ToList();
                }

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string LopSH = cbClass.SelectedItem.ToString();
            string txt = searchBox.Text; //lấy vào text để phục vụ cho hàm search nè 
            ShowDGV(LopSH, txt); //gọi lên hàm show
        }


    }
}
    