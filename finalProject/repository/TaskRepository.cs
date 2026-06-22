using entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class TaskRepository(DataProject dataProject):ITaskRepository
    {
        //DataProject dataProject = new DataProject();
        public PossibleTask GetTaskById(int id)=> dataProject.PossibleTasks.Include(t => t.TaskTypeId).FirstOrDefault(t => t.Id == id);
        public IEnumerable<PossibleTask> GetAllTasks() => dataProject.PossibleTasks.Include(t=>t.TaskTypeId);

        public void AddTask(PossibleTask possibleTask)
        {
            dataProject.PossibleTasks.Add(possibleTask);
            dataProject.SaveChanges();
        }

        public void UpdateTask(PossibleTask possibleTask)
        {
            var possibleTaskToUpdate = dataProject.PossibleTasks.Include(t => t.TaskTypeId).FirstOrDefault(t => t.Id == possibleTask.Id);
            possibleTaskToUpdate = possibleTask;
            dataProject.SaveChanges();
            //possibleTaskToUpdate.Status = possibleTask.Status;
            //possibleTaskToUpdate.Location = possibleTask.Location;
            //possibleTaskToUpdate.TaskType = possibleTask.TaskType;
            //possibleTaskToUpdate.TaskDescription = possibleTask.TaskDescription;
            //possibleTaskToUpdate.Date = possibleTask.Date;

        }

        //delete






    }
}
