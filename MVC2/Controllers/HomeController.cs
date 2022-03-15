using MVC2.DB_Context_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            manojEntities obj = new manojEntities();
            var res = obj.carmodels.ToList();
            List<carmodel> carobj = new List<carmodel>();
            
           foreach(var item in res)
            {
                carobj.Add(new carmodel
                {
                    id = item.id,
                    name = item.name,
                    model = item.model,
                    price = item.price
                });
            }
           
            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}