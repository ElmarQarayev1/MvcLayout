using Microsoft.AspNetCore.Mvc;
using MvcLayout.Models;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {

        List<Product> _products = new List<Product>();
        List<Brand> _brands = new List<Brand>();

        public HomeController()
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
            _brands = new List<Brand>()
            {
                new Brand
                {
                    Id=1,
                    Name="samsung",
                    Count=12
                },
                new Brand
                {
                    Id=2,
                    Name="iphone",
                    Count=9
                },
                new Brand
                {
                    Id=3,
                    Name="nokia",
                    Count=10
                },
                new Brand
                {
                    Id=4,
                    Name="honor",
                    Count=9
                }

            };

        }

        public IActionResult Index()
        {
            ViewBag.Products = _products;
            if (_products == null || _products.Count == 0)
            {
                TempData["ErrorMessage"] = "Products not found";
                return RedirectToAction("error");
            }
            ViewBag.Brands = _brands;
            if (_brands == null || _brands.Count == 0)
            {
                TempData["ErrorMessage"] = "Brands not found";
                return RedirectToAction("error");
            }
            return View();
        }
    }
}
