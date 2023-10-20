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
    public partial class frm_02_add_row : Form
    {
        DataTable table = new DataTable();

        public frm_02_add_row()
        {
            InitializeComponent();
        }

        private void frm_02_add_row_Load(object sender, EventArgs e)
        {
            // set datatable columns values
            table.Columns.Add("Id", typeof(int));// data type int
            table.Columns.Add("First Name", typeof(string));// datatype string
            table.Columns.Add("Last Name", typeof(string));// datatype string
            table.Columns.Add("Age", typeof(int));// data type int

            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBoxID.Text, textBoxFN.Text, textBoxLN.Text, textBoxAGE.Text);
            dataGridView1.DataSource = table;
        }
    }
}
