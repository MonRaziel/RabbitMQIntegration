using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitIntegration.Integrator.Application.Models
{
    public class CoverResponse
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Mensaje { get; set; }
    }
}
