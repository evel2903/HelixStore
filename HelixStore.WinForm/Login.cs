using HelixStore.Business.Staffs.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelixStore.WinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.Length == 0 || txt_phone.Text.Length == 0)
            {
                MessageBox.Show("Enter your phone number & password");
                return;
            }
            
            var res = new PublicStaffService().FindByPhoneAndPassword(txt_phone.Text, txt_password.Text);
            if (res == null)
            {
                MessageBox.Show("Wrong phone number or password");
                return;
            }
            this.Hide();
            new Index(res).Show();

        }
    }
}
