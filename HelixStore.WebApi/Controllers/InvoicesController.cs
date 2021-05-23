using HelixStore.Business.Invoices.Public;
using HelixStore.Data.Models;
using HelixStore.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HelixStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        PublicInvoicetService _publicInvoiceService = new PublicInvoicetService();
        [HttpPost("Create")]
        public ActionResult<Invoice> Create(string invoiceJson, string invoiceDetailsJson)
        {
            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(invoiceJson);
            invoice.InvoiceDate = DateTime.Now;
            List<InvoiceDetail> invoiceDetails = JsonConvert.DeserializeObject<List<InvoiceDetail>>(invoiceDetailsJson);

            return _publicInvoiceService.CreateInvoice(invoice, invoiceDetails);
        }
        [HttpGet("GetInvoiceVMs")]
        public ActionResult<List<InvoiceReportVM>> GetInvoiceVMByCustomerId(int cus_id)
        {
            var list = _publicInvoiceService.GetInvoiceVMByCusTomerId(cus_id);
            return list.Count == 0 ? NotFound() : list;
        }
    }


}
