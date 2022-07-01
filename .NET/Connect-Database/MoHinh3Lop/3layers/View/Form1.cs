using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3layers.DTO;
using _3layers.View;
using _3layers.BLL;

namespace _3layers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCBB();
            cbbLSH.SelectedIndex = 0;  
        }
        public void setCBB()
        {
            cbbLSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbLSH.Items.AddRange(BLL.BLLQLSV.Instance.GetCBB().ToArray()); 
        }
        private void showDTG(int ID_Lop, string txt="")
        {
            dataGridView1.DataSource = BLLQLSV.Instance.GetSVViewByIDLop(ID_Lop,txt);
        }
       
        private void butShow_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CBBItem)cbbLSH.SelectedItem).Value;
            showDTG(ID_Lop,""); 
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.dShowDGV = new Form2.mydel(showDTG); 
            f.Show(); 
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f = new Form2(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                f.dShowDGV = new Form2.mydel(showDTG);
                f.Show(); 
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) {
                    BLLQLSV.Instance.DeleteSV(dataGridView1.SelectedRows[i].Cells["MSSV"].Value.ToString()); 
                }
                showDTG(0); 
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            showDTG(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);
        }
    }
}
