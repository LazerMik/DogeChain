﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogeChain.Platform
{
    ///<inheritdoc/>>
    public class DogechainInfoService : IDogechainInfoService
    {
        private readonly HttpClient _httpClient;

        /// <summary/>
        public DogechainInfoService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://dogechain.info/chain/Dogecoin/q/"),
                Timeout = TimeSpan.FromMinutes(1)
            };
        }
        
        ///<inheritdoc/>>
        public async Task<string> GetBlockCount()
        {
            using (var response = await _httpClient.GetAsync("getblockcount"))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> GetCurrentDifficulty()
        {
            using (var response = await _httpClient.GetAsync("getdifficulty"))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }

        ///<inheritdoc/>>
        public async Task<string> GetTotalMined()
        {
            using (var response = await _httpClient.GetAsync("totalbc"))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}