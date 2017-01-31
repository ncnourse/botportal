using NateBotSecure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NateBotAPI.Controllers
{
    public class BotMessageController : ApiController
    {
        // GET api/values
        public BotMessage Get()
        {

            return new BotMessage()
            {
                Message = MvcApplication.CurrentCommand,
                BotSpeed = MvcApplication.RobotSpeed
              };
        }

        public class BotMessage
        {
            public string Message { get; set; }
            public int BotSpeed { get; set; }
        }
    }
}