using Domain.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clients.Clients
{
    public class ManageTweets
    {
        private HttpClient HttpClient;
        public ManageTweets(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateTweet(CreateTweetModel tweet)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(tweet), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await HttpClient.PostAsync("tweets", content);
            return responseMessage;
        }
    }
}
