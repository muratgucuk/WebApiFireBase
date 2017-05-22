using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFireBase.Firebase;

namespace WebApiFireBase.Controllers
{
    [RoutePrefix("api/irrigation")]
    public class IrrigationController : ApiController
    {
        [HttpGet]
        [Route("humidity")]
        public void AddHumidity(string data, string status)
        {
            IFirebase firebase = new Irrigation("https://irrigation-9f0e2.firebaseio.com/");
            firebase.Post(data, status);
        }
    }
}
