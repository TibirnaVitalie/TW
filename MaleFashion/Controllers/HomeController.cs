using MaleFashion.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaleFashion.BusinessLogic.DBModel;

namespace MaleFashion.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
               UDbTable q = new UDbTable();
               q.Username = "Vitalie";
               q.Password = "ad9b73de850b889e4a04e215634ddc59"; //hash for 12345678
               q.Email = "Top SECRET";
               q.Level = Domain.Enums.URole.Admin;
               q.LasIp = "123456789";
               q.LastLogin = DateTime.Now;

               using (var db = new UserContext())
               {
                    db.Users.Add(q);
                    db.SaveChanges();
               }
               return View();
        }
    }
}