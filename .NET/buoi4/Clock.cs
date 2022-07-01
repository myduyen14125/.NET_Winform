using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Buoi4
{
    public delegate void SecondHandler(object o, TimeEventArgs e);//khai bao delegate binh thuong, tra ve void thi moi co the tham chieu toi nhieu ham
    public class Clock
    {
        public event SecondHandler OnSecondChange; 
        public void Run() {
            while(true) {
                Thread.Sleep(1000);
                if(OnSecondChange != null) {
                    OnSecondChange(this, new TimeEventArgs(DateTime.Now));
                }
            }
        }
    }
}