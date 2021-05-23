using HelixStore.Business.Customers.Public;
using HelixStore.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelixStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        PublicCustomerService _publicCustomerService = new PublicCustomerService();

        [HttpPost("Login")]
        public ActionResult<Customer> Login(string phone, string password)
        {
            var customer = _publicCustomerService.Login(phone, password);

            return customer == null ? NotFound() : customer;
        }
        [HttpPost("Signup")]
        public ActionResult<Customer> Signup(string fullname, string gender, string phone)
        {
            var customer = _publicCustomerService.Signup(fullname, gender, phone);

            return customer;
        }
        [HttpGet("Address/{id}")]
        public ActionResult<List<DeliveryAddress>> GetDeliveryAddressById(int id)
        {
            var address = _publicCustomerService.GetDeliveryAddressByCustomerId(id);
            return address == null ? NotFound(): address;
        }
        [HttpGet("Address/New/{id}")]
        public ActionResult<DeliveryAddress> CreqateDeliveryAddress(int id, string name, string address, string phone)
        {
            var deliveryAddress = new DeliveryAddress();
            deliveryAddress.DeliveryAddressRecipient = name;
            deliveryAddress.DeliveryAddressAddress = address;
            deliveryAddress.DeliveryAddressPhone = phone;
            deliveryAddress.CustomerId = id;


            var a = _publicCustomerService.CreateDeliveryAddressByCustomerId(deliveryAddress);
            return a;
        }
    }
}
