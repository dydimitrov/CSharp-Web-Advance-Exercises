namespace Torshia.Services.Contracts
{
    using System.Collections.Generic;
    using Torshia.Models.ViewModels.Reports;
    public interface IReportService
    {
        void Create(string username, int taskId);

        ICollection<ReportListViewModel> All();

        ReportDetailsViewModel Details(int id);
    }
}
