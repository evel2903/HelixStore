using HelixStore.Business.Staffs.Manage;
using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelixStore.WinForm.Forms
{
    public partial class StaffForm : Form
    {
        private ManageStaffService manage = new ManageStaffService();
        public StaffForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btn_del.Enabled = false;
            btn_edit.Enabled = false;

            LoadTable();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(manage.Create(GetStaff()) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Failed!");
            }

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Staff staff = GetStaff();
            if (manage.Update(staff.StaffId, staff) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Failed!");
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Staff staff = GetStaff();
            if (manage.Delete(staff.StaffId) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            ResetFormInput();
        }

        private Staff GetStaff()
        {
            Staff staff = new Staff();
            staff.StaffId = int.Parse(staff_id.Text);
            staff.StaffFullname = staff_fullname.Text;
            staff.StaffGender = staff_gender_male.Checked ? "Male" : "Female";
            staff.StaffAddress = staff_address.Text;
            staff.StaffPhone = staff_phone.Text;
            staff.StaffPassword = staff_password.Text;
            staff.RoleId = staff_role.Checked ? 0 : 1;
            return staff;
        }

        private void ResetFormInput()
        {
            btn_add.Enabled = true;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;

            staff_id.Text = "-1";
            staff_fullname.Text = "";
            staff_gender_male.Checked = false;
            staff_address.Text = "";
            staff_phone.Text = "";
            staff_password.Text = "";
            staff_role.Checked = false;
        }

        private void LoadTable()
        {
            staff_table.Rows.Clear();
            List<Staff> staffs = manage.GetAll();

            staffs.ForEach(s =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(staff_table);

                row.Cells[0].Value = s.StaffId;
                row.Cells[1].Value = s.StaffFullname;
                row.Cells[2].Value = s.StaffGender;
                row.Cells[3].Value = s.StaffAddress;
                row.Cells[4].Value = s.StaffPhone;
                row.Cells[5].Value = s.StaffPassword;
                row.Cells[6].Value = s.RoleId == 0 ? "Admin" : "Staff";
                staff_table.Rows.Add(row);

            });
        }

        private void staff_table_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staff_table.Rows[e.RowIndex];

                if(row.Cells[0].Value != null)
                {
                    btn_add.Enabled = false;
                    btn_del.Enabled = true;
                    btn_edit.Enabled = true;
                    Staff staff = GetStaffInTableRow(row);

                    staff_id.Text = staff.StaffId.ToString();
                    staff_fullname.Text = staff.StaffFullname;
                    staff_gender_male.Checked = staff.StaffGender == "Male" ? true : false;
                    staff_address.Text = staff.StaffAddress;
                    staff_phone.Text = staff.StaffPhone;
                    staff_password.Text = staff.StaffPassword;
                    staff_role.Checked = staff.RoleId == 0 ? true : false;
                }
                
            }
        }

        private Staff GetStaffInTableRow(DataGridViewRow row)
        {
            Staff staff = new Staff();

            staff.StaffId = int.Parse(row.Cells[0].Value.ToString());
            staff.StaffFullname = row.Cells[1].Value.ToString();
            staff.StaffGender = row.Cells[2].Value.ToString();
            staff.StaffAddress = row.Cells[3].Value.ToString();
            staff.StaffPhone = row.Cells[4].Value.ToString();
            staff.StaffPassword = row.Cells[5].Value.ToString();
            staff.RoleId = row.Cells[6].Value.ToString() == "Admin" ? 0 : 1;

            return staff;
        }


    }
}
