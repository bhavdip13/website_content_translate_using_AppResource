using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website_Content_Translate_Using_AppResource.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeCulture(string lang, string returnUrl)
        {

            var langCookie = new HttpCookie("lang", lang)
            {
                HttpOnly = true
            };
            Response.AppendCookie(langCookie);
            return Redirect(returnUrl);

            //SetCulture(lang);
            //// Little house keeping
            //Regex re = new Regex("^/\\w{2,3}(-\\w{2})?");
            //returnUrl = re.Replace(returnUrl, "/" + lang.ToLower());
            //return Redirect(returnUrl);
        }
    }
}
