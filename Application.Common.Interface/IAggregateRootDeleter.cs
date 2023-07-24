namespace Application.Common.Interface
{
    /// <summary>
    /// Interface to provide a connection between service layer and domain, to remove a aggregate root
    /// </summary>
    /// <typeparam name="ICommand"></typeparam>
    public interface IAggregateRootDeleter<ICommand>
    {
        /// <summary>
        /// Deletes an aggregate root from provided command
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="loggedInPersonId"></param>
        Task DeleteAsync(ICommand cmd, int loggedInPersonId);
    }
}