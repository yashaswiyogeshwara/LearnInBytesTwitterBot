using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace Clients.Clients
{
    public class SearchTweets
    {
        private HttpClient HttpClient;
        public SearchTweets(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task<SearchTweetResponseModel> SearchTweet(SearchTweetModel searchModel) 
        {
            SearchTweetResponseModel result = null;
            UriBuilder builder = new UriBuilder("recent");
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["query"] = searchModel.Query;
            if(!String.IsNullOrEmpty(searchModel.FromId))
            {
                query["since_id"] = searchModel.FromId;
            }   
            builder.Query = query.ToString();
            string url = builder.ToString();
            HttpResponseMessage response = await HttpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<SearchTweetResponseModel>(message);
            }
            return result;
        }
    }
}
