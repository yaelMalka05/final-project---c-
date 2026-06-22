using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> GetAllAssignments();
        Assignment GetAssignmentById(int id);
        void UpdateAssignment(Assignment foundAssignment);
    }
}
