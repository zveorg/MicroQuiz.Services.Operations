using MediatR;
using System;

namespace MicroQuiz.Services.Operations.Core.Events
{
    public class BaseCompletedEvent : IEvent, IRequest
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
    }
}
