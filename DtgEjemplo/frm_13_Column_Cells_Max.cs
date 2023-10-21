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
    public partial class frm_13_Column_Cells_Max : Form
    {
        public frm_13_Column_Cells_Max()
        {
            InitializeComponent();
        }

        private void frm_13_Column_Cells_Max_Load(object sender, EventArgs e)
        {
            // populate datagridview with some data
            Random r = new Random();
            for (int i = 0; i <= 10; i++)
            {
                dataGridView1.Rows.Add("First Name" + i.ToString(), "Last Name" + i.ToString(), r.Next(20, 65).ToString());
            }

            dataGridView1.AllowUserToAddRows = false;

            // method 1
            textBoxMax.Text = (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[2].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[2].FormattedValue)).Max().ToString();


            // method 2
            int max = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (max < int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    max = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
            }

            textBoxMax.Text = max.ToString();

            // method 3
            int[] columnData = new int[dataGridView1.Rows.Count];
            columnData = (from DataGridViewRow row in dataGridView1.Rows
                          where row.Cells[2].FormattedValue.ToString() != string.Empty
                          select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            textBoxMax.Text = columnData.Max().ToString();
        }
    }
}
