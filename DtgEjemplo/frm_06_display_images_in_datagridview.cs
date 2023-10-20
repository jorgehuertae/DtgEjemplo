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
    public partial class frm_06_display_images_in_datagridview : Form
    {
        public frm_06_display_images_in_datagridview()
        {
            InitializeComponent();
        }

        private void frm_06_display_images_in_datagridview_Load(object sender, EventArgs e)
        {
            // create Datagridview image column
            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            // set header text to the column
            dgvImageColumn.HeaderText = "Image";
            // display the entire image
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // create Datagridview text column
            DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
            dgvIdColumn.HeaderText = "Id";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 130;

            dataGridView1.AllowUserToAddRows = false;


            dataGridView1.Columns.Add(dgvIdColumn);
            dataGridView1.Columns.Add(dgvImageColumn);

            // create and add images to the dataGridView
            Image img1;
            img1 = Image.FromFile(@"D:\Images\logo1.png");
            dataGridView1.Rows.Add("RTUIKJGRR", img1);

            Image img2;
            img2 = Image.FromFile(@"D:\Images\logo2.png");
            dataGridView1.Rows.Add("AZERTYU", img2);

            Image img3;
            img3 = Image.FromFile(@"D:\Images\logo3.png");
            dataGridView1.Rows.Add("MLKJHG", img3);

            Image img4;
            img4 = Image.FromFile(@"D:\Images\logo4.png");
            dataGridView1.Rows.Add("FGHJKLKUY", img4);

            Image img5;
            img5 = Image.FromFile(@"D:\Images\logo5.png");
            dataGridView1.Rows.Add("VBJHGF", img5);
        }
    }
}
