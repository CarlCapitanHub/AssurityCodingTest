using Services.Models;

namespace Services
{
    /// <summary>
    /// Category Service Class
    /// </summary>
    public class CategoryService : BaseWebService
    {
        #region Implementation
        /// <summary>
        /// Initialize a new instance of the <see cref="CategoryService" /> class.
        /// </summary>
        /// <param name="baseUrl"></param>
        public CategoryService(string baseUrl) : base(baseUrl)
        {

        }
        #endregion

        #region Properties

        #endregion

        #region Methods
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
        #endregion
    }
}