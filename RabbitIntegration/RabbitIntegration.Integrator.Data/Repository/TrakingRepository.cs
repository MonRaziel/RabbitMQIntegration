using System;
using System.Collections.Generic;
using System.Text;
using RabbitIntegration.Integrator.Data.Context;
using RabbitIntegration.Integrator.Domain.Interfaces;
using RabbitIntegration.Integrator.Domain.Models;

namespace RabbitIntegration.Integrator.Data.Repository
{
    public class TrakingRepository : ITrakingRepository
    {
        private readonly IntegratorDbContext _ctx;

        public TrakingRepository(IntegratorDbContext ctx)
        {
            _ctx = ctx;
        }

        public void TrakingOrders(OrderTraking orderTraking)
        {
            _ctx.OrdersTraking.Add(orderTraking);
        }
    }
}
