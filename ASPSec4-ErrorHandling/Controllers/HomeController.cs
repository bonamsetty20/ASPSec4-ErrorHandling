using ASPSec4_ErrorHandling.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPSec4_ErrorHandling.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object Session { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int age = Convert.ToInt16(form["age"]);
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        [HandleError(View = "Error")]
        public ActionResult Index2(FormCollection form, string v)
        {
            try
            {
                int age = Convert.ToInt16(form["age"]);
            }
            catch (Exception ex)
            {
                Session  = ex.Message;
                throw ex;
            }
            return View();
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
