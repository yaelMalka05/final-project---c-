using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface ITaskRepository
    {
         PossibleTask GetTaskById(int id);
        IEnumerable<PossibleTask> GetAllTasks();
        void AddTask(PossibleTask possibleTask);
        void UpdateTask(PossibleTask possibleTask);




    }
}
