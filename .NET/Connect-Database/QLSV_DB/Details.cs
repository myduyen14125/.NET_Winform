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
    public partial class Details : Form
    {
        DataProvider db = new DataProvider();
        public delegate void MyDel(string LopSH, string txtSearch);
        public MyDel myDel { get; set; }
        public string MSSV { get; set; }
        public Details(string s) //truyền string s from mainform
        {
            InitializeComponent();
            MSSV = s;
            string query = "select * from SV";
            foreach (DataRow i in db.GetRecords(query).Rows)
            {
                cbClass.Items.Add(new CbbItem
                {
                    Value = i["MSSV"].ToString(),
                    Text = i["Class"].ToString(),
                });
            }
            GUI();
        }

        public void GUI()
        {            
            if (MSSV != "") //neu co truyen MSSV tu ben kia qua 
            {
                string query = "select * from SV where MSSV = '" + MSSV + "'";
                txtMSSV.Enabled = false;
                txtMSSV.Text = db.GetRecords(query).Rows[0]["MSSV"].ToString();
                txtName.Text = db.GetRecords(query).Rows[0]["NameSV"].ToString();
                cbClass.SelectedItem = db.GetRecords(query).Rows[0]["Class"].ToString();
                rbMale.Checked = Convert.ToBoolean(db.GetRecords(query).Rows[0]["Gender"].ToString());
                rbFemale.Checked = !rbMale.Checked;
                txtDateOfBirth.Value = Convert.ToDateTime(db.GetRecords(query).Rows[0]["DateOfBirth"].ToString());
                txtDTB.Text = db.GetRecords(query).Rows[0]["DTB"].ToString();
                checkPhoto.Checked = Convert.ToBoolean(db.GetRecords(query).Rows[0]["Photo"].ToString());
                checkHocba.Checked = Convert.ToBoolean(db.GetRecords(query).Rows[0]["SchoolProfile"].ToString());
                checkCMND.Checked = Convert.ToBoolean(db.GetRecords(query).Rows[0]["CitizenID"].ToString());
                foreach(CbbItem i in cbClass.Items)
                {
                    if (i.Text == db.GetRecords(query).Rows[0]["Class"].ToString())
                    {
                        cbClass.SelectedItem = i;
                        break;
                    }
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string birthday = txtDateOfBirth.Value.Month + "/" + txtDateOfBirth.Value.Day + "/" + txtDateOfBirth.Value.Year;
            string data =
                "'" + txtMSSV.Text + "'," +
                "'" + txtName.Text + "'," +
                "'" + cbClass.SelectedItem.ToString() + "'," +
                "'" + rbMale.Checked + "'," +
                "'" + birthday + "'," +
                Convert.ToDouble(txtDTB.Text) + "," +
                "'" + checkPhoto.Checked + "'," +
                "'" + checkHocba.Checked + "'," +
                "'" + checkCMND.Checked + "'";
            string queryAdd = "insert into SV values(" + data + ")";
            string queryUpdate = "update SV set" +
                " NameSV = '" + txtName.Text + "'," +
                " Class = '" + cbClass.SelectedItem.ToString() + "'," +
                " Gender = '" + rbMale.Checked + "'," +
                " DateOfBirth = '" + birthday + "'," +
                " DTB = '" + Convert.ToDouble(txtDTB.Text) + "'," +
                " Photo = '" + checkPhoto.Checked + "'," +
                " SchoolProfile = '" + checkHocba.Checked + "'," +
                " CitizenID = '" + checkCMND.Checked + "'" +
                " where MSSV = '" + MSSV + "'"
                ;
            MessageBox.Show(queryUpdate);
            if (MSSV == "") db.ExecuteDB(queryAdd);
            else db.ExecuteDB(queryUpdate);
            myDel("All", "");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //txtMSSV.Clear(); txtName.Clear(); cbClass.SelectedIndex = 0; txtDateOfBirth.CalendarFont = null; txtDTB.Clear();
            //rbFemale.Checked = false; rbMale.Checked = false;
            //checkPhoto.Checked = false; checkHocba.Checked = false; checkCMND.Checked = false;
            this.Hide();
        }
    }
}