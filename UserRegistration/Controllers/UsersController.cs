using Core.Providers.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models.Users;

namespace UserRegistration.Controllers
{
    public class UsersController : Controller
    {
        readonly IUserProvider provider;

        public UsersController(IUserProvider provider)
        {
            this.provider = provider;
        }

        public ActionResult Index()
        {
            UserIndexViewModel model = new UserIndexViewModel(provider);
            return View(model);
        }

        public ActionResult IndexListPartial()
        {
            UserIndexViewModel model = new UserIndexViewModel(provider);
            return PartialView(model);
        }

        public ActionResult Register()
        {
            UserNewViewModel model = new UserNewViewModel(provider);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserNewViewModel model)
        {
            if(ModelState.IsValid)
            {
                model.Save(provider);
                return Redirect("Index");
            }

            return View(model);
        }


        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
