using CV.Management.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    public class CvController : Controller
    {
        public ActionResult Profile(string language)
        {
            if (language == "lv")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("lv");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("lv");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult PersonalInformation(PersonalInformationViewModel personal)
        {
            return RedirectToAction("Index");
        }
    }
}