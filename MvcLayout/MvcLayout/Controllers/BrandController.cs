using System;
using Microsoft.AspNetCore.Mvc;
using MvcLayout.Models;

namespace MvcLayout.Controllers
{
	public class BrandController:Controller
	{
        List<Brand> _brands = new List<Brand>();
        public BrandController()
		{
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
        public IActionResult GetAll()
        {
            return Json(_brands);
        }
		public IActionResult Index()
		{
            if (_brands == null || _brands.Count == 0)
            {
                TempData["ErrorMessage"] = "Brands not found";
                return RedirectToAction("error");
            }
            ViewBag.Brands = _brands;

            return View();

		}
        public IActionResult Error()
        {

            return View();
        }

    }
}

