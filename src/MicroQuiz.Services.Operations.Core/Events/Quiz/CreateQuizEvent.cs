using System;

namespace MicroQuiz.Services.Operations.Core.Events.Quiz
{
    public class CreateQuizEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
