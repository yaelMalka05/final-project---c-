namespace entities
{
    public enum TaskStatus
    {
        open , completed , assigned
    }

    public enum UrgencyTask
    {
        urgent, middle, calm
    }



    public class PossibleTask
    {
        public int Id { get; init; }

        public string TaskDescription { get; set; }

        public DateTime? Date { get; set; }

        public string Location { get; set; }

        public TaskStatus? Status { get; set; }

        public AreasOfExpertise? TaskTypeId { get; set; }

        public UrgencyTask? Urgency { get; set; }

        public int? TaskFeedbackId {  get; set; }

        public Feedback? TaskFeedback { get; set; }
    }
}
