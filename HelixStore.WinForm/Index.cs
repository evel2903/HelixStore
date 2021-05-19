using HelixStore.WinForm.Forms;
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

namespace HelixStore.WinForm
{
    public partial class Index : Form
    {
        private Form currentLayoutForm;

        public Index()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_home);
            RenderMainLayout(new HomeForm());
            
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_products);
            RenderMainLayout(new ProductForm());
        }

        private void btn_staffs_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_staffs);
            RenderMainLayout(new StaffForm());
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_invoice);
            RenderMainLayout(new InvoiceForm());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_customer);
            RenderMainLayout(new CustomersForm());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_logout);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ActiveButton(Button btn)
        {
            //Reset to default
            btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            btn_staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            //Active button Clicked
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
        }

        private void RenderMainLayout(Form form)
        {
           

            if (currentLayoutForm != null)
            {
                currentLayoutForm.Close();
                Main_Content.Controls.Clear();
            }

            currentLayoutForm = form;
            //End
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new System.Drawing.Point(6, 6);
            form.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            form.Margin = new System.Windows.Forms.Padding(0);
            Main_Content.Controls.Add(form);
            Main_Content.Tag = form;
            form.BringToFront();
            form.Show();

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


    }

}
