namespace Domain.Common.Interface
{
    public interface IDomainEvent
    {
        /// <summary>
        /// Parameter to decide order of Priority of events
        /// </summary>
        int Priority { get; }
    }
}