
namespace HelixStore.WinForm.Forms
{
    partial class OrdersForm
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
            this.Customer_Layout = new System.Windows.Forms.Panel();
            this.selected_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_view_detail = new System.Windows.Forms.Button();
            this.order_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Layout
            // 
            this.Customer_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Customer_Layout.Controls.Add(this.selected_id);
            this.Customer_Layout.Controls.Add(this.label1);
            this.Customer_Layout.Controls.Add(this.btn_view_detail);
            this.Customer_Layout.Controls.Add(this.order_table);
            this.Customer_Layout.Location = new System.Drawing.Point(0, 0);
            this.Customer_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Layout.Name = "Customer_Layout";
            this.Customer_Layout.Size = new System.Drawing.Size(952, 593);
            this.Customer_Layout.TabIndex = 0;
            // 
            // selected_id
            // 
            this.selected_id.AutoSize = true;
            this.selected_id.BackColor = System.Drawing.Color.Silver;
            this.selected_id.Location = new System.Drawing.Point(85, 557);
            this.selected_id.Name = "selected_id";
            this.selected_id.Size = new System.Drawing.Size(18, 15);
            this.selected_id.TabIndex = 3;
            this.selected_id.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected ID";
            // 
            // btn_view_detail
            // 
            this.btn_view_detail.Enabled = false;
            this.btn_view_detail.Location = new System.Drawing.Point(823, 544);
            this.btn_view_detail.Name = "btn_view_detail";
            this.btn_view_detail.Size = new System.Drawing.Size(120, 40);
            this.btn_view_detail.TabIndex = 1;
            this.btn_view_detail.Text = "View Detail";
            this.btn_view_detail.UseVisualStyleBackColor = true;
            this.btn_view_detail.Click += new System.EventHandler(this.btn_view_detail_Click);
            // 
            // order_table
            // 
            this.order_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.order_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.order_table.Location = new System.Drawing.Point(0, 0);
            this.order_table.Name = "order_table";
            this.order_table.RowTemplate.Height = 25;
            this.order_table.Size = new System.Drawing.Size(952, 538);
            this.order_table.TabIndex = 0;
            this.order_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_table_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Created";
            this.Column2.Name = "Column2";
            this.Column2.Width = 275;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer";
            this.Column3.Name = "Column3";
            this.Column3.Width = 275;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Staff";
            this.Column4.Name = "Column4";
            this.Column4.Width = 275;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 275;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Customer_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomersForm";
            this.Customer_Layout.ResumeLayout(false);
            this.Customer_Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Customer_Layout;
        private System.Windows.Forms.Label selected_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_view_detail;
        private System.Windows.Forms.DataGridView order_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}