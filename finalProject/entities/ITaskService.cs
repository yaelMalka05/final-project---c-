using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface ITaskService
    {
        public List<Task> GetAllTaskToShow(string date, string urgency);
        public Task GetTaskByIdToShow(int id);
        public void AddPossibleTask(Task t);
        public void UpdateTask(int id, Task taskToUpdate);
        public void UpdateTaskStatus(int id, string taskStatus);
        public IEnumerable<Task> GetOpenTask();
        public IEnumerable<Task> FilterT(string? date, string? location);

    }
}
