using System.Threading.Tasks;

namespace DogeChain.SimpleApi.Platform
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
        Task<string> GetBlockCountAsync();

        /// <summary>
        /// Get last solved block's difficulty
        /// </summary>
        /// <returns></returns>
        Task<string> GetCurrentDifficultyAsync();

        /// <summary>
        /// Get the amount of currency ever mined
        /// </summary>
        /// <returns></returns>
        Task<string> GetTotalMinedAsync();
    }
}