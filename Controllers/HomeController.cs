using System;
using Microsoft.AspNetCore.Mvc;
namespace Core.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            ViewBag.Message = "Hello!";
            ViewBag.Time = DateTime.Now;
            return View();
        }
    }
}