using System;
using System.Net.Http;
using System.Threading.Tasks;
using DogeChain.JsonApi.Models;
using Newtonsoft.Json;

namespace DogeChain.JsonApi.Address
{
    ///<inheritdoc/>>
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dogechain.info/api/v1/address/"),
                Timeout = TimeSpan.FromMinutes(1)
            };
        }
        
        ///<inheritdoc/>>
        public async Task<ResponseModel> GetBalanceAsync(string address)
        {
            using (var response = await _httpClient.GetAsync(address))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<BalanceModel>(json);
                    return model;
                }
                else
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<ErrorModel>(json);
                    return model;
                }
            }
        }

        ///<inheritdoc/>>
        public async Task<ResponseModel> GetRecievedByAddressAsync(string address)
        {
            using (var response = await _httpClient.GetAsync(address))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<TotalAmountModel>(json);
                    return model;
                }
                else
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<ErrorModel>(json);
                    return model;
                }
            }
        }

        ///<inheritdoc/>>
        public async Task<ResponseModel> GetSentByAddressAsync(string address)
        {
            using (var response = await _httpClient.GetAsync(address))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<SentAmountModel>(json);
                    return model;
                }
                else
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<ErrorModel>(json);
                    return model;
                }
            }
        }

        ///<inheritdoc/>>
        public async Task<ResponseModel> GetUnspentOutputsAsync(string address)
        {
            using (var response = await _httpClient.GetAsync(address))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<UnspentOutputModel>(json);
                    return model;
                }
                else
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<ErrorModel>(json);
                    return model;
                }
            }
        }

        ///<inheritdoc/>>
        public Task<ResponseModel> GetAddressQrCodeAsync(string address)
        {
            throw new NotImplementedException();
        }
    }
}