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
    public partial class frm_09_add_checkbox_to_datagridview : Form
    {
        public frm_09_add_checkbox_to_datagridview()
        {
            InitializeComponent();
        }

        private void frm_09_add_checkbox_to_datagridview_Load(object sender, EventArgs e)
        {
            // add some row to datagridview

            // true the checkBox Is checked

            // false the checkBox Is Not checked
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(false);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(false);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(false);
            dataGridView1.Rows.Add(false);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            ///////////////////////////////////

            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.HeaderText = "Check Box Column";
            dataGridView2.Columns.Add(CheckBoxColumn);
            dataGridView2.Rows.Add(false);
            dataGridView2.Rows.Add(true);
            dataGridView2.Rows.Add(false);
            dataGridView2.Rows.Add(true);
            dataGridView2.Rows.Add(true);
            dataGridView2.Rows.Add(true);
            dataGridView2.Rows.Add(false);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    MessageBox.Show("Is Checked");
                }
                else
                {
                    MessageBox.Show("Is Not Checked");
                }
            }
        }
    }
}
