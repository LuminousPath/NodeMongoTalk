using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MongoDemo.Models
{
    public class MongoDBContext : DbContext
    {
        MongoDB.Driver.MongoDatabase database;

        public IQueryable<Student> Students { get; set; }
        public IQueryable<Class> Classes { get; set; }

        public MongoDBContext()
        {
            System.Configuration.Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MongoDemo1");

            MongoClient client = new MongoClient(config.AppSettings.Settings["MongoDBConnection"].Value.ToString());

            var server = client.GetServer();

            database = server.GetDatabase("Demo1");

            Students = database.GetCollection<Student>("Students").AsQueryable<Student>();
            Classes = database.GetCollection<Class>("Classes").AsQueryable<Class>();

        }


        
    }
}