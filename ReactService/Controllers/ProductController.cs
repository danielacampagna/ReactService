using Model;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ReactService.Controllers
{
    public class ProductController : ApiController
    {
        ProductService service = new ProductService();

        [HttpGet]
        [Route("GetProducts")]
        public IHttpActionResult GetProducts()
        {
            var products = service.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProduct")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = service.GetProduct(id);
            return Ok(product);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IHttpActionResult AddProduct([FromBody]Product product)
        {
            return Ok(product);
        }
    }
}
