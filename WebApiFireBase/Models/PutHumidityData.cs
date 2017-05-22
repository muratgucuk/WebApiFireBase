using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFireBase.Models
{
    public class PutHumidityData
    {
        public Children children { get; set; }
        public HumidityData humidity { get; set; }
    }
}