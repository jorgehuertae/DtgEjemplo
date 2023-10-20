namespace DtgEjemplo
{
    partial class frm_02_add_row
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
            label1 = new Label();
            textBoxID = new TextBox();
            btnAdd = new Button();
            textBoxFN = new TextBox();
            label2 = new Label();
            textBoxLN = new TextBox();
            label3 = new Label();
            textBoxAGE = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(226, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(562, 426);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 82);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(89, 79);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(89, 123);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(100, 23);
            textBoxFN.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // textBoxLN
            // 
            textBoxLN.Location = new Point(89, 168);
            textBoxLN.Name = "textBoxLN";
            textBoxLN.Size = new Size(100, 23);
            textBoxLN.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // textBoxAGE
            // 
            textBoxAGE.Location = new Point(89, 211);
            textBoxAGE.Name = "textBoxAGE";
            textBoxAGE.Size = new Size(100, 23);
            textBoxAGE.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 214);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Edad";
            // 
            // frm_02_add_row
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAGE);
            Controls.Add(label4);
            Controls.Add(textBoxLN);
            Controls.Add(label3);
            Controls.Add(textBoxFN);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frm_02_add_row";
            Text = "frm_02_add_row";
            Load += frm_02_add_row_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxID;
        private Button btnAdd;
        private TextBox textBoxFN;
        private Label label2;
        private TextBox textBoxLN;
        private Label label3;
        private TextBox textBoxAGE;
        private Label label4;
    }
}