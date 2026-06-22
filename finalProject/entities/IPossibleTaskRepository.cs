using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IPossibleTaskRepository
    {
        IEnumerable<PossibleTask> GetAllTasks();
        PossibleTask GetTaskById(int id);
        void AddTask(PossibleTask possibleTask);
        void UpdateTask(PossibleTask foundTask);

    }
}
