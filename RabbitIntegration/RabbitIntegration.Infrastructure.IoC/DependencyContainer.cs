using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RabbitIntegration.Domain.Core.Bus;
using RabbitIntegration.Infrastructure.Bus;
using RabbitIntegration.Integrator.Application.Interfaces;
using RabbitIntegration.Integrator.Application.Services;
using RabbitIntegration.Integrator.Data.Context;
using RabbitIntegration.Integrator.Data.Repository;
using RabbitIntegration.Integrator.Domain.CommandHandlers;
using RabbitIntegration.Integrator.Domain.Commands;
using RabbitIntegration.Integrator.Domain.Interfaces;

namespace RabbitIntegration.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMqBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMqBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            //services.AddTransient<TransferEventHandler>();

            //Domain Events
            //services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<EnterOrderCommand, bool>, EnterOrderCommandHandler>();

            //Application Services
            services.AddTransient<IOrderService, OrderService>();
            //services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<ITrakingRepository, TrakingRepository>();
            //services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<IntegratorDbContext>();
            //services.AddTransient<TransferDbContext>();
        }
    }
}
