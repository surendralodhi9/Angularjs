using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAngular.Controllers
{
    public class HomeController : Controller
    {


        DatabaseClass databs = new DatabaseClass();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult dashboard()
        {

            return View();
        }
        public JsonResult Userlogin(Users us)
        {

            string result =Convert.ToString(databs.userlogin(us));
            if (result == "1")
            {
                Session["user"] = us.username;
                
            }
            else
            result= "Username or password is wrong";

            return Json(result, JsonRequestBehavior.AllowGet);
               

        }
    }
}