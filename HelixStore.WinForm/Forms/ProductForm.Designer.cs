
namespace HelixStore.WinForm.Forms
{
    partial class ProductForm
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
            this.Product_Layout = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.search_product_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.product_table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_img = new System.Windows.Forms.Button();
            this.product_img = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.product_description = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.product_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.product_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.update_amount = new System.Windows.Forms.Button();
            this.product_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.product_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.Product_Layout.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_img)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Product_Layout
            // 
            this.Product_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Product_Layout.Controls.Add(this.panel10);
            this.Product_Layout.Controls.Add(this.panel3);
            this.Product_Layout.Controls.Add(this.panel2);
            this.Product_Layout.Location = new System.Drawing.Point(0, 0);
            this.Product_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Product_Layout.Name = "Product_Layout";
            this.Product_Layout.Size = new System.Drawing.Size(952, 593);
            this.Product_Layout.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.search_product_type);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(216, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(736, 32);
            this.panel10.TabIndex = 3;
            // 
            // search_product_type
            // 
            this.search_product_type.FormattingEnabled = true;
            this.search_product_type.Location = new System.Drawing.Point(519, 4);
            this.search_product_type.Name = "search_product_type";
            this.search_product_type.Size = new System.Drawing.Size(213, 23);
            this.search_product_type.TabIndex = 1;
            this.search_product_type.SelectedValueChanged += new System.EventHandler(this.search_product_type_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.product_table);
            this.panel3.Location = new System.Drawing.Point(216, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 562);
            this.panel3.TabIndex = 2;
            // 
            // product_table
            // 
            this.product_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.product_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameproduct,
            this.amount,
            this.price,
            this.description,
            this.producttype,
            this.image});
            this.product_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_table.Location = new System.Drawing.Point(0, 0);
            this.product_table.Name = "product_table";
            this.product_table.RowTemplate.Height = 25;
            this.product_table.Size = new System.Drawing.Size(736, 562);
            this.product_table.TabIndex = 0;
            this.product_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_table_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // nameproduct
            // 
            this.nameproduct.HeaderText = "Name";
            this.nameproduct.Name = "nameproduct";
            this.nameproduct.Width = 150;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 70;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 152;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 250;
            // 
            // producttype
            // 
            this.producttype.HeaderText = "Product Type";
            this.producttype.Name = "producttype";
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 593);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add_img);
            this.panel1.Controls.Add(this.product_img);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 150);
            this.panel1.TabIndex = 3;
            // 
            // btn_add_img
            // 
            this.btn_add_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_img.Location = new System.Drawing.Point(125, 0);
            this.btn_add_img.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_img.Name = "btn_add_img";
            this.btn_add_img.Size = new System.Drawing.Size(75, 23);
            this.btn_add_img.TabIndex = 3;
            this.btn_add_img.Text = "Add";
            this.btn_add_img.UseVisualStyleBackColor = true;
            this.btn_add_img.Click += new System.EventHandler(this.btn_add_img_Click);
            // 
            // product_img
            // 
            this.product_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_img.Location = new System.Drawing.Point(0, 36);
            this.product_img.Name = "product_img";
            this.product_img.Size = new System.Drawing.Size(200, 114);
            this.product_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_img.TabIndex = 2;
            this.product_img.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Product Image";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(135, 561);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 32);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(8, 561);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(135, 523);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 32);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(8, 523);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.product_description);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(8, 188);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 123);
            this.panel9.TabIndex = 6;
            // 
            // product_description
            // 
            this.product_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_description.Location = new System.Drawing.Point(0, 21);
            this.product_description.Name = "product_description";
            this.product_description.Size = new System.Drawing.Size(200, 100);
            this.product_description.TabIndex = 2;
            this.product_description.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.product_price);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(8, 137);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 45);
            this.panel8.TabIndex = 5;
            // 
            // product_price
            // 
            this.product_price.Location = new System.Drawing.Point(0, 22);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(200, 23);
            this.product_price.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.product_id);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 23);
            this.panel7.TabIndex = 5;
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.BackColor = System.Drawing.Color.Silver;
            this.product_id.Location = new System.Drawing.Point(27, 3);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(18, 15);
            this.product_id.TabIndex = 2;
            this.product_id.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.update_amount);
            this.panel6.Controls.Add(this.product_amount);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(8, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 45);
            this.panel6.TabIndex = 4;
            // 
            // update_amount
            // 
            this.update_amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_amount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_amount.Location = new System.Drawing.Point(77, 0);
            this.update_amount.Name = "update_amount";
            this.update_amount.Size = new System.Drawing.Size(122, 23);
            this.update_amount.TabIndex = 3;
            this.update_amount.Text = "InventoryReceiving";
            this.update_amount.UseVisualStyleBackColor = true;
            this.update_amount.Click += new System.EventHandler(this.update_amount_Click);
            // 
            // product_amount
            // 
            this.product_amount.Enabled = false;
            this.product_amount.Location = new System.Drawing.Point(0, 22);
            this.product_amount.Name = "product_amount";
            this.product_amount.Size = new System.Drawing.Size(200, 23);
            this.product_amount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.product_name);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 45);
            this.panel5.TabIndex = 3;
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(0, 22);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(200, 23);
            this.product_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.product_type);
            this.panel4.Location = new System.Drawing.Point(8, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 45);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Type";
            // 
            // product_type
            // 
            this.product_type.FormattingEnabled = true;
            this.product_type.Location = new System.Drawing.Point(0, 21);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(200, 23);
            this.product_type.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Product_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductForm";
            this.Product_Layout.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_img)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Product_Layout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView product_table;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RichTextBox product_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox product_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox product_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_img;
        private System.Windows.Forms.PictureBox product_img;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox search_product_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.Button update_amount;
    }
}