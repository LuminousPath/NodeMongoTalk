using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver.Linq;

namespace MongoDemo.Controllers
{
    public class HomeController : Controller
    {
        public MongoDemo.Models.Class displayclass;
        //
        // GET: /Home/

        public ActionResult Index()
        {

            using(var ctx = new MongoDemo.Models.MongoDBContext())
            {
                var newclass = from cls in ctx.Classes
                               select cls;
                displayclass = newclass.First();

            }

            return View(displayclass);
        }

    }
}
