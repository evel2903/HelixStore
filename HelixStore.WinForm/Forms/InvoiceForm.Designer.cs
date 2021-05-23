
namespace HelixStore.WinForm.Forms
{
    partial class InvoiceForm
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
            this.Invoice_Layout = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.discount_apply = new System.Windows.Forms.Button();
            this.invoice_detail_table = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del_invoice_item = new System.Windows.Forms.Button();
            this.invoice_item_id_selected = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.invoice_provisionalAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.invoice_saveChange = new System.Windows.Forms.Button();
            this.invoice_changeAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_invoice_saveAndExport = new System.Windows.Forms.Button();
            this.invoice_total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.invoice_discount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.product_id_selected = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_select_product = new System.Windows.Forms.Button();
            this.product_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_productType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.new_deliveryAddress_phone = new System.Windows.Forms.TextBox();
            this.new_deliveryAddress_address = new System.Windows.Forms.TextBox();
            this.new_deliveryAddress_save = new System.Windows.Forms.Button();
            this.new_deliveryAddress_recipient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.select_deliveryAddress = new System.Windows.Forms.ComboBox();
            this.btn_new_deliveryAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.new_customer_save = new System.Windows.Forms.Button();
            this.new_customer_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_customer_gender = new System.Windows.Forms.CheckBox();
            this.new_customer_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.select_customer = new System.Windows.Forms.TextBox();
            this.btn_new_customer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_customer = new System.Windows.Forms.TextBox();
            this.btn_search_customer = new System.Windows.Forms.PictureBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_Layout.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_detail_table)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoice_Layout
            // 
            this.Invoice_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Invoice_Layout.Controls.Add(this.panel7);
            this.Invoice_Layout.Controls.Add(this.panel6);
            this.Invoice_Layout.Controls.Add(this.panel4);
            this.Invoice_Layout.Controls.Add(this.panel1);
            this.Invoice_Layout.Location = new System.Drawing.Point(0, 0);
            this.Invoice_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Invoice_Layout.Name = "Invoice_Layout";
            this.Invoice_Layout.Size = new System.Drawing.Size(952, 593);
            this.Invoice_Layout.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.discount_apply);
            this.panel7.Controls.Add(this.invoice_detail_table);
            this.panel7.Controls.Add(this.btn_del_invoice_item);
            this.panel7.Controls.Add(this.invoice_item_id_selected);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.invoice_provisionalAmount);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btn_invoice_saveAndExport);
            this.panel7.Controls.Add(this.invoice_total);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.invoice_discount);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(272, 98);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(680, 495);
            this.panel7.TabIndex = 3;
            // 
            // discount_apply
            // 
            this.discount_apply.Location = new System.Drawing.Point(618, 354);
            this.discount_apply.Name = "discount_apply";
            this.discount_apply.Size = new System.Drawing.Size(57, 23);
            this.discount_apply.TabIndex = 12;
            this.discount_apply.Text = "Apply";
            this.discount_apply.UseVisualStyleBackColor = true;
            this.discount_apply.Click += new System.EventHandler(this.discount_apply_Click);
            // 
            // invoice_detail_table
            // 
            this.invoice_detail_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.invoice_detail_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoice_detail_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Colum9});
            this.invoice_detail_table.Location = new System.Drawing.Point(1, 3);
            this.invoice_detail_table.Name = "invoice_detail_table";
            this.invoice_detail_table.RowTemplate.Height = 25;
            this.invoice_detail_table.Size = new System.Drawing.Size(477, 492);
            this.invoice_detail_table.TabIndex = 11;
            this.invoice_detail_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invoice_detail_table_CellMouseClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Raw ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Product Name";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Colum9
            // 
            this.Colum9.HeaderText = "Total";
            this.Colum9.Name = "Colum9";
            this.Colum9.Width = 150;
            // 
            // btn_del_invoice_item
            // 
            this.btn_del_invoice_item.Enabled = false;
            this.btn_del_invoice_item.Location = new System.Drawing.Point(621, 1);
            this.btn_del_invoice_item.Name = "btn_del_invoice_item";
            this.btn_del_invoice_item.Size = new System.Drawing.Size(54, 23);
            this.btn_del_invoice_item.TabIndex = 10;
            this.btn_del_invoice_item.Text = "Del";
            this.btn_del_invoice_item.UseVisualStyleBackColor = true;
            this.btn_del_invoice_item.Click += new System.EventHandler(this.btn_del_invoice_item_Click);
            // 
            // invoice_item_id_selected
            // 
            this.invoice_item_id_selected.AutoSize = true;
            this.invoice_item_id_selected.BackColor = System.Drawing.Color.Silver;
            this.invoice_item_id_selected.Location = new System.Drawing.Point(569, 5);
            this.invoice_item_id_selected.Name = "invoice_item_id_selected";
            this.invoice_item_id_selected.Size = new System.Drawing.Size(18, 15);
            this.invoice_item_id_selected.TabIndex = 9;
            this.invoice_item_id_selected.Text = "-1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "ID Selected";
            // 
            // invoice_provisionalAmount
            // 
            this.invoice_provisionalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoice_provisionalAmount.Location = new System.Drawing.Point(483, 325);
            this.invoice_provisionalAmount.Name = "invoice_provisionalAmount";
            this.invoice_provisionalAmount.Size = new System.Drawing.Size(192, 23);
            this.invoice_provisionalAmount.TabIndex = 8;
            this.invoice_provisionalAmount.Text = "0";
            this.invoice_provisionalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Provisional Amount";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.invoice_saveChange);
            this.panel8.Controls.Add(this.invoice_changeAmount);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(483, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(192, 107);
            this.panel8.TabIndex = 6;
            // 
            // invoice_saveChange
            // 
            this.invoice_saveChange.Enabled = false;
            this.invoice_saveChange.Location = new System.Drawing.Point(44, 59);
            this.invoice_saveChange.Name = "invoice_saveChange";
            this.invoice_saveChange.Size = new System.Drawing.Size(100, 32);
            this.invoice_saveChange.TabIndex = 4;
            this.invoice_saveChange.Text = "Save Change";
            this.invoice_saveChange.UseVisualStyleBackColor = true;
            this.invoice_saveChange.Click += new System.EventHandler(this.invoice_saveChange_Click);
            // 
            // invoice_changeAmount
            // 
            this.invoice_changeAmount.Location = new System.Drawing.Point(3, 21);
            this.invoice_changeAmount.Name = "invoice_changeAmount";
            this.invoice_changeAmount.Size = new System.Drawing.Size(182, 23);
            this.invoice_changeAmount.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Change Amount";
            // 
            // btn_invoice_saveAndExport
            // 
            this.btn_invoice_saveAndExport.Location = new System.Drawing.Point(483, 458);
            this.btn_invoice_saveAndExport.Name = "btn_invoice_saveAndExport";
            this.btn_invoice_saveAndExport.Size = new System.Drawing.Size(192, 32);
            this.btn_invoice_saveAndExport.TabIndex = 5;
            this.btn_invoice_saveAndExport.Text = "Save And Export";
            this.btn_invoice_saveAndExport.UseVisualStyleBackColor = true;
            this.btn_invoice_saveAndExport.Click += new System.EventHandler(this.btn_invoice_saveAndExport_Click);
            // 
            // invoice_total
            // 
            this.invoice_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoice_total.Location = new System.Drawing.Point(483, 432);
            this.invoice_total.Name = "invoice_total";
            this.invoice_total.Size = new System.Drawing.Size(192, 23);
            this.invoice_total.TabIndex = 2;
            this.invoice_total.Text = "0";
            this.invoice_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(483, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Discount";
            // 
            // invoice_discount
            // 
            this.invoice_discount.Location = new System.Drawing.Point(483, 378);
            this.invoice_discount.Name = "invoice_discount";
            this.invoice_discount.Size = new System.Drawing.Size(192, 23);
            this.invoice_discount.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.product_id_selected);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.btn_select_product);
            this.panel6.Controls.Add(this.product_table);
            this.panel6.Controls.Add(this.select_productType);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(0, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 495);
            this.panel6.TabIndex = 2;
            // 
            // product_id_selected
            // 
            this.product_id_selected.AutoSize = true;
            this.product_id_selected.BackColor = System.Drawing.Color.Silver;
            this.product_id_selected.Location = new System.Drawing.Point(93, 453);
            this.product_id_selected.Name = "product_id_selected";
            this.product_id_selected.Size = new System.Drawing.Size(18, 15);
            this.product_id_selected.TabIndex = 5;
            this.product_id_selected.Text = "-1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "ID Selected";
            // 
            // btn_select_product
            // 
            this.btn_select_product.Location = new System.Drawing.Point(181, 453);
            this.btn_select_product.Name = "btn_select_product";
            this.btn_select_product.Size = new System.Drawing.Size(75, 32);
            this.btn_select_product.TabIndex = 3;
            this.btn_select_product.Text = "Select";
            this.btn_select_product.UseVisualStyleBackColor = true;
            this.btn_select_product.Click += new System.EventHandler(this.btn_select_product_Click);
            // 
            // product_table
            // 
            this.product_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.product_table.Location = new System.Drawing.Point(0, 50);
            this.product_table.Name = "product_table";
            this.product_table.RowTemplate.Height = 25;
            this.product_table.Size = new System.Drawing.Size(266, 397);
            this.product_table.TabIndex = 2;
            this.product_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_table_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // select_productType
            // 
            this.select_productType.FormattingEnabled = true;
            this.select_productType.Location = new System.Drawing.Point(2, 21);
            this.select_productType.Name = "select_productType";
            this.select_productType.Size = new System.Drawing.Size(264, 23);
            this.select_productType.TabIndex = 1;
            this.select_productType.SelectedIndexChanged += new System.EventHandler(this.select_productType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Product Type";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.select_deliveryAddress);
            this.panel4.Controls.Add(this.btn_new_deliveryAddress);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(499, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 92);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.new_deliveryAddress_phone);
            this.panel5.Controls.Add(this.new_deliveryAddress_address);
            this.panel5.Controls.Add(this.new_deliveryAddress_save);
            this.panel5.Controls.Add(this.new_deliveryAddress_recipient);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(165, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 85);
            this.panel5.TabIndex = 10;
            // 
            // new_deliveryAddress_phone
            // 
            this.new_deliveryAddress_phone.Location = new System.Drawing.Point(67, 54);
            this.new_deliveryAddress_phone.Name = "new_deliveryAddress_phone";
            this.new_deliveryAddress_phone.Size = new System.Drawing.Size(130, 23);
            this.new_deliveryAddress_phone.TabIndex = 10;
            // 
            // new_deliveryAddress_address
            // 
            this.new_deliveryAddress_address.Location = new System.Drawing.Point(67, 29);
            this.new_deliveryAddress_address.Name = "new_deliveryAddress_address";
            this.new_deliveryAddress_address.Size = new System.Drawing.Size(130, 23);
            this.new_deliveryAddress_address.TabIndex = 8;
            // 
            // new_deliveryAddress_save
            // 
            this.new_deliveryAddress_save.Location = new System.Drawing.Point(206, 21);
            this.new_deliveryAddress_save.Name = "new_deliveryAddress_save";
            this.new_deliveryAddress_save.Size = new System.Drawing.Size(75, 42);
            this.new_deliveryAddress_save.TabIndex = 9;
            this.new_deliveryAddress_save.Text = "Save";
            this.new_deliveryAddress_save.UseVisualStyleBackColor = true;
            this.new_deliveryAddress_save.Click += new System.EventHandler(this.new_deliveryAddress_save_Click);
            // 
            // new_deliveryAddress_recipient
            // 
            this.new_deliveryAddress_recipient.Location = new System.Drawing.Point(67, 3);
            this.new_deliveryAddress_recipient.Name = "new_deliveryAddress_recipient";
            this.new_deliveryAddress_recipient.Size = new System.Drawing.Size(130, 23);
            this.new_deliveryAddress_recipient.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Recipient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phone";
            // 
            // select_deliveryAddress
            // 
            this.select_deliveryAddress.FormattingEnabled = true;
            this.select_deliveryAddress.Location = new System.Drawing.Point(0, 37);
            this.select_deliveryAddress.Name = "select_deliveryAddress";
            this.select_deliveryAddress.Size = new System.Drawing.Size(159, 23);
            this.select_deliveryAddress.TabIndex = 2;
            this.select_deliveryAddress.SelectedIndexChanged += new System.EventHandler(this.select_deliveryAddress_SelectedIndexChanged);
            // 
            // btn_new_deliveryAddress
            // 
            this.btn_new_deliveryAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_deliveryAddress.Location = new System.Drawing.Point(84, 3);
            this.btn_new_deliveryAddress.Name = "btn_new_deliveryAddress";
            this.btn_new_deliveryAddress.Size = new System.Drawing.Size(75, 23);
            this.btn_new_deliveryAddress.TabIndex = 4;
            this.btn_new_deliveryAddress.Text = "New";
            this.btn_new_deliveryAddress.UseVisualStyleBackColor = true;
            this.btn_new_deliveryAddress.Click += new System.EventHandler(this.btn_new_deliveryAddress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Delivery\r\nAddress\r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.new_customer_save);
            this.panel2.Controls.Add(this.new_customer_phone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.new_customer_gender);
            this.panel2.Controls.Add(this.new_customer_fullname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(161, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 85);
            this.panel2.TabIndex = 1;
            // 
            // new_customer_save
            // 
            this.new_customer_save.Location = new System.Drawing.Point(250, 16);
            this.new_customer_save.Name = "new_customer_save";
            this.new_customer_save.Size = new System.Drawing.Size(75, 42);
            this.new_customer_save.TabIndex = 9;
            this.new_customer_save.Text = "Save";
            this.new_customer_save.UseVisualStyleBackColor = true;
            this.new_customer_save.Click += new System.EventHandler(this.new_customer_save_Click);
            // 
            // new_customer_phone
            // 
            this.new_customer_phone.Location = new System.Drawing.Point(67, 54);
            this.new_customer_phone.Name = "new_customer_phone";
            this.new_customer_phone.Size = new System.Drawing.Size(179, 23);
            this.new_customer_phone.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fullname";
            // 
            // new_customer_gender
            // 
            this.new_customer_gender.AutoSize = true;
            this.new_customer_gender.Location = new System.Drawing.Point(67, 29);
            this.new_customer_gender.Name = "new_customer_gender";
            this.new_customer_gender.Size = new System.Drawing.Size(52, 19);
            this.new_customer_gender.TabIndex = 6;
            this.new_customer_gender.Text = "Male";
            this.new_customer_gender.UseVisualStyleBackColor = true;
            // 
            // new_customer_fullname
            // 
            this.new_customer_fullname.Location = new System.Drawing.Point(67, 3);
            this.new_customer_fullname.Name = "new_customer_fullname";
            this.new_customer_fullname.Size = new System.Drawing.Size(179, 23);
            this.new_customer_fullname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.select_customer);
            this.panel3.Controls.Add(this.btn_new_customer);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.search_customer);
            this.panel3.Controls.Add(this.btn_search_customer);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 90);
            this.panel3.TabIndex = 1;
            // 
            // select_customer
            // 
            this.select_customer.Enabled = false;
            this.select_customer.Location = new System.Drawing.Point(2, 67);
            this.select_customer.Name = "select_customer";
            this.select_customer.Size = new System.Drawing.Size(154, 23);
            this.select_customer.TabIndex = 1;
            // 
            // btn_new_customer
            // 
            this.btn_new_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_customer.Location = new System.Drawing.Point(81, 43);
            this.btn_new_customer.Name = "btn_new_customer";
            this.btn_new_customer.Size = new System.Drawing.Size(75, 23);
            this.btn_new_customer.TabIndex = 3;
            this.btn_new_customer.Text = "New";
            this.btn_new_customer.UseVisualStyleBackColor = true;
            this.btn_new_customer.Click += new System.EventHandler(this.btn_new_customer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by PhoneNumber";
            // 
            // search_customer
            // 
            this.search_customer.Location = new System.Drawing.Point(2, 21);
            this.search_customer.Name = "search_customer";
            this.search_customer.Size = new System.Drawing.Size(125, 23);
            this.search_customer.TabIndex = 1;
            // 
            // btn_search_customer
            // 
            this.btn_search_customer.Image = global::HelixStore.WinForm.Properties.Resources.ei_search;
            this.btn_search_customer.Location = new System.Drawing.Point(133, 21);
            this.btn_search_customer.Name = "btn_search_customer";
            this.btn_search_customer.Size = new System.Drawing.Size(23, 23);
            this.btn_search_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search_customer.TabIndex = 0;
            this.btn_search_customer.TabStop = false;
            this.btn_search_customer.Click += new System.EventHandler(this.btn_search_customer_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Raw ID";
            this.Column4.Name = "Column4";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Invoice_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoiceForm";
            this.Invoice_Layout.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_detail_table)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Invoice_Layout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button new_customer_save;
        private System.Windows.Forms.TextBox new_customer_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox new_customer_gender;
        private System.Windows.Forms.TextBox new_customer_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_customer;
        private System.Windows.Forms.PictureBox btn_search_customer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox select_deliveryAddress;
        private System.Windows.Forms.Button btn_new_deliveryAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_new_customer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox new_deliveryAddress_phone;
        private System.Windows.Forms.TextBox new_deliveryAddress_address;
        private System.Windows.Forms.Button new_deliveryAddress_save;
        private System.Windows.Forms.TextBox new_deliveryAddress_recipient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_select_product;
        private System.Windows.Forms.DataGridView product_table;
        private System.Windows.Forms.ComboBox select_productType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button invoice_saveChange;
        private System.Windows.Forms.TextBox invoice_changeAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox invoice_discount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_invoice_saveAndExport;
        private System.Windows.Forms.Label invoice_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox select_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label product_id_selected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label invoice_provisionalAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label invoice_item_id_selected;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_del_invoice_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView invoice_detail_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum9;
        private System.Windows.Forms.Button discount_apply;
    }
}