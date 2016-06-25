using System.Collections.Generic;
using System.Web.Http;

namespace OnDemandWebServer.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/testing")]
        public List<string> Get()
        {
            return new List<string>
            {
                "hello",
                "world"
            };
        } 
    }
}