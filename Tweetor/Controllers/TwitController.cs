using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tweetor.Models;

namespace Tweetor.Controllers
{
    public class TwitController : Controller
    {
        public TwitRepository repository;
        public TwitController(TwitRepository repo)
        {
            repository = repo;
        }

        public ViewResult TwitList() => View(repository.Twits);
    }
       
}
