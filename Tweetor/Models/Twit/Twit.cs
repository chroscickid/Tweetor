using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetor.Models
{
    public class Twit
    {
        public string content { get; set; }
        public int Likes { get; set; }
        public int TwitID { get; set; }
        public string Author { get; set; }
    }
}
