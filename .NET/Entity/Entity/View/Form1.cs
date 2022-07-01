using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity.BLL;
using Entity.DTO;

namespace Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCBB();
        }
        public void setCBB()
        {
            cbbClass.Items.Add(new CBBItem { Value = "", Text = "All" });
            cbbClass.Items.AddRange(BLL.BLLQLSV.Instance.GetCBB().ToArray());
            cbbClass.SelectedIndex = 0;
        }
        
        private void showDTG(string ID_Lop, string txt = "")
        {
            dataGridView1.DataSource = BLLQLSV.Instance.GetSVViewByIDLop(ID_Lop, txt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Select *
            //var l1 = from p in db.SVs select p;
            //var l2 = db.SVs.Select(p => p);
            //var l1 = from p in db.SVs
            //         select new {p.MSSV, p.NameSV, p.LopSH.NamLop};
            //var l2 = db.Svs.Select(p => new {p.MSSV, p.NameSV, p.LopSH.NamLop};
            //select ... where
            //var l1 = from p in db.SVs
            //         where p.ID_Lop == "101"
            //         select new { p.MSSV, p.NameSV, p.LopSH.NameLop };
            showDTG(((CBBItem)cbbClass.SelectedItem).Value, tbSearch.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.dShowDGV = new Form2.mydel(showDTG);
            f.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                //var s = db.SVs.Find(MSSV);
                Form2 f = new Form2(dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString());
                f.dShowDGV = new Form2.mydel(showDTG);
                f.Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MSSV = i.Cells["MSSV"].Value.ToString();
                    BLLQLSV.Instance.DeleteSV(MSSV);
                }
                showDTG("");
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQLSV.Instance.SortSV(((CBBItem)cbbClass.SelectedItem).Value, tbSearch.Text);
        }
    }
}
