using System.Collections.Generic;
using Torshia.Models.Enums;
using Torshia.Models.ViewModels.Tasks;

namespace Torshia.Models.ViewModels.Reports
{
    public class ReportListViewModel
    {
        public int Id { get; set; }
        public Status Status { get; set; }        
        public int TaskId { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
    }
}
