using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IAssignmentRepository
    {
        List<Assignment> GetAllAssignments();
        Assignment GetAssignmentById(int idcode);
        void AddAssignment(Assignment assignment);
        void UpdateAssignment(Assignment assignment);

    }
}
