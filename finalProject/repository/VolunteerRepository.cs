using entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class VolunteerRepository(DataProject  dataProject):IVolunteerRepository
    {
        //DataProject dataProject = new DataProject();
        public Volunteer GetVolunteerById(int id) => dataProject.Volunteers.Include(v => v.PersonalAreasOfExpertise).FirstOrDefault(v => v.Id == id);
        public IEnumerable<Volunteer> GetAllVolunteers() => dataProject.Volunteers.Include(v => v.PersonalAreasOfExpertise).ToList();

        public void AddVolunteer(Volunteer volunteer) 
        {
            dataProject.Volunteers.Add(volunteer);
            dataProject.SaveChanges();
        } 

        public void UpdateVolunteer(Volunteer volunteer)
        {
            var VolunteerToUpdate = dataProject.Volunteers.Include(v => v.PersonalAreasOfExpertise).FirstOrDefault(v => v.Id == volunteer.Id);
            VolunteerToUpdate = volunteer;
            dataProject.SaveChanges();
            //VolunteerToUpdate.EmailAddress = volunteer.EmailAddress;
            //VolunteerToUpdate.PhoneNumber = volunteer.PhoneNumber;
            //VolunteerToUpdate.FullName = volunteer.FullName;

        }

        //public void AddExpertiseToVolunteer(int id, AreasOfExpertise areasOfExpertise)
        //{
        //    dataProject.Volunteers.FirstOrDefault(v => v.Id == id).PersonalAreasOfExpertise.Add(areasOfExpertise);
        //}


        //delete
        public void deleteVolunteer(int id)
        {
            var volunteerToDelete = dataProject.Volunteers.FirstOrDefault(v => v.Id == id);
            if (volunteerToDelete != null)
            {
                dataProject.Volunteers.Remove(volunteerToDelete);
                dataProject.SaveChanges();
            }
        }

        public Volunteer GetEmail(string EmailAddress)
        {
            var volunteer = dataProject.Volunteers.Where(v => v.EmailAddress == EmailAddress).FirstOrDefault();
            return volunteer;
        }
    }
}
