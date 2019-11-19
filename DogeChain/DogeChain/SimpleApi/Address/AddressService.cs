using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogeChain.SimpleApi.Address
{
    ///<inheritdoc/>>
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        /// <summary/>
        public AddressService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://dogechain.info/chain/Dogecoin/q/"),
                Timeout = TimeSpan.FromMinutes(1)
            };
        }

        ///<inheritdoc/>>
        public async Task<string> GetBalanceAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("addressbalance/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> AddressToHashAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("addresstohash/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> AddressValidationAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("checkaddress/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> DecodeAddressAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("decode_address/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> GetRecievedByAddressAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("getreceivedbyaddress/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> GetSentByAddressAsync(string address)
        {
            using (var response = await _httpClient.GetAsync("getsentbyaddress/" + address))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}