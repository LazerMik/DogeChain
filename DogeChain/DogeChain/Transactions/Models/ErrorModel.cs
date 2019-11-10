namespace DogeChain.Transactions.Models
{
    /// <summary>
    /// Error model
    /// </summary>
    public class ErrorModel : ResponseModel
    {
        /// <summary>
        /// Error description
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Is success
        /// </summary>
        public int Success { get; set; }
    }
}