using Services.Models;

namespace Services
{
    /// <summary>
    /// Base Web Service Class
    /// </summary>
    public class BaseWebService
    {
        #region Implementation
        /// <summary>
        /// Initializes new instace of Base Web Service class.
        /// Setup the Web Service Client for each web service.
        /// </summary>
        /// <param name="baseUrl"></param>
        public BaseWebService(string baseUrl)
        {
            var options = new RestClientOptions(baseUrl);

            // Initiliaze the http client instance with the specified base url and options
            Client = new RestClient(options, useClientFactory: true);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the Web Service Client
        /// </summary>
        protected RestClient Client { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Exeute the Get Method given the Request provided
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestResponse ExecuteGetMethod(RestRequest request)
        {
            return Client.ExecuteGet(request);
        }

        /// <summary>
        /// Execute the Post Method given the Request provided
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestResponse ExecutePostMethod(RestRequest request)
        {
            return Client.ExecutePost(request);
        }


        /// <summary>
        /// Execute the Put Method given the Request provided
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestResponse ExecutePutMethod(RestRequest request)
        {
            return Client.ExecutePut(request);
        }

        /// <summary>
        /// Deserialize the response content into specified object instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public T DeserializeContent<T>(string content)
        {
            return JsonSerializer.Deserialize<T>(content)!;
        }
    }
    #endregion
}
