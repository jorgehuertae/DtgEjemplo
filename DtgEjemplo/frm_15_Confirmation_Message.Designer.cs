namespace DtgEjemplo
{
    partial class frm_15_Confirmation_Message
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
            BTN_REMOVE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 438);
            dataGridView1.TabIndex = 1;
            // 
            // BTN_REMOVE
            // 
            BTN_REMOVE.Location = new Point(12, 466);
            BTN_REMOVE.Name = "BTN_REMOVE";
            BTN_REMOVE.Size = new Size(75, 23);
            BTN_REMOVE.TabIndex = 2;
            BTN_REMOVE.Text = "REMOVE";
            BTN_REMOVE.UseVisualStyleBackColor = true;
            BTN_REMOVE.Click += BTN_REMOVE_Click;
            // 
            // frm_15_Confirmation_Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 517);
            Controls.Add(BTN_REMOVE);
            Controls.Add(dataGridView1);
            Name = "frm_15_Confirmation_Message";
            Text = "frm_15_Confirmation_Message";
            Load += frm_15_Confirmation_Message_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BTN_REMOVE;
    }
}