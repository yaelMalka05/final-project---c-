using entities;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = entities.TaskStatus;

namespace service
{
    public class TaskService(ITaskRepository repos)
    {

        //TaskRepository repos = new TaskRepository();


        public List<TaskToShow> GetAllTaskToShow(string date , string urgency)
        {
            var list = repos.GetAllTasks().ToList();

            if (date != null)
            {
                list = list.OrderBy(tasks => tasks.Date).ToList();
            }
            if (urgency != null) { 
                 list = list.OrderBy(task => task.Urgency).ToList();
            }

            List<TaskToShow> taskToShows = new List<TaskToShow>();
            string type;
            foreach (var t in list)
            {
                if (t.TaskTypeId == null)
                    type = "unknown";
                taskToShows.Add(new TaskToShow(t.Id, t.TaskDescription, t.Date?.ToString(),
                    t.Location, t.Status.ToString(), t.TaskTypeId.Expertise, t.Urgency.ToString()));
            }

            return taskToShows;
        }


        public TaskToShow GetTaskByIdToShow(int id)
        {
            var t = repos.GetTaskById(id);
            TaskToShow taskToShow = new TaskToShow(t.Id, t.TaskDescription, t.Date.ToString(),
                    t.Location, t.Status.ToString(), t.TaskTypeId.ToString(), t.Urgency.ToString());
            return taskToShow;
        }




        public void AddPossibleTask(TaskToAdd t)
        {
            List<PossibleTask> list = repos.GetAllTasks().ToList();

            if (t.TaskDescription.Length > 10 || t.TaskDescription.Length > 50)
            {
                PossibleTask possibleTask = new PossibleTask()
                {
                    //Id = list.Count + 10,
                    TaskDescription = t.TaskDescription,
                    Date = t.Date,
                    Location = t.Location,
                    Status = TaskStatus.open,
                    Urgency = t.Urgency
                };
                //AddTaskType(possibleTask);
                repos.AddTask(possibleTask);
            }

            else throw new Exception("Task description is too short or too long");
        }

        //public void AddTaskType(PossibleTask possibleTask)
        //{
        //    if(possibleTask.TaskDescription.Contains("cook") )
        //    {
        //        possibleTask.TaskType = AreasOfExpertise.cooking;
        //    }
        //}



        // לבדוק עם המורה !!!
        //public void AddTaskType(PossibleTask possibleTask)
        //{
        //    bool found = false;

        //    foreach (AreasOfExpertise expertise in Enum.GetValues(typeof(AreasOfExpertise)))
        //    {
        //        if (possibleTask.TaskDescription.Contains(expertise.ToString().ToLower()))
        //        {
        //            possibleTask.TaskType = expertise;
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found)
        //    {
        //        possibleTask.TaskType = AreasOfExpertise.unknown;
        //    }
        //}


        public void UpdateTask(int id, TaskToUpdate taskToUpdate)
        {
            var foundTask = repos.GetTaskById(id);
            if (foundTask != null)
            {
                //
                if (taskToUpdate.TaskDescription != null)
                    foundTask.TaskDescription = taskToUpdate.TaskDescription;
                //
                if (taskToUpdate.Date != null)
                    foundTask.Date = (DateTime)taskToUpdate.Date;

                if (taskToUpdate.Location != null)
                    foundTask.Location = taskToUpdate.Location;

                if (taskToUpdate.Status != null)
                    foundTask.Status = (TaskStatus)taskToUpdate.Status;

                if (taskToUpdate.Urgency != null)
                    foundTask.Urgency = (UrgencyTask)taskToUpdate.Urgency;

                repos.UpdateTask(foundTask);
            }

            else throw new Exception("id task was not found");


        }

        public void UpdateTaskStatus(int id, string taskStatus)
        {
            TaskStatus s = (TaskStatus)Enum.Parse(typeof(TaskStatus), taskStatus, true);
            UpdateTask(id, new TaskToUpdate(null, null, null,s,null));
        }


        public IEnumerable<TaskToShow> GetOpenTask()
        {
            var task = repos.GetAllTasks().Where(t => t.Status == TaskStatus.open);
            var list = new List<TaskToShow>();
            foreach (var t in task)
            {
               list.Add(new TaskToShow(t.Id, t.TaskDescription, t.Date.ToString(),
                    t.Location, t.Status.ToString(), t.TaskTypeId.ToString(), t.Urgency.ToString()));
            }
            return list;
        }




        public IEnumerable<TaskToShow> FilterT(string? date, string? location)
        {
            var tasks = repos.GetAllTasks();

            if (date != null)
                tasks = tasks.Where(t => t.Date.ToString() == date);
            if (location != null)
                tasks = tasks.Where(t => t.Location.Contains(location));

            List<TaskToShow> taskToShows = new List<TaskToShow>();

            foreach (var t in tasks)
            {
                taskToShows.Add(new TaskToShow(t.Id, t.TaskDescription, t.Date.ToString(),
                    t.Location, t.Status.ToString(), t.TaskTypeId.ToString(), t.Urgency.ToString()));
            }
            return taskToShows;

        }




    }
}
