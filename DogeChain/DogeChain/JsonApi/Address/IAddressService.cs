using System.Threading.Tasks;
using DogeChain.JsonApi.Models;

namespace DogeChain.JsonApi.Address
{
    /// <summary>
    /// Service for operations with address with jsonModels
    /// </summary>
    public interface IAddressService
    {
        /// <summary>
        /// Returns balance for a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<ResponseModel> GetBalanceAsync(string address);

        /// <summary>
        /// Returns total amount of received coins of a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<ResponseModel> GetRecievedByAddressAsync(string address);

        /// <summary>
        /// Returns total amount of sent coins of a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<ResponseModel> GetSentByAddressAsync(string address);

        /// <summary>
        /// Returns unspent outputs for a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<ResponseModel> GetUnspentOutputsAsync(string address);

        /// <summary>
        /// Generates QR-code for given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<ResponseModel> GetAddressQrCodeAsync(string address);
    }
}