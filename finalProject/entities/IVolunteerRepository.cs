using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IVolunteerRepository
    {
        IEnumerable<Volunteer> GetAllVolunteers();
        Volunteer GetVolunteerById(int id);
        void AddVolunteer(Volunteer volunteer);
        void UpdateVolunteer(Volunteer foundVolunteer);
    }
}
