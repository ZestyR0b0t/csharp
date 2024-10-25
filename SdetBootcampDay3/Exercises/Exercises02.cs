using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using RestSharp;

namespace SdetBootcampDay3.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        private const string BASE_URL = "http://jsonplaceholder.typicode.com";

        private RestClient client;

        [OneTimeSetUp]
        public void SetupRestSharpClient()
        {
            client = new RestClient(BASE_URL);
        }

        /**
         * TODO: rewrite these three tests into a single parameterized test
         * If you're stuck, have a look at the exercises for Day 1, as we
         * did the exact same thing there (just for a unit test instead of an API test).
         * Do this either using the [TestCase] attribute, or using [TestDataSource] combined
         * with the appropriate method to create and yield the TestCaseData objects.
         */
        [TestCase(1, "Leanne Graham")]
        [TestCase(2, "Ervin Howell")]
        [TestCase(3, "Clementine Bauch")]
        
        [Test]
        public async Task GetDataForUserId_CheckName_ShouldEqualExpectedName(int userId, string expectedName)
        {
            RestResponse response = await GetUserResponse(userId);

            Assert.That(GetUserName(response), Is.EqualTo(expectedName));
        }

        private async Task<RestResponse> GetUserResponse(int userId)
        {
            RestRequest request = new RestRequest($"/users/{userId}", Method.Get);
            return await client.ExecuteAsync(request);
        }

        private string GetUserName(RestResponse response)
        {
            JObject responseData = JObject.Parse(response.Content!);
            return responseData.SelectToken("name")!.ToString();
        }
    }
}
