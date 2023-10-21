using Domain.Common;
using Domain.Common.Interface;
using SensorData.Domain.MoistureSensors.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorData.Domain.MoistureSensors
{
    public sealed class MoistureSensor : AggregateRoot<MoistureSensorId>
    {
        public MoistureSensor() { }
        private MoistureSensor(MoistureSensorId id)
        {
            Id = id;
        }
        protected override void EnsureValidState()
        {
            throw new NotImplementedException();
        }

        protected override void PreValidation(IDomainEvent @event)
        {
            throw new NotImplementedException();
        }

        protected override void When(IDomainEvent @event)
        {
            throw new NotImplementedException();
        }
        public static MoistureSensor Create(MoistureSensorId id)
            => new(id);

    }
}
