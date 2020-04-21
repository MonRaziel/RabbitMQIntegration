using RabbitIntegration.Domain.Core.Bus;
using RabbitIntegration.Integrator.Domain.Events;
using RabbitIntegration.Integrator.Domain.Interfaces;
using RabbitIntegration.Integrator.Domain.Models;
using System.Threading.Tasks;

namespace RabbitIntegration.Integrator.Domain.EventHandlers
{
    public class EnterOrderEventHandler : IEventHandler<EnterOrderEvent>
    {
        private readonly ITrakingRepository _trakingRepository;

        public EnterOrderEventHandler(ITrakingRepository trakingRepository)
        {
            _trakingRepository = trakingRepository;
        }

        public Task Handle(EnterOrderEvent @event)
        {
            _trakingRepository.TrakingOrders(new OrderTraking()
            {
                Guid = @event.Guid,
                CodigoDane = @event.CodigoDane,
                Id = @event.Id
            });

            return Task.CompletedTask;
        }
    }
}
