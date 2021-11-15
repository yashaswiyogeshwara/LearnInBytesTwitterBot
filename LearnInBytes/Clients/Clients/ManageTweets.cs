using System.Net.Http;
using System.Text;
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

        public async Task CreateTweet(string tweet)
        {
            StringContent content = new StringContent(tweet, Encoding.UTF8, "application/json");
            await HttpClient.PostAsync("tweets", content);
        }
    }
}
