using BeeSolverApi.Model;
using Newtonsoft.Json;

namespace BeeSolverApi.Repository
{
    public class MagicCardRepository : IMagicCardRepository
    {
        private const string ApiEndpoint = "https://api.magicthegathering.io/v1/cards";

        public Task<CardDetails> GetAllMagicCards()
        {
            var jsonResponse = string.Empty;
            using (var http = new HttpClient())
            {
                var response = http.GetAsync(ApiEndpoint).Result;
                jsonResponse = response.Content.ReadAsStringAsync().Result;
            }
            var result = JsonConvert.DeserializeObject<CardDetails>(jsonResponse)??new CardDetails();
            return Task.FromResult(result);
        }
    }
}
