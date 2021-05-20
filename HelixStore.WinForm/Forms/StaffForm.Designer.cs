
namespace HelixStore.WinForm.Forms
{
    partial class StaffForm
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
            this.Staff_Layout = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staff_table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.staff_password = new System.Windows.Forms.TextBox();
            this.staff_phone = new System.Windows.Forms.TextBox();
            this.staff_address = new System.Windows.Forms.RichTextBox();
            this.staff_role = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staff_gender_male = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staff_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Staff_Layout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_Layout
            // 
            this.Staff_Layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Staff_Layout.Controls.Add(this.panel1);
            this.Staff_Layout.Controls.Add(this.btn_reset);
            this.Staff_Layout.Controls.Add(this.btn_del);
            this.Staff_Layout.Controls.Add(this.btn_edit);
            this.Staff_Layout.Controls.Add(this.btn_add);
            this.Staff_Layout.Controls.Add(this.staff_password);
            this.Staff_Layout.Controls.Add(this.staff_phone);
            this.Staff_Layout.Controls.Add(this.staff_address);
            this.Staff_Layout.Controls.Add(this.staff_role);
            this.Staff_Layout.Controls.Add(this.label7);
            this.Staff_Layout.Controls.Add(this.label6);
            this.Staff_Layout.Controls.Add(this.label5);
            this.Staff_Layout.Controls.Add(this.label2);
            this.Staff_Layout.Controls.Add(this.staff_gender_male);
            this.Staff_Layout.Controls.Add(this.label4);
            this.Staff_Layout.Controls.Add(this.staff_id);
            this.Staff_Layout.Controls.Add(this.label1);
            this.Staff_Layout.Controls.Add(this.staff_fullname);
            this.Staff_Layout.Controls.Add(this.label3);
            this.Staff_Layout.Location = new System.Drawing.Point(0, 0);
            this.Staff_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Staff_Layout.Name = "Staff_Layout";
            this.Staff_Layout.Size = new System.Drawing.Size(952, 593);
            this.Staff_Layout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.staff_table);
            this.panel1.Location = new System.Drawing.Point(246, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 577);
            this.panel1.TabIndex = 19;
            // 
            // staff_table
            // 
            this.staff_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.staff_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staff_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.gender,
            this.address,
            this.phone,
            this.password,
            this.role});
            this.staff_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staff_table.Location = new System.Drawing.Point(0, 0);
            this.staff_table.Name = "staff_table";
            this.staff_table.RowTemplate.Height = 25;
            this.staff_table.Size = new System.Drawing.Size(698, 577);
            this.staff_table.TabIndex = 15;
            this.staff_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.staff_table_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "FullName";
            this.fullname.Name = "fullname";
            this.fullname.Width = 145;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 80;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 150;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Width = 250;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.Width = 75;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(165, 379);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 32);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(165, 341);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 32);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(13, 379);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 341);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // staff_password
            // 
            this.staff_password.Location = new System.Drawing.Point(80, 252);
            this.staff_password.Name = "staff_password";
            this.staff_password.Size = new System.Drawing.Size(160, 23);
            this.staff_password.TabIndex = 13;
            // 
            // staff_phone
            // 
            this.staff_phone.Location = new System.Drawing.Point(80, 211);
            this.staff_phone.Name = "staff_phone";
            this.staff_phone.Size = new System.Drawing.Size(160, 23);
            this.staff_phone.TabIndex = 12;
            // 
            // staff_address
            // 
            this.staff_address.Location = new System.Drawing.Point(80, 114);
            this.staff_address.Name = "staff_address";
            this.staff_address.Size = new System.Drawing.Size(160, 79);
            this.staff_address.TabIndex = 11;
            this.staff_address.Text = "";
            // 
            // staff_role
            // 
            this.staff_role.AutoSize = true;
            this.staff_role.Location = new System.Drawing.Point(80, 291);
            this.staff_role.Name = "staff_role";
            this.staff_role.Size = new System.Drawing.Size(62, 19);
            this.staff_role.TabIndex = 10;
            this.staff_role.Text = "Admin";
            this.staff_role.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // staff_gender_male
            // 
            this.staff_gender_male.AutoSize = true;
            this.staff_gender_male.Location = new System.Drawing.Point(80, 80);
            this.staff_gender_male.Name = "staff_gender_male";
            this.staff_gender_male.Size = new System.Drawing.Size(52, 19);
            this.staff_gender_male.TabIndex = 5;
            this.staff_gender_male.Text = "Male";
            this.staff_gender_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // staff_id
            // 
            this.staff_id.AutoSize = true;
            this.staff_id.BackColor = System.Drawing.Color.Silver;
            this.staff_id.Location = new System.Drawing.Point(80, 9);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(18, 15);
            this.staff_id.TabIndex = 1;
            this.staff_id.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // staff_fullname
            // 
            this.staff_fullname.Location = new System.Drawing.Point(80, 36);
            this.staff_fullname.Name = "staff_fullname";
            this.staff_fullname.Size = new System.Drawing.Size(160, 23);
            this.staff_fullname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "FullName";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.Staff_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaffForm";
            this.Staff_Layout.ResumeLayout(false);
            this.Staff_Layout.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staff_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Staff_Layout;
        private System.Windows.Forms.TextBox staff_password;
        private System.Windows.Forms.TextBox staff_phone;
        private System.Windows.Forms.RichTextBox staff_address;
        private System.Windows.Forms.CheckBox staff_role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox staff_gender_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label staff_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staff_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView staff_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}