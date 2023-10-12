using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HompPage.Models;
using System.Data.Entity;

namespace HompPage.Controllers
{
    public class MemberController : Controller
    {
        HomePageEntities2 db = new HomePageEntities2();
        // GET: Member

        //디비에서 가져와서 뷰에 전달하는 역할
       [HttpGet]
       public ActionResult Entry()
        {
            Members members = new Members();
            return View(members);
        }

        //뷰에서 포스트를 받으면 매개변수로 받아서 컨트롤러 실행
        [HttpPost]
        public ActionResult Entry(Members member)
        {
            member.EntryDate = DateTime.Now;
            try
            {
                db.Members.Add(member);
                db.SaveChanges();
                ViewBag.Result = "OK";
            }
            catch (Exception ex)
            {
                ViewBag.Result = "FAIL";
            }
            return View(member);
        }
        
        public JsonResult IDCheck(string memberid)
        {
            string result = string.Empty;

            Members member = db.Members.Find(memberid);

            if(member == null)
            {
                result = "OK";
            }
            else
            {
                result = "FAIL";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}