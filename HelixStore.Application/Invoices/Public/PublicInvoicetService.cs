using HelixStore.Business.Products.Manage;
using HelixStore.Business.Products.Public;
using HelixStore.Data.Models;
using HelixStore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Invoices.Public
{
    public class PublicInvoicetService : IPublicInvoicetService
    {
        private readonly HelixStoreContext _context;
        public PublicInvoicetService()
        {
            _context = new HelixStoreContext();
        }
        public Invoice CreateInvoice(Invoice invoice, List<InvoiceDetail> details)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();

            var i = _context.Invoices.ToList().Last();
            details.ForEach(d =>
            {
                d.InvoiceId = i.InvoiceId;
                _context.InvoiceDetails.Add(d);
                _context.SaveChanges();

                new ManageProductService().InventoryDelivery(d.InvoiceDetailAmount, d.ProductId);
                _context.SaveChanges();
            });
            _context.SaveChanges();

            return i;
        }

        public InvoiceReportVM GetInvoiceReportVM(int id)
        {
            Invoice i = _context.Invoices.FirstOrDefault(_i => _i.InvoiceId == id);
            InvoiceReportVM invoiceReportVM = new InvoiceReportVM();
            List<InvoiceRowReportVM> rows = new List<InvoiceRowReportVM>();

            _context.InvoiceDetails.Where(idt=>idt.InvoiceId == id).ToList().ForEach(iDetail =>
            {
                Product product = new PublicProductService().GetProductById(iDetail.ProductId);
                InvoiceRowReportVM invoiceRowReportVM = new InvoiceRowReportVM();

                invoiceRowReportVM.ProductName = product.ProductName;
                invoiceRowReportVM.Amount = iDetail.InvoiceDetailAmount;
                invoiceRowReportVM.Price = product.ProductPrice;
                invoiceRowReportVM.Total = iDetail.InvoiceDetailTotal;

                rows.Add(invoiceRowReportVM);
            });

            invoiceReportVM.InvoiceDate = i.InvoiceDate;
            invoiceReportVM.invoiceRows = rows;
            invoiceReportVM.CustomerName = _context.Customers.FirstOrDefault(c => c.CustomerId == i.CustomerId).CustomerFullname;
            invoiceReportVM.StaffName = _context.Staffs.FirstOrDefault(s => s.StaffId == i.StaffId).StaffFullname;

            var address = _context.DeliveryAddresses.FirstOrDefault(da => da.DeliveryAddressId == i.DeliveryAddressId);

            invoiceReportVM.DeliveryAddressRecipient = address.DeliveryAddressRecipient;
            invoiceReportVM.DeliveryAddressAddress = address.DeliveryAddressAddress;
            invoiceReportVM.DeliveryAddressPhone = address.DeliveryAddressPhone;

            invoiceReportVM.ProvisionalAmount = i.InvoiceProvisionalAmount;
            invoiceReportVM.Discount = i.InvoiceDiscount;
            invoiceReportVM.Total = i.InvoiceTotal;

            return invoiceReportVM;
        }
    }
}
