using System;

namespace Torshia.Models.ViewModels.Tasks
{
    public class TaskDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public string Participants { get; set; }
        public string AffectedSectors { get; set; }
        public int Level { get; set; }
    }
}
