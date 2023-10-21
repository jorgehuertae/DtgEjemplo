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
    public partial class frm_10_delete_datagridview_checked_checkbox_cell : Form
    {
        public frm_10_delete_datagridview_checked_checkbox_cell()
        {
            InitializeComponent();
        }

        private void frm_10_delete_datagridview_checked_checkbox_cell_Load(object sender, EventArgs e)
        {
            // create a text columns
            DataGridViewTextBoxColumn dgvcId = new DataGridViewTextBoxColumn();
            dgvcId.HeaderText = "Id";
            DataGridViewTextBoxColumn dgvcFn = new DataGridViewTextBoxColumn();
            dgvcFn.HeaderText = "First Name";
            DataGridViewTextBoxColumn dgvcLn = new DataGridViewTextBoxColumn();
            dgvcLn.HeaderText = "Last Name";

            // create checkbox column
            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Delete";

            // add columns to datagridview
            dataGridView1.Columns.Add(dgvcId);
            dataGridView1.Columns.Add(dgvcFn);
            dataGridView1.Columns.Add(dgvcLn);
            dataGridView1.Columns.Add(dgvcCheckBox);

            // add some row to datagridview
            // true the checkBox Is checked
            // false the checkBox Is Not checked
            dataGridView1.Rows.Add("1", "DTYUI", "RTYUI", false);
            dataGridView1.Rows.Add("2", "KJHGF", "OIUY", false);
            dataGridView1.Rows.Add("3", "SDFGH", "LTDFGH", false);
            dataGridView1.Rows.Add("4", "ERJHGV", "CVHEYH", false);
            dataGridView1.Rows.Add("5", "AQSFGHKK", "TRDFHJH", false);
            dataGridView1.Rows.Add("6", "NQAAZTYI", "KITGHKG", false);
            dataGridView1.Rows.Add("7", "XBVSARY", "OTYHNC", false);
            dataGridView1.Rows.Add("8", "ACJKT", "PMLGESB", false);
            dataGridView1.Rows.Add("9", "FGHKL", "IUYTEYK", false);
            dataGridView1.Rows.Add("10", "WQAZR", "ERTYUVBD", false);
            dataGridView1.Rows.Add("11", "CKKTS", "EGCQA", false);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                bool delete = (bool)dataGridView1.Rows[i].Cells[3].Value;

                // if the checkbox cell is checked

                if (delete == true)
                {
                    DataGridViewRow rowToRemove = dataGridView1.Rows[i];

                    dataGridView1.Rows.Remove(rowToRemove);
                }
            }
        }
    }
}
