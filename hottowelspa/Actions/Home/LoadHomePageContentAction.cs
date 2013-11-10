using hottowelspa.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hottowelspa.Actions.Home
{
    public class LoadHomePageContentAction<T> where T: class
    {

        #region Properties

        public Func<HomePageViewModel, T> OnComplete { get; set;}

        #endregion

        public  T Execute()
        {
            var model = new HomePageViewModel();

            return OnComplete(model);
        }
    }
}