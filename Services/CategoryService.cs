using Services.Models;

namespace Services
{
    /// <summary>
    /// Category Service Class
    /// </summary>
    public class CategoryService : BaseWebService
    {

        /// <summary>
        /// Initialize a new instance of the <see cref="CategoryService" /> class.
        /// </summary>
        /// <param name="baseUrl"></param>
        public CategoryService(string baseUrl) : base(baseUrl)
        {

        }

        /// <summary>
        /// Gets the Category details of the specified ID.
        /// </summary>
        /// <param name="categoryId">Category ID to get details of.</param>
        /// <returns></returns>
        public CategoryModel GetCategoryById(string categoryId)
        {
            // Creating the Request
            var request = new RestRequest($"{categoryId}/Details.json?catalogue=false");

            // Sending the Request and Getting a Response
            var response = Client.ExecuteGet(request);

            // Checking if Content is not null
            string content = response.Content ?? string.Empty;

            // Assigning Response Status Code to CurrentResponseStatusCode property for Status Code validation
            CurrentResponseStatusCode = response.StatusCode;

            // Returning the content in a Category Model instance
            return JsonSerializer.Deserialize<CategoryModel>(content)!;
        }

        /// <summary>
        /// Finds the Promotion with the specified name and description in the given array of Promotions.
        /// </summary>
        /// <param name="promotions"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public Promotion? FindPromotion(Promotion[] promotions, string name, string description)
        {
            foreach (var promotion in promotions)
            {
                if (promotion is not null)
                {
                    if (promotion.Name == name && promotion.Description == description)
                    {
                        // Returns the promotion instance that satisfies the condition
                        return promotion;
                    }
                }
            }

            // Returns null if the specific promotion is not found
            return null;
        }
    }
}