using System;
using System.Collections.Generic;
using System.Text;
using RabbitIntegration.Integrator.Application.Models;

namespace RabbitIntegration.Integrator.Application.Interfaces
{
    public interface IOrderService
    {
        CoverResponse CoverValidation(CoverValidation coverValidation);

        CoverValidation EnterOrder(CoverValidation order);
    }
}
