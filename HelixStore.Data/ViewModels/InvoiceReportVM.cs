using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixStore.Data.ViewModels
{
    public class InvoiceReportVM
    {
        //date create
        public DateTime InvoiceDate { get; set; }
        //list row
        public List<InvoiceRowReportVM> invoiceRows { get; set; }
        //customer - staffs name
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        //address
        public string DeliveryAddressRecipient { get; set; }
        public string DeliveryAddressAddress { get; set; }
        public string DeliveryAddressPhone { get; set; }
        //price
        public Decimal ProvisionalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public int InvoiceId { get; set; }
    }
}
