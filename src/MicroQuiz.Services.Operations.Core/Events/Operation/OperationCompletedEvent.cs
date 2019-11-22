using MediatR;
using System;

namespace MicroQuiz.Services.Operations.Core.Events.Operation
{
    public class OperationCompletedEvent : IEvent, IRequest
    {
        public Guid Id { get; set; }
    }
}
