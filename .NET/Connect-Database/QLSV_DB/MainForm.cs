using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DB
{
    public partial class MainForm : Form
    {
        DataProvider dt = new DataProvider();
        public MainForm()
        {
            InitializeComponent();
            SetCbb();
        }
        public void SetCbb()
        {
            string query = "select * from SV";
            dt.GetRecords(query);
            if (cbClass.Items != null)
            {
                cbClass.Items.Clear();
            }
            cbClass.Items.Add(new CbbItem { Value = "", Text = "All" });
            foreach (DataRow i in dt.GetRecords(query).Rows)
            {
                cbClass.Items.Add(new CbbItem
                {
                    Value = i["MSSV"].ToString(),
                    Text = i["Class"].ToString(),
                });
            }
            cbClass.SelectedIndex = 0;
        }
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex >= 0)
            {
                //ep kieu moi SelectedItem thanh CbbItem
                //string s = ((CbbItem)cbClass.SelectedItem).Value.ToString() + " " + ((CbbItem)cbClass.SelectedItem).Text.ToString();
                //MessageBox.Show(s);
                string query = "";
                DataTable dt = new DataTable();
                if (cbClass.SelectedItem.ToString() == "All")
                {
                    query = "select * from SV";
                }
                else
                {
                    query = "select * from SV where Class = '" + cbClass.SelectedItem.ToString() + "'";
                }
                dataGridView1.DataSource = DataProvider.Instance.GetRecords(query);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowSV("All", "");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string LopSH = cbClass.SelectedItem.ToString();
            string txt = searchBox.Text;
            ShowSV(LopSH, txt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details f = new Details("");
            f.myDel = new Details.MyDel(ShowSV);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Details f = new Details(MSSV);
                f.myDel = new Details.MyDel(ShowSV);
                f.Show();
            }
        }
        public void ShowSV(string txtLopSH, string txtSearch)
        {
            string query = "";
            if (txtLopSH == "All")
            {
                query = "select * from SV where NameSV LIKE '%" + txtSearch+ "%'";
            }
            else
            {
                query = "select * from SV where Class = '" + txtLopSH + "' and NameSV LIKE '%" + txtSearch + "%'";
            }
            dataGridView1.DataSource = dt.GetRecords(query);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string query = "delete from SV where MSSV = '" + i.Cells["MSSV"].Value.ToString() + "'";
                    dt.ExecuteDB(query);
                }
                cbClass.SelectedIndex = 0;
                ShowSV(cbClass.SelectedItem.ToString(), "");
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            
        }
    }
}
