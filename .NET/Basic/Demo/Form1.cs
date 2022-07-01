using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbKeyPress.Text = "Key press: " + e.KeyChar;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            if (textBox1.Text != "")
            {
                if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
                {
                    MessageBox.Show("Có rồi á á");
                }
                else
                {
                    listBox1.Items.Add(textBox1.Text + " " + DateTime.Now);
                }
            }
            else
            {
                MessageBox.Show("Nhập text em ơi!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //.SelectedIndex → Trả về bị trí item đang được lựa chọn
            //.SelectedItem → Trả về một line đang được lựa chọn, 01 item đang được lựa chọn
            //.SelectedItems → Trả về nhiều lines đang lựa chọn
            if (listBox1.SelectedItems.Count == 1) //nếu đang chọn 1 phần tử trong listbox 
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            textBox1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                MessageBox.Show(rbMale.Checked.ToString());
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                MessageBox.Show(rbFemale.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }
    
        
    }
}