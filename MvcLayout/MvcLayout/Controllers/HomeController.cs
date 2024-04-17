using Microsoft.AspNetCore.Mvc;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
         //BrandController _brandController;
         //ProductController _productController;

        public IActionResult Index()
        {
            //var brands = _brandController.GetAll();

            //var products = _productController.GetAll();

            //ViewBag.Brands = brands;
            //ViewBag.Products = products;

            return View();
        }
    }
}
