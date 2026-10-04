using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductCatalogMVC.Models;

namespace ProductCatalogMVC.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Description = "High performance laptop for students",
                Price = 55000,
                Category = "Electronics",
                Quantity = 10,
                ImageUrl = "/images/laptop.jpg"
            },

            new Product
            {
                ProductId = 2,
                ProductName = "Smartphone",
                Description = "Latest smartphone with advanced features",
                Price = 25000,
                Category = "Electronics",
                Quantity = 15,
                ImageUrl = "/images/smartphone.jpg"
            },

            new Product
            {
                ProductId = 3,
                ProductName = "Headphone",
                Description = "Wireless headphone with clear sound",
                Price = 2500,
                Category = "Accessories",
                Quantity = 20,
                ImageUrl = "/images/headphones.jpg"
            },

            new Product
            {
                ProductId = 4,
                ProductName = "Watch",
                Description = "Smart watch with fitness tracking",
                Price = 1500,
                Category = "Accessories",
                Quantity = 25,
                ImageUrl = "/images/Watch.jpg"
            },

            new Product
            {
                ProductId = 5,
                ProductName = "Refrigerator",
                Description = "Large capacity refrigerator with energy efficiency",
                Price = 45000,
                Category = "Appliances",
                Quantity = 5,
                ImageUrl = "/images/refrigerator.jpg"
            }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}