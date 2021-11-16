using Clients.Clients;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterServices
{
    public class SearchRecentTweets
    {
        private SearchTweets SearchTweetsClient;
        public SearchRecentTweets(SearchTweets searchTweetsClient)
        {
            SearchTweetsClient = searchTweetsClient;
        }
        public Task<SearchTweetResponseModel> Search() 
        {
            //SearchTweetsClient.SearchTweet()
            return null;
        }
    }
}
