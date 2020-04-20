using System;
using System.Collections.Generic;
using System.Text;
using RabbitIntegration.Integrator.Domain.Models;

namespace RabbitIntegration.Integrator.Domain.Interfaces
{
    public interface ITrakingRepository
    {
        void TrakingOrders(OrderTraking orderTraking);
    }
}
