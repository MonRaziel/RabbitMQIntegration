using RabbitIntegration.Domain.Core.Bus;
using RabbitIntegration.Integrator.Application.Interfaces;
using RabbitIntegration.Integrator.Application.Models;
using RabbitIntegration.Integrator.Domain.Commands;
using RabbitIntegration.Integrator.Domain.Interfaces;
using System;

namespace RabbitIntegration.Integrator.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly ITrakingRepository _trakingRepository;
        private readonly IEventBus _bus;

        public OrderService(ITrakingRepository trakingRepository, IEventBus bus)
        {
            _trakingRepository = trakingRepository;
            _bus = bus;
        }

        public CoverResponse CoverValidation(CoverValidation coverValidation)
        {
            return null;
        }

        public CoverValidation EnterOrder(CoverValidation order)
        {
            var enterOrderCommand = new EnterOrderCommand(
                order.Id,
                order.CodigoDane,
                new Guid().ToString()
            );

            _bus.SendCommand(enterOrderCommand);

            //If you need to validate if all went well.
            //Task<bool> taskResult  = (Task<bool>)_bus.SendCommand(enterOrderCommand);

            //_trakingRepository
            //You can also track your request in DB using the traking repository

            return order;
        }
    }
}
