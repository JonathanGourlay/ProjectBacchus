using Microsoft.Extensions.Options;
using Net6SpaTemplate.BLL.Client;

namespace Net6SpaTemplate.BLL
{
    public class TestFacade : ITestFacade
    {   
        private readonly IClient _foodApiClient;
        private readonly APIKeys _apikeys;

        public TestFacade(IClient foodApiClient, IOptions<APIKeys> APIKeys)
        {
            _foodApiClient = foodApiClient;
            _apikeys = APIKeys.Value;
        }
        public async Task<IEnumerable<Recipe>> GetRecipie(string search)
        {
            var recipeResponse = await _foodApiClient.V2Async(Client.Type.Public, _apikeys.RecipieAppId, _apikeys.RecipieAPIKey, q: search);

            var recipies = recipeResponse.Hits.Select((h) => {
                return new Recipe()
                {
                    Images = h.Recipe.Images.SMALL.Url,
                    Links = h._links.Self.Href
                };
               });

            return recipies;
        }
    }

    public interface ITestFacade
    {
        Task<IEnumerable<Recipe>> GetRecipie(string search);
    }
}