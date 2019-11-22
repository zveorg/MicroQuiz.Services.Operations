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
    public class QuizCreatedEventHandler : IRequestHandler<QuizCreatedEvent>
    {
        private readonly IBusPublisher _busPublisher;
        private readonly IOperationRepository _operationRepository;

        public QuizCreatedEventHandler(
            IBusPublisher busPublisher,
            IOperationRepository operationRepository)
        {
            _busPublisher = busPublisher.ThrowIfNull(nameof(busPublisher));
            _operationRepository = operationRepository.ThrowIfNull(nameof(operationRepository));
        }

        public async Task<Unit> Handle(QuizCreatedEvent request, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetAsync(request.OperationId);
            if(operation == null)
                return Unit.Value;

            var step = operation.Steps.FirstOrDefault(i => i.EntityId == request.Id);
            if(step == null)
                return Unit.Value;

            step.State = OperationState.Completed;
            if (operation.Steps.All(i => i.State == OperationState.Completed))
                operation.State = OperationState.Completed;

            await _operationRepository.UpdateAsync(operation);

            if (operation.State == OperationState.Completed)
                await _busPublisher.PublishAsync(new OperationCompletedEvent { Id = request.OperationId });

            return Unit.Value;

        }
    }
}
