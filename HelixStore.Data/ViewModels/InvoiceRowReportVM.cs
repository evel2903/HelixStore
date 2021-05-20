using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Data.ViewModels
{
    public class InvoiceRowReportVM
    {
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public Decimal Price { get; set; }
        public Decimal Total { get; set; }
    }
}
