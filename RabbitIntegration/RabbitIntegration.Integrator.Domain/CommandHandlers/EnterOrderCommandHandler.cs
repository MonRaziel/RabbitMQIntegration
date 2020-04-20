using RabbitIntegration.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RabbitIntegration.Integrator.Domain.Commands;
using RabbitIntegration.Integrator.Domain.Events;

namespace RabbitIntegration.Integrator.Domain.CommandHandlers
{
    public class EnterOrderCommandHandler : IRequestHandler<EnterOrderCommand, bool>
    {
        private readonly IEventBus _bus;
        public EnterOrderCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(EnterOrderCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new EnterOrderEvent(request.Id, request.CodigoDane, request.Guid));

            return Task.FromResult(false);
        }
    }
}
