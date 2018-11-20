namespace IRunesAplication.Controllers
{
    using Data.Models;
    using SimpleMvc.Framework.Contracts;
    using SimpleMvc.Framework.Controllers;
    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            this.ViewModel["anonymousDisplay"] = "flex";
            this.ViewModel["userDisplay"] = "none";
            this.ViewModel["adminDisplay"] = "none";
            this.ViewModel["show-error"] = "none";
            this.ViewModel["notLoggedUser"] = "block";
            this.ViewModel["loggedUser"] = "none";
        }

        protected User Profile { get; private set; }

        protected void ShowError(string error)
        {
            this.ViewModel["show-error"] = "block";
            this.ViewModel["error"] = error;
        }

        protected void ShowSuccess(string successMessage)
        {
            this.ViewModel["show-success"] = "block";
            this.ViewModel["success"] = successMessage;
        }

        protected IActionResult RedirectToHome()
            => this.Redirect("/");

        protected IActionResult RedirectToLogin()
            => this.Redirect("/users/login");

        protected override void InitializeController()
        {
            base.InitializeController();

            if (this.User.IsAuthenticated)
            {
                this.ViewModel["anonymousUser"] = "none";
                this.ViewModel["userDisplay"] = "flex";
                this.ViewModel["notLoggedUser"] = "none";
                this.ViewModel["loggedUser"] = "block";
                this.ViewModel["username"] = this.User.Name;
            }
        }        
    }
}
