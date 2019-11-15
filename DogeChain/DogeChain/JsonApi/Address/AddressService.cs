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
        public async Task<ResponseModel> GetBalance(string address)
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
        public async Task<ResponseModel> GetRecievedByAddress(string address)
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
        public async Task<ResponseModel> GetSentByAddress(string address)
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
        public async Task<ResponseModel> GetUnspentOutputs(string address)
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
        public Task<ResponseModel> GetAddressQrCode(string address)
        {
            throw new NotImplementedException();
        }
    }
}