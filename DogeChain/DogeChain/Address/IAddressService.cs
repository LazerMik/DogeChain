using System.Threading.Tasks;

namespace DogeChain.Address
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
        Task<string> GetBalance(string address);

        /// <summary>
        /// Get public key hash encoded in an address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> AddressToHash(string address);

        /// <summary>
        /// Check address validity
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> AddressValidation(string address);

        /// <summary>
        /// Get the version prefix and hash encoded in an address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> DecodeAddress(string address);

        /// <summary>
        /// Get the amount ever received by a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> GetRecievedByAddress(string address);

        /// <summary>
        /// Get the amount ever sent from a given address.
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns></returns>
        Task<string> GetSentByAddress(string address);
        
    }
}