using HelixStore.Business.Invoices.Public;
using HelixStore.Data.Models;
using HelixStore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelixStore.WinForm.Report
{
    public partial class InvoiceReportForm : Form
    {
        public InvoiceReportForm()
        {
            InitializeComponent();
            LoadData(2);
        }
        public InvoiceReportForm(int invoiceId)
        {
            InitializeComponent();
            //2
            LoadData(invoiceId);
        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            this.Controls.Add(panel_invoice);
            Graphics grp = panel_invoice.CreateGraphics();
            Size formSize = panel_invoice.Size;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            Point panelLocation = PointToScreen(panel_invoice.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void LoadData(int invoiceId)
        {
            InvoiceReportVM iRVM = new PublicInvoicetService().GetInvoiceReportVM(invoiceId);

            date.Text = iRVM.InvoiceDate.ToString();
            customer.Text = iRVM.CustomerName;
            staff.Text = iRVM.StaffName;
            recipient.Text = iRVM.DeliveryAddressRecipient;
            address.Text = iRVM.DeliveryAddressAddress;
            phone.Text = iRVM.DeliveryAddressPhone;
            pa.Text = iRVM.ProvisionalAmount.ToString();
            discount.Text = iRVM.Discount.ToString();
            total.Text = iRVM.Total.ToString();

            LoadTable(iRVM.invoiceRows);

        }
        private void LoadTable(List<InvoiceRowReportVM> rows)
        {
            rows_table.Rows.Clear();

            rows.ForEach(r =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(rows_table);

                row.Cells[0].Value = r.ProductName;
                row.Cells[1].Value = r.Amount;
                row.Cells[2].Value = r.Price;
                row.Cells[3].Value = r.Total;
                rows_table.Rows.Add(row);
            });
        }
    }
}
