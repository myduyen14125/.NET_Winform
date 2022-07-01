using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        Point ps;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//khi nhan chuot xuong -> call mousedown
        {
            if (e.Button == MouseButtons.Right)
            {
                ps = e.Location;
            } 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(Color.Red, 2f);
                g.DrawLine(p, ps, e.Location);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(Color.Green, 2f);
                g.DrawLine(p, ps, e.Location);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Keychar: " + e.KeyChar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text =
                "Keycode: " + e.KeyCode + "\n" +
                "KeyData: " + e.KeyData + "\n" +
                "KeyValue: " + e.KeyValue + "\n";
        }
    }
}
