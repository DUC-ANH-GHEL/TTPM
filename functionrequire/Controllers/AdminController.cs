using functionrequire.Helper;
using functionrequire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace functionrequire.Controllers
{
    public class AdminController : Controller
    {
        DataContext dc;
        public AdminController()
        {
            dc = new DataContext();
        }
        // GET: Admin
        public ActionResult Login()
        {

            if (Session["FullName"] == null)
            {
                return View();
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Login(Account ac)
        {
            //var checkpass = dc.Accounts.Where(a => a.Email.Equals(ac.Email)).Where(b => b.Pass.Equals(ac.Pass)).FirstOrDefault();
            //if (checkpass != null)
            //{
            //    SessionHelper.FullName = checkpass.FullName;
            //    SessionHelper.Role = checkpass.Status;
            //    ViewBag.id = checkpass.Id;
            //    ViewBag.fullname = checkpass.FullName;
            //    ViewBag.status = SessionHelper.Role;
            //    ViewBag.usid = SessionHelper.UserId;
            //    return View("Login");
            //}
            ViewBag.fullname = ac.FullName;
            Session["FullName"] = ac.FullName;
            Session["ID"] = ac.Pass;
            if (ac.Pass != "B8686")
            {
                ViewBag.status = false;
            }
            return View("Index", dc.HarkWorks.AsEnumerable().OrderByDescending(x => x.Grade));
        }
        public ActionResult Logout()
        {
            Session["FullName"] = null;
            return RedirectToAction("Login");
        }
        public void Index()
        {
            dc.Accounts.ToList();
            ViewBag.message = "hhh";
        }
    }
}