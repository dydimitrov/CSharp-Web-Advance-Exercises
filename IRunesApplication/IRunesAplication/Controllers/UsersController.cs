namespace IRunesAplication.Controllers
{
    using IRunesAplication.ViewModels;
    using Services;
    using Services.Contracts;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Contracts;
    
    public class UsersController:BaseController
    {
        private readonly IUserService users;

        public UsersController()
        {
            this.users = new UserService();
        }
        public IActionResult Register()
        {
            return this.View();           
        }
        
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!IsValidModel(model))
            {
                return this.View();
            }
            this.users.Create(model.Username, model.Password, model.Email);
            return RedirectToLogin();
        }

        public IActionResult Login()
        {
            return this.View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (this.users.IsExist(model.Username, model.Password))
            {
                this.SignIn(model.Username);
                this.ViewModel["notLoggedUser"] = "none";
                this.ViewModel["loggedUser"] = "block";
                this.ViewModel["username"] = model.Username;

                return this.RedirectToHome();
            }
            else
            {
                this.ViewModel["error"] = "Please check your credentials.";
                return View();
            }
        }

        public IActionResult Logout()
        {
            this.SignOut();

            return RedirectToHome();
        }
    }
}
