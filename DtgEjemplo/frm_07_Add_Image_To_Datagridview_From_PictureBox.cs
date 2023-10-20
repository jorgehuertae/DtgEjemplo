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
    public partial class frm_07_Add_Image_To_Datagridview_From_PictureBox : Form
    {
        public frm_07_Add_Image_To_Datagridview_From_PictureBox()
        {
            InitializeComponent();
        }

        private void frm_07_Add_Image_To_Datagridview_From_PictureBox_Load(object sender, EventArgs e)
        {
            //create a DataGridView Image Column
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            //set a header test to DataGridView Image Column
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewTextBoxColumn dgvId = new DataGridViewTextBoxColumn();
            dgvId.HeaderText = "Id";

            dataGridView1.Columns.Add(dgvId);
            dataGridView1.Columns.Add(dgvImage);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                dataGridView1.Rows.Add(textBoxId.Text, img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
