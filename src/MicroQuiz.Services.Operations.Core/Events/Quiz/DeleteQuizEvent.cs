using System;

namespace MicroQuiz.Services.Operations.Core.Events.Quiz
{
    public class DeleteQuizEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
    }
}
