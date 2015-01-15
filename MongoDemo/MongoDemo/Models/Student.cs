using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDemo.Models
{
    public class Student
    {
        public ObjectId Id;
        public string FName { get; set; }
        public string LName { get; set; }
        public int age { get; set; }
    }
}