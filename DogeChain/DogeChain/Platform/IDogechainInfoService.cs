using System.Threading.Tasks;

namespace DogeChain.Platform
{
    /// <summary>
    /// Service for getting information about platform
    /// </summary>
    public interface IDogechainInfoService
    {
        /// <summary>
        /// Get current block count
        /// </summary>
        /// <returns></returns>
        Task<string> GetBlockCount();

        /// <summary>
        /// Get last solved block's difficulty
        /// </summary>
        /// <returns></returns>
        Task<string> GetCurrentDifficulty();

        /// <summary>
        /// Get the amount of currency ever mined
        /// </summary>
        /// <returns></returns>
        Task<string> GetTotalMined();
    }
}