using m=HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        m.Restaurant r = new m.Restaurant() { Id = 1, Name = "Chipotle", Score = 4.5 };

        //Action Methods: methods which handles HTTP requests ->GET, POST, PUT, DELETE
        [HttpGet]
        [Route("")]
        [Route("Home")]
        [Route("Home/index")]
        //public string Index()
        //public JsonResult Index()
        public IActionResult Index()
        {
            //ViewData["title"] = "Home Page";
            ViewBag.Title = "HomePage";
            //ViewData["Rest"] = r;
            ViewBag.Rest = r;
            //return View(r);
            return View("Index1");
        }
        [HttpGet]
        [Route("Home/index/{id}")]
        public string Index(int? id)
        {
            return id.ToString();
        }

        //Action Methods return types:
        /* 
         IActionResult->ActionResult->ViewResult
                                     ->Jsonresult
                                     ->ContentResult
                                     ->PartialViewResult
                                     ->FileResult
                                     ->ObjectResult
                                     ->ResirectResult         
         */

        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }

    }
}
