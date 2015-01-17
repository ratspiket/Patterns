
namespace Patterns.Logging
{
    /// <summary>
    /// Interface ILogManager
    /// </summary>
    public interface ILogManager
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>ILogger.</returns>
        ILogger GetLogger(string name);
    }
}
