using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApiFireBase.Firebase
{
    public interface IFirebase
    {
        void Post(string data, string status);
        void Put(string child1, string child2, string child3, string data, string status);
        void Delete(string child1, string child2, string child3);
    }
}