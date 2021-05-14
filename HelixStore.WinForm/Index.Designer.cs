
namespace HelixStore.WinForm
{
    partial class Index
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
            this.Left_Sidebar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_staffs = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_userLoginRole = new System.Windows.Forms.Label();
            this.txt_userLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main_Content = new System.Windows.Forms.Panel();
            this.btn_customer = new System.Windows.Forms.Button();
            this.Left_Sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_Sidebar
            // 
            this.Left_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Left_Sidebar.Controls.Add(this.btn_customer);
            this.Left_Sidebar.Controls.Add(this.btn_logout);
            this.Left_Sidebar.Controls.Add(this.btn_invoice);
            this.Left_Sidebar.Controls.Add(this.btn_staffs);
            this.Left_Sidebar.Controls.Add(this.btn_products);
            this.Left_Sidebar.Controls.Add(this.btn_home);
            this.Left_Sidebar.Controls.Add(this.panel3);
            this.Left_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Left_Sidebar.Name = "Left_Sidebar";
            this.Left_Sidebar.Size = new System.Drawing.Size(200, 768);
            this.Left_Sidebar.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Image = global::HelixStore.WinForm.Properties.Resources.Logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.Location = new System.Drawing.Point(0, 700);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_logout.Size = new System.Drawing.Size(200, 68);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_invoice.FlatAppearance.BorderSize = 0;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice.Image = global::HelixStore.WinForm.Properties.Resources.invoice;
            this.btn_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_invoice.Location = new System.Drawing.Point(0, 373);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_invoice.Size = new System.Drawing.Size(200, 68);
            this.btn_invoice.TabIndex = 4;
            this.btn_invoice.Text = "Invoices";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_staffs
            // 
            this.btn_staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_staffs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staffs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_staffs.FlatAppearance.BorderSize = 0;
            this.btn_staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staffs.Image = global::HelixStore.WinForm.Properties.Resources.employee;
            this.btn_staffs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_staffs.Location = new System.Drawing.Point(0, 305);
            this.btn_staffs.Name = "btn_staffs";
            this.btn_staffs.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_staffs.Size = new System.Drawing.Size(200, 68);
            this.btn_staffs.TabIndex = 3;
            this.btn_staffs.Text = "Staffs";
            this.btn_staffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staffs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_staffs.UseVisualStyleBackColor = false;
            this.btn_staffs.Click += new System.EventHandler(this.btn_staffs_Click);
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Image = global::HelixStore.WinForm.Properties.Resources.storage;
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_products.Location = new System.Drawing.Point(0, 237);
            this.btn_products.Name = "btn_products";
            this.btn_products.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_products.Size = new System.Drawing.Size(200, 68);
            this.btn_products.TabIndex = 2;
            this.btn_products.Text = "Products";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_products.UseVisualStyleBackColor = false;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Image = global::HelixStore.WinForm.Properties.Resources.home;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.Location = new System.Drawing.Point(0, 169);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_home.Size = new System.Drawing.Size(200, 68);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txt_userLoginRole);
            this.panel3.Controls.Add(this.txt_userLogin);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 169);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HelixStore.WinForm.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_userLoginRole
            // 
            this.txt_userLoginRole.AutoSize = true;
            this.txt_userLoginRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_userLoginRole.Location = new System.Drawing.Point(66, 89);
            this.txt_userLoginRole.Name = "txt_userLoginRole";
            this.txt_userLoginRole.Size = new System.Drawing.Size(54, 19);
            this.txt_userLoginRole.TabIndex = 2;
            this.txt_userLoginRole.Text = "Admin";
            // 
            // txt_userLogin
            // 
            this.txt_userLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_userLogin.Location = new System.Drawing.Point(10, 54);
            this.txt_userLogin.Name = "txt_userLogin";
            this.txt_userLogin.Size = new System.Drawing.Size(180, 32);
            this.txt_userLogin.TabIndex = 1;
            this.txt_userLogin.Text = "Admin User";
            this.txt_userLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelixStore.WinForm.Properties.Resources.user;
            this.pictureBox1.InitialImage = global::HelixStore.WinForm.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Content
            // 
            this.Main_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Main_Content.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Main_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Content.Location = new System.Drawing.Point(200, 0);
            this.Main_Content.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Content.Name = "Main_Content";
            this.Main_Content.Size = new System.Drawing.Size(1240, 768);
            this.Main_Content.TabIndex = 1;
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btn_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Image = global::HelixStore.WinForm.Properties.Resources.user;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_customer.Location = new System.Drawing.Point(0, 441);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btn_customer.Size = new System.Drawing.Size(200, 68);
            this.btn_customer.TabIndex = 6;
            this.btn_customer.Text = "Customers";
            this.btn_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 768);
            this.Controls.Add(this.Main_Content);
            this.Controls.Add(this.Left_Sidebar);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helix";
            this.Left_Sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_Sidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_userLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Main_Content;
        private System.Windows.Forms.Label txt_userLoginRole;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button btn_staffs;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_customer;
    }
}

