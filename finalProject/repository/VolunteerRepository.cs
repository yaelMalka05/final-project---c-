using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class VolunteerRepository
    {
        DataProject dataProject = new DataProject();
        public Volunteer GetVolunteerById(int id) => dataProject.Volunteers.FirstOrDefault(v => v.Id == id);
        public IEnumerable<Volunteer> GetAllVolunteers() => dataProject.Volunteers;

        public void AddVolunteer(Volunteer volunteer) => dataProject.Volunteers.Add(volunteer);

        public void UpdateVolunteer(Volunteer volunteer)
        {
            var VolunteerToUpdate = dataProject.Volunteers.FirstOrDefault(v => v.Id == volunteer.Id);
            VolunteerToUpdate = volunteer;
            //VolunteerToUpdate.EmailAddress = volunteer.EmailAddress;
            //VolunteerToUpdate.PhoneNumber = volunteer.PhoneNumber;
            //VolunteerToUpdate.FullName = volunteer.FullName;

        }

        //public void AddExpertiseToVolunteer(int id, AreasOfExpertise areasOfExpertise)
        //{
        //    dataProject.Volunteers.FirstOrDefault(v => v.Id == id).PersonalAreasOfExpertise.Add(areasOfExpertise);
        //}


        //delete



    }
}
