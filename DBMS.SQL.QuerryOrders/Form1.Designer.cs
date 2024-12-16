namespace DBMS.SQL.QuerryOrders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrders = new DataGridView();
            ogvDetail = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ControlLight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(35, 29);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1201, 258);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellMouseUp += dgvOrders_CellMouseUp;
            // 
            // ogvDetail
            // 
            ogvDetail.BackgroundColor = SystemColors.ControlLight;
            ogvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogvDetail.Location = new Point(35, 328);
            ogvDetail.Name = "ogvDetail";
            ogvDetail.Size = new Size(1201, 188);
            ogvDetail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(35, 1);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "ใบสั่งซื้อ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(35, 300);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 3;
            label2.Text = "รายละเอียดสินค้า";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 536);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ogvDetail);
            Controls.Add(dgvOrders);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridView ogvDetail;
        private Label label1;
        private Label label2;
    }
}
