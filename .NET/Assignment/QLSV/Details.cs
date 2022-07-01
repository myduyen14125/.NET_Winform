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
    public partial class Details : Form
    {
        //Define delegate
        public delegate void MyDel(string LopSH, string txt);
        //create instance (null)
        public MyDel myDel { get; set; }
        private QLSV qlsv = new QLSV();
        public string MSSV { get; set; }
        public Details(string s) //truyền string s vào để lúc khởi tạo form detail sẽ nhận thêm MSSV vào 
        {
            InitializeComponent();
            MSSV = s; //bien MSSV toan cuc ne, ham dung la truyen gia tri vo cho no = s
            foreach (string i in qlsv.GetAllClass().Distinct())
            {
                cbClass.Items.Add(i);
            }
            GUI();
        }

        public void GUI()
        {
            if (MSSV != "") //neu co truyen MSSV tu ben kia qua 
            {
                txtMSSV.Enabled = false;
                txtMSSV.Text = qlsv.GetSVByMSSV(MSSV).MSSV;
                txtName.Text = qlsv.GetSVByMSSV(MSSV).Name;
                cbClass.SelectedItem = qlsv.GetSVByMSSV(MSSV).Class;
                rbMale.Checked = qlsv.GetSVByMSSV(MSSV).Gender;
                rbFemale.Checked = !rbMale.Checked;
                txtDateOfBirth.Value = qlsv.GetSVByMSSV(MSSV).DateOfBirth;
                txtDTB.Text = qlsv.GetSVByMSSV(MSSV).AvgScore.ToString();
                checkPhoto.Checked = qlsv.GetSVByMSSV(MSSV).Photo;
                checkHocba.Checked = qlsv.GetSVByMSSV(MSSV).SchoolProfile;
                checkCMND.Checked = qlsv.GetSVByMSSV(MSSV).CitizenID;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SV s = new SV
            {
                MSSV = txtMSSV.Text,
                Name = txtName.Text,
                Class = cbClass.SelectedItem.ToString(),
                Gender = rbMale.Checked,
                DateOfBirth = txtDateOfBirth.Value,
                AvgScore = Convert.ToDouble(txtDTB.Text),
                Photo = checkPhoto.Checked,
                SchoolProfile = checkHocba.Checked,
                CitizenID = checkCMND.Checked,  
            };
            qlsv.ExecuteDB(s);
            myDel("All", "");
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear(); txtName.Clear(); cbClass.SelectedIndex = 0; txtDateOfBirth.CalendarFont = null; txtDTB.Clear();
            rbFemale.Checked = false; rbMale.Checked = false;
            checkPhoto.Checked = false; checkHocba.Checked = false; checkCMND.Checked = false;
        }
    }
}
