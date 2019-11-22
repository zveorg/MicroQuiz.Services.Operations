using MediatR;
using System;

namespace MicroQuiz.Services.Operations.Core.Events.Operation.Quiz
{
    public class CreateQuizOperationEvent : IEvent, IRequest
    {
        public Guid OperationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
