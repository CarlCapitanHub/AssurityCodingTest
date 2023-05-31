namespace Services
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

            // Initiliaze the http client instance with the specified base url and options
            Client = new RestClient(options, useClientFactory:true);
        }

        /// <summary>
        /// Gets or Sets the Web Service Client
        /// </summary>
        protected RestClient Client { get; set; }

        /// <summary>
        /// Gets or Sets the HttpStatusCode of a current response
        /// </summary>
        public HttpStatusCode CurrentResponseStatusCode { get; protected set; }
    }
}
