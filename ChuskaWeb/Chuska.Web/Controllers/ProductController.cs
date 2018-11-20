using Chuska.Models.ViewModels.Product;
using Chuska.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chuska.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService products;
        public ProductController(IProductService products)
        {
            this.products = products;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(ProductCreateViewModel model)
        {
            products.Create(model.Name, model.Price, model.Description, model.ProductType);

            return this.RedirectToAction("Index","Home");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var product = products.FindById(id);
            return View(product);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(ProductEditViewModel model, int id)
        {
            products.EditById(model, id);
            return this.RedirectToAction("Index","Home");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var product = products.FindById(id);
            return View(product);
        }
        [HttpPost("/Product/Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult ConfirmDelete(int id)
        {
            products.DeleteById(id);
            return this.RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            var model = products.FindById(id);
            return View(model);
        }
        

        [Authorize]
        public IActionResult Order(int id)
        {
            var username = this.User.Identity.Name;
            products.Order(id, username);
            return this.RedirectToAction("Index","Home");
        }
    }
}