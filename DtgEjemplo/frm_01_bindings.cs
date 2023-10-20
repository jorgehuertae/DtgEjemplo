using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DtgEjemplo
{
    public partial class frm_01_bindings : Form
    {
        public frm_01_bindings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            // add columns to datatable
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));

            // add rows to datatable
            table.Rows.Add(1, "First A", "Last A", 10, "10/10/2023");
            table.Rows.Add(2, "First B", "Last B", 20, "28/02/2023");
            //table.Rows.Add(3, "First C", "Last C", 30);
            //table.Rows.Add(4, "First D", "Last D", 40);
            //table.Rows.Add(5, "First E", "Last E", 50);
            //table.Rows.Add(6, "First F", "Last F", 60);
            //table.Rows.Add(7, "First G", "Last G", 70);
            //table.Rows.Add(8, "First H", "Last H", 80);

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
    }
}