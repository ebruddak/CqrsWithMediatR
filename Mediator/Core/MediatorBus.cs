using Mediator.Core.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Core
{
    public sealed class MediatorBus : IMediatorBus
    {
        private readonly IMediator mediator;
   

        public MediatorBus(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            return mediator.Send(request, cancellationToken);
        }
    }
}
