
namespace HelixStore.WinForm.Report
{
    partial class InvoiceReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReportForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel_invoice = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.recipient = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rows_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pa = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel_invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rows_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice";
            // 
            // panel_invoice
            // 
            this.panel_invoice.Controls.Add(this.label10);
            this.panel_invoice.Controls.Add(this.staff);
            this.panel_invoice.Controls.Add(this.customer);
            this.panel_invoice.Controls.Add(this.label9);
            this.panel_invoice.Controls.Add(this.phone);
            this.panel_invoice.Controls.Add(this.recipient);
            this.panel_invoice.Controls.Add(this.address);
            this.panel_invoice.Controls.Add(this.label5);
            this.panel_invoice.Controls.Add(this.label3);
            this.panel_invoice.Controls.Add(this.label1);
            this.panel_invoice.Controls.Add(this.rows_table);
            this.panel_invoice.Controls.Add(this.date);
            this.panel_invoice.Controls.Add(this.label8);
            this.panel_invoice.Controls.Add(this.label7);
            this.panel_invoice.Controls.Add(this.label6);
            this.panel_invoice.Controls.Add(this.discount);
            this.panel_invoice.Controls.Add(this.label4);
            this.panel_invoice.Controls.Add(this.pa);
            this.panel_invoice.Controls.Add(this.total);
            this.panel_invoice.Controls.Add(this.label2);
            this.panel_invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_invoice.Location = new System.Drawing.Point(0, 0);
            this.panel_invoice.Name = "panel_invoice";
            this.panel_invoice.Size = new System.Drawing.Size(495, 704);
            this.panel_invoice.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Staff";
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.Silver;
            this.staff.Location = new System.Drawing.Point(311, 121);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(172, 23);
            this.staff.TabIndex = 19;
            this.staff.Text = "yyyy/mm/dd";
            this.staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Silver;
            this.customer.Location = new System.Drawing.Point(12, 121);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(172, 23);
            this.customer.TabIndex = 18;
            this.customer.Text = "yyyy/mm/dd";
            this.customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Silver;
            this.phone.Location = new System.Drawing.Point(269, 567);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(224, 23);
            this.phone.TabIndex = 16;
            this.phone.Text = "0";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recipient
            // 
            this.recipient.BackColor = System.Drawing.Color.Silver;
            this.recipient.Location = new System.Drawing.Point(2, 567);
            this.recipient.Name = "recipient";
            this.recipient.Size = new System.Drawing.Size(224, 23);
            this.recipient.TabIndex = 15;
            this.recipient.Text = "0";
            this.recipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Silver;
            this.address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.address.Location = new System.Drawing.Point(2, 623);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(491, 23);
            this.address.TabIndex = 14;
            this.address.Text = "0";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recipient";
            // 
            // rows_table
            // 
            this.rows_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rows_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rows_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rows_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.rows_table.Location = new System.Drawing.Point(12, 158);
            this.rows_table.Name = "rows_table";
            this.rows_table.RowTemplate.Height = 25;
            this.rows_table.Size = new System.Drawing.Size(471, 375);
            this.rows_table.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 118;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Silver;
            this.date.Location = new System.Drawing.Point(114, 71);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(264, 23);
            this.date.TabIndex = 9;
            this.date.Text = "yyyy/mm/dd";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Create";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.Silver;
            this.discount.Location = new System.Drawing.Point(172, 679);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(150, 23);
            this.discount.TabIndex = 5;
            this.discount.Text = "0";
            this.discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Provisional Amount";
            // 
            // pa
            // 
            this.pa.BackColor = System.Drawing.Color.Silver;
            this.pa.Location = new System.Drawing.Point(2, 679);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(150, 23);
            this.pa.TabIndex = 3;
            this.pa.Text = "0";
            this.pa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Silver;
            this.total.Location = new System.Drawing.Point(343, 679);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(150, 23);
            this.total.TabIndex = 2;
            this.total.Text = "0";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(420, 710);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 34);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // InvoiceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 745);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel_invoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InvoiceReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Report";
            this.panel_invoice.ResumeLayout(false);
            this.panel_invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rows_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_invoice;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridView rows_table;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label recipient;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label staff;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label label9;
    }
}