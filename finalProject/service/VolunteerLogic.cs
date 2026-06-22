using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public record VolunteerLogic();
    
}
namespace service
{
    public record VolunteerToAdd(string FullName, string PhoneNumber, string EmailAddress);

}
namespace service
{
    public record VolunteerToShow(string FullName, string PhoneNumber, string EmailAddress , string? personalAreasOfExpertise);


}
namespace service
{
    public record VolunteerToUpdate(string? FullName = null, string? PhoneNumber = null,
        string? EmailAddress = null);

}
