using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace WebApiFireBase.Firebase
{
    public interface IFirebase
    {
        void Post(string data, string status);
        Task Put(string child1, string child2, string child3, string data, string status);
        void Delete(string child1, string child2, string child3);
    }
}