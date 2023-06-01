using RestSharp;
using Services;
using Services.Models;
using Tests.TestData;

namespace SampleAPIAutomationTest
{
    [TestClass]
    public class CategoriesTests
    {
        CategoryService? categoryService;

        /// <summary>
        /// Test Initialize
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the object for CategoryService with the Base URL endpoint
            categoryService = new CategoryService($"https://api.tmsandbox.co.nz/v1/Categories/");
        }

        /// <summary>
        /// Category Test Method
        /// </summary>
        [TestMethod]
        public void CategoryTest()
        {
            // Create the Get Request
            RestRequest request = new RestRequest($"{CategoryData.CategoryId}/Details.json?catalogue=false");

            // Send the Get Request
            RestResponse? response = categoryService?.ExecuteGetMethod(request);

            // Deserialize the Content into an object instance
            string content = response?.Content ?? string.Empty;
            CategoryModel? category = categoryService?.DeserializeContent<CategoryModel>(content);

            // Find the Promotion Details in the Category with the specified name and description
            Promotion[]? promotions = category?.Promotions ?? Array.Empty<Promotion>();
            Promotion? promotion = categoryService?.FindPromotion(promotions, CategoryData.PromotionName, CategoryData.PromotionDescription) ?? null;

            // Verify Status Code is OK
            Assert.AreEqual(HttpStatusCode.OK, response?.StatusCode, $"Failed - Status Code is Expected: {HttpStatusCode.OK} but Actual: {response?.StatusCode}");

            // Validate Category Name is as expected
            Assert.AreEqual(CategoryData.Name, category?.Name, $"Failed - Name is Expected: {CategoryData.Name} but Actual: {category?.Name}");

            // Validate CanRelist property is set to true
            Assert.IsTrue(category?.CanRelist, "Failed: CanRelist is set to false");

            // Validate Promotion Name is as expected
            Assert.AreEqual(CategoryData.PromotionName, promotion?.Name, $"Failed - Promotion Name is Expected: {CategoryData.PromotionName} but Actual: {promotion?.Name}");

            // Validate Promotion Description is as expected
            Assert.AreEqual(CategoryData.PromotionDescription, promotion?.Description, $"Failed - Promotion Description is Expected: {CategoryData.PromotionDescription} but Actual: {promotion?.Description}");
        }
    }
}