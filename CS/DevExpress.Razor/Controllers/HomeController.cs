using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.IO;
using DevExpress.Web.ASPxClasses.Internal;
using DevExpress.Razor.Models;
using System.Web.Script.Serialization;

namespace DevExpress.Razor.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View();
        }
        public ActionResult CallbackPanelPartial() {
            ViewData["Data"] = GetSerializationObject();
            return PartialView("CallbackPanelPartial");
        }


        MyData GetSerializationObject() {
            string jsonText = Request.Params["SerializationData"];
            if (string.IsNullOrEmpty(jsonText))
                return null;

            MyData data = null;
            try {
                data = new JavaScriptSerializer().Deserialize<MyData>(jsonText);
            } catch {
                ViewData["ErrorMessage"] = "Incorrect data";
            }

            return data;
        }
    }
}
