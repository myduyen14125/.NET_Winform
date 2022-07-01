using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin
{
    public partial class MyLogin: UserControl
    {
        public MyLogin()
        {
            InitializeComponent();
        }
        public string User
        {
            get { return tbUsername.Text; }
            set { }
        }
        public string Password
        {
            get { return tbPasswd.Text; }
            set { }
        }
    }
}
