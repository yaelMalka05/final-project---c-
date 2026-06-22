










using entities;

namespace service
{
    public record TaskToAdd(string TaskDescription, DateTime Date, string Location ,UrgencyTask Urgency);

}
namespace service
{
    public record TaskToShow(int Id,string TaskDescription, string Date,
        string Location , string Status , string TaskType , string urgency);
}
namespace service
{
    public record TaskLogic();

}
namespace service
{
    public record TaskToUpdate(string? TaskDescription = null, DateTime? Date = null,
        string? Location = null, entities.TaskStatus? Status = null, UrgencyTask? Urgency = null );

}