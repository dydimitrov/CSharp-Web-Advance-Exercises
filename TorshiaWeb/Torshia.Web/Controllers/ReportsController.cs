namespace Torshia.Web.Controllers
{
    using SIS.Framework.ActionResults;
    using System.Text;
    using Torshia.Services.Contracts;

    public class ReportsController : BaseController
    {
        private readonly IReportService reports;

        public ReportsController(IReportService reports)
        {
            this.reports = reports;
        }
        public IActionResult All()
        {
            if (this.Identity == null || !this.Identity.Roles.Contains("Admin"))
            {
                return this.RedirectToAction("/Users/Login");
            }
            var listOfReports = this.reports.All();
            var sb = new StringBuilder();

            foreach (var report in listOfReports)
            {
                sb.AppendLine($@"<tr class=""row""><th class=""col-md-1"">{report.Id}</th><td class=""col-md-5"">{report.Title}</td><td class=""col-md-1"">{report.Level}</td><td class=""col-md-2"">{report.Status}</td><td class=""col-md-2""><div class=""button-holder d-flex justify-content-between""><button class=""btn bg-torshia text-white""><a class=""text-white"" href=""/Reports/Details?id={report.Id}"">Details</a></button></div></td></tr>");
            }

            this.Model.Data["Reports"] = sb.ToString();
            return this.View();
        }

        public IActionResult Details(int id)
        {
            var report = this.reports.Details(id);

            this.Model.Data["Id"] = report.Id;
            this.Model.Data["TaskTitle"] = report.Title;
            this.Model.Data["Level"] = report.Level;
            this.Model.Data["ReportStatus"] = report.Status;
            this.Model.Data["DueDate"] = report.DueDate;
            this.Model.Data["ReportOn"] = report.ReportedOn;
            this.Model.Data["ReporterName"] = report.Reporter;
            this.Model.Data["Participants"] = report.Participants;
            this.Model.Data["Sectors"] = report.Sectors;
            this.Model.Data["Description"] = report.Description;
            return this.View();
        }
    }
}
