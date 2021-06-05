using NTPT_1821050973.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTPT_1821050973.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        // GET: accounts
        Encryption encry = new Encryption();
        SinhvienContext db = new Context();
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(account acc)
        {
            if (ModelState.IsValid)
            {
                acc.Password = encry.PasswordEncryption(acc.Password);
                db.accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "accounts");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(account acc)
        {
            if (ModelState.IsValid)
            {
                string encryptionpass = encry.PasswordEncryption(acc.Password);
                var model = db.accounts.Where(m => m.username == acc.username && m.Password == encryptionpass).ToList().Count();
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.username, true);
                    return RedirectToAction("Index", "Sinhviens");


                }
                else
                {
                    ModelState.AddModelError(" ", "Thông Tin Đăng Nhập Không Chính Xác");
                }
            }
            return View(acc);
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}