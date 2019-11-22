using MediatR;
using System;

namespace MicroQuiz.Services.Operations.Core.Events
{
    public class BaseRejectedEvent : IRejectedEvent, IRequest
    {
        public Guid OperationId { get; set; }
        public Guid Id { get; set; }
        public string Reason { get; set; }
    }
}
