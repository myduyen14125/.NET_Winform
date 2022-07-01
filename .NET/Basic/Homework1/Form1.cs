using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] a = File.ReadAllLines(@"E:\.NET\Basic\Homework1\data.txt");
            for (int i = 0; i < a.Length; i++)
            {
                listBox.Items.Add(a[i]);
            }
        }


        //Check btn
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            input_code.Text = "";
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            string[] input_pass = {"1234", "2345", "0123"};
            string res = "";
            for (int i = 0; i < input_pass.Length; i++)
            {
                if (input_code.Text == input_pass[i])
                {
                    res += DateTime.Now.ToString() + " " + "Success" + "\n";
                    break;
                }
                if (i == input_pass.Length - 1)
                {
                    res += DateTime.Now.ToString() + " " + "Restricted Access!" + "\n";
                }
            }
            listBox.Items.Add(res);
            File.AppendAllText(@"E:\.NET\Basic\Homework1\data.txt", res);
            input_code.Text = "";
        }


        private void Click_event(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (input_code.Text.Length < 4)
            {
                input_code.Text += b.Text;
            }
            //or input_code.Text = ((Button)o).Text;
            else
            {
                MessageBox.Show("Maxlength = 4!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    break;
                case Keys.D3: 
                    button3.PerformClick();
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    break;
                case Keys.D0:
                    button0.PerformClick();
                    break;

                ////
                case Keys.Oemplus: 
                    if (!e.Shift) //phim bang
                        equalBtn.PerformClick();
                    else 
                        plusBtn.PerformClick();
                    break;
                case Keys.C:
                    cancel_btn.PerformClick();
                    break;
                case Keys.Enter:
                    enter_btn.PerformClick();
                    break;

                    

            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
