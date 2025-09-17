using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Graphicsweb.Models;


namespace Graphicsweb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index() 
        { 
        
            return View();
        }
      
        public ActionResult About()
        {
            return View();

        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ClintData clintData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    handlDb handlDb = new handlDb();
                    if (handlDb.InsertData(clintData))
                    {
                        ViewBag.message = "Insert Succssfuly";
                    }
                }
                return View();
            }
            catch (Exception dx)
            {
                ViewBag.messsage = dx.Message;
            }
            return View();
        }


    }
}