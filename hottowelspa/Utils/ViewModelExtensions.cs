using hottowelspa.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace hottowelspa.Utils
{
    public static class ViewModelExtensions
    {

        public static JsonResult AsJsonResult(this ViewModelBase model)
        {
            var serialiser = new JsonSerializer();

            var writer = new StringWriter();
            serialiser.Serialize(writer,model);

            return new JsonResult()
            {
                Data = writer.ToString(),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}