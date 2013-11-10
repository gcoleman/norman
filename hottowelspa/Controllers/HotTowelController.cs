using hottowelspa.Actions.Home;
using System.Web.Mvc;
using hottowelspa.Utils;

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


        /// <summary>
        /// Reurns contact information for the application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult ContactInfo()
        {
            return new JsonResult() { Data = new { telephoneNumber = "0800-111-1111", emailAddress = "demo@emailaddress.com" }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        [HttpGet]
        public JsonResult HomePageContent()
        {
            var action = new LoadHomePageContentAction<JsonResult>()
            {
                OnComplete = (m) => m.AsJsonResult()
            };

            return action.Execute();
        }

        private void Execute()
        {
            throw new System.NotImplementedException();
        }

    }
}
