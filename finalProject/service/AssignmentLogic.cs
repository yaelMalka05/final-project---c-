using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public record AssignmentLogic();
    
}
namespace service
{
    public record AssignmentToShow(int VolunteerId, int TaskId, string CompletionReportingTime);

}
namespace service
{
    public record AssignmentToUpdate(int VolunteerId, int TaskId, DateTime? CompletionReportingTime=null);

}
