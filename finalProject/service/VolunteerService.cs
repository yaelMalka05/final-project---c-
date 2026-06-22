using AutoMapper;
using DTOs;
using entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace service
{
    public class VolunteerService(IVolunteerRepository repos , IMapper mapper)
    {
        //VolunteerRepository repos = new VolunteerRepository();

        public List<VolunteerToShow> GetAllVolunteerToShow(string? sort)
        {
            var list = repos.GetAllVolunteers();
            if (sort != null)
            {
                list = list.OrderBy(v => v.FullName);
            }
            


            List<VolunteerToShow> volunteerToShows = new List<VolunteerToShow>();

            foreach (var v in list)
            {
                volunteerToShows.Add(new VolunteerToShow(v.FullName, v.PhoneNumber , v.EmailAddress , v.PersonalAreasOfExpertise?.Expertise));
            }

            return volunteerToShows;
        }

        public VolunteerToShow GetVolunteerByIdToShow(int id)
        {
            var v = repos.GetVolunteerById(id);
            VolunteerToShow volunteerToShow = new VolunteerToShow(v.FullName, v.PhoneNumber,v.EmailAddress, v.PersonalAreasOfExpertise.Expertise);
            return volunteerToShow;
        }



        public void AddVolunteer(VolunteerToAdd v)
        {
            List<Volunteer> list = repos.GetAllVolunteers().ToList();

            if (!list.Any(o => o.EmailAddress == v.EmailAddress))
            {
                //Volunteer volunteer = new Volunteer()
                Volunteer volunteer = mapper.Map<Volunteer>(v);
                //{
                //Id = list.Count + 10,
                //
                //FullName = v.FullName,
                //PhoneNumber = v.PhoneNumber,
                //EmailAddress = v.EmailAddress};


                repos.AddVolunteer(volunteer);
            }

            else throw new Exception("volunteer is already exist in the system");
        }


        public void updateVolunteer(int id, VolunteerToUpdate volunteerToUpdate)
        {
            var foundVolunteer = repos.GetVolunteerById(id);
            if (foundVolunteer != null)
            {
                if (volunteerToUpdate.FullName != null)
                    foundVolunteer.FullName = volunteerToUpdate.FullName;

                if (volunteerToUpdate.PhoneNumber != null)
                    foundVolunteer.PhoneNumber = volunteerToUpdate.PhoneNumber;

                if (volunteerToUpdate.EmailAddress != null)
                    foundVolunteer.EmailAddress = volunteerToUpdate.EmailAddress;


                repos.UpdateVolunteer(foundVolunteer);
            }

            else throw new Exception("id volunteer was not found");


        }




        public void AddPersonalAreasOfExpertise()
        {

        }




        //public void deleteVolunteer(int id)
        //{
        //    List<Volunteer> list = repos.GetAllVolunteers();
        //    var foundVolunteer = repos.GetVolunteerById(id);

        //    if (foundVolunteer != null)
        //    {
        //        //Delete(id);
        //        //remove(foundVolunteer);
        //        //foreach (var v in list)
        //        //{
        //        //    if (v.Id == id)
        //        //        v.Remove();
        //        //}
        //    }
        //    else
        //        throw new Exception("id volunteer was not found and can not be remove");
        //}
        public void deleteVolunteer(int id)
        {
            try
            {
                repos.deleteVolunteer(id);
            }
            catch (Exception e) 
            {
                throw new Exception("id volunteer was not found and can not be remove");
            } 
        }

        public  Volunteer ValidatUser(LoginDTO login)
        {
            var user = repos.GetEmail(login.Email);
            if (user == null)
                return null;
            if (user.Password != login.Password)
                return user;
            return user;
        }
    }
}
