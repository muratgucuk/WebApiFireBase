using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFireBase.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public async System.Threading.Tasks.Task<string> Get(int id)
        {

            var firebase = new FirebaseClient("https://irrigation-9f0e2.firebaseio.com/");
            var humi = await firebase
               .Child("irrigation")
               .PostAsync(new humiditydata
               {
                   data = "test",
                   status = "true"
               });

            await firebase
  .Child("irrigation")
  .Child("humiditydata")
  .Child("02")
  .PutAsync(new humiditydata
  {
      data = "test",
      status = "true"
  });




            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class humiditydata
    {
        public string data { get; set; }
        public string status { get; set; }
    }
}
