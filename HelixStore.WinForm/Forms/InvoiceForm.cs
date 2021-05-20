using HelixStore.Business.Customers.Manage;
using HelixStore.Business.Customers.Public;
using HelixStore.Business.Invoices.Public;
using HelixStore.Business.Products.Public;
using HelixStore.Data.Models;
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
    public partial class InvoiceForm : Form
    {
        private Staff _staff;
        Customer customerPresent = new Customer();
        List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
        DeliveryAddress deliveryAddressPresent = new DeliveryAddress();

        public InvoiceForm(Staff staff)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            LoadProductType();

            SetEnabledFormNewCustomer(false);
            SetEnabledFormNewDeliveryAddress(false);
            btn_select_product.Enabled = false;
            SetEnabledFormChangeProductDetail(false);

            _staff = staff;
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

        public string GetFirstAWord(string str)
        {
            return str.Substring(0, str.IndexOf(" "));
        }

        public Decimal MultiplyMoney(Decimal price, int amount)
        {
            ulong p = ulong.Parse(price.ToString().Substring(0, price.ToString().IndexOf(".")));
            ulong a = ulong.Parse(amount.ToString());

            return Decimal.Parse((p * a).ToString());
        }

        public Decimal SubtractionMoney(Decimal total, string subVallue)
        {
            ulong p = ulong.Parse(total.ToString().Substring(0, total.ToString().IndexOf(".")));
            ulong s = ulong.Parse(subVallue);

            return Decimal.Parse((p - s).ToString());
        }
        
        public Decimal SummationMoney(List<Decimal> vs)
        {
            ulong result = 0;
            vs.ForEach(v =>
            {
                result += ulong.Parse(v.ToString());
            });

            return Decimal.Parse(result.ToString());
        }

        private void SetEnabledFormNewCustomer(bool stt)
        {
            new_customer_fullname.Text = null;
            new_customer_gender.Checked = false;
            new_customer_phone.Text = null;

            new_customer_fullname.Enabled = stt;
            new_customer_gender.Enabled = stt;
            new_customer_phone.Enabled = stt;
            new_customer_save.Enabled = stt;
        }

        private void SetEnabledFormNewDeliveryAddress(bool stt)
        {
            new_deliveryAddress_recipient.Text = null;
            new_deliveryAddress_address.Text = null;
            new_deliveryAddress_phone.Text = null;

            new_deliveryAddress_recipient.Enabled = stt;
            new_deliveryAddress_address.Enabled = stt;
            new_deliveryAddress_phone.Enabled = stt;
            new_deliveryAddress_save.Enabled = stt;
        }
        private void SetEnabledFormChangeProductDetail(bool stt)
        {
            invoice_item_id_selected.Text = "-1";
            invoice_changeAmount.Text = null;

            btn_del_invoice_item.Enabled = stt;
            invoice_changeAmount.Enabled = stt;
            invoice_saveChange.Enabled = stt;
        }

        //Control Customer Panel-------------------------------------------------------------------------------------------

        private void btn_search_customer_Click(object sender, EventArgs e)
        {
            Customer customer = new ManageCustomerService().FindByPhone(search_customer.Text);
            if (customer != null)
            {
                select_customer.Text = customer.CustomerId + " - " + customer.CustomerFullname;
                customerPresent = customer;
                LoadDeliveryAddress(customer.CustomerId);
            }
            else
            {
                MessageBox.Show("Not Found!");
                select_customer.Text = null;
                customerPresent = null;
                LoadDeliveryAddress(-1);
            }
        }

        private void btn_new_customer_Click(object sender, EventArgs e)
        {
            SetEnabledFormNewCustomer(true);
        }

        private void new_customer_save_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.CustomerFullname = new_customer_fullname.Text;
                customer.CustomerGender = new_customer_gender.Checked == true ? "Male" : "Female";
                customer.CustomerPhone = new_customer_phone.Text;

                Customer isCreate = new PublicCustomerService().Create(customer);

                if (isCreate != null)
                {
                    select_customer.Text = isCreate.CustomerId + " - " + isCreate.CustomerFullname;
                    customerPresent = isCreate;
                    LoadDeliveryAddress(customer.CustomerId);
                    MessageBox.Show("Success!");
                    SetEnabledFormNewCustomer(false);
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            catch { }
        }

        //Control DeliveryAddress Panel-----------------------------------------------------------------------------------

        private void LoadDeliveryAddress(int id)
        {
            try
            {
                List<DeliveryAddress> deliveryAddresses = new PublicCustomerService().GetDeliveryAddressByCustomerId(id);

                if (deliveryAddresses.Count > 0)
                {

                    deliveryAddresses.ForEach(d => {
                        select_deliveryAddress.Items.Add(d.DeliveryAddressId + " - " + d.DeliveryAddressAddress);
                    });
                }
                else
                {
                    select_deliveryAddress.Items.Clear();
                }
            }
            catch { }
        }

        private void btn_new_deliveryAddress_Click(object sender, EventArgs e)
        {
            SetEnabledFormNewDeliveryAddress(true);
        }

        private void new_deliveryAddress_save_Click(object sender, EventArgs e)
        {
            try
            {
                DeliveryAddress d = new DeliveryAddress();
                d.DeliveryAddressRecipient = new_deliveryAddress_recipient.Text;
                d.DeliveryAddressAddress = new_deliveryAddress_address.Text;
                d.DeliveryAddressPhone = new_deliveryAddress_phone.Text;
                d.CustomerId = customerPresent.CustomerId;
                DeliveryAddress isCreate = new PublicCustomerService().CreateDeliveryAddressByCustomerId(d);
                if (isCreate != null)
                {
                    deliveryAddressPresent = isCreate;
                    LoadDeliveryAddress(customerPresent.CustomerId);
                    MessageBox.Show("Success!");
                    SetEnabledFormNewDeliveryAddress(false);
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            catch { }
        }

        private void select_deliveryAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            deliveryAddressPresent = new PublicCustomerService()
                .GetDeliveryAddressByrId(int.Parse(GetFirstAWord(select_deliveryAddress.SelectedItem.ToString())));
        }

        //Control Product Panel-----------------------------------------------------------------------------------
        private void LoadProductType()
        {
            var productTypes = new PublicProductService().GetProductType();

            productTypes.ForEach(prdt =>
            {
                select_productType.Items.Add(prdt.ProductTypeId + " - " + prdt.ProductTypeName);
            });
        }

        private void LoadProducts(int typeid)
        {
            product_table.Rows.Clear();
            var products = new PublicProductService().GetProductByType(typeid);

            products.ForEach(p =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(product_table);

                row.Cells[0].Value = p.ProductId;
                row.Cells[1].Value = p.ProductName;
                row.Cells[2].Value = p.ProductAmount;
                product_table.Rows.Add(row);
            });

        }
        private void select_productType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts(int.Parse(GetFirstAWord(select_productType.SelectedItem.ToString())));
        }

        private void product_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_select_product.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = product_table.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    product_id_selected.Text = row.Cells[0].Value.ToString();
                }
            }
        }

        private void btn_select_product_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new PublicProductService().GetProductById(int.Parse(product_id_selected.Text));
                invoiceDetails.Add(CreateInvoiceDetailByProduct(product, 1));
                LoadInvoiceDetail();
                UpdateProvisionalAmount();
            }
            catch { }

        }

        private InvoiceDetail CreateInvoiceDetailByProduct(Product product, int amount)
        {
            var invoiceD = new InvoiceDetail();
            invoiceD.ProductId = int.Parse(product_id_selected.Text);
            invoiceD.InvoiceDetailAmount = amount;
            invoiceD.InvoiceDetailTotal = MultiplyMoney(product.ProductPrice, amount);

            return invoiceD;
        }

        //Control Invoice Panel-----------------------------------------------------------------------------------

        private void LoadInvoiceDetail()
        {
            invoice_detail_table.Rows.Clear();
            invoiceDetails.ForEach(p =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(invoice_detail_table);
                var product = new PublicProductService().GetProductById(p.ProductId);

                row.Cells[0].Value = p.ProductId;
                row.Cells[1].Value = product.ProductName;
                row.Cells[2].Value = p.InvoiceDetailAmount;
                row.Cells[3].Value = product.ProductPrice;
                row.Cells[4].Value = p.InvoiceDetailTotal;
                invoice_detail_table.Rows.Add(row);

            });

            UpdateProvisionalAmount();
        }

        private void UpdateProvisionalAmount()
        {
            List<Decimal> pa = new List<Decimal>();
            invoiceDetails.ForEach(p => pa.Add(p.InvoiceDetailTotal));

            invoice_provisionalAmount.Text = SummationMoney(pa).ToString();
        }

        private void invoice_detail_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = invoice_detail_table.Rows[e.RowIndex];
                SetEnabledFormChangeProductDetail(true);
                if (row.Cells[0].Value != null)
                {
                    invoice_item_id_selected.Text = row.Cells[0].Value.ToString();

                }
                
            }
        }

        private void btn_del_invoice_item_Click(object sender, EventArgs e)
        {
            
            foreach(var i in invoiceDetails)
            {
                if(i.ProductId == int.Parse(invoice_item_id_selected.Text))
                {
                    invoiceDetails.Remove(i);
                    break;
                }
            }
            SetEnabledFormChangeProductDetail(false);
            LoadInvoiceDetail();
        }

        private void invoice_saveChange_Click(object sender, EventArgs e)
        {
            foreach (var i in invoiceDetails)
            {
                if (i.ProductId == int.Parse(invoice_item_id_selected.Text))
                {
                    var product = new PublicProductService().GetProductById(i.ProductId);

                    i.InvoiceDetailAmount = int.Parse(invoice_changeAmount.Text);
                    i.InvoiceDetailTotal = MultiplyMoney(product.ProductPrice, i.InvoiceDetailAmount);

                    MessageBox.Show(i.InvoiceDetailAmount.ToString());
                    break;
                }
            }
            SetEnabledFormChangeProductDetail(false);
            LoadInvoiceDetail();
        }

        private void discount_apply_Click(object sender, EventArgs e)
        {
            ulong a = ulong.Parse(invoice_provisionalAmount.Text);
            ulong b = ulong.Parse(invoice_discount.Text == "" ? "0" : invoice_discount.Text);
            invoice_total.Text = Decimal.Parse((a - b).ToString()).ToString();
        }

        private void btn_invoice_saveAndExport_Click(object sender, EventArgs e)
        {
            try
            {
                var invoice = new Invoice();
                invoice.InvoiceDate = DateTime.Now;
                invoice.InvoiceProvisionalAmount = Decimal.Parse(invoice_provisionalAmount.Text);
                invoice.InvoiceDiscount = Decimal.Parse(invoice_discount.Text);
                invoice.InvoiceTotal = Decimal.Parse(invoice_total.Text);
                invoice.DeliveryAddressId = deliveryAddressPresent.DeliveryAddressId;
                invoice.CustomerId = customerPresent.CustomerId;
                invoice.StaffId = _staff.StaffId;

                var i = new PublicInvoicetService().CreateInvoice(invoice, invoiceDetails);
                MessageBox.Show("Success!");
                invoiceDetails.Clear();
                LoadInvoiceDetail();
                LoadProducts(int.Parse(GetFirstAWord(select_productType.SelectedItem.ToString())));

                InvoiceReportForm invoiceReport = new InvoiceReportForm(i.InvoiceId);
                invoiceReport.Show();
            }
            catch { MessageBox.Show("Failed!"); }
        }
    }
}
