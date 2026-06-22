using entities;
using repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class AssignmentService
    {
        AssignmentRepository repos = new AssignmentRepository();


        public List<AssignmentToShow> GetAllAssignmentToShow()
        {
            List<Assignment> list = repos.GetAllAssignments();

            List<AssignmentToShow> assignmentToShows = new List<AssignmentToShow>();

            foreach (var a in list)
            {
                assignmentToShows.Add(new AssignmentToShow(a.VolunteerId , a.TaskId ,
                    a.CompletionReportingTime.ToString()));
            }

            return assignmentToShows;
        }


        public AssignmentToShow GetAssignmentByIdToShow(int id)
        {
            var a = repos.GetAssignmentById(id);
            AssignmentToShow assignmentToShow = new AssignmentToShow(a.VolunteerId, a.TaskId,
                    a.CompletionReportingTime.ToString());
            return assignmentToShow;
        }


        public void updateAssignment(int id, AssignmentToUpdate assignmentToUpdate)
        {
            var foundAssignment = repos.GetAssignmentById(id);
            if (foundAssignment != null)
            {
                if (assignmentToUpdate.CompletionReportingTime != null)
                    foundAssignment.CompletionReportingTime = (DateTime)assignmentToUpdate.CompletionReportingTime;

                repos.UpdateAssignment(foundAssignment);
            }
            else throw new Exception("assignment was not found");
        }







    }
}
