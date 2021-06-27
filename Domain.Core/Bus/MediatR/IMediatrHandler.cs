using System.Threading.Tasks;

namespace Domain.Core.Bus.MediatR
{
    public interface IMediatrHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
