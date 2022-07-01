using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_DB
{
    class CbbItem
    {
        //cbb dùng để tương tác với table LopSH
        //khi tạo ra một DataRow -> tạo ra 1 đối tượng CbbItem 
        //gồm 2 thuộc tính value là id và Text -> rồi trả về text
        //sau đố thêm đối tượng này - tức CbbItem vào comboBox.Item.Add(....)
        private string _value;
        private string _Text; //đoạn text hiển thị lên cbb

        public string Value { get => _value; set => _value = value; }
        public string Text { get => _Text; set => _Text = value; }
        public override string ToString()
        {
            return Text;
        }
    }
}
