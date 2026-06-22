using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class VDTO
    {
        public record VolunteerDTO(string FullName, string PhoneNumber,
            string EmailAddress, string? personalAreasOfExpertise, int? PersonalAreasOfExpertiseId);
        public record VolunteerPostDTO(string FullName, string PhoneNumber, string EmailAddress,
            string? personalAreasOfExpertise, int? PersonalAreasOfExpertiseId)
        {
            public DateTime birthday { get; set; }

        }
    }
}

