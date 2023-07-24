using Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class Entity<TId> : IInternalEventHandler
        where TId : Value<TId, int>
    {
        private IInternalEventHandler internalEventHandler;
        public TId Id { get; set; }
        void IInternalEventHandler.Handle(IDomainEvent @event) => When(@event);
        protected virtual void When(IDomainEvent @event) { }
        protected void Apply(IDomainEvent @event) 
        {
            When(@event);
            internalEventHandler.Handle(@event);
        }
        public void SetApplier(IInternalEventHandler internalEventHandler) => this.internalEventHandler = internalEventHandler;

    }
}
