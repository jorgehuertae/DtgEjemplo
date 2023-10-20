using Newtonsoft.Json.Linq;
using System.Data;

namespace DtgEjemplo
{
    public partial class frm_03_display_data_selected : Form
    {

        DataTable table = new DataTable();

        int selectedRow;

        public frm_03_display_data_selected()
        {
            InitializeComponent();
        }

        private void frm_03_display_data_selected_Load(object sender, EventArgs e)
        {
            // set datatable columns values
            table.Columns.Add("Id", typeof(int));// data type int
            table.Columns.Add("Nombre", typeof(string));// data type string
            table.Columns.Add("Apellido", typeof(string));// data type int
            table.Columns.Add("Edad", typeof(int));// data type string

            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);

            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add row to datatable from textboxes
            table.Rows.Add(textBoxID.Text, textBoxFN.Text, textBoxLN.Text, textBoxAGE.Text);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];

            newDataRow.Cells[0].Value = textBoxID.Text;
            newDataRow.Cells[1].Value = textBoxFN.Text;
            newDataRow.Cells[2].Value = textBoxLN.Text;
            newDataRow.Cells[3].Value = textBoxAGE.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the index of the selected row in datagridview
            //and delete a row from datatable
            //and bind the datagridview with datatable
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }



        private void btnToList_Click(object sender, EventArgs e)
        {
            var _objectList = JArray.FromObject(table).ToObject<List<Persona>>();
            var _obj = _objectList!.FirstOrDefault();
        }

        private class Persona
        {
            public Persona()
            {
            }

            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public string Apellido { get; set; } = string.Empty;
            public int Edad { get; set; }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;// get the Row Index
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxFN.Text = row.Cells[1].Value.ToString();
            textBoxLN.Text = row.Cells[2].Value.ToString();
            textBoxAGE.Text = row.Cells[3].Value.ToString();
        }
    }
}
