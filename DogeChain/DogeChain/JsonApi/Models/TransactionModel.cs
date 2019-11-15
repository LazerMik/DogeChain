using System.Collections.Generic;
using Newtonsoft.Json;

namespace DogeChain.JsonApi.Models
{
    /// <summary>
    /// Successful response model
    /// </summary>
    public class TransactionModel : ResponseModel
    {
        /// <summary>
        /// Transaction Info
        /// </summary>
        public Transaction Transaction { get; set; }
    }

    /// <summary>
    /// Transaction model
    /// </summary>
    public class Transaction
    {
        public string Hash { get; set; }
        
        public int Confirmations { get; set; }
        
        public int Size { get; set; }
        
        public int Version { get; set; }
        
        public int Locktime { get; set; }
        
        [JsonProperty("block_hash")] public string BlockHash { get; set; }
        
        public int Time { get; set; }
        
        [JsonProperty("inputs_n")] public int InputsNumber { get; set; }

        public List<Input> Inputs { get; set; }

        [JsonProperty("inputs_value")] public string InputsValue { get; set; }

        [JsonProperty("outputs_n")] public int OutputsNumber { get; set; }

        public List<Output> Outputs { get; set; }

        [JsonProperty("outputs_value")] public string OutputsValue { get; set; }

        public string Fee { get; set; }
    }

    public class Output
    {
        [JsonProperty("pos")] public int Position { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }
    }


    public class Input
    {
        [JsonProperty("pos")] public int Position { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public ScriptSig ScriptSig { get; set; }

        [JsonProperty("previous_output")] public PreviousOutput PreviousOutput { get; set; }
    }

    public class PreviousOutput
    {
        public string Hash { get; set; }
        [JsonProperty("pos")] public int Position { get; set; }
    }

    public class ScriptSig
    {
        public string Hex { get; set; }
    }
}