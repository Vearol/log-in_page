using LogInPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogInPage.Controllers
{
    public class AccountsController : Controller
    {
        private AccountDbContext db = new AccountDbContext();
        // GET: Accounts
        public ActionResult Index()
        {
            return View(db.Accounts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Account newAccount)
        {
            if (ModelState.IsValid)
            {
                newAccount.Comment = "General comment";
                newAccount.Date = DateTime.Now;
                db.Accounts.Add(newAccount);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newAccount);
            }
        }
    }
}