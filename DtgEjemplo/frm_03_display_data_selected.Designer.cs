namespace DtgEjemplo
{
    partial class frm_03_display_data_selected
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
            textBoxAGE = new TextBox();
            label4 = new Label();
            textBoxLN = new TextBox();
            label3 = new Label();
            textBoxFN = new TextBox();
            label2 = new Label();
            btnUpdate = new Button();
            textBoxID = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnToList = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(464, 426);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBoxAGE
            // 
            textBoxAGE.Location = new Point(83, 158);
            textBoxAGE.Name = "textBoxAGE";
            textBoxAGE.Size = new Size(100, 23);
            textBoxAGE.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 161);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 17;
            label4.Text = "Edad";
            // 
            // textBoxLN
            // 
            textBoxLN.Location = new Point(83, 115);
            textBoxLN.Name = "textBoxLN";
            textBoxLN.Size = new Size(100, 23);
            textBoxLN.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 118);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(83, 70);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(100, 23);
            textBoxFN.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(48, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(83, 26);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(48, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnToList
            // 
            btnToList.Location = new Point(48, 351);
            btnToList.Name = "btnToList";
            btnToList.Size = new Size(135, 23);
            btnToList.TabIndex = 21;
            btnToList.Text = "ToList";
            btnToList.UseVisualStyleBackColor = true;
            btnToList.Click += btnToList_Click;
            // 
            // frm_03_display_data_selected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToList);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(textBoxAGE);
            Controls.Add(label4);
            Controls.Add(textBoxLN);
            Controls.Add(label3);
            Controls.Add(textBoxFN);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frm_03_display_data_selected";
            Text = "frm_03_display_data_selected";
            Load += frm_03_display_data_selected_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxAGE;
        private Label label4;
        private TextBox textBoxLN;
        private Label label3;
        private TextBox textBoxFN;
        private Label label2;
        private Button btnUpdate;
        private TextBox textBoxID;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnToList;
    }
}