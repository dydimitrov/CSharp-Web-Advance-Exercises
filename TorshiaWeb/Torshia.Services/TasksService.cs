namespace Torshia.Services
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Collections.Generic;
    using Torshia.Data;
    using Torshia.Models;
    using Torshia.Models.Enums;
    using Torshia.Models.ViewModels.Tasks;
    using Torshia.Services.Contracts;

    public class TasksService : ITasksService
    {
        private readonly TorshiaContext context;
        public TasksService(TorshiaContext context)
        {
            this.context = context;
        }

        public void Create(string title,
                                    DateTime dueDate,
                                    string description,
                                    string participants,
                                    List<string> sectors)
        {

            var task = new Task()
            {
                Title = title.Replace("+", " "),
                DueDate = dueDate,
                Description = HttpUtility.UrlDecode(description),
                Participants = HttpUtility.UrlDecode(participants),
                IsReported = false
            };

            foreach (var sector in sectors)
            {
                var result = (Sectors)Enum.Parse(typeof(Sectors), sector);
                var tasksSector = new TasksSectors()
                {
                    Sectors = result
                };
                task.AffectedSectors.Add(tasksSector);
            }
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public TaskDetailsViewModel Details(int id)
        {
            var taskFromDb = context.Tasks.First(t => t.Id == id);
            var taskSectors = context.AffectedSectors.Where(t => t.TaskId == id).Select(s => s.Sectors).ToList();

            var task = new TaskDetailsViewModel()
            {
                Id = id,
                Title = taskFromDb.Title,
                DueDate = taskFromDb.DueDate,
                Description = taskFromDb.Description,
                Participants = taskFromDb.Participants,
                AffectedSectors = string.Join(',', taskSectors),
                Level = taskSectors.Count
            };

            return task;
        }

        public ICollection<TaskListViewModel> All()
        {
            var tasks = context.Tasks.Where(t => t.IsReported == false).Select(x => new TaskListViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Level = x.AffectedSectors.Count()
            })
            .ToList();

            return tasks;
        }
    }
}
