namespace Torshia.Web.Controllers
{
    using SIS.Framework.ActionResults;
    using System.Text;
    using System.Linq;
    using Torshia.Services;
    using Torshia.Services.Contracts;

    public class HomeController : BaseController
    {
        private readonly ITasksService tasks;
        public HomeController(TasksService tasks)
        {
            this.tasks = tasks;
        }
        public IActionResult Index()
        {
            if (this.Identity != null)
            { 
                var listOfTasks = this.tasks.All().ToArray();
                var sb = new StringBuilder();
                var emptyBlock = @"<div class=""task col mx-3 bg-transparent rounded py-3""></div>";
                               
                if (listOfTasks.Length <= 5)
                {
                    var counter = 1;
                    foreach (var task in listOfTasks)
                    {
                        sb.AppendLine($@"<div class=""task col mx-3 bg-torshia rounded py-3""><h6 class=""task-title text-white text-center my-3"">{task.Title}</h6><hr class=""bg-white hr-2 w-75""><h6 class=""task-title text-white text-center my-4"">Level: {task.Level}</h6><hr class=""bg-white hr-2 w-75""><div class=""follow-button-holder d-flex justify-content-between w-50 mx-auto mt-4""><a href = ""report""><h6 class=""text-center text-white"">Report</h6></a><a href = ""/tasks/details?id={task.Id}""><h6 class=""text-center text-white"">Details</h6></a></div></div>");
                        counter++;
                    }
                    for (int i = 0; i < 6 - counter; i++)
                    {
                        sb.AppendLine(emptyBlock);
                    }
                }
                else
                {
                    var rows = listOfTasks.Length / 5;
                    if (listOfTasks.Length % 5 != 0)
                    {
                        rows += 1;
                    }
                    var counterOfTasks = 0;

                    for (int i = 0; i < rows; i++)
                    {
                        sb.AppendLine(@"<div class=""tasks-row row mt-4"">");

                        for (int j = 0; j < 5; j++)
                        {
                            if (counterOfTasks >= listOfTasks.Length)
                            {
                                break;
                            }
                            sb.AppendLine($@"<div class=""task col mx-3 bg-torshia rounded py-3""><h6 class=""task-title text-white text-center my-3"">{listOfTasks[i].Title}</h6><hr class=""bg-white hr-2 w-75""><h6 class=""task-title text-white text-center my-4"">Level: {listOfTasks[i].Level}</h6><hr class=""bg-white hr-2 w-75""><div class=""follow-button-holder d-flex justify-content-between w-50 mx-auto mt-4""><a href = ""/tasks/report?id={listOfTasks[i].Id}""><h6 class=""text-center text-white"">Report</h6></a><a href = ""/tasks/details?id={listOfTasks[i].Id}""><h6 class=""text-center text-white"">Details</h6></a></div></div>");
                            counterOfTasks++;
                        }
                        if (listOfTasks.Length % 5 != 0 && i == rows-1)
                        {
                            var counterEmptyBlocks = 5 - (listOfTasks.Length % 5);
                            for (int k = 0; k < counterEmptyBlocks; k++)
                            {
                                sb.AppendLine(emptyBlock);
                            }
                        }
                        sb.AppendLine(@"</div>");
                    }
                }
                
                this.Model.Data["Tasks"] = "block";
                this.Model.Data["ContentTasks"] = sb.ToString();
            }
            return this.View();
        }
    }
}
