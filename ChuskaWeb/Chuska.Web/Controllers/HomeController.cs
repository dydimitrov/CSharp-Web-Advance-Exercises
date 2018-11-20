using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chuska.Services.Contracts;
using Chuska.Models.ViewModels.Product;
using Chuska.Services;

namespace Chuska.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IProductService products;
        public HomeController(IProductService products)
        {
            this.products = products;
        }
        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var model = products.GetAllProducts();
                return View(model);
            }
            return View();
        }
    }
}
