namespace Torshia.Services
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Torshia.Data;
    using Torshia.Models;
    using Torshia.Models.Enums;
    using Torshia.Models.ViewModels.Reports;
    using Torshia.Services.Contracts;

    public class ReportService : IReportService
    {
        private readonly TorshiaContext context;
        public ReportService(TorshiaContext context)
        {
            this.context = context;
        }

        public void Create(string username,int taskId)
        {
            var user = context.Users.First(u => u.Username == username);
            var rnd = new Random();
            var status = rnd.Next(1, 100) >= 75 ? Status.Completed : Status.Archived;

            var report = new Report()
            {
                ReportedOn = DateTime.UtcNow,
                Reporter = user,
                TaskId = taskId,
                Status = status
            };
            context.Tasks.First(t => t.Id == taskId).IsReported = true;
            context.Reports.Add(report);
            context.SaveChanges();
        }

        public ICollection<ReportListViewModel> All()
        {
            var allReports = context.Reports.Select(r => new ReportListViewModel()
            {
                Id = r.Id,
                TaskId = r.TaskId,
                Title = r.Task.Title,
                Level = r.Task.AffectedSectors.Count,
                Status = r.Status
            })
            .ToList();

            return allReports;
        }
        public ReportDetailsViewModel Details(int id)
        {
            //ToDo
            var reportDetails = context.Reports.Where(r => r.Id == id).Select( x => new ReportDetailsViewModel()
            {
                Id = x.Id,
                Title = x.Task.Title,
                Level = x.Task.AffectedSectors.Count,
                Status = x.Status,
                Reporter = x.Reporter.Username,
                DueDate = x.Task.DueDate,
                ReportedOn = x.ReportedOn,
                Participants = x.Task.Participants,
                Sectors = string.Join(',', x.Task.AffectedSectors),
                Description = x.Task.Description
            })
            .ToList();
            return reportDetails[0];
        }
    }
}
