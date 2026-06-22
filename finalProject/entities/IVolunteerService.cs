using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public interface IVolunteerService
    {
        public List<Volunteer> GetAllVolunteerToShow(string sort);
        public Volunteer GetVolunteerByIdToShow(int id);
        public void AddVolunteer(Volunteer v);
        public void updateVolunteer(int id, Volunteer volunteerToUpdate);
        public void AddPersonalAreasOfExpertise();

    }
}
