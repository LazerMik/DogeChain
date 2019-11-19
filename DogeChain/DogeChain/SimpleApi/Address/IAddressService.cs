using System.Threading.Tasks;

namespace DogeChain.SimpleApi.Address
{
    /// <summary>
    /// Service for operations with address
    /// </summary>
    public interface IAddressService
    {
        /// <summary>
        /// Get balance of given address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> GetBalanceAsync(string address);

        /// <summary>
        /// Get public key hash encoded in an address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> AddressToHashAsync(string address);

        /// <summary>
        /// Check address validity
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> AddressValidationAsync(string address);

        /// <summary>
        /// Get the version prefix and hash encoded in an address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> DecodeAddressAsync(string address);

        /// <summary>
        /// Get the amount ever received by a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> GetRecievedByAddressAsync(string address);

        /// <summary>
        /// Get the amount ever sent from a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> GetSentByAddressAsync(string address);
        
    }
}