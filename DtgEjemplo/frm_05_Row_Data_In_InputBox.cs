using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DtgEjemplo
{
    public partial class frm_05_Row_Data_In_InputBox : Form
    {
        DataTable table = new DataTable();

        public frm_05_Row_Data_In_InputBox()
        {
            InitializeComponent();
        }

        private void frm_05_Row_Data_In_InputBox_Load(object sender, EventArgs e)
        {
            // populate DatagridView with some data using datatable
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(String));
            table.Columns.Add("Last Name", typeof(String));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add(1, "AAA", "BBB", 32);
            table.Rows.Add(2, "CCC", "DDD", 23);
            table.Rows.Add(3, "EEE", "FFF", 16);
            table.Rows.Add(4, "GGG", "HHH", 45);
            table.Rows.Add(5, "III", "JJJ", 53);
            table.Rows.Add(6, "KKK", "LLL", 62);

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get selected row index
            int selectedRowIndex = e.RowIndex;

            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];

            // get data from the selected row
            int id = int.Parse(row.Cells[0].Value.ToString());
            //string id2 = row.Cells[0].Value.ToString();
            string fn = row.Cells[1].Value.ToString();
            string ln = row.Cells[2].Value.ToString();
            int age = int.Parse(row.Cells[3].Value.ToString());

            // show the selected row data on inputboxes
            id = int.Parse(Interaction.InputBox("The Id", "Row Data", id.ToString(), -1, -1));
            fn = Interaction.InputBox("The First Name", "Row Data", fn, -1, -1);
            ln = Interaction.InputBox("The Last Name", "Row Data", ln, -1, -1);
            age = int.Parse(Interaction.InputBox("The Age", "Row Data", age.ToString(), -1, -1));


            row.Cells[0].Value = id;
            row.Cells[1].Value = fn;
            row.Cells[2].Value = ln;
            row.Cells[3].Value = age;


            dataGridView1.DataSource = table;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // get data from inputboxes
            int id = int.Parse(Interaction.InputBox("Enter The Id", "Data", "", -1, -1));
            string fn = Interaction.InputBox("Enter The First Name", "Data", "", -1, -1);
            string ln = Interaction.InputBox("Enter The Last Name", "Data", "", -1, -1);
            int age = int.Parse(Interaction.InputBox("Enter The Age", "Data", "", -1, -1));

            table.Rows.Add(id, fn, ln, age);

            dataGridView1.DataSource = table;
        }
    }
}
