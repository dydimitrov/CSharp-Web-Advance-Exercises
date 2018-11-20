using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Eventures.Services.Contracts;
using Eventures.Models.ViewModels.Product;
using Eventures.Services;

namespace Eventures.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
