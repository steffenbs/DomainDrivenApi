using Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AggregateRoot<TId> : IInternalEventHandler
    {
        private readonly IList<IDomainEvent> changes = new List<IDomainEvent>();
        public TId Id { get; set; }
        protected void Apply(IDomainEvent @event)
        {
            PreValidation(@event);
            When(@event);
            EnsureValidState();
            changes.Add(@event);
        }
        protected abstract void PreValidation(IDomainEvent @event);
        protected abstract void When(IDomainEvent @event);
        protected abstract void EnsureValidState();
        protected void ApplyToEntity(IInternalEventHandler entity, IDomainEvent @event) => entity?.Handle(@event);
        public IEnumerable<IDomainEvent> GetChanges() => changes;
        void IInternalEventHandler.Handle(IDomainEvent @event) => ApplyEventFromEntity(@event);

        private void ApplyEventFromEntity(IDomainEvent @event)
        {
            When(@event);
            changes.Add(@event);
        }
    }
}
