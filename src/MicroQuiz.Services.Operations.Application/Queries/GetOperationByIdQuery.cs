using MediatR;
using MicroQuiz.Services.Operations.Core.Dtos;
using System;

namespace MicroQuiz.Services.Operations.Application.Queries
{
    public class GetOperationByIdQuery: IRequest<OperationDto>
    {
        public Guid Id { get; set; }
    }
}
