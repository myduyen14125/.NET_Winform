using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity.DTO;
using Entity.BLL;

namespace Entity
{
    public partial class Form2 : Form
    {
        public delegate void mydel(string ID_Lop, string txt = "");
        public mydel dShowDGV;
        public string MSSV {  get; set; }
        quanlysinhvienEntities db = new quanlysinhvienEntities();
        public Form2(string mssv = "")
        {
            MSSV = mssv;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if (MSSV != "")
            {
                txtMSSV.Text = MSSV;
                txtMSSV.Enabled = false;
                txtTenSV.Text = BLLQLSV.Instance.GetSVByMSSV(MSSV).NameSV.ToString();
                txtTenLSH.Text = BLLQLSV.Instance.GetNameLopByIDLop(BLLQLSV.Instance.GetSVByMSSV(MSSV).ID_Lop);
                txtDTB.Text = BLLQLSV.Instance.GetSVByMSSV(MSSV).DTB.ToString();
            }
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            SV sv = new SV()
            {
                MSSV = txtMSSV.Text,
                NameSV = txtTenSV.Text,
                ID_Lop = BLLQLSV.Instance.GetIDLopByTenLSH(txtTenLSH.Text),
                DTB = Convert.ToDouble(txtDTB.Text)
            };
            BLLQLSV.Instance.AddorUpdateSV(sv);
            this.Close();
            dShowDGV(0);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
