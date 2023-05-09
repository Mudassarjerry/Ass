using Cerebral_Palsy.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cerebral_Palsy.Controller
{
    public class Excercises_Controller : Controller
    {

        private readonly Database _proddbcontext;

        public Excercises_Controller(Database customerdbcontext)
        {
            _proddbcontext = customerdbcontext;
        }

        [HttpPut("AddProducts")]
        public IActionResult SaveProducts([FromBody] Product product)
        {
            _proddbcontext.products.Add(product);
            _proddbcontext.SaveChanges();

            return Ok();
        }


        [HttpGet("AllProducts")]
        public IEnumerable<Product> GetProducts()
        {

            return _proddbcontext.products;
        }
    }


}
}
