using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using entities;
using DTOs;

namespace service
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<VDTO.VolunteerPostDTO , Volunteer>();
            CreateMap<Volunteer, VDTO.VolunteerDTO>().
                ForMember(d => d.PersonalAreasOfExpertiseId, opt => opt.MapFrom(
                    src => src.PersonalAreasOfExpertise.Expertise.ToLower()));
        }
        //src => src.PersonalAreasOfExpertise != null 
        //            ? src.PersonalAreasOfExpertise.Expertise : "unknown"));
    }
}
