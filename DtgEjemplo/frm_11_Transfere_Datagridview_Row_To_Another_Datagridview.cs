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
    public partial class frm_11_Transfere_Datagridview_Row_To_Another_Datagridview : Form
    {
        public frm_11_Transfere_Datagridview_Row_To_Another_Datagridview()
        {
            InitializeComponent();
        }

        private void frm_11_Transfere_Datagridview_Row_To_Another_Datagridview_Load(object sender, EventArgs e)
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
            dgvcCheckBox.HeaderText = "Select";

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

            // columns for dataGridView2
            DataGridViewTextBoxColumn dgvcId2 = new DataGridViewTextBoxColumn();
            dgvcId2.HeaderText = "Id";
            DataGridViewTextBoxColumn dgvcFn2 = new DataGridViewTextBoxColumn();
            dgvcFn2.HeaderText = "First Name";
            DataGridViewTextBoxColumn dgvcLn2 = new DataGridViewTextBoxColumn();
            dgvcLn2.HeaderText = "Last Name";
            dataGridView2.Columns.Add(dgvcId2);
            dataGridView2.Columns.Add(dgvcFn2);
            dataGridView2.Columns.Add(dgvcLn2);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // loop to check if the checkbox cell is checked
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                // rowAlreadyExist => if the row already exist on dataGridView2
                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dataGridView1.Rows[i].Cells[3].Value;
                if (checkedCell == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    // the dataGridView2 have one row or more
                    if (dataGridView2.Rows.Count != 0)
                    {
                        // loop to see if the row already exist on dataGridView2
                        for (int j = 0; j <= dataGridView2.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dataGridView2.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }

                        // add if the row ont exist on dataGridView2
                        if (rowAlreadyExist == false)
                        {
                            dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                        }
                    }

                    // add if the dataGridView2 have no row 
                    else
                    {
                        dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                    }
                }
            }
        }
    }
}
