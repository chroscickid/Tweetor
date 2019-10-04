using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetor.Models
{
    public interface TwitRepository
    {
        IEnumerable<Twit> Twits { get; }
    }
}