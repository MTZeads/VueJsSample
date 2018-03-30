using System;
using System.Web.Http;

namespace VueJsSample.Controllers
{
    public class RandomMessageApiController : ApiController
    {
        [Route("api/RandomMessageAPI/Get")]
        [HttpGet]
        public string Get()
        {
            return $"API returned {new Random().Next(1, 1000)}";
        }
    }
}