using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroQuiz.Services.Operations.Core.Events.Operation
{
    public class OperationRejectedEvent : IRejectedEvent, IRequest
    {
        public Guid Id { get; set; }

        public string Reason { get; set; }
    }
}
