using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public void Change(string Language)
        {
            if (!string.IsNullOrEmpty(Language))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = Language;
            Response.Cookies.Add(cookie);

            if (Request.UrlReferrer != null)
                Response.Redirect(Request.UrlReferrer.AbsoluteUri);
            else
                Response.Redirect("/");
        }
    }
}
