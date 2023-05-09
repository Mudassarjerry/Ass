using Cerebral_Palsy.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cerebral_Palsy.Controller
{
    public class Cus_Controller : Controller
    {

        private readonly Database _customerDB_Context;

        public Cus_Controller(Database customerDB_Context)
        {
            _customerDB_Context = customerDB_Context;
        }

        [HttpPut("CustomerData")]
        public IActionResult SaveCustomerData([FromBody] Customer customer)
        {
            _customerDB_Context.customer.Add(customer);
            _customerDB_Context.SaveChanges();

            return Ok();
        }

        [HttpGet("CustomerDataView")]
        public IEnumerable<Customer> GetCustomers()
        {

            return _customerDB_Context.customer;

        }


    }
}
}
