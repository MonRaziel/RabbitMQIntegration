﻿using RabbitIntegration.Domain.Core.Events;
using System;

namespace RabbitIntegration.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
