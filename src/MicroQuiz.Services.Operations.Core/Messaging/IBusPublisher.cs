using MicroQuiz.Services.Operations.Core.Events;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Core.Messaging
{
    public interface IBusPublisher
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
