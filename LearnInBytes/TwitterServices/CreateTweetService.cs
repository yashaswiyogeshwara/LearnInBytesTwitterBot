using Clients.Clients;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TwitterServices
{
    public class CreateTweetService
    {
        private ManageTweets ManageTweetsClient;
        public CreateTweetService(ManageTweets manageTweetsClient)
        {
            ManageTweetsClient = manageTweetsClient;
        }

        public async Task<HttpResponseMessage>  CreateTweet(string tweet)
        {
            CreateTweetModel model = new CreateTweetModel()
            {
                Tweet = tweet
            };
            return  await ManageTweetsClient.CreateTweet(model);
        }
    }
}
