using MediatR;
using MicroQuiz.Services.Operations.Core.Events;

namespace MicroQuiz.Services.Operations.Core.Messaging
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeEvent<TEvent>() where TEvent : IEvent, IRequest;
    }
}
