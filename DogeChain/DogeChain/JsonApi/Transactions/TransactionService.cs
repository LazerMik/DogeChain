using System;
using System.Net.Http;
using System.Threading.Tasks;
using DogeChain.JsonApi.Models;
using Newtonsoft.Json;

namespace DogeChain.JsonApi.Transactions
{
    ///<inheritdoc/>>
    public class TransactionService : ITransactionService
    {
        private readonly HttpClient _httpClient;

        public TransactionService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dogechain.info/api/v1/"),
                Timeout = TimeSpan.FromMinutes(1)
            };
        }

        ///<inheritdoc/>>
        public async Task<ResponseModel> GetTransaction(string transactionHash)
        {
            using (var response = await _httpClient.GetAsync("transaction/"+transactionHash))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<TransactionModel>(json);
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
    }
}