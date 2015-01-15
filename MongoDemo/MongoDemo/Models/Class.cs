using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MongoDemo.Models
{
    public class Class
    {
        public ObjectId Id;
        public string ClassName { get; set; }
        public int ClassNumber { get; set; }

    }
}