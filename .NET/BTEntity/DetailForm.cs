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
    public partial class DetailForm : Form
    {   
        public string MSSV { get; set; }
        public delegate void Mydel(int id, string txt);
        public Mydel d { get; set; }    
        public DetailForm(string m)
        {
            InitializeComponent();
            MSSV = m;
            SetCBB();
            GUI();
        }
        void SetCBB()
        {
            foreach (LOP i in BLL_QLSV.Instance.GetAllLSH())
            {
                cbbLSH.Items.Add(new CBBItem
                {
                    Text = i.NameLop,
                    Value = i.ID_Lop
                });
            }
            cbbLSH.SelectedIndex = 0;
        }
        void GUI()
        {
            SV s = BLL_QLSV.Instance.GetSVByMSSV(MSSV);
            if (s != null)
            {
                txtMSSV.Enabled = false;
                txtMSSV.Text = s.MSSV;
                txtName.Text = s.NameSV;
                txtDTB.Text = s.DTB.ToString();
                cbbLSH.SelectedIndex =(int) s.ID_Lop - 1;
                rBtnMale.Checked = (bool)s.Gender;
                rBtnFemale.Checked = !rBtnMale.Checked;
                cbPic.Checked = (bool)s.Anh;
                cbHB.Checked = (bool)s.HocBa;
                cbNN.Checked = (bool)s.CCNN;
                birthDate.Value = (DateTime)s.NgaySinh;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SV s = new SV
            {
                NameSV = txtName.Text,
                MSSV = txtMSSV.Text,
                ID_Lop = ((CBBItem)cbbLSH.SelectedItem).Value,
                Gender = rBtnMale.Checked ? true : false,
                DTB = Convert.ToDouble(txtDTB.Text),
                NgaySinh = birthDate.Value,
                Anh = cbPic.Checked,
                HocBa = cbHB.Checked,
                CCNN = cbNN.Checked,
                LOP = BLL_QLSV.Instance.GetLopByID(((CBBItem)cbbLSH.SelectedItem).Value)
            };
            BLL_QLSV.Instance.AddUpdate(s);
            d(0, "");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
