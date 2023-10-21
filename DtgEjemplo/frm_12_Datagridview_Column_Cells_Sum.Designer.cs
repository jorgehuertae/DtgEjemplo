namespace DtgEjemplo
{
    partial class frm_12_Datagridview_Column_Cells_Sum
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
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            textBoxSum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 367);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(12, 437);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(100, 23);
            textBoxSum.TabIndex = 3;
            // 
            // frm_12_Datagridview_Column_Cells_Sum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 493);
            Controls.Add(textBoxSum);
            Controls.Add(dataGridView1);
            Name = "frm_12_Datagridview_Column_Cells_Sum";
            Text = "frm_12_Datagridview_Column_Cells_Sum";
            Load += frm_12_Datagridview_Column_Cells_Sum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxSum;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
    }
}