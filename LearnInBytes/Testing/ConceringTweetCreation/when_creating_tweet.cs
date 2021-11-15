using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.ConceringTweetCreation
{
    public class when_creating_tweet
    {
        public when_creating_tweet()
        {
            Arrange();
            Act();
        }
        private void Arrange()
        {
            var Subject = new TweetClient();
            Subject.Tweet();
        }
        private void Act()
        {
            throw new NotImplementedException();
        }
        
    }
}
