using MicroQuiz.Services.Operations.Core.Enums;
using System;

namespace MicroQuiz.Services.Operations.Core.Dtos
{
    public class OperationDto
    {
        public Guid Id { get; set; }

        public OperationState State { get; set; }

    }
}
