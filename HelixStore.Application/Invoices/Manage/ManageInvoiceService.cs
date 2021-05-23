using HelixStore.Business.Invoices.Public;
using HelixStore.Data.Models;
using HelixStore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Invoices.Manage
{
    public class ManageInvoiceService:IManageInvoiceService
    {

        private readonly HelixStoreContext _context;
        public ManageInvoiceService()
        {
            _context = new HelixStoreContext();
        }

        public List<InvoiceReportVM> GetAll()
        {
            List<InvoiceReportVM> list = new List<InvoiceReportVM>();
            var invoices = _context.Invoices.ToList();

            invoices.ForEach(i =>
            {
                var item = new PublicInvoicetService().GetInvoiceReportVM(i.InvoiceId);
                item.InvoiceId = i.InvoiceId;
                list.Add(item);
            });

            return list;
        }
    }
}
