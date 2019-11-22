using System;
using System.Collections.Generic;
using System.Text;

namespace MicroQuiz.Services.Operations.Core.Events.Operation.Question
{
    public class DeleteQuestionOperationEvent : IEvent
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
    }
}
