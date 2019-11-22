using MicroQuiz.Services.Operations.Application.Queries;
using MicroQuiz.Services.Operations.Core.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Application.QueryHandlers
{
    public class GetOperationByIdQueryHandler //: IRequestHandler<GetOperationByIdQuery, OperationDto>
    {
        public GetOperationByIdQueryHandler()
        {

        }

        public Task<OperationDto> Handle(GetOperationByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
