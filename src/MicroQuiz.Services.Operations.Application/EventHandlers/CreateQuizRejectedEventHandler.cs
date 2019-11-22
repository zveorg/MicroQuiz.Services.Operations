using MediatR;
using MicroQuiz.Services.Operations.Core.Enums;
using MicroQuiz.Services.Operations.Core.Events.Operation;
using MicroQuiz.Services.Operations.Core.Events.Quiz;
using MicroQuiz.Services.Operations.Core.Extensions;
using MicroQuiz.Services.Operations.Core.Messaging;
using MicroQuiz.Services.Operations.Core.Repositories;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Application.EventHandlers
{
    public class CreateQuizRejectedEventHandler : IRequestHandler<CreateQuizRejectedEvent>
    {
        private readonly IBusPublisher _busPublisher;
        private readonly IOperationRepository _operationRepository;

        public CreateQuizRejectedEventHandler(
            IOperationRepository operationRepository,
            IBusPublisher busPublisher)
        {
            _operationRepository = operationRepository.ThrowIfNull(nameof(operationRepository));
            _busPublisher = busPublisher.ThrowIfNull(nameof(busPublisher));
        }

        public async Task<Unit> Handle(CreateQuizRejectedEvent request, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetAsync(request.OperationId);
            if (operation == null)
                return Unit.Value;

            var step = operation.Steps.FirstOrDefault(i => i.EntityId == request.Id);
            if (step == null)
                return Unit.Value;

            //there is no other step
            step.State = OperationState.Rejected;
            operation.State = OperationState.Rejected;
            operation.RejectionReason = request.Reason;
            step.RejectionReason = request.Reason;

            await _operationRepository.UpdateAsync(operation);

            await _busPublisher.PublishAsync(new OperationRejectedEvent { Id = operation.Id, Reason = request.Reason });

            return Unit.Value;
        }
    }
}
