using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class AssignmentRepository
    {
        DataProject dataProject = new DataProject();
        public List<Assignment> GetAllAssignments() => dataProject.Assignments.ToList();

        public Assignment GetAssignmentById(int idcode) => dataProject.Assignments.FirstOrDefault(a => a.Id == idcode);

        public void AddAssignment(Assignment assignment) => dataProject.Assignments.Add(assignment);

        public void UpdateAssignment(Assignment assignment)
        {
            var assignmentToUpdate = dataProject.Assignments.FirstOrDefault
                (t => t.VolunteerId == assignment.VolunteerId && t.TaskId == assignment.TaskId);
            assignmentToUpdate = assignment;
            //assignmentToUpdate.CompletionReportingTime = assignment.CompletionReportingTime;
        //var assignmentToUpdate = DataProject.Assignments.FirstOrDefault(a => a.codeId == assignment.codeId);

        }



        



    }
}
