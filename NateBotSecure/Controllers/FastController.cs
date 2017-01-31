using NateBotSecure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NateBotAPI.Controllers
{
    public class FastController : ApiController
    {
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            MvcApplication.RobotSpeed = 500;

            return request.CreateResponse(HttpStatusCode.OK);
        }
    }
}