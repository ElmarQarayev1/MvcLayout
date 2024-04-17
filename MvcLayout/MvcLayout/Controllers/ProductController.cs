using System;
using Microsoft.AspNetCore.Mvc;
using MvcLayout.Models;

namespace MvcLayout.Controllers
{
	public class ProductController:Controller
	{
		List<Product> _products = new List<Product>();
		public ProductController()
		{
			_products = new List<Product>()
			{
				new Product
				{
					Id=1,
					Name="telefon",
					Price=123
				},
                new Product
                {
                    Id=2,
                    Name="masin",
                    Price=93
                },
                new Product
                {
                    Id=3,
                    Name="soyuducu",
                    Price=103
                },
                new Product
                {
                    Id=4,
                    Name="kondisoner",
                    Price=90
                }

            };
		}

        public IActionResult GetAll()
        {
            return Json(_products);
        }
        public IActionResult Index()
        {
            if (_products == null || _products.Count == 0)
            {
                TempData["ErrorMessage"] = "Products not found";
                return RedirectToAction("error");
            }

            ViewBag.Products = _products;

            return View();
        }

        public IActionResult Details(int id)
        {
            Product? product = _products.Find(x => x.Id == id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Product not found by given id";
                return RedirectToAction("error");
            }

            ViewBag.product = product;

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
