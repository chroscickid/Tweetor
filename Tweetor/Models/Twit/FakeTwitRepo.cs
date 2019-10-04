using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetor.Models;

namespace Tweet.Models
{
    public class FakeTwitRepo : TwitRepository
    {
        public IEnumerable<Twit> Twits => new List<Twit>
        {
            new Twit { content = "Hello Tweetor!", Likes = 500, TwitID = 0, Author = "Daddyfinger" },
            new Twit { content = "I could've been first", Likes = 200, TwitID = 1, Author = "Adam"} 
            
        };
    }
}