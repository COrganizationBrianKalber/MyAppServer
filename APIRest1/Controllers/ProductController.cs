using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIRest1.Models;
using System.Web.Http;


namespace APIRest1.Controllers
{
    public class ProductController : ApiController
    {
        static Dictionary<int, Product> products = new Dictionary<int, Product>();

        //GET
        public IEnumerable<Product> Get()
        {
            return new List<Product>(products.Values);
        }
    }
}
