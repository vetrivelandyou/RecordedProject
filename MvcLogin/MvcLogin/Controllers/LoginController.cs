using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLogin.Models;

namespace MvcLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(User user)
        {
            using (DBModels db = new DBModels ())
            {
                var userDetail = db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if(userDetail == null)
                {
                    user.LoginErrorMsg = "Invalid UserName or Password";
                    return View("Index", user);
                }
                else
                {
                    Session["userID"] = user.UserID;
                    Session["userName"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
           
        }
        public ActionResult LogOut()
        {
            int userId = (int) Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}