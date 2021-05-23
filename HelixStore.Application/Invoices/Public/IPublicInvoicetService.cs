using HelixStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Invoices.Public
{
    public interface IPublicInvoicetService
    {
        Invoice CreateInvoice(Invoice invoice, List<InvoiceDetail> details);
    }
}
