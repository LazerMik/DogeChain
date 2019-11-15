using System.Collections.Generic;
using Newtonsoft.Json;

namespace DogeChain.JsonApi.Models
{
    public class UnspentOutputModel : ResponseModel
    {
        [JsonProperty("unspent_outputs")]
        public List<UnspentOutput> UnspentOutputs { get; set; }
    }

    public class UnspentOutput
    {
        [JsonProperty("tx_hash")]
        public string TxHash { get; set; }

        [JsonProperty("tx_output_n")]
        public int TxOutputNumber { get; set; }

        public string Script { get; set; }

        public string Value { get; set; }

        public int Confirmations { get; set; }
    }
}