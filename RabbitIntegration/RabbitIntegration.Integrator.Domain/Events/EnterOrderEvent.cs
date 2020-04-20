using System;
using System.Collections.Generic;
using System.Text;
using RabbitIntegration.Domain.Core.Events;

namespace RabbitIntegration.Integrator.Domain.Events
{
    public class EnterOrderEvent : Event
    {
        public int Id { get; private set; }
        public string CodigoDane { get; private set; }
        public string Guid { get; private set; }

        public EnterOrderEvent(int id, string codigoDane, string guid)
        {
            Id = id;
            CodigoDane = codigoDane;
            Guid = guid;
        }
    }
}
