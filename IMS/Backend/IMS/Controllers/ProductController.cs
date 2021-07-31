using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;

namespace IMS.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/AllProducts")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void AddProduct(ProductModel p)
        {
            ProductService.AddProduct(p);
        }

    }
}
