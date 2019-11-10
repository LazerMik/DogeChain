using System.Threading.Tasks;
using DogeChain.Transactions.Models;

namespace DogeChain.Transactions
{
    /// <summary>
    /// Service for transaction processing
    /// </summary>
    public interface ITransactionService
    {
        /// <summary>
        /// Returns transaction by transaction hash.
        /// </summary>
        /// <param name="transactionHash">Transaction Hash</param>
        /// <returns></returns>
        Task<ResponseModel> GetTransaction(string transactionHash);
    }
}