namespace Models
{
    /// <summary>
    /// Base Web Service Class
    /// </summary>
    public class BaseWebService
    {
        /// <summary>
        /// Initializes new instace of Base Web Service class.
        /// Setup the Web Service Client for each web service.
        /// </summary>
        /// <param name="baseUrl"></param>
        public BaseWebService(string baseUrl)
        {
            var options = new RestClientOptions(baseUrl);
            BaseUrl = baseUrl;
            Client = new RestClient(options, useClientFactory:true);
        }

        /// <summary>
        /// Gets or Sets the Web Service Client
        /// </summary>
        protected RestClient Client { get; set; }

        /// <summary>
        /// Gets or Sets the BaseURL
        /// </summary>
        protected string BaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets the HttpStatusCode of a current response
        /// </summary>
        public HttpStatusCode CurrentResponseStatusCode { get; protected set; }
    }
}
