using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _NhanVien
{
    public class QLNV
    {
        private NV[] _data; 
        public int length { get; set; }
        public QLNV() {
            _data = null;
            length = 0;
        }
        //them doi tuong nhan vien vao cuoi mang 
        public void Add(NV o) { /// data :|12345|   temp: |12345o| data = |6size| data = temp
            NV[] temp = new NV[length + 1]; //tao mang temp co kich thuoc bang kthuoc mang data + 1
            for (int i = 0; i < length; i++)
            {
                temp[i] = _data[i]; //cho 2 mang bang nhau 
            }

            temp[length] = o;
            ++length;
            _data = new NV[length]; //luc nay kich thuoc mang data da tang len 
            for (int i = 0; i < length; i++)
            {
                _data[i] = temp[i];
            }
        }

        // //them NV vao index  data = |12346| temp = |      |temp = |12346 | temp = |123456| data = |       | data = temp 
        public void Insert(int index, NV o)
        {
            if (index == length + 1) {
                Add(o);
                return;
            } 
            NV[] temp = new NV[length + 1];
            for (int i = 0; i < length; i++)
            {
                temp[i] = _data[i];
            }
            //dich chuyen ve sau 1 thu tu
            for (int i = 0; i < length; i++) {
                if (i == index) {
                    for (int j = i + 1; j < length; j++)    
                         temp[j] = temp[i];
                }
            }
            temp[index] = o;
            ++length;
            _data = new NV[length];
            for (int i = 0; i < length; i++) {
                _data[i] = temp[i];
            }
        }

        // //string: moi dong la 1 doi tuong NV
        public override string ToString()
        {
            string res = "";
            if (length == 0)
                return res;
            foreach (NV i in _data)
            {
                res += i.maNV + " " + i.Name + " " + i.Age + "\n";
            }
            return res;
        }
        //tra ve vi tri cua thang nhan vien trong mang
        public int IndexOf(NV o)
        {
            int index = -1;
            for (int i = 0; i < length; i++)
            {
                if (o.maNV == _data[i].maNV)
                    return i + 1;
            }
            return index;
        }
        public void Remove(NV o)
        {
            RemoveAt(IndexOf(o));
        }
        public void RemoveAt(int index) //data = |12345| temp = |12345| temp = |1235 | data = |1111| data = temp (chayj leng-1)
        {
            NV[] temp = new NV[length];
            for (int i = 0; i < length; i++)
            {
                temp[i] = _data[i];
            }
            for (int i = 0; i < length; i++) {
                if (i == index) {
                    for (int j = i + 1; j < length; j++)
                        temp[i] = temp[j];
                }
            }
            --length;
            _data = new NV[length];
            for (int i = 0; i < length; i++) {
                _data[i] = temp[i];
            }
        }
        public void Update(NV o)
        {
            foreach (NV i in _data) {
                if (i.maNV == o.maNV) {
                    Console.WriteLine("Cap nhat lai ten NV: ");
                    i.Name = Console.ReadLine();
                    Console.WriteLine("Cap nhat lai tuoi NV: ");
                    i.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }
        }

        public NV[] Sort()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (_data[i].Age > _data[j].Age)
                    {
                        swap(ref _data[i], ref _data[j]);
                    }
                }
            }
            return _data;
        }
        public void swap(ref NV x, ref NV y)
        {
            NV temp = new NV();
            temp = x;
            x = y;
            y = temp;
        }
    }
}