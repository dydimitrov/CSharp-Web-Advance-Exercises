using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Method;
using System.Collections.Generic;
using Torshia.Services;
using Torshia.Services.Contracts;
using Torshia.Models.ViewModels.Tasks;

namespace Torshia.Web.Controllers
{
    public class TasksController : BaseController
    {
        private readonly ITasksService tasks;
        private readonly IReportService reports;

        public TasksController(ITasksService tasks, IReportService reports)
        {
            this.tasks = tasks;
            this.reports = reports;
        }
        public IActionResult Create()
        {
            if (this.Identity == null)
            {
                return RedirectToAction("/users/login");
            }
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(TaskCreateViewModel model)
        {
            var listOfSectors = new List<string>();
            listOfSectors.Add(model.Customers);
            listOfSectors.Add(model.Finances);
            listOfSectors.Add(model.Internal);
            listOfSectors.Add(model.Management);
            listOfSectors.Add(model.Marketing);
            listOfSectors.RemoveAll(s => s == null);

            this.tasks.Create(model.Title, 
                              model.DueDate, 
                              model.Description, 
                              model.Participants, 
                              listOfSectors);

            return RedirectToAction("/home/index");
        }

        public IActionResult Details(int id)
        {
            if (this.Identity == null)
            {
                return this.RedirectToAction("/users/login");
            }
            var task = tasks.Details(id);
            this.Model.Data["Title"] = task.Title.ToString();
            this.Model.Data["Level"] = task.Level.ToString();
            this.Model.Data["DueDate"] = task.DueDate.ToShortDateString();
            this.Model.Data["Participants"] = task.Participants.ToString();
            this.Model.Data["AffectedSectors"] = task.AffectedSectors;
            this.Model.Data["Description"] = task.Description;

            return View();
        }
        public IActionResult Report(int id)
        {
            var username = this.Identity.Username;
            this.reports.Create(username, id);
            return RedirectToAction("/Home/Index");
        }
    }
}
