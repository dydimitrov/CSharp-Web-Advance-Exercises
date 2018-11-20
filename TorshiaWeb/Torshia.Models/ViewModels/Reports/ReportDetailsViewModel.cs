using System;
using Torshia.Models.Enums;

namespace Torshia.Models.ViewModels.Reports
{
    public class ReportDetailsViewModel
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReportedOn { get; set; }
        public string Reporter { get; set; }
        public string Participants { get; set; }
        public string Sectors { get; set; }
        public string Description { get; set; }
    }
}
