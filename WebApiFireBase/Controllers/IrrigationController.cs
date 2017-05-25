using System.Web.Http;
using WebApiFireBase.Firebase;
using WebApiFireBase.Models;

namespace WebApiFireBase.Controllers
{
    [RoutePrefix("api/irrigation")]
    public class IrrigationController : ApiController
    {
        IFirebase firebase;

        [HttpPost]
        public void Add(HumidityData model)
        {
            firebase = new Irrigation();
            firebase.Post(model.data, model.status);
        }

        [HttpPut]
        public void Put(PutHumidityData model)
        {
            firebase = new Irrigation();
            firebase.Put(model.children.child1, model.children.child2, model.children.child3, model.humidity.data, model.humidity.status);
        }

        [HttpDelete]
        public void Delete(Children model)
        {
            firebase = new Irrigation();
            firebase.Delete(model.child1, model.child2, model.child3);
        }
    }
}
