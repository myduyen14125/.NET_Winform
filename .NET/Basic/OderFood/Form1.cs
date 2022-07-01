using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OderFood
{
    public partial class Form1 : Form
    {
        List<DataTable> listTables = new List<DataTable>();
        public Form1()
        {
            InitializeComponent();
            CreateTable();
        }
        private void ClickEvent (object o, EventArgs e)
        {
            DataTable dt = new DataTable();
            int currentTable = cbNumberOfTable.SelectedIndex;
            dt = listTables[currentTable];
            int numberOfRow = dt.Rows.Count;
            string dish = ((Button)o).Text;
            bool check = false;

            for (int i = 0; i < numberOfRow; i++)
            {
                if (dt.Rows[i].Field<string>(0) == ((Button)o).Text)
                {
                    int count = dt.Rows[i].Field<int>(1);
                    dt.Rows[i].SetField(1, count + 1);
                    check = true;
                }
            }

            if (check == false)
            {
                dt.Rows.Add(((Button)o).Text, 1);
            }

        }
        private void CreateTable()
        {
            int numberOfTable = cbNumberOfTable.Items.Count;
            for (int i = 0; i < numberOfTable; i++)
            {
                listTables.Add(new DataTable());
                listTables[i].Columns.AddRange(new DataColumn[] {
                    new DataColumn {ColumnName = "Món ăn", DataType = typeof(string)}, 
                    new DataColumn {ColumnName = "Số lượng", DataType = typeof(int)},
                });
            }
            cbNumberOfTable.SelectedIndex = 0;
        }

        private void cbNumberOfTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listTables[cbNumberOfTable.SelectedIndex];
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            listTables[cbNumberOfTable.SelectedIndex].Rows.Clear();
            dataGridView1.DataSource = listTables[cbNumberOfTable.SelectedIndex];
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listTables[cbNumberOfTable.SelectedIndex];
            if(listTables[cbNumberOfTable.SelectedIndex].Rows.Count > 0)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }
    }
}
