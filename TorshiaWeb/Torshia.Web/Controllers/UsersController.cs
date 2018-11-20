namespace Torshia.Web.Controllers
{
    using SIS.Framework.ActionResults;
    using SIS.Framework.Attributes.Method;
    using SIS.Framework.Security;
    using System.Collections.Generic;
    using Torshia.Services;
    using Torshia.Services.Contracts;
    using Torshia.Models.ViewModels.Users;

    public class UsersController : BaseController
    {
        private readonly IUserService users;
        public UsersController(UserService users)
        {
            this.users = users;
        }
        public IActionResult Login() => this.View();

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = users.FindUser(model.Username, model.Password);

            var identityUser = new IdentityUser()
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Roles = new List<string> { user.Role.ToString() }
            };            

            if (user != null)
            {
                this.SignIn(identityUser);
                
                return this.RedirectToAction("/");
            }
            else
            {
                return this.Login();
            }
        }

        public IActionResult Register() => this.View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            this.users.RegisterUser(model.Username, model.Password, model.Email);
            return RedirectToAction("/Users/Login");
        }

        public IActionResult Logout()
        {
            this.SignOut();
            return this.RedirectToAction("/");
        }
    }
}
