using System;

namespace MicroQuiz.Services.Operations.Core.Events.Operation.Question
{
    public class UpdateQuestionOperationEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
    }
}
