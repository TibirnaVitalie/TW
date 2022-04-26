using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaleFashion.Web.Models
{
    public class ShopController : Controller
    {
          // GET: Shop
          public ActionResult Index()
          {
               var product = Request.QueryString["p"];
               UserData u = new UserData();
               u.Username = "Guest from Shop";
               u.Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };
               u.SingleProduct = product;

               return View(u);

          }

          [HttpPost]
          public ActionResult Index(string btn)
          {
               return Json(new { RedirectUrl = Url.Action("Product", new { @p = btn }) });
          }
     }
}