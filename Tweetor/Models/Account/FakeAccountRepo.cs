using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetor.Models;

namespace Tweet.Models
{
    public class FakeAccountRepo : AccountRepository
    {
        public IEnumerable<Account> Accounts => new List<Account>
        {
           new Account { LoginID = "Daddyfinger", Password = "Password", tweetCount = 0},
           new Account { LoginID = "Adam", Password = "Password", tweetCount = 1}
            
        };
    }
}