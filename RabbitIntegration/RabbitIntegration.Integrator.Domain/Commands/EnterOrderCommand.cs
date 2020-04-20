using System;
using System.Collections.Generic;
using System.Text;
using RabbitIntegration.Domain.Core.Commands;

namespace RabbitIntegration.Integrator.Domain.Commands
{
    public class EnterOrderCommand : Command
    {
        public int Id { get; protected set; }
        public string CodigoDane { get; protected set; }
        public string Guid { get; protected set; }

        public EnterOrderCommand(int id, string codigoDane, string guid)
        {
            Id = id;
            CodigoDane = codigoDane;
            Guid = guid;
        }
    }
}
