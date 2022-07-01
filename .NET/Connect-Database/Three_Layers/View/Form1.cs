using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Three_Layers.DTO;
using Three_Layers.BLL;

namespace Three_Layers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cbbLSH.Items.Add(new CbbItem
            {
                Value = 0,
                Text = "All"
            });
            cbbLSH.Items.AddRange(BLLQLSV.Instance.GetCBB().ToArray());
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CbbItem)cbbLSH.SelectedItem).Value;
            dataGridView1.DataSource = BLLQLSV.Instance.GetSVViewByIDLop(ID_Lop);
        }
    }
}
