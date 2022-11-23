using Microsoft.Extensions.Options;
using Net6SpaTemplate.BLL.Client;
using Net6SpaTemplate.BLL.Objects;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Net6SpaTemplate.BLL
{
    public class TestFacade : ITestFacade
    {
        private readonly IClient _foodApiClient;
        private readonly APIKeys _apikeys;
        private readonly RestClient _client;

        public TestFacade(IClient foodApiClient, IOptions<APIKeys> APIKeys)
        {
            _foodApiClient = foodApiClient;
            _apikeys = APIKeys.Value;
            _client = new RestClient();
        }
        public async Task<IEnumerable<Recipe>> GetRecipie(string search)
        {
            return await GetRecipies(search);
        }

        private async Task<IEnumerable<Recipe>> GetRecipies(string search)
        {
            var recipeResponse = await _foodApiClient.V2Async(Client.Type.Public, _apikeys.RecipieAppId, _apikeys.RecipieAPIKey, q: search);

            var recipieList = new List<Recipe>();
            //var recipeResponse = new List<Recipe>();
            //recipeResponse.Add(new Recipe() {
            //    Images = "https://edamam-product-images.s3.amazonaws.com/web-img/e42/e42f9119813e890af34c259785ae1cfb-m.jpg?X-Amz-Security-Token=IQoJb3JpZ2luX2VjEHAaCXVzLWVhc3QtMSJGMEQCIBjipezh3kIfL1KbvCxY4CNxeZj21U8bApn2Fem31X53AiAuq07kiD2%2FFkSkwu4TB24kaywNEXW560gQeb8yQTRZPirMBAh5EAAaDDE4NzAxNzE1MDk4NiIMRIhYpYbPQJ3M%2FWriKqkE8cEfTCupu0hBd%2Fbc55Yh%2B9S2wZusxqNPqj%2Bl0z6ydgkU70FrE6d7487eFiKGUdzyYZJKl1NhFq3FSFMDp079BFAAP9biN6YjJHP0prs4T2vxaQWjKFPz9PTmXTQsMy0OaNlbdsFKVdp9KVKHjVTi0b2wUOUhfsNC4lRaS4ZoynqqiSadrOzcGocfZ3n%2FVf7CwGyfd3pjLurHnoox5DNygndjYsbC7xsWjdMaa1xX%2BOe26t06bi5gNbGwJ4lWHvpSewKe31kf%2BcIUOvdoI4QLgXvnKEHpWFdAg8WMUfflv9GDla6YBDlwfTxjJnI7sjzjgglKJHafXgT9MRhALiqpISnfUeYYu49XZdvXRgscBnM9z6QXe3z74sFrwh9dGEoDGHN8NhTjf9S99aFCECVEw1%2BNXHn2bxJxlSRx6jctZSJlc%2FNB%2BCxaSLXVU7onFGnDZT0zZ2pufcXKCMX2rKuCue%2BcLBGoRBewD2otOdr1ZC6XA1xMciTsBXqFWEmWqWZeeRWtLyOXkInopg6JG1%2BxoUGVxBT9gDZItZhGduit8nQvy1p5q5UXLYgaEcu%2F%2Bk4UELEFsAL2qcOemXv2lc9Vps7HeJZOwpOaexslJkl9sSfCMSmfUeQZy7e%2B3arqj2al3YhALljMBYXYUGP6EFVxYOxGhjetbjEN01yPRwnd5h0k5ZihqkSMDWuWQV7YKbicpu%2Fjn5QdaDWv64v9SgpVRRv%2Bg8aMxvNB%2BTDjmumbBjqqAaKwe6uUFz18qb4ydAKL%2FRLyTX6WX3CmaqgzymxJRK%2FOmWSTcdPWSx2b0Vy6uP4qhsJEyeFZTRt5X6G1Ej9V%2BaaUMiuPqpVrQzwdvMPxEXhTRJcUkVpG5CnINafKTkt%2FADjo1bz1iDj0pwMV78Bj9Ksf80oeAWrRboXsz5Sp4wJrqLcJk8MzGPWSFdVKT1XoROt7ZLud5rAGrJA8ZApsroHBKYWBm0H%2B1yLz&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20221120T174108Z&X-Amz-SignedHeaders=host&X-Amz-Expires=3600&X-Amz-Credential=ASIASXCYXIIFOS5X4YZS%2F20221120%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Signature=3a15e140f736afd44563df663013818840b06cd34e89c19d8d4650319334de8b",
            //    Recipie = new RecipieResponse()
            //        { recipe = DummyRecipie.getJsonObject() }
            //    }
            //);

            foreach (var recipe in recipeResponse.Hits.Take(6))
            {
                var request = new RestRequest(recipe._links.Self.Href);
                var resp = new Recipe()
                {
                    Images = recipe.Recipe.Images.SMALL.Url,
                    Recipie = await _client.GetAsync<RecipieResponse>(request)
                };
                resp.Recipie.recipe.nutrients = new Nutrients
                {
                    FAT = (resp.Recipie.recipe.totalNutrients.FAT.quantity + resp.Recipie.recipe.totalNutrients.FAT.unit),
                    FASAT = (resp.Recipie.recipe.totalNutrients.FASAT.quantity + resp.Recipie.recipe.totalNutrients.FASAT.unit),
                    FATRN = (resp.Recipie.recipe.totalNutrients.FATRN.quantity + resp.Recipie.recipe.totalNutrients.FATRN.unit),
                    FAMS = (resp.Recipie.recipe.totalNutrients.FAMS.quantity + resp.Recipie.recipe.totalNutrients.FAMS.unit),
                    FAPU = (resp.Recipie.recipe.totalNutrients.FAPU.quantity + resp.Recipie.recipe.totalNutrients.FAPU.unit),
                    CHOCDF = (resp.Recipie.recipe.totalNutrients.CHOCDF.quantity + resp.Recipie.recipe.totalNutrients.CHOCDF.unit),
                    CHOCDFnet = (resp.Recipie.recipe.totalNutrients.CHOCDFnet.quantity + resp.Recipie.recipe.totalNutrients.CHOCDFnet.unit),
                    FIBTG = (resp.Recipie.recipe.totalNutrients.FIBTG.quantity + resp.Recipie.recipe.totalNutrients.FIBTG.unit),
                    SUGAR = (resp.Recipie.recipe.totalNutrients.SUGAR.quantity + resp.Recipie.recipe.totalNutrients.SUGAR.unit),
                    SUGARadded = (resp.Recipie.recipe.totalNutrients.SUGARadded.quantity + resp.Recipie.recipe.totalNutrients.SUGARadded.unit),
                    PROCNT = (resp.Recipie.recipe.totalNutrients.PROCNT.quantity + resp.Recipie.recipe.totalNutrients.PROCNT.unit),
                    CHOLE = (resp.Recipie.recipe.totalNutrients.CHOLE.quantity + resp.Recipie.recipe.totalNutrients.CHOLE.unit),
                    NA = (resp.Recipie.recipe.totalNutrients.NA.quantity + resp.Recipie.recipe.totalNutrients.NA.unit),
                    CA = (resp.Recipie.recipe.totalNutrients.CA.quantity + resp.Recipie.recipe.totalNutrients.CA.unit),
                    MG = (resp.Recipie.recipe.totalNutrients.MG.quantity + resp.Recipie.recipe.totalNutrients.MG.unit),
                    K = (resp.Recipie.recipe.totalNutrients.K.quantity + resp.Recipie.recipe.totalNutrients.K.unit),
                    FE = (resp.Recipie.recipe.totalNutrients.FE.quantity + resp.Recipie.recipe.totalNutrients.FE.unit),
                    ZN = (resp.Recipie.recipe.totalNutrients.ZN.quantity + resp.Recipie.recipe.totalNutrients.ZN.unit),
                    P = (resp.Recipie.recipe.totalNutrients.P.quantity + resp.Recipie.recipe.totalNutrients.P.unit),
                    VITA_RAE = (resp.Recipie.recipe.totalNutrients.VITA_RAE.quantity + resp.Recipie.recipe.totalNutrients.VITA_RAE.unit),
                    VITC = (resp.Recipie.recipe.totalNutrients.VITC.quantity + resp.Recipie.recipe.totalNutrients.VITC.unit),
                    THIA = (resp.Recipie.recipe.totalNutrients.THIA.quantity + resp.Recipie.recipe.totalNutrients.THIA.unit),
                    RIBF = (resp.Recipie.recipe.totalNutrients.RIBF.quantity + resp.Recipie.recipe.totalNutrients.RIBF.unit),
                    NIA = (resp.Recipie.recipe.totalNutrients.NIA.quantity + resp.Recipie.recipe.totalNutrients.NIA.unit),
                    VITB6A = (resp.Recipie.recipe.totalNutrients.VITB6A.quantity + resp.Recipie.recipe.totalNutrients.VITB6A.unit),
                    FOLDFE = (resp.Recipie.recipe.totalNutrients.FOLDFE.quantity + resp.Recipie.recipe.totalNutrients.FOLDFE.unit),
                    FOLFD = (resp.Recipie.recipe.totalNutrients.FOLFD.quantity + resp.Recipie.recipe.totalNutrients.FOLFD.unit),
                    FOLAC = (resp.Recipie.recipe.totalNutrients.FOLAC.quantity + resp.Recipie.recipe.totalNutrients.FOLAC.unit),
                    VITB12 = (resp.Recipie.recipe.totalNutrients.VITB12.quantity + resp.Recipie.recipe.totalNutrients.VITB12.unit),
                    VITD = (resp.Recipie.recipe.totalNutrients.VITD.quantity + resp.Recipie.recipe.totalNutrients.VITD.unit),
                    TOCPHA = (resp.Recipie.recipe.totalNutrients.TOCPHA.quantity + resp.Recipie.recipe.totalNutrients.TOCPHA.unit),
                    VITK1 = (resp.Recipie.recipe.totalNutrients.VITK1.quantity + resp.Recipie.recipe.totalNutrients.VITK1.unit),
                    Sugaralcohol = (resp.Recipie.recipe.totalNutrients.Sugaralcohol.quantity + resp.Recipie.recipe.totalNutrients.Sugaralcohol.unit),
                    WATER = (resp.Recipie.recipe.totalNutrients.WATER.quantity + resp.Recipie.recipe.totalNutrients.WATER.unit)

                };
                    recipieList.Add(resp);
            }
                return recipieList;
        }
    }

    public interface ITestFacade
    {
        Task<IEnumerable<Recipe>> GetRecipie(string search);
    }
}