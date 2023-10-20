namespace DtgEjemplo
{
    partial class frm_07_Add_Image_To_Datagridview_From_PictureBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            BtnBrowseImage = new Button();
            pictureBox1 = new PictureBox();
            BtnAdd = new Button();
            textBoxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(168, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(464, 426);
            dataGridView1.TabIndex = 4;
            // 
            // BtnBrowseImage
            // 
            BtnBrowseImage.Location = new Point(48, 12);
            BtnBrowseImage.Name = "BtnBrowseImage";
            BtnBrowseImage.Size = new Size(75, 23);
            BtnBrowseImage.TabIndex = 5;
            BtnBrowseImage.Text = "Search";
            BtnBrowseImage.UseVisualStyleBackColor = true;
            BtnBrowseImage.Click += BtnBrowseImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 140);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(48, 221);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 7;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(12, 266);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(150, 23);
            textBoxId.TabIndex = 8;
            // 
            // frm_07_Add_Image_To_Datagridview_From_PictureBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxId);
            Controls.Add(BtnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(BtnBrowseImage);
            Controls.Add(dataGridView1);
            Name = "frm_07_Add_Image_To_Datagridview_From_PictureBox";
            Text = "frm_07_Add_Image_To_Datagridview_From_PictureBox";
            Load += frm_07_Add_Image_To_Datagridview_From_PictureBox_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnBrowseImage;
        private PictureBox pictureBox1;
        private Button BtnAdd;
        private TextBox textBoxId;
    }
}