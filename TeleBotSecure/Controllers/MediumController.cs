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
    public class MediumController : ApiController
    {
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            MvcApplication.RobotSpeed = 250;

            return request.CreateResponse(HttpStatusCode.OK);
        }
    }
}