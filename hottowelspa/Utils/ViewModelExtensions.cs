using hottowelspa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace hottowelspa.Utils
{
    public static class ViewModelExtensions
    {

        public static JsonResult AsJsonResult(this ViewModelBase model)
        {
            var serialiser = new JavaScriptSerializer();

            var result = serialiser.Serialize(model);

            return new JsonResult()
            {
                Data = result,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}