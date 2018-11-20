using SIS.Framework.ActionResults;
using SIS.Framework.Controllers;

namespace SIS.Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            this.Model.Data["content"] = "Hello from new mvc";
            return this.View();
        }
    }
}
