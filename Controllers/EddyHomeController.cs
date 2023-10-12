using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

    


namespace HompPage.Controllers
{
    public class EddyHomeController : Controller
    {
        // GET: EddyHome      
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Feedback()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


        public ActionResult Contacts()
        {
            return View();
        }

     
        public ActionResult Portfolio()
        {
            return View();
        }

        
        public ActionResult Resume()
        {
            return View();
        }

        
    }
}