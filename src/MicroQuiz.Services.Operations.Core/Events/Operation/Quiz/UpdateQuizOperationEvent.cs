using System;

namespace MicroQuiz.Services.Operations.Core.Events.Operation.Quiz
{
    public class UpdateQuizOperationEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
