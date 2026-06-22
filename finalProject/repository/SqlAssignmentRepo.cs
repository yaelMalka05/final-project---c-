using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class SqlAssignmentRepo : IAssignmentRepository
    {
        public IEnumerable<Assignment> GetAllAssignments()
        {
            throw new NotImplementedException();
        }

        public Assignment GetAssignmentById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAssignment(Assignment foundAssignment)
        {
            throw new NotImplementedException();
        }
    }
}
