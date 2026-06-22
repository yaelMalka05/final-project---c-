using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    //public enum AreasOfExpertise
    //{
    //    cleaning, cooking, transportation, babysitting, outings, games, activities
    //        ,gardening ,delivery, tutoring , unknown
    //}





    public class Volunteer
    {
        public int Id { get; init; }

        public string FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        //public List<AreasOfExpertise> PersonalAreasOfExpertise { get; private set; } = new List<AreasOfExpertise>();
        public int? PersonalAreasOfExpertiseId { get; set; }
        public AreasOfExpertise? PersonalAreasOfExpertise { get; set; }
        public string? Password { get; set; }
    }
}
