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
    public partial class DetailForm : Form
    {
        public delegate void MyDel(string huongNC, string status, string GVHD, string txt); 
        public MyDel myDel { get; set; }
        private ListManage listManage  = new ListManage();
        public string ID { get; set; }
        public DetailForm(string s)
        {
            InitializeComponent();
            ID = s;
            AddCbbValue();
            GUI();
        }
        public void AddCbbValue()
        {
            foreach (string i in listManage.GetAllHuongNC().Distinct())
            {
                cbHuongNC.Items.Add(i);
            }
            foreach (int i in listManage.GetAllYear().Distinct())
            {
                cbYear.Items.Add(i);
            }
        }
        public void GUI()
        {
            if (ID != "") //neu co truyen MSSV tu ben kia qua 
            {
                txtID.Enabled = false;
                txtID.Text = listManage.GetDoanByID(ID).ID;
                txtName.Text = listManage.GetDoanByID(ID).NameDA;
                txtSV.Text = listManage.GetDoanByID(ID).SV;
                cbHuongNC.SelectedItem = listManage.GetDoanByID(ID).HuongNC;
                cbGVHD.SelectedItem = listManage.GetDoanByID(ID).GVHD;
                cbYear.SelectedItem = listManage.GetDoanByID(ID).Year;
                rbTrue.Checked = listManage.GetDoanByID(ID).Status;
                rbFalse.Checked = !rbTrue.Checked;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || txtSV.Text == "" || cbHuongNC.SelectedIndex < 0 || cbGVHD.SelectedIndex < 0 || cbYear.SelectedIndex < 0)
            {
                MessageBox.Show("Fill in the form!");
            }
            else
            {
                Doan p = new Doan()
                {
                    ID = txtID.Text,
                    NameDA = txtName.Text,
                    SV = txtSV.Text,
                    HuongNC = cbHuongNC.SelectedItem.ToString(),
                    GVHD = cbGVHD.SelectedItem.ToString(),
                    Status = rbTrue.Checked,
                    Year = Convert.ToInt32(cbYear.SelectedItem.ToString()),
                };
                listManage.ExecuteDB(p);
                myDel("All", "All", "All", "");
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //txtID.Clear();txtName.Clear();txtSV.Clear();cbGVHD.SelectedIndex = 0;
            //cbHuongNC.SelectedIndex = 0; cbYear.SelectedIndex = 0; 
            this.Close();
        }

        private void cbHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGVHD.Items.Clear();
            foreach (string i in listManage.GetGVHDByHuongNC(cbHuongNC.SelectedItem.ToString())) {
                cbGVHD.Items.Add(i);
            }
        }
    }
}
