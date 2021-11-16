using Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clients.Clients
{
    public class Retweet
    {
        private HttpClient HttpClient;
        private ILogger<Retweet> Logger;
        public Retweet(HttpClient httpClient, ILogger<Retweet> logger)
        {
            HttpClient = httpClient;
            Logger = logger;
        }
        public async Task<HttpResponseMessage> RetweetMessage(RetweetModel model) {
            string url = String.Format("users/{0}/retweets", model.UserId);
            StringContent content = new StringContent(JsonSerializer.Serialize(model),Encoding.UTF8,"application/json");
            HttpResponseMessage responseMessage = await HttpClient.PostAsync(url, content);
            return responseMessage; 
        }
    }
}
