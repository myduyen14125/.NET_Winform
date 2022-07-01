using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceNewspaper
{
    public partial class MainForm : Form
    {
        public ListManage listManage = new ListManage();

        public MainForm()
        {
            InitializeComponent();
            AddCbbValue();
            
        }
        public void AddCbbValue()
        {
            cbHuongNC.Items.Add("All");
            foreach (string i in listManage.GetAllHuongNC().Distinct())
            {
                cbHuongNC.Items.Add(i); 
            }
            cbGVHD.Items.Add("All");
            foreach (string i in listManage.GetAllGVHD().Distinct())
            {
                cbGVHD.Items.Add(i); 
            }
            cbStatus.Items.Add("All");
            foreach (bool i in listManage.GetAllStatus().Distinct())
            {
                cbStatus.Items.Add(i); 
            }
            cbHuongNC.SelectedIndex = 0;
            cbGVHD.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.myDel = new DetailForm.MyDel(ShowDGV);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                DetailForm f = new DetailForm(ID);
                f.myDel = new DetailForm.MyDel(ShowDGV);
                f.Show();
            }
            else
            {
                MessageBox.Show("Choose a row!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa DATN?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    List<string> del = new List<string>();
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        del.Add(i.Cells["ID"].Value.ToString());
                    }
                    listManage.DelDoan(del);
                    cbHuongNC.SelectedIndex = 0;
                    ShowDGV(cbHuongNC.SelectedItem.ToString(), "All", "All");
                }
            }
            else
            {
                MessageBox.Show("Choose at least a row to delete!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbHuongNC.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid type!");
            }
            else
            {
                string huongNC = cbHuongNC.SelectedItem.ToString();
                string status = cbStatus.SelectedItem.ToString();
                string GVHD = cbGVHD.SelectedItem.ToString();
                string txt = txtSearch.Text;
                ShowDGV(huongNC, status, GVHD, txt);
            }
        }
        public void ShowDGV(string huongNC, string status, string GVHD, string txt = "") 
        {
            DataGridViewComboBoxColumn combobox = (DataGridViewComboBoxColumn)dataGridView1.Columns["Year"];
            foreach (int i in listManage.GetAllYear().Distinct())
            {
                combobox.Items.Add(i);
            }
            dataGridView1.DataSource = listManage.GetDoanByFilter(huongNC, status, GVHD, txt);
            //Load STT
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }

        }
    }
}
