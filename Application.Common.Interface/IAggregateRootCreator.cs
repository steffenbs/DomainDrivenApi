namespace Application.Common.Interface
{
    /// <summary>
    /// Interface to provide a connection between service layer and domain to create new aggregate root.
    /// </summary>
    /// <typeparam name="ICommand"></typeparam>
    /// <typeparam name="ReturnObject"></typeparam>
    public interface IAggregateRootCreator<ICommand, ReturnObject>
    {
        /// <summary>
        /// Creates a new aggregate root from a provided command
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="loggedInPersonId"></param>
        /// <returns>Returns the newly created aggregate root</returns>
        Task<ReturnObject> CreateAsync(ICommand cmd, int loggedInPersonId);
    }
}