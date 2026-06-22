using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IAssignmentService
    {
        public List<Assignment> GetAllAssignmentToShow();
        public Assignment GetAssignmentByIdToShow(int id);
        public void updateAssignment(int id, Assignment assignmentToUpdate);

    }
}
