using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DtgEjemplo
{
    public partial class frm_17_txt_to_dgv : Form
    {
        DataTable table = new DataTable();

        public frm_17_txt_to_dgv()
        {
            InitializeComponent();
        }

        private void frm_17_txt_to_dgv_Load(object sender, EventArgs e)
        {
            // add columns to datatable
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            // get lines from the text file
            string[] lines = File.ReadAllLines(@"D:\\Images\\table.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
    }
}
