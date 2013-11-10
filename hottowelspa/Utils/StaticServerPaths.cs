using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace hottowelspa.Utils
{
    public static class StaticServerPaths
    {
        #region General

        /// <summary>
        /// Path to the Contact Info controller action
        /// </summary> 
        public static string PathToContactInformation(this UrlHelper url)
        {
            return url.Action("ContactInfo", new { Controller = "HotTowel" });
        }

        #endregion
    }


    public class StaticRoutes
    {
        

        #region Constructor
        public static object LoadStaticRoutes(UrlHelper url)
        {
            return new
            {
                GeneralPaths = SetupGeneralRoutes(url)
            };
        }

        #endregion

        #region Methods

        private static object SetupGeneralRoutes(UrlHelper url)
        {
            return new
            {
                pathToContactInformation = url.PathToContactInformation()
            }; 
        }

        #endregion

    }
}