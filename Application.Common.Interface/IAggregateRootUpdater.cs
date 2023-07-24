namespace Application.Common.Interface
{
    /// <summary>
    /// Interface to provide a connection between service layer and domain.
    /// </summary>
    /// <typeparam name="ICommand"></typeparam>
    public interface IAggregateRootUpdater<ICommand>
    {
        /// <summary>
        /// Applies an action as a command to the domain object.
        /// </summary>
        /// <param name="cmd"></param>
        Task HandleAsync(ICommand cmd, int loggedInPersonId, bool whatIf);
    }
}