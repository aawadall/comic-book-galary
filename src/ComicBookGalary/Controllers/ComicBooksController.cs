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
            ViewBag.SeriesTitle = "Gone with the wind";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>some details about the issue</p><p>it is not that important</p>";
            ViewBag.Artists = new string[]
            {
                "Artist 1",
                "Artist 2",
                "Artist 3",
                "Artist 4",
                "Artist 5",
                "Artist 6"
            };
            return View();
        }
    }
}