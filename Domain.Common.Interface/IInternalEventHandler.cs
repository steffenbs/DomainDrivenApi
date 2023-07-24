namespace Domain.Common.Interface
{
    public interface IInternalEventHandler
    {
        void Handle(IDomainEvent @event);
    }
}