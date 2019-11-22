using System;

namespace MicroQuiz.Services.Operations.Core.Events.Operation.Quiz
{
    public class DeleteQuizOperationEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
    }
}
