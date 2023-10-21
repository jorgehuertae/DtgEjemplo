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
    public partial class frm_12_Datagridview_Column_Cells_Sum : Form
    {
        public frm_12_Datagridview_Column_Cells_Sum()
        {
            InitializeComponent();
        }

        private void frm_12_Datagridview_Column_Cells_Sum_Load(object sender, EventArgs e)
        {
            // populate datagridview with some data
            for (int i = 0; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i.ToString(), "First Name" + i.ToString(), "Last Name" + i.ToString());
            }
            dataGridView1.AllowUserToAddRows = false;

            // method 1
            textBoxSum.Text = (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[0].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();

            //  method 2
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            textBoxSum.Text = sum.ToString();

            // method 3
            int[] columnData = new int[dataGridView1.Rows.Count];
            columnData = (from DataGridViewRow row in dataGridView1.Rows
                          where row.Cells[0].FormattedValue.ToString() != string.Empty
                          select Convert.ToInt32(row.Cells[0].FormattedValue)).ToArray();
            textBoxSum.Text = columnData.Sum().ToString();
        }
    }
}
