using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFireBase.Firebase;
using WebApiFireBase.Models;

namespace WebApiFireBase.Controllers
{
    [RoutePrefix("api/irrigation/humidity")]
    public class IrrigationController : ApiController
    {
        [HttpPost]
        public void AddHumidity(HumidityData model)
        {
            IFirebase firebase = new Irrigation();
            firebase.Post(model.data, model.status);
        }

        [HttpPut]
        public void PutHumidity(PutHumidityData model)
        {
            IFirebase firebase = new Irrigation();
            firebase.Put(model.children.child1, model.children.child2, model.children.child3, model.humidity.data, model.humidity.status);
        }

        [HttpDelete]
        public void DeleteHumidity(Children model)
        {
            IFirebase firebase = new Irrigation();
            firebase.Delete(model.child1, model.child2, model.child3);
        }
    }
}
