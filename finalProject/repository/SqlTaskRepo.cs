using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class SqlTaskRepo : IPossibleTaskRepository
    {
        public void AddTask(PossibleTask possibleTask)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PossibleTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public PossibleTask GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(PossibleTask foundTask)
        {
            throw new NotImplementedException();
        }
    }
}
