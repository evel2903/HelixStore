using HelixStore.Business.Invoices.Manage;
using HelixStore.Data.Models;
using HelixStore.Data.ViewModels;
using HelixStore.WinForm.Report;
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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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

        private void LoadTable()
        {
            order_table.Rows.Clear();
            List<InvoiceReportVM> list = new ManageInvoiceService().GetAll();

            list.ForEach(s =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(order_table);

                row.Cells[0].Value = s.InvoiceId;
                row.Cells[1].Value = s.InvoiceDate;
                row.Cells[2].Value = s.CustomerName;
                row.Cells[3].Value = s.StaffName;
                row.Cells[4].Value = s.Total;
                order_table.Rows.Add(row);
            });

        }

        private void product_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = order_table.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    selected_id.Text = row.Cells[0].Value.ToString();
                    btn_view_detail.Enabled = true;
                }
            }
        }

        private void btn_view_detail_Click(object sender, EventArgs e)
        {
            InvoiceReportForm invoiceReport = new InvoiceReportForm(int.Parse(selected_id.Text));
            invoiceReport.Show();
        }
    }
}
