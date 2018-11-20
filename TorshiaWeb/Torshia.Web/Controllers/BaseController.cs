namespace Torshia.Web.Controllers
{
    using System.Runtime.CompilerServices;
    using SIS.Framework.ActionResults;
    using SIS.Framework.Controllers;

    public class BaseController : Controller
    {

        protected override IViewable View([CallerMemberName] string actionName = "")
        {
            if (this.Identity == null)
            {
                this.Model.Data["notLoggedUser"] = "block";
                this.Model.Data["welcomeLogged"] = "none";
                this.Model.Data["welcomeAdmin"] = "none";
                this.Model.Data["loggedUser"] = "none";
                this.Model.Data["adminUser"] = "none";
                this.Model.Data["Tasks"] = "none";
                this.Model.Data["logoutBtn"] = "none";
            }
            else if (this.Identity != null && this.Identity.Roles.Contains("Admin"))
            {
                this.Model.Data["username"] = this.Identity.Username;
                this.Model.Data["notLoggedUser"] = "none";
                this.Model.Data["loggedUser"] = "none";
                this.Model.Data["adminUser"] = "block";
                this.Model.Data["welcomeLogged"] = "none";
                this.Model.Data["welcomeAdmin"] = "block";
                this.Model.Data["logoutBtn"] = "block";
                this.Model.Data["Tasks"] = "block";
            }
            else
            {
                this.Model.Data["username"] = this.Identity.Username;
                this.Model.Data["adminUser"] = "none";
                this.Model.Data["notLoggedUser"] = "none";
                this.Model.Data["loggedUser"] = "block";
                this.Model.Data["welcomeAdmin"] = "none";
                this.Model.Data["welcomeLogged"] = "block";
                this.Model.Data["logoutBtn"] = "block";
                this.Model.Data["Tasks"] = "block";
            }
            return base.View(actionName);
        }
    }
}
