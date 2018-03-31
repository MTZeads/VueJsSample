using System;
using System.Web.Http;

namespace VueJsSample.Controllers
{
    public class RandomMessageApiController : ApiController
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }

        [Route("api/RandomMessageAPI/Get")]
        [HttpGet]
        public int Get()
        {
            return RandomNumber(1, 100);
        }
    }
}