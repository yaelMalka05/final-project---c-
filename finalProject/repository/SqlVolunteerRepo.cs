using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class SqlVolunteerRepo : IVolunteerRepository
    {
        public void AddVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            throw new NotImplementedException();
        }

        public Volunteer GetVolunteerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVolunteer(Volunteer foundVolunteer)
        {
            throw new NotImplementedException();
        }
    }
}
