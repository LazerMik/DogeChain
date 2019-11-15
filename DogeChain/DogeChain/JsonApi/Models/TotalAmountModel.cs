namespace DogeChain.JsonApi.Models
{
    /// <summary>
    /// Total amount of received coins model
    /// </summary>
    public class TotalAmountModel : ResponseModel
    {
        /// <summary>
        /// Total amount of received coins
        /// </summary>
        public string Recieved { get; set; }
    }
}