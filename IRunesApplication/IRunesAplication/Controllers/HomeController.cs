﻿namespace IRunesAplication.Controllers
{
    using SimpleMvc.Framework.Contracts;

    public class HomeController : BaseController
    {
        public IActionResult Index() =>this.View();
    }
}