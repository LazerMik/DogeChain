namespace DogeChain.JsonApi.Models
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
    }
}