using HelixStore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Business.Invoices.Manage
{
    public interface IManageInvoiceService
    {
        List<InvoiceReportVM> GetAll();
    }
}
