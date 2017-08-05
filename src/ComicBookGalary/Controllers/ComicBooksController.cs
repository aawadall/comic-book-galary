using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalary.Controllers
{
    public class ComicBooksController:Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hey Everyone, guess what! this is a Content Result"
            };
           // return "Hello";
        }
    }
}