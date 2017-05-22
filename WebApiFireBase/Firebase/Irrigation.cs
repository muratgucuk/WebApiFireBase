using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using WebApiFireBase.Firebase;
using WebApiFireBase.Models;

namespace WebApiFireBase.Firebase
{
    public class Irrigation : IFirebase
    {
        private FirebaseClient _firebase = null;
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public Irrigation()
        {
            this.Url = "https://irrigation-9f0e2.firebaseio.com/";
            _firebase = new FirebaseClient(Url);
        }

        public Irrigation(string url)
        {
            this.Url = url;
            _firebase = new FirebaseClient(Url);
        }

        public async void Delete(string child1, string child2, string child3)
        {
            await _firebase
                .Child(child1)
                .Child(child2)
                .Child(child3)
                .DeleteAsync();
        }

        public async void Post(string data, string status)
        {
            await _firebase
               .Child("irrigation")
               .PostAsync(new HumidityData
               {
                   data = data,
                   status = status
               });
        }

        public async void Put(string child1, string child2, string child3, string data, string status)
        {
            await _firebase
              .Child(child1)
              .Child(child2)
              .Child(child3)
              .PutAsync(new HumidityData
              {
                  data = data,
                  status = status
              });
        }
    }
}