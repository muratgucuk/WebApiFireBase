using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiFireBase.Firebase;
using WebApiFireBase.Models;
using static System.Net.WebRequestMethods;

namespace WebApiFireBase.Controllers
{
    [RoutePrefix("api/irrigation")]
    public class IrrigationController : ApiController
    {
        IFirebase firebase;

        [HttpPost]
        [Route("PostHumidity")]
        public void AddHumidity(HumidityData model)
        {
            firebase = new Irrigation();
            firebase.Post(model.data, model.status);
        }

        [HttpPut]
        [Route("PutHumidity")]
        public void PutHumidity(PutHumidityData model)
        {
            firebase = new Irrigation();
            firebase.Put(model.children.child1, model.children.child2, model.children.child3, model.humidity.data, model.humidity.status);
        }

        [HttpDelete]
        [Route("DeleteHumidity")]
        public void DeleteHumidity(Children model)
        {
            firebase = new Irrigation();
            firebase.Delete(model.child1, model.child2, model.child3);
        }
    }
}
