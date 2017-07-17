using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleAuthen.Controllers
{
    [RoutePrefix("api/Game")]
    public class GameController : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(DateTime.Now.ToLongDateString());
        }
    }
}
