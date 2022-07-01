using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = 0;//set as default is 0 tooth
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();//đóng k giải phóng
            //this.Dispose();, đóng rồi giải phóng toàn bộ lun
        }
        private double Calculate() //tính tiền
        {
            double sum = 0;
            if (cb_caovoi.Checked == true)
                sum += 100;
            if (cb_taytrang.Checked)
                sum += 1200;
            if (cb_chuphinh.Checked)
                sum += 200;
            int countTeeth = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            sum += countTeeth * 80;
            return sum;
        }
        private void cashBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Nhap ten em oi");
            }
            else
            {
                totalBox.Text = Calculate().ToString();
            }
        }
    }
}
