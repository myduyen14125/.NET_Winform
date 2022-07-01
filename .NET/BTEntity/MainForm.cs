using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTEntity.BLL;
using BTEntity.DTO;

namespace BTEntity
{
    public partial class MainForm : Form
    {   
        demoQLSV db = new demoQLSV();
        public MainForm()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cbbLSH.Items.Add(new CBBItem { Text = "All", Value = 0 });
            foreach (LOP i in BLL_QLSV.Instance.GetAllLSH())
            {
                cbbLSH.Items.Add(new CBBItem
                {
                    Text = i.NameLop,
                    Value = i.ID_Lop
                });
            }
            cbbSort.Items.AddRange(new object[] {
                "Tên",
                "Lớp",
                "MSSV",
                "Điểm trung bình"
            });
            cbbSort.SelectedIndex = 0;  
            cbbLSH.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            ShowSV(((CBBItem)cbbLSH.SelectedItem).Value, "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm frm = new DetailForm("");
            frm.d = ShowSV;
            frm.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count == 1)
            {
                string MSSV = dgvSV.SelectedRows[0].Cells["MSSV"].Value.ToString();
                DetailForm frm = new DetailForm(MSSV);
                frm.d = ShowSV;
                frm.Show();




            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                List<string> listdel = new List<string>();
                foreach (DataGridViewRow i in dgvSV.SelectedRows)
                {
                    listdel.Add(i.Cells["MSSV"].Value.ToString());
                    
                }
                BLL_QLSV.Instance.DeleteSV(listdel);

                ShowSV(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);


            }
        }
        public void ShowSV(int id, string txt)
        {
            dgvSV.DataSource = BLL_QLSV.Instance.GetView(BLL_QLSV.Instance.SearchSV(id, txt));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSV(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<string> listNow = new List<string>();
            foreach (DataGridViewRow i in dgvSV.Rows)
            {
                listNow.Add(i.Cells["MSSV"].Value.ToString());
            }
            dgvSV.DataSource = BLL_QLSV.Instance.GetView(BLL_QLSV.Instance.SortSV(listNow, cbbSort.SelectedItem.ToString()));
        }
    }
}
