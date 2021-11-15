using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Clients
{
    public class Retweet
    {
        private HttpClient HttpClient; 
        public Retweet(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task Retweet() { 
            
        }
    }
}
