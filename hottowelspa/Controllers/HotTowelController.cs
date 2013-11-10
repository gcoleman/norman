using System.Web.Mvc;

namespace hottowelspa.Controllers
{
    public class HotTowelController : Controller
    {
        //
        // GET: /HotTowel/

        public ActionResult Index()
        {
            return View();
        }


        //
        //GET: /HotTowel/
        [HttpGet]
        public JsonResult ContactInfo()
        {
            return new JsonResult() { Data = new { telephoneNumber = "0800-111-1111", emailAddress = "demo@emailaddress.com" }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}
