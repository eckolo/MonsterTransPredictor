using MonsterTransPredictor.Models.Infrastructure;
using MonsterTransPredictor.Models.Infrastructure.Service;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MonsterTransPredictor.Controllers
{
    public class DbInitializeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Execute()
        {
            using(var mtp = new Mtp())
            {
                DbInitializer.Initialize(mtp);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
