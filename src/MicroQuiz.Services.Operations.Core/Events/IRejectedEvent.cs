namespace MicroQuiz.Services.Operations.Core.Events
{
    public interface IRejectedEvent : IEvent
    {
        string Reason { get; set; }
    }
}