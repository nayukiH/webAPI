using SecondAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SecondAPI.Controllers
{
    public class ProductsController : ApiController
    {
        
        product[] products = new product[]
        {
            new product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
