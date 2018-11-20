using System;
using System.Collections.Generic;
using Torshia.Models.ViewModels.Tasks;

namespace Torshia.Services.Contracts
{
    public interface ITasksService
    {
        void Create(string title,
                    DateTime DueDate,
                    string description,
                    string participants,
                    List<string> sectors);

        TaskDetailsViewModel Details(int id);

        ICollection<TaskListViewModel> All();
    }
}
