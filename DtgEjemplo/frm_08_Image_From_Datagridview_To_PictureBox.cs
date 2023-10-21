using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DtgEjemplo
{
    public partial class frm_08_Image_From_Datagridview_To_PictureBox : Form
    {
        public frm_08_Image_From_Datagridview_To_PictureBox()
        {
            InitializeComponent();
        }

        private void frm_08_Image_From_Datagridview_To_PictureBox_Load(object sender, EventArgs e)
        {
            //create a DataGridView Image Column
            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            //set a header text to DataGridView Image Column
            dgvImageColumn.HeaderText = "Image";
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
            dgvIdColumn.HeaderText = "Id";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 130;

            dataGridView1.AllowUserToAddRows = false;

            // add columns to datagridview
            dataGridView1.Columns.Add(dgvIdColumn);
            dataGridView1.Columns.Add(dgvImageColumn);

            // populate the datagridview with some message
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            MemoryStream ms = new MemoryStream();
            Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[1].Value;
            img.Save(ms, ImageFormat.Jpeg);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
